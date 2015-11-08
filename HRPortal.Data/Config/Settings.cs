using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HRPortal.Data.Config
{
    public class Settings
    {

        private static string _rootPath;

        public static string RootPath
        {
            get
            {
                if (string.IsNullOrEmpty(_rootPath))
                {
                    _rootPath = HttpContext.Current.Server.MapPath("~/");
                }

                return _rootPath;
            }
        }



        //var rootPath = Server.MapPath("~/");
    }
}
