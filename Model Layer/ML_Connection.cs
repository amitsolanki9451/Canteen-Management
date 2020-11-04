using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using ModelLayer;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Data.Common;

namespace ModelLayer
{
   public class ML_Connection
    {
        public delegate bool  IsSourceDbConnection_Delegate();
        public delegate bool IsTargetDbConnection_Delegate();

       
       

        #region Private fields
        private static Application hostApplication;      
        private static string installPath = null;
        private static NameValueCollection assemblyConfig = null;       
        #endregion
        #region Private constants
        private const string RegistryKeyName = @"Software\test";
        private const int DefaultTimeout = 100;
        private const int DefaultUpdaterInterval = 60;
        #endregion

       public static string CreateConnection()
       {
           //System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/Ecertificate");
           //System.Configuration.ConnectionStringSettings connString;
           //if (rootWebConfig.ConnectionStrings.ConnectionStrings.Count > 0)
           //{
           //    connString = rootWebConfig.ConnectionStrings.ConnectionStrings["PnGConString"];
           //    if (connString != null)
           //        Console.WriteLine("PnGConString connection string = \"{0}\"", connString.ConnectionString);
           //    else
           //        Console.WriteLine("No PnGConString connection string");
           //}

           string connectionString = ConfigurationManager.ConnectionStrings["ManualString"].ToString();
           //string connectionString = AppConfig["ManualString"].ToString();
           return connectionString;
       }
       public static string GetURLType()
       {
           string strURLType = AppConfig["URLType"].ToString();
           if (string.IsNullOrEmpty(strURLType))
           {
               strURLType = "http://mcertificate.org/verifyCertificate.aspx?";
           }
           return strURLType;
       }

       public static string Hindalco_DigitalizationStringConnection()
       {

           string connectionString = ConfigurationManager.ConnectionStrings["Hindalco_DigitalizationString"].ToString();

           return connectionString;
       }

       public static bool getTargetDbStatus()
       {
           bool strReturn = false;
           IsTargetDbConnection_Delegate tdb = new IsTargetDbConnection_Delegate(ML_Connection.IsTargetDbConnection);

          // Action action = ML_Connection.IsTargetDbConnection;
           //action.BeginInvoke(null, null);

        
           try
           {
               // Initiate the asynchronous call.
               IAsyncResult ar = tdb.BeginInvoke( null, null);

               // Wait for the WaitHandle to become signaled.
               ar.AsyncWaitHandle.WaitOne();

                           // Retrieve the results of the asynchronous call.
               strReturn = tdb.EndInvoke(ar);  

               //strReturn = tdb(); //invoking the method
           }
           catch (DbException)
           {
               // logger.Warn(LogTopicEnum.Agent, "Error in DB connection test on CheckDBConnection", ex);
               strReturn = false; // any error is considered as db connection error for now
           }
           catch (Exception ex)
           {
               System.Exception exctm = ex;
               // logger.Warn(LogTopicEnum.Agent, "Error in DB connection test on CheckDBConnection", ex);
               strReturn = false; // any error is considered as db connection error for now
           }

           return strReturn;
       }
    
       
       public static bool IsTargetDbConnection()//string connectionString)
       {
           bool strReturn = false;
           try
           {
               using (var connection = new SqlConnection(AppConfig["TargetConString"].ToString()))
               {
                   connection.Open();
                   strReturn = true;
               }
           }
           catch (DbException)
           {
               // logger.Warn(LogTopicEnum.Agent, "Error in DB connection test on CheckDBConnection", ex);
               strReturn = false; // any error is considered as db connection error for now
           }
           catch (Exception ex)
           {
               System.Exception exctm = ex;
               // logger.Warn(LogTopicEnum.Agent, "Error in DB connection test on CheckDBConnection", ex);
               strReturn = false; // any error is considered as db connection error for now
           }

           return strReturn;
       }


       public static bool getSourceDbStatus()
       {
           bool strReturn = false;
           IsSourceDbConnection_Delegate sdb = new IsSourceDbConnection_Delegate(ML_Connection.IsSourceDbConnection);
           try
           {
               // Initiate the asynchronous call.
               IAsyncResult ar = sdb.BeginInvoke(null, null);
               // Wait for the WaitHandle to become signaled.
               ar.AsyncWaitHandle.WaitOne();

               // Retrieve the results of the asynchronous call.
               strReturn = sdb.EndInvoke(ar);  

              // IAsyncResult R = null;
            //   strReturn = sdb();//(null, null); //invoking the method
           }
           catch (DbException)
           {
               // logger.Warn(LogTopicEnum.Agent, "Error in DB connection test on CheckDBConnection", ex);
               strReturn = false; // any error is considered as db connection error for now
           }
           catch (Exception ex)
           {
               System.Exception exctm = ex;
               strReturn = false; // any error is considered as db connection error for now
           }

           return strReturn;
       }
       
