using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;

namespace ModelLayer
{
	/// <summary>
	/// Summary description for AddinResourceManager.
	/// </summary>
	public class EResourceManager
	{
		private static NameValueCollection resources = null;
        private EResourceManager() { }

		private static void LoadResources()
		{
			resources = new NameValueCollection();
			resources.Add("msg_AccessDenied", "You are currently logged on from another computer. Only one login per user is allowed at any given time.\nThe current DemoMail composition window can no longer be used. Please close it and restart Outlook.");
			resources.Add("msg_UnknownServerError", "Server error.\nPlease try again later.");
			resources.Add("msg_Expire", "Access to the tool had expired.\n Contact your Client Administrator.");
			resources.Add("msg_LoginIncorrect", "Login failed.");
			resources.Add("msg_LoadParentCompaniesFailed", "Initialization failed.");
			resources.Add("msg_RegistrySaveFailed", "There was an error saving data to Registry.");
			resources.Add("msg_RegistryProxySaveFailed", "There was an error saving  proxy data to Registry.");
			resources.Add("msg_MustBeLogged", "You must be logged in to use DemoMail");
			resources.Add("msg_AccessOLUIError", "Unable access to Outlook UI.");
			resources.Add("msg_TemplateAddError", "Error adding template.");
			resources.Add("msg_CanceledByUser", "Canceled by user.");
			resources.Add("msg_MessageConstructing", "Message is being constructed. Please stand by...");
			resources.Add("msg_EmailNotUnique", "Email is used by another contact.");
			resources.Add("msg_SendToDistList", "DemoMails can not currently be sent to distribution lists.");
			resources.Add("msg_ContactUpdated", "DemoMail database updated.");
			resources.Add("msg_EmptyMessage", "No media session has been selected.\nPlease select at least one media session.");
			resources.Add("msg_EmptyFirstName", "First name cannot be empty.");
			resources.Add("msg_EmptyLastName", "Last name cannot be empty.");
			resources.Add("msg_EmptyCompany", "Company cannot be empty.");
			resources.Add("msg_InvalidEmail", "E-mail address is not valid.");
			resources.Add("msg_ErrorLoadingContact", "Error loading contact.");
			resources.Add("msg_NoRecipients", "No recipients found.");
			resources.Add("msg_DuplicateSessions", "Duplicate session found.\nMessage will not be sent.");
			resources.Add("msg_TemplateCorrupted", "The DemoMail template has been modified and corrupted and cannot be sent. You must now close this window and open a new DemoMail composition window.\n\nDo not attempt to modify the contents of the DemoMail template as this will again result in corruption of the template.");
			resources.Add("msg_MustBeWordMail", "To use DemoMail your email editor must be set to Word.  Go to: Tools->Options->Email and check the box “Use Microsoft Office Word 2003 as email editor”");
			resources.Add("msg_AddContactToDB", "Error adding contact to DemoMail.\nPlease try again later.");
			
			resources.Add("title_General", "DemoMail™ Outlook Add-in");
			resources.Add("title_ValidatingUser", "Validating user...");
			resources.Add("title_LoadingSessions", "Loading sessions...");
			resources.Add("title_LoadingTemplate", "Loading template...");
			resources.Add("title_SavingTrackingInfo", "Saving tracking info...");
			resources.Add("title_LoadingGetServerDate", "Loading server time information...");
			resources.Add("title_LoadingTrackViewingReport", "Loading track viewing report...");
			resources.Add("title_LoadingMailingsDetailsReport", "Loading mailings details report...");
			resources.Add("title_LoadingViewingDetailsReport", "Loading viewings details report...");
			resources.Add("title_LoadingContacts", "Loading contacts...");
			resources.Add("title_LoadingContact", "Loading contact...");
			resources.Add("title_UploadContact", "Uploading contact info...");
			resources.Add("title_ValidatingEmail", "Validating email...");
			resources.Add("title_UpdateContact", "Updating contact info...");
			resources.Add("title_InitContactEditor", "Initializing editor...");

			resources.Add("item_SelectContent", "Select Content");
			resources.Add("item_RemoveContent", "Remove Content");

			resources.Add("msgfrmt_RemoveTemplateFailed", "Failed to remove template \"{0}\" from mail body. \nProbably template is corrupted.");
			resources.Add("msgfrmt_SessionNotAddedInBody", "A session found in the mail body which was not added.");

		}

		private static NameValueCollection GetResources()
		{
			if(resources == null)
			{
				LoadResources();
			}

			return resources;
		}

		public static string GetString(string name)
		{
			return GetResources().Get(name);
		}

		public static Image GetImage(string name)
		{
            //Commented By Umesh To Develop DM Outlook Addins 2007 
            //Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			//return Image.FromStream(stream);
            Bitmap bMap = null;// new Bitmap(Config.InstallPath + name);
            return (Image)bMap;

		}
	}
}
