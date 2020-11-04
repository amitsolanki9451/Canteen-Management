using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
//using System.Web.UI;
//using System.Web.UI.WebControls;
using System.IO;
//using System.Web;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using System.Web;
using System.Globalization;
namespace ModelLayer
{
    #region Comments
    /// <summary>
    /// ML_Common Class.
    /// </summary>
    /// <remarks>
    /// <h3>Trimurari Singh</h3>
    /// <list type="table">
    /// 	<listheader>
    /// 		<th>Author</th>
    /// 		<th>Date</th>
    /// 		<th>Details</th>
    /// 	</listheader>
    /// 	<item>
    /// 		<term>Trimurari Singh</term>
    /// 		<description>2/7/2011</description>
    /// 		<description>Created</description>
    /// 	</item>
    /// </list>
    /// </remarks>
    #endregion

    [Serializable]
    public class ML_Common
    {

        /// <summary>
        /// Define Common Method and  Properties.        
        /// </summary>      
        /// <Developr>
        /// <Name>Trimurari Singh</Name>
        /// <CreatedOn></CreatedOn>
        /// <LastModifiedOn></LastModifiedOn>
        /// </Developr>

        #region Global Variable

        private static Exception lastException;
        // private static bool debug;

        #endregion

        #region Public properties
        public static string MessageBoxTitle
        {
            get { return "returnTitle"; }
        }
              
        #endregion


        #region constructor
        public ML_Common()
        {

        }
        #endregion

        #region HTML methods

        public static string clean(object strret)
        {
            string what = string.Empty;
            try
            {
                if (strret != null)
                {
                    what = Convert.ToString(strret);
                    if (!string.IsNullOrEmpty(what))
                    {
                        what = what.Replace("\n\n/", "<P>");
                        what = what.Replace("’", "'");
                        what = what.Replace("“", "\"");
                        what = what.Replace("”", "\"");
                        what = what.Replace("'", "&rsquo;");
                        what = what.Replace("\"", "&quot;");
                        what = what.Replace("<", "&lt;");
                        what = what.Replace(">", "&gt;");
                    }
                    else
                    {
                        what = string.Empty;
                    }
                }

            }
            catch (Exception mex)
            {
                lastException = mex;
                what = string.Empty;
                return what;
            }
            return what;
        }


     


        public static string clean(string what)
        {
            try
            {
                if (!string.IsNullOrEmpty(what))
                {                    
                    what = what.Replace("\n\n/", "<P>");
                    what = what.Replace("’", "'");
                    what = what.Replace("“", "\"");
                    what = what.Replace("”", "\"");
                    what = what.Replace("'", "&rsquo;");
                    what = what.Replace("\"", "&quot;");
                    what = what.Replace("<", "&lt;");
                    what = what.Replace(">", "&gt;");
                    what = what.Trim();
                }
                else
                {
                    what = string.Empty;
                }

            }
            catch (Exception mex)
            {
                lastException = mex;
                what = string.Empty;
                return what;
            }
            return what;
        }

        public static string dirty(string what)
        {
            try
            {
                if (!string.IsNullOrEmpty(what))
                {
                    what = what.Replace("&rsquo;", "'");
                    what = what.Replace("&quot;", "\"");
                    what = what.Replace("&lt;", "<");
                    what = what.Replace("&gt;", ">");
                }
                else
                {
                    what = string.Empty;
                }

            }
            catch (Exception mex)
            {
                lastException = mex;
                what = string.Empty;
                return what;
            }
            return what;
        }

        public static string dirty(object strret)
        {
            string what = string.Empty;
            try
            {
                if (strret != null)
                {
                    what = Convert.ToString(strret);
                    if (!string.IsNullOrEmpty(what))
                    {
                        what = what.Replace("&rsquo;", "'");
                        what = what.Replace("&quot;", "\"");
                        what = what.Replace("&lt;", "<");
                        what = what.Replace("&gt;", ">");
                    }
                    else
                    {
                        what = string.Empty;
                    }
                }
                else
                {
                    what = string.Empty;
                }

            }
            catch (Exception mex)
            {
                lastException = mex;
                what = string.Empty;
                return what;
            }
            return what;
        }

        public static string quoteWildcards(string strret)
        {
            string what = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(strret))
                {
                    what = Convert.ToString(strret);
                    what = what.Replace("[", "[[]");
                    what = what.Replace("%", "[%]");
                    what = what.Replace("_", "[_]");
                }

