using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models.Interfaces;

namespace HRPortal.Data.Repository
{
    public static class Factory
    {
        public static IRepository CreateRepository()
        {
            switch (ConfigurationManager.AppSettings["mode"])
            {
                case "mock":
                    return new MockRepository();
                case "prod":
                    return new ProdRepository();
                default:
                    throw new NotSupportedException("You need to choose a mode!!");
            }
        }
    }
}
