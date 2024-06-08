using PersonalFinance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinanceHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceHost sh = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            Uri bpa = new Uri("net.pipe://localhost/NetNamedPipeBinding");
            Uri tcpa = new Uri("net.tcp://localhost:8000/TcpBinding");

            sh = new ServiceHost(typeof(PersonalFinance.Service1), bpa, tcpa);
            // sh = new ServiceHost(typeof(ServiceClass), tcpa);

            NetTcpBinding tcpb = new NetTcpBinding();
            NetNamedPipeBinding pb = new NetNamedPipeBinding();

            ServiceMetadataBehavior mBehave = new ServiceMetadataBehavior();

            sh.Description.Behaviors.Add(mBehave);

            sh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexNamedPipeBinding(), "mex");
            sh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");

            sh.AddServiceEndpoint(typeof(IService1), pb, bpa);
            sh.AddServiceEndpoint(typeof(IService1), tcpb, tcpa);

            sh.Open();
            label1.Text = "Service Running";
        }
    }
}