                return what;
            }
            catch (Exception mex)
            {
                lastException = mex;
                what = string.Empty;
                return what;

            }

        }
                
        public static string string2Eclips(string what, int maxCharLen)
        {
            int maxLength = 10;

            try
            {
                if (maxCharLen > 0)
                {
                    maxLength = maxCharLen;
                }
                if (!string.IsNullOrEmpty(what))
                {
                    if (what.Length >= maxLength)
                    {
                        what = what.Substring(0, maxLength);
                        what = what + "...";
                    }

                }
                else
                {
                    what = string.Empty;
                }
                return what;
            }
            catch (Exception mex)
            {
                lastException = mex;
                what = string.Empty;
                return what;
            }
        }

        public static string string2NoEclips(string what, int maxCharLen)
        {
            int maxLength = 10;

            try
            {
                if (maxCharLen > 0)
                {
                    maxLength = maxCharLen;
                }
                if (!string.IsNullOrEmpty(what))
                {
                    if (what.Length >= maxLength)
                    {
                        what = what.Substring(0, maxLength);                      
                    }

                }
                else
                {
                    what = string.Empty;
                }
                return what;
            }
            catch (Exception mex)
            {
                lastException = mex;
                what = string.Empty;
                return what;
            }
        }




        public static string string2Eclips(object strret, int maxCharLen)
        {
            int maxLength = 10;
            string what = string.Empty;
            try
            {
                if (strret != null)
                {
                    what = Convert.ToString(strret);

                    if (maxCharLen > 0)
                    {
                        maxLength = maxCharLen;
                    }
                    if (!string.IsNullOrEmpty(what))
                    {
                        if (what.Length >= maxLength)
                        {
                            what = what.Substring(0, maxLength);
                            what = what + "...";
                        }
                    }
                    else
                    {
                        what = string.Empty;
                    }
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                what = string.Empty;
                return what;
            }
            return what;
        }
                  
        #endregion

        #region Supporting COM-interop methods
        /// <summary>
        /// Decrements the reference count of the supplied runtime callable wrapper.
        /// </summary>
        /// <param name="comReference">The COM object to release.</param>
        public static void ReleaseReference(object comReference)
        {
            try { Marshal.ReleaseComObject(comReference); }
            catch { }
        }
        #endregion

        #region Errors & Exceptions methods
        /// <summary>
        /// Show MessageBox to user with specified error description.
        /// </summary>
        /// <param name="message"></param>
        public static void ShowInformation(string message)
        {
            MessageBox.Show(message, MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Show MessageBox to user with specified error description.
        /// </summary>
        /// <param name="message"></param>
        public static void ShowError(string message)
        {
            MessageBox.Show(message, MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);        
        }

        /// <summary>
        /// Show MessageBox to user with specified error message
        /// and publish provided exception.
        /// </summary>
        /// <param name="message">Message to show to user.</param>
        /// <param name="e">Exception that cause that error.</param>
        //public static void ShowException(string message, Exception e)
        //{
        //    ExceptionManager.AsyncPostException(message, e);
        //    if (e is WebException || (e.InnerException != null && e.InnerException is WebException))
        //    {
        //        ShowError("Error connecting to server.\nCheck your internet connection and try again.");
        //    }
        //    else
        //    {
        //        string userMessage = string.Empty;
        //        if (message != null)
        //        {
        //            userMessage += message + "\n";
        //        }
        //        if (Config.ShowError)
        //        {
        //            Exception deepestException = GetFirstException(e);
        //            userMessage += deepestException.Message;
        //        }
        //        else
        //        {
        //            userMessage = "Error processing your request.";
        //        }

        //        ShowError(userMessage);
        //    }
        //}

        /// <summary>
        /// Show MessageBox to user with error message
        /// and publish provided exception.
        /// </summary>
        /// <param name="e">Exception that cause that error.</param>
        //public static void ShowException(Exception e)
        //{
        //  //  ShowException(null, e);
        //}

        /// <summary>
        /// Gets first exception - the deepest inner exception in chain.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Exception GetFirstException(Exception e)
        {
            Exception result = e;
            while (result.InnerException != null)
            {
                result = result.InnerException;
            }
            return result;
        }

        #endregion

        #region Encrypt/Decrypt Methods
        /// <summary>
        /// This method can be called for encryption 
        /// SEE METHOD DECRYPT() ALSO
        /// </summary>
        public static string Encrypt(string s)
        {
            string r = "";

            for (int c = 0; c < s.Length; c++)
            {
                //string curchar = sprintf("%03s",523+ord(substr(s,c,1))) + substr(rand(),0,3);

                int no = 523 + (int)(s.Substring(c, 1).ToCharArray())[0];
                string curchar;
                curchar = no.ToString();
                curchar = curchar.PadLeft(3, '0');
                curchar = curchar.Substring(0, 3);

                Random rand = new Random();
                string suffix = rand.Next().ToString();
                suffix = suffix.PadLeft(3, '0');
                suffix = suffix.Substring(0, 3);

                r += curchar + suffix;
            }
            return r;
        }

        /// <summary>
        /// This method is inverse of method encrypt() and can be called for decryption 
        /// SEE METHOD ENCRYPT() ALSO
        /// </summary>
        public static string Decrypt(string s)
        {
            string r = "";

            for (int c = 0; c < s.Length; c += 6)
            {
                //string curchar = chr(substr($s,$c,3)-523);
                int no = string2Int32(s.Substring(c, 3)) - 523;
                byte curchar = Convert.ToByte(no.ToString());


                r += (char)curchar;
            }

            return r;
        }

        #endregion 

        #region String to Integer Conversion Methods
        /// <summary>
        /// An exception free string to integer conversion function
        /// </summary>
        public static int string2Int32(string s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch
            {
                return 0;
            }
        }

        #endregion 

        #region Methods for NULL
        /// <summary>
        /// null safe convertion to string.
        /// </summary>
        public static string NullSafe(object s)
        {
            string result = string.Empty;
            try
            {
                if (s != null)
                {
                    result = s.ToString();
                }
            }
            catch { }
            return result;
        }

        #endregion

        #region Validation methods
        public static bool ValidateEmail(string email)
        {
            bool result = false;
            if (email != null && email.Length > 0)
            {
                //			string filter=@"^([\w\-]+(\.[\w\-]+)*)@(([\w\-]+\.)*\w[\w\-]{0,66})\.([a-z]{2,6}(\.[a-z]{2})?)$";
                //			string filter=@"^[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]*@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]*\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
                string filter = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,5}|[0-9]{1,3})(\]?)$";

                result = Regex.IsMatch(email, filter, RegexOptions.IgnoreCase);
            }
            return result;
        }
        #endregion

        #region Temporary files management
        /// <summary>
        /// Get full file name with the specified extension and ensure that file 
        /// with that name doesn't exist.
        /// Creates zero-bytes file on the disk.
        /// </summary>
        /// <param name="extension">File extention to use.</param>
        /// <returns>Unique filename.</returns>
        public static string GetTempFilename(string extension)
        {
            string filename = null;
            bool found = true;
            int index = 0;
            string tempPath = Path.GetTempPath();

            do
            {
                index++;
                filename = tempPath + "demomailtempfile" + index.ToString() + "." + extension;
                found = File.Exists(filename);
            } while (found);

            File.Create(filename).Close();
            return filename;
        }
        #endregion
        
        #region Shell methods
        /// <summary>
        /// Open specified URI.
        /// </summary>
        /// <param name="uri"></param>
        public static void OpenURI(string uri)
        {
            //InternetExplorerClass internetExplorer = new InternetExplorerClass();
            //object oEmpty = String.Empty;
            //object oURL = uri;
            //internetExplorer.Visible = true;
            //internetExplorer.Navigate2(ref oURL, ref oEmpty, ref oEmpty, ref oEmpty, ref oEmpty);
            ////			Process.Start("explorer.exe", "\"" + uri + "\"");
        }
        #endregion

        #region WinForms methods
        public static void ActivateForm(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }

            form.Activate();
            form.BringToFront();

        }
        #endregion


        public static bool IsPasswordsEqual(string password1, string password2)
        {
            if (password1.Equals(password2))
            {
                return true;
            }

            return false;
        }

        //ToDecimal
        //ToDouble
        //ToInt16
        //ToInt32
        //ToInt64
        //ToSingle
        //ToUInt16
        //ToUInt32
        //ToUInt64
        //ToString
        //ToBoolean
        //ToDateTime  


        //ToByte
        //ToChar            
        //ToSByte      


        /// <summary>
        /// Convert into int
        /// </summary>
        /// <param name="value">Takes value</param>
        /// <returns>Returns an integer</returns>
        public static int ToInt(object value)
        {
            int intReturn = 0;
            try
            {
                if (int.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                {
                    return intReturn;
                }
                else
                {
                    return default(int);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(int);
            }
        }
        public static int? ToNullableInt(object value)
        {
            int intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (int.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(int?);
                    }
                }
                else
                {
                    return default(int?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(int?);
            }
        }

     




        public static int string2int(string value)
        {
            int intReturn = 0;
            try
            {
                if (int.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                {
                    return intReturn;
                }
                else
                {
                    return default(int);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(int);
            }
        }
        public static int string2int(object value)
        {
            int intReturn = 0;
            try
            {
                if (int.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                {
                    return intReturn;
                }
                else
                {
                    return default(int);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(int);
            }
        }
        public static int? string2Nullableint(object value)
        {
            int intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (int.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(int?);
                    }
                }
                else
                {
                    return default(int?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(int?);
            }
        }

        public static Int16 string2int16(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToInt16(s);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return 0;
            }
        }
        public static Int16 string2int16(object objval)
        {
            Int16 strint = 0;
            try
            {
                if (objval != null)
                {
                    strint = Convert.ToInt16(objval);
                }
                else
                {
                    strint = 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                strint = 0;
                return 0;
            }
            return strint;
        }
        public static Int16? string2Nullableint16(object value)
        {
            Int16 intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (Int16.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(Int16?);
                    }
                }
                else
                {
                    return default(Int16?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(Int16?);
            }
        }

        public static UInt16 string2UInt16(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToUInt16(s);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return 0;
            }
        }
        public static UInt16 string2UInt16(object objval)
        {
            UInt16 strint = 0;
            try
            {
                if (objval != null)
                {
                    strint = Convert.ToUInt16(objval);
                }
                else
                {
                    strint = 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                strint = 0;
                return 0;
            }
            return strint;
        }
        public static UInt16? string2NullableUInt16(object value)
        {
            UInt16 intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (UInt16.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(UInt16?);
                    }
                }
                else
                {
                    return default(UInt16?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(UInt16?);
            }
        }

        public static int string2int32(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToInt32(s);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return 0;
            }
        }
        public static int string2int32(object objval)
        {
            int strint = 0;
            try
            {
                if (objval != null)
                {
                    strint = Convert.ToInt32(objval);
                }
                else
                {
                    strint = 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                strint = 0;
                return 0;
            }
            return strint;
        }
        public static int? string2Nullableint32(object value)
        {
            int intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (Int32.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(int?);
                    }
                }
                else
                {
                    return default(int?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(int?);
            }
        }

        public static UInt32 string2UInt32(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToUInt32(s);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return 0;
            }
        }
        public static UInt32 string2UInt32(object objval)
        {
            UInt32 strint = 0;
            try
            {
                if (objval != null)
                {
                    strint = Convert.ToUInt32(objval);
                }
                else
                {
                    strint = 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                strint = 0;
                return 0;
            }
            return strint;
        }
        public static UInt32? string2NullableUInt32(object value)
        {
            UInt32 intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (UInt32.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(UInt32?);
                    }
                }
                else
                {
                    return default(UInt32?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(UInt32?);
            }
        }

        public static Int64 string2int64(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToInt64(s);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return 0;
            }
        }
        public static Int64 string2int64(object objval)
        {
            Int64 strint = 0;
            try
            {
                if (objval != null)
                {
                    strint = Convert.ToInt64(objval);
                }
                else
                {
                    strint = 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                strint = 0;
                return 0;
            }
            return strint;
        }
        public static Int64? string2Nullableint64(object value)
        {
            Int64 intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (Int64.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(Int64?);
                    }
                }
                else
                {
                    return default(Int64?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(Int64?);
            }
        }

        public static UInt64 string2UInt64(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToUInt64(s);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return 0;
            }
        }
        public static UInt64 string2UInt64(object objval)
        {
            UInt64 strint = 0;
            try
            {
                if (objval != null)
                {
                    strint = Convert.ToUInt64(objval);
                }
                else
                {
                    strint = 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                strint = 0;
                return 0;
            }
            return strint;
        }
        public static UInt64? string2NullableUInt64(object value)
        {
            UInt64 intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (UInt64.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(UInt64?);
                    }
                }
                else
                {
                    return default(UInt64?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(UInt64?);
            }
        }

        public static long string2Long(string value)
        {
            long intReturn = 0;
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (long.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(long);
                    }
                }
                else
                {
                    return default(long);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(long);
            }
        }
        public static long string2Long(object value)
        {
            long intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (long.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(long);
                    }
                }
                else
                {
                    return default(long);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(long);
            }
        }
        public static long? string2Nullablelong(object value)
        {
            long intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (long.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(long?);
                    }
                }
                else
                {
                    return default(long?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(long?);
            }
        }

        public static decimal string2Decimal(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToDecimal(s);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return 0;
            }
        }
        public static decimal string2Decimal(object objval)
        {
            decimal strLong = 0;
            try
            {
                if (objval != null)
                {
                    strLong = Convert.ToDecimal(objval);
                }
                else
                {
                    strLong = 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                strLong = 0;
                return 0;
            }
            return strLong;
        }
        public static decimal? string2NullableDecimal(object value)
        {
            decimal intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (decimal.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(decimal?);
                    }
                }
                else
                {
                    return default(decimal?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(decimal?);
            }
        }


        /// <summary>
        /// Convert into decimal?
        /// </summary>
        /// <param name="value">Takes value</param>
        /// <returns>Returns a decimal</returns>
        public static decimal? ToNullableDecimal(object value)
        {
            try
            {
                if (value != null)
                {
                    decimal decReturn = default(decimal);
                    if (decimal.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out decReturn))
                    {
                        return decReturn;
                    }
                    else
                    {
                        return default(decimal?);
                    }
                }
                else
                {
                    return default(decimal?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(decimal?);
            }
        }
        public static decimal ToDecimal(object value)
        {
            try
            {
                if (value != null)
                {
                    decimal decReturn = default(decimal);
                    if (decimal.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out decReturn))
                    {
                        return decReturn;
                    }
                    else
                    {
                        return default(decimal);
                    }
                }
                else
                {
                    return default(decimal);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(decimal);
            }
        }


        /// <summary>
        /// Convert into double?
        /// </summary>
        /// <param name="value">Takes value</param>
        /// <returns>Returns a double</returns>
        public static double? ToNullableDouble(object value)
        {
            try
            {
                if (value != null)
                {
                    double dblReturn = default(double);
                    if (double.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(double?);
                    }
                }
                else
                {
                    return default(double?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(double?);
            }
        }
        public static double ToDouble(object value)
        {
            try
            {
                if (value != null)
                {
                    double dblReturn = default(double);
                    if (double.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(double);
                    }
                }
                else
                {
                    return default(double);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(double);
            }
        }
        public static double string2Double(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToDouble(s);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return 0;
            }
        }
        public static double string2Double(object objval)
        {
            double strLong = 0;
            try
            {
                if (objval != null)
                {
                    strLong = Convert.ToDouble(objval);
                }
                else
                {
                    strLong = 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                strLong = 0;
                return 0;
            }
            return strLong;
        }
        public static double? string2NullableDouble(object value)
        {
            double intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (double.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(double?);
                    }
                }
                else
                {
                    return default(double?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(double?);
            }
        }

        /// <summary>
        /// Convert into float?
        /// </summary>
        /// <param name="value">Takes value</param>
        /// <returns>Returns a double</returns>
        public static Single? ToNullableSingle(object value)
        {
            try
            {
                if (value != null)
                {
                    Single dblReturn = default(Single);
                    if (Single.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(Single?);
                    }
                }
                else
                {
                    return default(Single?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(Single?);
            }
        }
        /// <summary>
        /// Convert into float?
        /// </summary>
        /// <param name="value">Takes value</param>
        /// <returns>Returns a double</returns>
        public static Single ToSingle(object value)
        {
            try
            {
                if (value != null)
                {
                    Single dblReturn = default(Single);
                    if (Single.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(Single);
                    }
                }
                else
                {
                    return default(Single);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(Single);
            }
        }
        public static Single string2Single(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToSingle(s);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return 0;
            }
        }
        public static Single string2Single(object objval)
        {
            Single strint = 0;
            try
            {
                if (objval != null)
                {
                    strint = Convert.ToSingle(objval);
                }
                else
                {
                    strint = 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                strint = 0;
                return 0;
            }
            return strint;
        }
        public static Single? string2NullableSingle(object value)
        {
            Single intReturn = 0;
            try
            {
                if (value != null)
                {
                    if (Single.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out intReturn))
                    {
                        return intReturn;
                    }
                    else
                    {
                        return default(Single?);
                    }
                }
                else
                {
                    return default(Single?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(Single?);
            }
        }
        /// <summary>
        /// this method is use to convert string2money
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Single string2money(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return Convert.ToSingle(s);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return 0;
            }
        }


        /// <summary>
        /// Convert into float?
        /// </summary>
        /// <param name="value">Takes value</param>
        /// <returns>Returns a double</returns>
        public static float? ToNullableFloat(object value)
        {
            try
            {
                if (value != null)
                {
                    float dblReturn = default(float);
                    if (float.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(float?);
                    }
                }
                else
                {
                    return default(float?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(float?);
            }

        }
        public static float ToFloat(object value)
        {
            try
            {
                if (value != null)
                {
                    float dblReturn = default(float);
                    if (float.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(float);
                    }
                }
                else
                {
                    return default(float);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(float);
            }
        }
        public static float string2float(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    float dblReturn = default(float);
                    if (float.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(float);
                    }
                }
                else
                {
                    return default(float);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(float);
            }
        }
        public static float string2float(object value)
        {
            try
            {
                if (value != null)
                {
                    float dblReturn = default(float);
                    if (float.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(float);
                    }
                }
                else
                {
                    return default(float);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(float);
            }
        }
        public static float? string2Nullablefloat(object value)
        {
            try
            {
                if (value != null)
                {
                    float dblReturn = default(float);
                    if (float.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(float?);
                    }
                }
                else
                {
                    return default(float?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(float?);
            }
        }

        public static short ToShort(object value)
        {
            try
            {
                if (value != null)
                {
                    short dblReturn = default(short);
                    if (short.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(short);
                    }
                }
                else
                {
                    return default(short);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(short);
            }
        }
        public static short string2short(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    short dblReturn = default(short);
                    if (short.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(short);
                    }
                }
                else
                {
                    return default(short);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(short);
            }
        }
        public static short string2short(object value)
        {
            try
            {
                if (value != null)
                {
                    short dblReturn = default(short);
                    if (short.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(short);
                    }
                }
                else
                {
                    return default(short);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(short);
            }
        }
        public static short? string2Nullableshort(object value)
        {
            try
            {
                if (value != null)
                {
                    short dblReturn = default(short);
                    if (short.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(short?);
                    }
                }
                else
                {
                    return default(short?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(short?);
            }
        }

        public static ushort string2ushort(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    ushort dblReturn = default(ushort);
                    if (ushort.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(ushort);
                    }
                }
                else
                {
                    return default(ushort);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(ushort);
            }
        }
        public static ushort string2ushort(object value)
        {
            try
            {
                if (value != null)
                {
                    ushort dblReturn = default(ushort);
                    if (ushort.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(ushort);
                    }
                }
                else
                {
                    return default(ushort);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(ushort);
            }
        }
        public static ushort? string2Nullableushort(object value)
        {
            try
            {
                if (value != null)
                {
                    ushort dblReturn = default(ushort);
                    if (ushort.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(ushort?);
                    }
                }
                else
                {
                    return default(ushort?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(ushort?);
            }
        }
        /// <summary>
        /// Convert to bool?
        /// </summary>
        /// <param name="value">Takes value</param>
        /// <returns>Returns a bool</returns>
        public static bool? ToNullableBoolean(object value)
        {
            try
            {
                if (value != null)
                {
                    bool bReturn = default(bool);
                    if (bool.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out bReturn))
                    {
                        return bReturn;
                    }
                    else
                    {
                        return default(bool?);
                    }
                }
                else
                {
                    return default(bool?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(bool?);
            }
        }
        public static Boolean string2Boolean(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    bool dblReturn = default(bool);
                    if (bool.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(bool);
                    }
                }
                else
                {
                    return default(bool);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(bool);
            }
        }
        public static Boolean string2Boolean(object value)
        {
            try
            {
                if (value != null)
                {
                    bool dblReturn = default(bool);
                    if (bool.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(bool);
                    }
                }
                else
                {
                    return default(bool);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(bool);
            }
        }
        public static Boolean? string2NullableBoolean(object value)
        {
            try
            {
                if (value != null)
                {
                    bool dblReturn = default(bool);
                    if (bool.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(bool?);
                    }
                }
                else
                {
                    return default(bool?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(bool?);
            }
        }



        public static Boolean object2Boolean(object value)
        {
            bool bolReturn = false;
            try
            {
                if (value != null)
                {  
                    if (value.ToString() == "1")
                    {
                        bolReturn =true;
                    }
                    else if(value.ToString().Trim().ToLower()=="true")
                    {
                        bolReturn = true;
                    }
                    else
                    {
                        bolReturn =false;
                    }
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                bolReturn = false;
            }
            return bolReturn;
        }
        /// <summary>
        /// this method is use to convert int 2 bit
        /// </summary>
        /// <param name="intvalue"></param>
        /// <returns></returns>
        public static bool int2bit(int intvalue)
        {
            try
            {
                if (intvalue == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return false;
            }
        }

        /// <summary>
        /// this method is use to convert int 2 bit
        /// </summary>
        /// <param name="intvalue"></param>
        /// <returns></returns>
        public static bool int2bit(String intvalue)
        {
            try
            {
                if (string.Compare(intvalue, "1", true) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return false;
            }
        }


        public static bool string2CheckBox(String intvalue)
        {
            try
            {
                if (string.Compare(intvalue.Trim(), "1", true) == 0)
                {
                    return true;
                }
                else if (string.Compare(intvalue.Trim().ToLower(), "true", true) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return false;
            }
        }

        public static bool string2CheckBox(object intvalue)
        {
            try
            {
                if (intvalue != null)
                {
                    string strvalue = intvalue.ToString();
                    if (string.Compare(strvalue.Trim(), "1", true) == 0)
                    {
                        return true;
                    }
                    else if (string.Compare(strvalue.Trim().ToLower(), "true", true) == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return false;
            }
        }


        /// <summary>
        /// this method is use to convert string 2 bit
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <returns></returns>
        public static bool string2bit(string stringvalue)
        {
            try
            {
                if (string.Compare(stringvalue, "true", true) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return false;
            }
        }



        public static DateTime string2DateTime(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    DateTime dblReturn = default(DateTime);
                    if (DateTime.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(DateTime);
                    }
                }
                else
                {
                    return default(DateTime);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(DateTime);
            }
        }
        public static DateTime string2DateTime(object value)
        {
            try
            {
                if (value != null)
                {
                    DateTime dblReturn = default(DateTime);
                    if (DateTime.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return default(DateTime);
                    }
                }
                else
                {
                    return default(DateTime);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(DateTime);
            }
        }
        public static DateTime? string2NullableDateTime(object value)
        {
            try
            {
                if (value != null)
                {
                    DateTime dblReturn = default(DateTime);
                    if (DateTime.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {
                        return dblReturn;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return null;
            }
        }
        public static DateTime? string2NullableDateTime(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    DateTime decReturn;
                    if (DateTime.TryParse(value, out decReturn))
                    {
                        return decReturn;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return null;
            }
        }





        public static String string2Date(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    DateTime dblReturn = default(DateTime);
                    if (DateTime.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {

                        return dblReturn.ToShortDateString(); ;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return string.Empty;
            }
        }
        public static String string2Date(object value)
        {
            try
            {
                if (value != null)
                {
                    DateTime dblReturn = default(DateTime);
                    if (DateTime.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {

                        return dblReturn.ToShortDateString(); ;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return string.Empty;
            }
        }

        public static String string2Time(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    DateTime dblReturn = default(DateTime);
                    if (DateTime.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {

                        return dblReturn.ToShortTimeString(); ;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return string.Empty;
            }
        }
        public static String string2Time(object value)
        {
            try
            {
                if (value != null)
                {
                    DateTime dblReturn = default(DateTime);
                    if (DateTime.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dblReturn))
                    {

                        return dblReturn.ToShortTimeString(); ;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return string.Empty;
            }
        }

        /// <summary>
        /// This method tries to cast a string to date 
        /// if it fails it sets the date to 1900-01-01 to avoid crash
        /// if year is less than 1900 then sql server raises exception so treat the year as 1900
        /// </summary>
        public static DateTime ToDateTimeSafe(string date)
        {
            DateTime d = System.DateTime.Now;
            try
            {
                d = Convert.ToDateTime(date);

            }
            catch (Exception ex)
            {
                d =  Convert.ToDateTime("1900-01-01");
                lastException = ex;
            }

            return d;
        }
        public static DateTime ToDateTimeSafe(object objdate)
        {
            DateTime strdate = System.DateTime.Now;
            try
            {
                if (objdate != null)
                {
                    strdate = Convert.ToDateTime(objdate);
                }

            }
            catch (Exception ex)
            {
                strdate =  Convert.ToDateTime("1900-01-01");
                lastException = ex;
            }

            return strdate;
        }

        /// <summary>
        /// Convert into DAteTIme or Null?
        ///  /// This method tries to cast a string to date 
        /// if it fails it sets the date to 1900-01-01 to avoid crash
        /// if year is less than 1900 then sql server raises exception so treat the year as 1900
        /// </summary>
        /// 

        private static DateTime ConvertToDateTime(string strDateTime)
        {
            DateTime dtFinaldate; string sDateTime;
            try { dtFinaldate = Convert.ToDateTime(strDateTime); }
            catch (Exception e)
            {
                string[] sDate = strDateTime.Split('/');
                sDateTime = sDate[1] + '/' + sDate[0] + '/' + sDate[2];
                dtFinaldate = Convert.ToDateTime(sDateTime);

                Exception et = e;
            }
            return dtFinaldate;
        }
        public static DateTime? ToDateTimeParseExactSafeNull(string dateString)
        {
            try
            {
                if (!string.IsNullOrEmpty(dateString))
                {
                    //DateTime mydy = Convert.ToDateTime(dateString);
                    DateTime mydt = ConvertToDateTime(dateString);
                    //string dateString = "Mon 16 Jun 8:30 AM 2008";
                  //  string format = "ddd dd MMM h:mm tt yyyy";
                    DateTime decReturn;
                    if (DateTime.TryParse(mydt.ToString(), out decReturn))
                    {
                        return decReturn;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return null;
            }
        }
      
        public static DateTime? ToDateTimeSafeNull(string value)
        {
          //  string dateString;
            CultureInfo culture;
            DateTimeStyles styles;
            try
            {
                if (!string.IsNullOrEmpty(value) && value != "1/1/1900 12:00:00 AM")
                {                   
                    DateTime decReturn;
                    culture = CultureInfo.CreateSpecificCulture("en-US");
                    styles = DateTimeStyles.None;
                    if (DateTime.TryParse(value, culture, styles, out decReturn))
                    {
                        return decReturn;
                    }
                    else
                    {
                        return  null;
                    }
                    //if (DateTime.TryParse(value, out decReturn))
                    //{
                    //    return decReturn;
                    //}
                    //else
                    //{
                    //    return null;
                    //}
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return null;
            }
        }
      
        
        
        public static DateTime? ToDateTimeSafeNull(object objvalue)
        {
            string dateString;
            CultureInfo culture;
            DateTimeStyles styles;
            //DateTime dateResult;

            DateTime? strdate = null;
            try
            {
                if (objvalue != null)
                {
                     // Parse a date and time with no styles.
                    dateString = objvalue.ToString();

                    if (dateString != "1/1/1900 12:00:00 AM")
                    {
                        DateTime decReturn;
                        culture = CultureInfo.CreateSpecificCulture("en-US");
                        styles = DateTimeStyles.None;
                        if (DateTime.TryParse(dateString, culture, styles, out decReturn))                       
                        {
                            strdate = decReturn;
                        }
                        else
                        {
                            strdate = null;
                        }
                    }
                }
                else
                {
                    strdate = null;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                strdate = null;// Convert.ToDateTime("1900-01-01");
            }
            return strdate;
        }


        public static string StringDateTime2DateOnly(object objvalue)
        {
            string dateString;
            CultureInfo culture;
            DateTimeStyles styles;
            DateTime dateResult;

            DateTime? strdate = System.DateTime.Now;
            string what = string.Empty;
            try
            {
                if (objvalue != null)
                {
                    // Parse a date and time with no styles.
                    dateString = objvalue.ToString();

                    if (dateString != "1/1/1900 12:00:00 AM")
                    {
                        culture = CultureInfo.CreateSpecificCulture("en-US");
                        styles = DateTimeStyles.None;
                        if (DateTime.TryParse(dateString, culture, styles, out dateResult))
                        {
                            string strDate = dateResult.ToString();
                            string[] words = strDate.Split(' ');
                            if (words.Length > 0)
                            {
                                what = words[0];
                                what = what.Trim();
                            }
                            else
                            {
                                what = string.Empty;
                            }
                        }
                        else
                        {
                            what = string.Empty;
                        }
                    }                                         
                }
               
            }
            catch (Exception ex)
            {
                lastException = ex;
                strdate = null;// Convert.ToDateTime("1900-01-01");
            }
            return what;
        }

        public static string ToShortDateString(object objvalue)
        {
            string dateString;
            CultureInfo culture;
            DateTimeStyles styles;
            DateTime dateResult;

            DateTime? strdate = System.DateTime.Now;
            string what = string.Empty;
            try
            {
                if (objvalue != null)
                {
                    // Parse a date and time with no styles.
                    dateString = objvalue.ToString();

                    if (dateString != "1/1/1900 12:00:00 AM")
                    {
                        culture = CultureInfo.CreateSpecificCulture("en-US");
                        styles = DateTimeStyles.None;
                        if (DateTime.TryParse(dateString, culture, styles, out dateResult))
                        {
                            what = dateResult.ToShortDateString();
                        }
                        else
                        {
                            what = string.Empty;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                lastException = ex;
                strdate = null;// Convert.ToDateTime("1900-01-01");
            }
            return what;
        }

   
        /// <summary>
        /// Convert into DateTime?
        /// </summary>
        /// <param name="value">Takes value</param>
        /// <returns>Returns a DateTime</returns>
        public static DateTime? ToNullableDateTime(object value)
        {
            try
            {
                if (value != null)
                {
                    DateTime dtReturn = default(DateTime);
                    if (DateTime.TryParse(Convert.ToString(value, System.Threading.Thread.CurrentThread.CurrentCulture), out dtReturn))
                    {
                        return dtReturn;
                    }
                    else
                    {
                        return default(DateTime?);
                    }
                }
                else
                {
                    return default(DateTime?);
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return default(DateTime?);
            }
        }

        /// <summary>
        // Convert Date Function Converts The Date Into M/dd/yy Format
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string Convert_date(string date)
        {
            try
            {
                if (date.Length != 0)
                {
                    date = DateTime.Parse(date).ToString("M/dd/yy");
                    return date;
                }
                else
                    return string.Empty;
            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }
        }
        public static string Convert_date(string date, string ddFormate)
        {
            try
            {
                if (date.Length != 0)
                {
                    date = DateTime.Parse(date).ToString(ddFormate);
                    return date;
                }
                else
                    return string.Empty;
            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }
        }

        /// <summary>
        /// Convert Date Function Converts The Date Into M/dd/yy Format
        /// this function is use to show date without time in Grid view     
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string Convert_dateToGrid(string date)
        {
            try
            {
                if (date.Length != 0)
                {
                    date = DateTime.Parse(date).ToString("M/dd/yy");

                    string[] strdateTime = date.Split(' ');
                    if (strdateTime.Length > 0)
                    {
                        return date = strdateTime[0];
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }
        }


        public static bool int2TrueOrFalse(int intvalue)
        {
            try
            {
                if (intvalue == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return false;
            }
        }

        public static bool int2TrueOrFalse(String intvalue)
        {
            try
            {
                if (string.Compare(intvalue, "1", true) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return false;
            }
        }

        public static bool string2TrueOrFalse(string stringvalue)
        {
            try
            {
                if (string.Compare(stringvalue, "true", true) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return false;
            }
        }


        public static bool object2TrueOrFalse(object stringvalue)
        {
            try
            {
                if (stringvalue != null)
                {
                    if (string.Compare(stringvalue.ToString(), "true", true) == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return false;
            }
        }


        public static int bit2int(bool bitvalue)
        {
            try
            {
                if (bitvalue)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return 0;
            }
        }

        public static string int2string(int bitvalue)
        {
            try
            {
                return bitvalue.ToString();
            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }
        }

        public static string long2string(long bitvalue)
        {
            try
            {
                return bitvalue.ToString();
            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }
        }

        public static string bit2Char(bool bitvalue)
        {
            try
            {
                if (bitvalue)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return "0";
            }
        }

        /// <summary>
        /// this method is use to convert string2money
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string string2Currency(string s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    double number = 0;// Todouble(s);
                    number = double.Parse(s);

                    string strReturn = string.Empty;
                    strReturn = String.Format("{0:0.00}", number);
                    //strReturn = String.Format("{0:c}", number);                    
                    return strReturn;

                }
                else
                {
                    return "0.00";
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return "0.00";
            }
        }

        public static String int2YesorNo(Int32 s)
        {
            try
            {
                if (Convert.ToInt32(s) >= 1)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
            catch (Exception e)
            {
                lastException = e;
                return "No";
            }
        }

        public static string string2string(string what)
        {
            try
            {
                if (!string.IsNullOrEmpty(what))
                {
                    what = Convert.ToString(what);
                    //what.Replace("\n\n/", "<P>");
                    //what = what.Replace("’", "'");
                    //what = what.Replace("“", "\"");
                    //what = what.Replace("”", "\"");
                    //what = what.Replace("'", "&rsquo;");
                    //what = what.Replace("\"", "&quot;");
                    //what = what.Replace("<", "&lt;");
                    //what = what.Replace(">", "&gt;");
                    what = what.Trim();
                }
                else
                {
                    what = string.Empty;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                what = string.Empty;
            }
            return what;
        }

        public static string object2String(object value)
        {
            string what = string.Empty;
            if (value != null)
            {
                what = value.ToString();
                try
                {
                    if (!string.IsNullOrEmpty(what))
                    {
                        what = Convert.ToString(what);
                        what = what.Trim();
                    }
                    else
                    {
                        what = string.Empty;
                    }
                }
                catch (Exception mex)
                {
                    lastException = mex;
                    what = string.Empty;
                    return what;
                }
            }
            return what;
        }

        public static string string2string(object value)
        {
            string what = string.Empty;
            if (value != null)
            {
                what = value.ToString();
                try
                {
                    if (!string.IsNullOrEmpty(what))
                    {
                        what = Convert.ToString(what);
                        what = what.Trim();
                    }
                    else
                    {
                        what = string.Empty;
                    }
                }
                catch (Exception mex)
                {
                    lastException = mex;
                    what = string.Empty;
                    return what;
                }
            }
            return what;
        }

     
      
        public static Guid string2Guid(string what)
        {
            Guid strGuid = Guid.Empty;
            try
            {
                if (!string.IsNullOrEmpty(what))
                {
                    strGuid = new Guid(what);
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                strGuid = Guid.Empty;
                return strGuid;
            }
            return strGuid;
        }

        public static Guid newGuid()
        {
            Guid strGuid = Guid.Empty;
            try
            {
                strGuid = Guid.NewGuid();
            }
            catch (Exception mex)
            {
                lastException = mex;
                strGuid = Guid.Empty;
                return strGuid;
            }
            return strGuid;
        }

        public static string newGuidString()
        {
            Guid strGuid = Guid.Empty;
            string GuidString = string.Empty;
            try
            {
                strGuid = Guid.NewGuid();
                GuidString = Convert.ToBase64String(strGuid.ToByteArray());
                GuidString = GuidString.Replace("=", "");
                GuidString = GuidString.Replace("+", "");
            }
            catch (Exception mex)
            {
                lastException = mex;
                strGuid = Guid.Empty;
                return GuidString;
            }
            return GuidString;
        }

        public static string maxLength(string stringvalue, int length)
        {
            try
            {
                if (stringvalue.Length > length)
                {
                    stringvalue = stringvalue.Substring(0, length);
                }
                return stringvalue;
            }
            catch (Exception mex)
            {
                lastException = mex;
                return stringvalue;
            }
        }


        #region Methods to support sql server's DBNULL
        /// <summary>
        /// This methods returns the string based value of the field and
        /// in case of DBNULL it returns empty string "" to avoid code crashes
        /// </summary>
        public static string DBNullSafe(object s)
        {
            try
            {
                if (s != null)
                {
                    return s.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }

        }
        #endregion


        /// <summary>
        /// use this method to set Default curson in Control
        /// </summary>
        /// <param name="control"></param>
        public static void SetFocus(System.Web.UI.Control control)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\r\n<script language='JavaScript'>\r\n");
            sb.Append("<!--\r\n");
            sb.Append("function SetFocus()\r\n");
            sb.Append("{\r\n");
            sb.Append("\tdocument.");

            System.Web.UI.Control p = control.Parent;
            while (!(p is System.Web.UI.HtmlControls.HtmlForm)) p = p.Parent;

            sb.Append(p.ClientID);
            sb.Append("['");
            sb.Append(control.UniqueID);
            sb.Append("'].focus();\r\n");
            sb.Append("}\r\n");
            sb.Append("window.onload = SetFocus;\r\n");
            sb.Append("// -->\r\n");
            sb.Append("</script>");

            //control.Page.RegisterClientScriptBlock("SetFocus", sb.ToString());
        }

        /// <summary>     
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string encrypt(string s)
        {
            try
            {
                string r = string.Empty;

                for (int c = 0; c < s.Length; c++)
                {
                    //string curchar = sprintf("%03s",523+ord(substr(s,c,1))) + substr(rand(),0,3);

                    int no = 523 + (int)(s.Substring(c, 1).ToCharArray())[0];
                    string curchar;
                    curchar = no.ToString();
                    curchar = curchar.PadLeft(3, '0');
                    curchar = curchar.Substring(0, 3);

                    Random rand = new Random();
                    string suffix = rand.Next().ToString();
                    suffix = suffix.PadLeft(3, '0');
                    suffix = suffix.Substring(0, 3);

                    r += curchar + suffix;
                }
                return r;
            }
            catch (Exception mex)
            {
                lastException = mex;
                return s;
            }
        }

        /// <summary>     
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string decrypt(string s)
        {
            try
            {
                string r = string.Empty;
                if (!string.IsNullOrEmpty(s))
                {
                    for (int c = 0; c < s.Length; c += 6)
                    {
                        //string curchar = chr(substr($s,$c,3)-523);
                        // int no = Common.string2int32(s.Substring(c, 3)) - 523;
                        int no = ML_Common.string2int32(s.Substring(c, 3)) - 523;
                        byte curchar = Convert.ToByte(no.ToString());


                        r += (char)curchar;
                    }
                }
                return r;
            }
            catch (Exception mex)
            {
                lastException = mex;
                return s;
            }
        }

        /// <summary>    
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string encrypt_number(int n)
        {
            try
            {
                if (n == 0)
                {
                    return string.Empty;
                }

                n = n * 131;

                string s = n.ToString();
                s = s.Trim();

                string ns = string.Empty;
                for (int lc = 0; lc < s.Length; lc++)
                {
                    string mc = s.Substring(lc, 1);
                    // int code = 65 + (Common.string2int32(mc) * 2);
                    int code = 65 + (ML_Common.string2int32(mc) * 2);
                    char thechar = (char)code;

                    ns = ns + thechar.ToString();

                }
                return ns;
            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }
        }

        /// <summary>       
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int decrypt_number(string s)
        {
            try
            {
                if (s == null)
                {
                    return 0;
                }

                if (s == string.Empty)
                {
                    return 0;
                }

                string nn = string.Empty;
                for (int lc = 0; lc < s.Length; lc++)
                {
                    string mc = s.Substring(lc, 1);
                    char[] chars = mc.ToCharArray();
                    int code = (int)chars[0];
                    code = code - 65;
                    code = code / 2;
                    mc = code.ToString();

                    nn = nn + mc;
                }
                int n = ML_Common.string2int32(nn) / 131;

                return n;
            }
            catch (Exception mex)
            {
                lastException = mex;
                return 0;
            }
        }


        #region Methods to support safe Excel export
        /// <summary>
        /// This methods returns the string based value of the field and
        /// in case of DBNULL it returns empty string "" to avoid code crashes
        /// Line brakes replaced with " "
        /// </summary>
        public static string ExcelSafe(object s)
        {
            try
            {
                if (s != null)
                {
                    if (s.GetType() == Type.GetType("System.DateTime"))
                    {

                        return Convert.ToDateTime(s).ToString("f");
                    }
                    else
                        return ML_Common.dirty(s.ToString().Replace("\x0A", " ").Replace("\x0D", " "));
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }

        }

        public static string ExcelSP2Wrapper(string filename)
        {
            // browser strings
            // SP2 Machine     = Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322)
            // Non SP2 Machine = Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322)

            string url = string.Empty;
            if (System.Web.HttpContext.Current.Request.UserAgent.IndexOf("SV1;") != -1)
            {
                url = "../ExportToExcel.aspx?f=" + filename;
            }
            else
            {
                url = "/DemoTrack/Exports/" + filename;
            }

            return url;
        }

        /// <summary>
        /// This methods returns the string based value of the field and
        /// in case of DBNULL it returns empty string "" to avoid code crashes
        /// Line brakes replaced with " "
        /// Date formats using current user preference
        /// </summary>
        /// 

        public static string ExcelDateSafe(object s, string dateFormat)
        {
            try
            {
                if (s != null)
                {
                    if (s.GetType() == Type.GetType("System.DateTime"))
                    {
                        DateTime date = Convert.ToDateTime(s);
                        return date.ToString(dateFormat) + " " + date.ToLongTimeString();

                    }
                    else
                        return ML_Common.dirty(s.ToString().Replace("\x0A", " ").Replace("\x0D", " "));
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }

        }

        /// <summary>
        /// This Method encloses phone number into ="xxx" so that they retain the 
        /// format otherwise Excel tries to guess some of it as numerics
        /// </summary>
        /// 
        public static string ExcelNumberSafe(object s)
        {
            try
            {
                if (s == null)
                {
                    return string.Empty;
                }

                return Enclose(s.ToString(), "=\"", "\"");
            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }

        }


        /// <summary>
        /// This methods returns time period in hh:mm:ss format 
        /// </summary>
        /// <param name="seconds">time period in seconds</param>
        /// <returns>hh:mm:ss string or "No data available" if input param less then 0 </returns>
        public static string secondsToHMS(int seconds)
        {
            try
            {
                if (seconds < 0)
                {
                    return "No data available";
                }
                else
                {
                    string ret = string.Empty;
                    TimeSpan ts = new TimeSpan(seconds * TimeSpan.TicksPerSecond);
                    int allHours = ts.Days * 24 + ts.Hours;
                    ret = allHours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString();
                    return ret;
                }

            }
            catch (Exception mex)
            {
                lastException = mex;
                return string.Empty;
            }

        }

        /// <summary>
        /// Enclose if needed
        /// </summary>
        public static string Enclose(string mainString, string start, string end)
        {
            try
            {
                if (mainString != null)
                {
                    mainString.Trim();
                    if (mainString != string.Empty)
                    {
                        mainString = start + mainString + end;
                        return mainString;
                    }
                }

                return mainString;
            }
            catch (Exception mex)
            {
                lastException = mex;
                return mainString;
            }

        }

        #endregion

        public static void SetDropDownValue(DropDownList ddlSearch, string values)
        {
            try
            {
                if (!string.IsNullOrEmpty(values))
                {
                    ddlSearch.ClearSelection();
                    for (int c = 0; c < ddlSearch.Items.Count; c++)
                    {
                        if (ddlSearch.Items[c].Value.Trim().ToLower() == values.Trim().ToLower())
                        {
                            ddlSearch.Items[c].Selected = true;
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
            }
        }

        public static void SetDropDownValue(DropDownList ddlSearch, long values)
        {
            try
            {
                if (values >= -1)
                {
                    ddlSearch.ClearSelection();
                    for (int c = 0; c < ddlSearch.Items.Count; c++)
                    {
                        if (ddlSearch.Items[c].Value.Trim().ToLower() == values.ToString().ToLower())
                        {
                            ddlSearch.Items[c].Selected = true;
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
            }
        }
      
    

        public static string GetDropDownValue(DropDownList ddlSearch, Boolean flag)
        {
            string returnval = string.Empty;
            try
            {
                if (flag)
                {
                    if (ddlSearch.SelectedIndex > 0)
                    {
                        returnval = ddlSearch.SelectedValue.ToString();
                    }
                }
                else
                {
                    if (ddlSearch.SelectedIndex > 0)
                    {

                        returnval = ddlSearch.SelectedItem.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                return string.Empty;

            }
            return returnval;
        }


        //ListBox
        public static List<string>  GetListBoxValue(System.Web.UI.WebControls.ListBox lbSearch, Boolean flag)
        {
            List<string> returnval = new List<string>();
            try
            {
                if (flag)
                {
                    returnval.AddRange(lbSearch.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Value).ToArray());
                    // returnval = String.Join(", ", lbSearch.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Value).ToArray());

                    //foreach (ListItem item in lbSearch.Items)
                    //{
                    //    if (item.Selected)
                    //    {    
                    //        returnval  += item.Value + ",";
                    //    }                     
                    //}                  
                }
                else
                {
                    returnval.AddRange(lbSearch.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Text).ToArray());
                   // returnval = String.Join(", ", lbSearch.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Text).ToArray());
                    //foreach (ListItem item in lbSearch.Items)
                    //{
                    //    if (item.Selected)
                    //    {
                    //        returnval += item.Text + ",";
                    //    }
                    //}      
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
             //   return string.Empty;

            }
            return returnval;
        }

        public static  List<Tuple<string, string>> GetListBoxTextandValue(System.Web.UI.WebControls.ListBox lbSearch, Boolean flag)
        {              

            List<Tuple<string, string>> returnval = new List<Tuple<string, string>>();

            try
            {
                if (flag)
                {
                   // returnval.AddRange(lbSearch.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Value).ToArray());
                    // returnval = String.Join(", ", lbSearch.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Value).ToArray());

                    foreach (ListItem item in lbSearch.Items)
                    {
                        if (item.Selected)
                        {    
                              // add an item
                                returnval.Add(new Tuple<string, string>(item.Value, item.Text));                          
                        }                     
                    }                  
                }
                else
                {
                    //returnval.AddRange(lbSearch.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Text).ToArray());
                    // returnval = String.Join(", ", lbSearch.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Text).ToArray());
                    foreach (ListItem item in lbSearch.Items)
                    {
                        if (item.Selected)
                        {    
                              // add an item
                                returnval.Add(new Tuple<string, string>(item.Value, item.Text));                          
                        }                     
                    }     
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
                //   return string.Empty;

            }
            return returnval;
        }
       

        public static void SetListBoxValue(System.Web.UI.WebControls.ListBox lbSearch, List<string> lstValues)
        {
            try
            {               
                    lbSearch.ClearSelection();

                    foreach (string selectedValue in lstValues)
                    {
                        lbSearch.Items.FindByValue(selectedValue).Selected = true;
                    }
                
                    //for (int c = 0; c < lbSearch.Items.Count; c++)
                    //{
                    //    if (lbSearch.Items[c].Value.Trim().ToLower() == values.Trim().ToLower())
                    //    {
                    //        lbSearch.Items[c].Selected = true;
                    //       // return;
                    //    }
                    //}
                
            }
            catch (Exception ex)
            {
                lastException = ex;
            }
        }




        //Windows
        //public static void SetDropDownValue(ComboBox ddlSearch, long values)
        //{
        //    try
        //    {
        //        if (values >= 0)
        //        {
        //            ddlSearch.Items.Clear();
        //            for (int c = 0; c < ddlSearch.Items.Count; c++)
        //            {
        //                if (ddlSearch.Items[c].ToString().Trim().ToLower() == values.ToString().ToLower())
        //                {
        //                    ddlSearch.SelectedValue = values.ToString();
        //                    return;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lastException = ex;
        //    }
        //}

        //Windows
        //public static string GetDropDownValue (ComboBox ddlSearch, Boolean flag=false, string itemname="")
        //{
        //    string returnval = string.Empty;
        //    try
        //    {
        //        if (flag)
        //        {
        //            if (ddlSearch.SelectedIndex >= 0)
        //            {
        //                returnval = ddlSearch.SelectedValue.ToString();
        //                //DataRowView row = (DataRowView)ddlSearch.SelectedValue;
        //                //if (row != null)
        //                //{
        //                //    if (string.IsNullOrEmpty(itemname))
        //                //    {
        //                //        returnval = row[0].ToString();
        //                //    }
        //                //    else
        //                //    {
        //                //        returnval = row[itemname.Trim()].ToString();
        //                //    }
        //                //}
        //                //else
        //                //{
        //                //    returnval = string.Empty;
        //                //}
        //            }
        //        }
        //        else
        //        {
        //            if (ddlSearch.SelectedIndex >= 0)
        //            {
        //                DataRowView row = (DataRowView)ddlSearch.SelectedItem;
        //                if (row != null)
        //                {
        //                    if (string.IsNullOrEmpty(itemname))
        //                    {
        //                        returnval = row[1].ToString();
        //                    }
        //                    else
        //                    {
        //                        returnval = row[itemname.Trim()].ToString();
        //                    }
        //                }
        //                else
        //                {
        //                    returnval = string.Empty;
        //                }
                      
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lastException = ex;
        //        return string.Empty;

        //    }
        //    return returnval;
        //}

        /// <summary>
        /// This Method is use to  Set Radio Button 
        /// </summary>
        /// <param name="ddlSearch"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        /// <Developer>
        /// <Name>Trimurari Singh</Name>
        /// <CreatedOn>09/01/2011</CreatedOn>
        /// <LastModifiedOn></LastModifiedOn>
        /// </Developer>
        public static string GetRDOValue(RadioButtonList ddlSearch, Boolean flag)
        {
            string returnval = string.Empty;
            try
            {
                if (flag)
                {
                    if (ddlSearch.SelectedIndex >= 0)
                    {
                        returnval = ddlSearch.SelectedValue.ToString();
                    }
                }
                else
                {
                    if (ddlSearch.SelectedIndex >= 0)
                    {
                        returnval = ddlSearch.SelectedItem.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                lastException = ex;
            }
            return returnval;
        }

        /// <summary>
        /// This Method is use to get radio Button value
        /// </summary>
        /// <param name="ddlSearch"></param>
        /// <param name="values"></param>
        /// <Developer>
        /// <Name>Trimurari Singh</Name>
        /// <CreatedOn>09/01/2011</CreatedOn>
        /// <LastModifiedOn></LastModifiedOn>
        /// </Developer>
        public static void SetRDOValue(RadioButtonList ddlSearch, string values)
        {
            try
            {
                if (!string.IsNullOrEmpty(values))
                {
                    ddlSearch.ClearSelection();
                    for (int c = 0; c < ddlSearch.Items.Count; c++)
                    {
                        if (ddlSearch.Items[c].Value.Trim().ToLower() == values.Trim().ToLower())
                        {
                            ddlSearch.Items[c].Selected = true;
                            return;
                        }
                    }
                }
                else
                {
                    ddlSearch.ClearSelection();
                    ddlSearch.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
            }
        }

     //Web
        public static byte[] GetPhotofilePath2Byte(FileUpload filePath)
        {
            byte[] imgByte = null;
            try
            {
                // if (!string.IsNullOrEmpty(filePath))
                //{
                //  FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                //  BinaryReader reader = new BinaryReader(stream);
                // imgByte = reader.ReadBytes((int)stream.Length);

                //To create a PostedFile
                HttpPostedFile File = filePath.PostedFile;
                //Create byte Array with file len
                imgByte = new Byte[File.ContentLength];
                //force the control to load data in array
                File.InputStream.Read(imgByte, 0, File.ContentLength);

                // reader.Close();
                // stream.Close();
                //  }
            }
            catch (Exception ex)
            {
                lastException = ex;

            }
            return imgByte;
        }

        public static byte[] GetbyteFromDB(object imgbyte)
        {
            byte[] MyData = new byte[0];
            try
            {
                if (imgbyte != null && imgbyte != System.DBNull.Value)
                {
                    MyData = (byte[])imgbyte;
                    // stream = new MemoryStream(MyData);
                    // pictureBox1.Image = Image.FromStream(stream);
                    //  pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;

            }
            return MyData;
        }

        public static MemoryStream byte2MemoryStream(byte[] imgbyte)
        {
            // byte[] MyData = new byte[0];
            MemoryStream stream = null;
            try
            {
                if (imgbyte != null)
                {
                    // MyData = (byte[])myRow[0];
                    stream = new MemoryStream(imgbyte);
                    //  pictureBox1.Image = Image.FromStream(stream);
                    // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;               
                }
            }
            catch (Exception ex)
            {
                lastException = ex;
            }
            return stream;
        }


        // upload image on server/ DB

        public static byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert, System.Drawing.Imaging.ImageFormat formatOfImage)
        {
            byte[] Ret = null;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return Ret;
        }

        //Open file in to a filestream and read data in a byte array.
        public static byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        public static byte[] ReadFileFromDB(object imgbyte)
        {
            byte[] MyData = new byte[0];
            try
            {
                if (imgbyte != null && imgbyte != System.DBNull.Value)
                {
                    MyData = (byte[])imgbyte;
                    // stream = new MemoryStream(MyData);
                    // pictureBox1.Image = Image.FromStream(stream);
                    //  pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                lastException = ex;

            }
            return MyData;
        }
        
              
        public  static bool HelperConvertNumberToText(int num, out string buf)
        {

            string[] strones = {
            "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
            "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen",
          };



            string[] strtens = {
              "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty",
              "Seventy", "Eighty", "Ninety", "Hundred"

          };



            string result = "";
            buf = "";
            int single, tens, hundreds;


            if (num > 1000)
                return false;



            hundreds = num / 100;
            num = num - hundreds * 100;
            if (num < 20)
            {
                tens = 0; // special case
                single = num;
            }

            else
            {
                tens = num / 10;
                num = num - tens * 10;
                single = num;
            }            

            result = "";
                        
            if (hundreds > 0)
            {
                result += strones[hundreds - 1];
                result += " Hundred ";
            }

            if (tens > 0)
            {
                result += strtens[tens - 1];
                result += " ";
            }

            if (single > 0)
            {
                result += strones[single - 1];
                result += " ";
            }
                        
            buf = result;

            return true;

        }



      public static bool ConvertNumberToText(int num, out string result)
        {
            string tempString = "";
            int thousands;
            int temp;

            result = "";
            if (num < 0 || num > 100000)
            {
              //MessageBox.Show(num + " \tNot Supported");
                return false;
            }          

            if (num == 0)
            {
               //MessageBox.Show(num + " \tZero");
                return false;
            }

            if (num < 1000)
            {
                HelperConvertNumberToText(num, out tempString);
                result += tempString;
            }
            else
            {
                thousands = num / 1000;
                temp = num - thousands * 1000;
                HelperConvertNumberToText(thousands, out tempString);
                result += tempString;
                result += "Thousand ";
                HelperConvertNumberToText(temp, out tempString);
                result += tempString;
            }

            return true;

          //output/result
            //if (ConvertNumberToText(num, out result) == true)
               // Console.WriteLine(num + "\t" + result);

        }


      private static Random RNG = new Random();

      public string Create16DigitString()
      {
          var builder = new StringBuilder();
          while (builder.Length < 16)
          {
              builder.Append(RNG.Next(10).ToString());
          }
          return builder.ToString();
      }

      private static HashSet<string> Results = new HashSet<string>();

      public string CreateUnique16DigitString()
      {
          var result = Create16DigitString();
          while (!Results.Add(result))
          {
              result = Create16DigitString();
          }

          return result;
      }



    }
}
