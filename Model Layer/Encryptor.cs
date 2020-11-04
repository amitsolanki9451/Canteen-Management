using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace ModelLayer
{
	public class CryptHelper
	{
		protected const int SYMMETRIC_KEY_LENGTH = 256;
		protected const bool USE_OAEP = false; // if you're running Windows 5.1 or greater, use this
		public const char DELIMITER = '|';

		protected static RijndaelManaged initSymmetricKey() 
		{
			RijndaelManaged sym = new RijndaelManaged();
			sym.KeySize = SYMMETRIC_KEY_LENGTH;
			sym.Mode = CipherMode.CBC;
			sym.Padding = PaddingMode.PKCS7;
			return sym;
		}
	}

	/// <summary>
	/// Summary description for Encryptor.
	/// </summary>
    public class Encryptor : CryptHelper, IDisposable
	{
		private RSACryptoServiceProvider asymProvider = new RSACryptoServiceProvider();
		private string keyName = "DemoMailKey1.0";

		public Encryptor(string keyName, string publicKeyXmlParams) 
		{
			this.keyName = keyName;
			asymProvider.FromXmlString(publicKeyXmlParams);
		}

		public Encryptor()
		{
            string path = "";// Config.InstallPath + "public.key";
			StreamReader reader = new StreamReader(path);
			string publicKey = reader.ReadToEnd();
			reader.Close();
			asymProvider.FromXmlString(publicKey);
		}


		public string Encrypt(string plaintext) 
		{
			RijndaelManaged sym = initSymmetricKey();

			sym.GenerateKey();
			sym.GenerateIV();
            
			// encrypt the data
			byte[] IV = sym.IV;
			byte[] plaintextBytes = Encoding.Unicode.GetBytes(plaintext);
			byte[] ciphertextBytes = sym.CreateEncryptor().TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);

			// encrypt the symmetric key with the public key
			byte[] encryptedKey = asymProvider.Encrypt(sym.Key, USE_OAEP);

			// resulting block of data has following format:
			// [len][encrypted symmetric key][IV][ciphertext]

			byte[] payload = new byte[2 + encryptedKey.Length + IV.Length + ciphertextBytes.Length];
			BinaryWriter writer = new BinaryWriter(new MemoryStream(payload));
			writer.Write((short)encryptedKey.Length);
			writer.Write(encryptedKey);
			writer.Write(IV);
			writer.Write(ciphertextBytes);
			writer.Close();

			// in order to allow key versioning, we prepend the base64 encoded payload
			// with the name of the RSA key used to encrypt it
			// (key name maps directly to key container name on back end)
			return string.Format("{0}{1}{2}", keyName, DELIMITER, Convert.ToBase64String(payload));
		}

		#region IDisposable Members

		public void Dispose()
		{
			asymProvider.Clear();
		}

		#endregion
	}
}