       public static bool IsSourceDbConnection()//string connectionString)
       {
           bool strReturn = false;
           try
           {
               using (var connection = new SqlConnection(CreateConnection()))
               {
                   connection.Open();
                   strReturn = true;
               }
           }
           catch (DbException)
           {
               // logger.Warn(LogTopicEnum.Agent, "Error in DB connection test on CheckDBConnection", ex);
               strReturn = false; // any error is considered as db connection error for now
           }
           catch (Exception ex)
           {
               System.Exception exctm = ex;
               strReturn = false; // any error is considered as db connection error for now
           }
           return strReturn;
       }

       public static bool CheckDbConnection()//string connectionString)
       {
           try
           {
               using (var connection = new SqlConnection(CreateConnection()))
               {
                   connection.Open();
                   return true;
               }
           }
           catch (DbException)
           {
               // logger.Warn(LogTopicEnum.Agent, "Error in DB connection test on CheckDBConnection", ex);
               return false; // any error is considered as db connection error for now
           }
           catch (Exception ex)
           {
               System.Exception exctm = ex;
               return false; // any error is considered as db connection error for now
           }
       }


       #region Private properties
       private static NameValueCollection AssemblyConfig
       {
           get
           {
               if (assemblyConfig == null)
               {
                   try
                   {
                       string configPath = Path.ChangeExtension(Assembly.GetExecutingAssembly().Location, ".config");
                       XmlDocument document = new XmlDocument();
                       document.Load(configPath);
                       XmlNode node = document.SelectSingleNode("/configuration/appSettings");
                       NameValueSectionHandler handler = new NameValueSectionHandler();
                       NameValueCollection encryptedConfig = handler.Create(null, null, node) as NameValueCollection;
                       assemblyConfig = new EncryptedNameValueCollection(encryptedConfig);
                   }
                   catch { }


                   if (assemblyConfig == null)
                   {
                       assemblyConfig = new NameValueCollection();
                   }
               }
               return assemblyConfig;
           }

       }

       public static NameValueCollection AppConfig
       {

           get
           {

               return new EncryptedNameValueCollection(ConfigurationManager.AppSettings);//   ConfigurationSettings.AppSettings);
               // return null;   
           }
       }
       #endregion

       #region Public properties

       /// <summary>
       /// Reference to Outlook object.
       /// </summary>
       public static Application HostApplication
       {
           get { return hostApplication; }
           set
           {
               hostApplication = value;              
           }
       }

      

       /// <summary>
       /// Gets install path.
       /// </summary>
       public static string InstallPath
       {
           get
           {
               if (installPath == null)
               {
                   RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(RegistryKeyName);
                   installPath = (string)registryKey.GetValue("InstallPath", string.Empty);
                   registryKey.Close();
               }

               return installPath;
           }
       }

       /// <summary>
       /// Gets path to updater application.
       /// </summary>
       public static string UpdaterPath
       {
           get { return InstallPath + "MailUpdater.exe"; }
       }

       /// <summary>
       /// Gets path to error log folder.
       /// </summary>
       public static string LogPath
       {
           get
           {
               string path = LocalApplicationDataPath + @"Log\";
               if (!Directory.Exists(path))
               {
                   Directory.CreateDirectory(path);
               }
               return path;
           }
       }

       /// <summary>
       /// Gets local ApplicationData path for add-in.
       /// \Documents and Settings\[USER]\Local Settings\Application Data\Point Marketing\DemoMail Outlook Add-in\
       /// </summary>
       public static string LocalApplicationDataPath
       {
           get
           {
               string root = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
               string path = root + @"\Marketing\Addin2007\";
               if (!Directory.Exists(path))
               {
                   Directory.CreateDirectory(path);
               }
               return path;
           }
       }

      

       /// <summary>
       /// True - if show extended error allowed, 
       /// false - show generic error message on exception.
       /// </summary>
       public static bool ShowError
       {
           get
           {
               bool result = false;
               string showErrorValue = AssemblyConfig["ShowError"];
               if (showErrorValue != null && showErrorValue.ToUpper() == "TRUE")
               {
                   result = true;
               }

               return result;
           }
       }

       public static int Timeout
       {
           get
           {
               int timeout = DefaultTimeout;
               string timeoutValue = AssemblyConfig["Timeout"];
               if (timeoutValue != null)
               {
                   try
                   {
                       timeout = Convert.ToInt32(timeoutValue);
                   }
                   catch { }
               }

               return timeout;
           }
       }

       /// <summary>
       /// Gets value of UpdaterInterval config key
       /// </summary>
       public static int UpdaterInterval
       {
           get
           {
               int interval = DefaultUpdaterInterval;
               string intervalValue = AssemblyConfig["UpdaterInterval"];
               if (intervalValue != null)
               {
                   try
                   {
                       interval = Convert.ToInt32(intervalValue);
                   }
                   catch { }
               }

               return interval;
           }
       }

       public static Version Version
       {
           get
           {
               Version version = new Version("0.0.1");
               RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(RegistryKeyName);
               string ver = (string)registryKey.GetValue("Version", null);
               if (ver != null)
               {
                   version = new Version(ver);
               }
               return version;
           }
       }

     

       #endregion




   }


}
