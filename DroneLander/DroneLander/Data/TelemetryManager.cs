using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace DroneLander
{
    public partial class TelemetryManager
    {
        static TelemetryManager defaultInstance = new TelemetryManager();
        MobileServiceClient client;

        private TelemetryManager()
        {
            this.client = new MobileServiceClient(Common.MobileServiceConstants.AppUrl);
        }

        public static TelemetryManager DefaultManager
        {
            get
            {
                return defaultInstance;
            }
            private set
            {
                defaultInstance = value;
            }
        }

        public MobileServiceClient CurrentClient
        {
            get { return client; }
        }
    }
}
