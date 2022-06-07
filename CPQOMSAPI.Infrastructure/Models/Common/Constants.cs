using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPI.Infrastructure.Models.Common
{
    public static class Constants
    {
        public static class Configuration
        {
            public const string ProductsDBConnectionString = "ProductsContext";
            public const string OrdersDBConnectionString = "OrdersContext";
           public const string DocsDBConnectionString = "DocsContext";
            public const string TestDBConnectionString = "HMSContext";
            public const string HMSDBConnectionString = "HMSContext";
        }

    }
}
