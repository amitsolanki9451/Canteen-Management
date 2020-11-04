using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
namespace ModelLayer
{
 	/// <summary>
	/// Provide access to NameValueCollection items that contain encrypted keys and values.
	/// </summary>
    public class EncryptedNameValueCollection : NameValueCollection
	{
		public EncryptedNameValueCollection(NameValueCollection col) : base(col){}

		public override string Get(string name)
		{
			string decryptedValue = null;
			string baseKey = null;
			string[] keys = AllKeys;
			for (int i = 0; i < keys.Length; i++)
			{
				string key = keys[i];
				if(name == ML_Common.Decrypt(key))
				{
					baseKey = key;
					break;
				}
			}

			if(baseKey != null)
			{
				string encryptedValue = base.Get(baseKey);
				if(encryptedValue != null)
				{
                    decryptedValue = ML_Common.Decrypt(encryptedValue);
				}
			}

			return decryptedValue;
		}
	}
}
