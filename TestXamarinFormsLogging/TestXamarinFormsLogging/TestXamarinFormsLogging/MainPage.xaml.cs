using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsLogger;

namespace TestXamarinFormsLogging
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            XamarinFormsLogger.Logger.SetApplicationLocalStoragePath();
        }
        public void OnButtonClicked(object sender, EventArgs args)
        {
            XamarinFormsLogger.Logger.Tag = "OnButtonClicked";
            XamarinFormsLogger.Logger.Level = LoggingLevel.Debug;
            XamarinFormsLogger.Logger.Message = "Hello from Xamarin Forms";
            XamarinFormsLogger.Logger.Log();
        }
    }
}
