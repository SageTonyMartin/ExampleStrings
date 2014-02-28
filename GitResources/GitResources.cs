using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitResources
{
    public class ContactResources
    {
        public string GetResourceString(string StringID)
        {
            string resStr = string.Empty;
            switch (StringID.ToUpper())
            {
                case "STRTITLE": resStr = Resource1.strTitle; break;
                case "STRSUBTITLE": resStr = Resource1.strSubTitle; break;
                case "STRNAME": resStr = Resource1.strName; break;
                case "STRADDRESS": resStr = Resource1.strAddress; break;
                case "STRCITY": resStr = Resource1.strCity; break;
                case "STRSTATE": resStr = Resource1.strState; break;
                case "STRZIP": resStr = Resource1.strZip; break;
                case "STRPHONE": resStr = Resource1.strPhone; break;
                case "HELPNAME": resStr = Resource1.HelpName; break;
                case "HELPADDRESS": resStr = Resource1.HelpAddress; break;
                case "HELPCITY": resStr = Resource1.HelpCity; break;
                case "HELPSTATE": resStr = Resource1.HelpState; break;
                case "HELPZIP": resStr = Resource1.HelpZip; break;
                case "HELPPHONE": resStr = Resource1.HelpPhone; break;
                default: break;
            }
            return resStr;
        }
    }
}
