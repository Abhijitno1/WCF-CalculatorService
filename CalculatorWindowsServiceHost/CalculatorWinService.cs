using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CalculatorService;

namespace CalculatorWindowsServiceHost
{
    public partial class CalculatorWinService : ServiceBase
    {
        ServiceHost sHost;
        public CalculatorWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            sHost = new ServiceHost(typeof(SimpleCalculator));
            sHost.Open();
        }

        protected override void OnStop()
        {
            sHost.Close();
        }
    }
}
