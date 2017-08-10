using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorldApp
{
    public partial class MainPage : ContentPage
    {

       //HelloWorldPage helloWorldPage;
      //  MainPage mainPage;

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // if (this.helloWorldPage == null)
            //  {
            //      this.helloWorldPage = new HelloWorldPage();
            //  }

            // helloWorldBtn += 1;
            //  mainPage = new HelloWorldApp.HelloWorldPage();

            App.Current.MainPage = new HelloWorldPage();

        }
    }
}
