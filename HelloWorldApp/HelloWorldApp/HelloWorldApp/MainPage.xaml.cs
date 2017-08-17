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


        /// <summary>
        /// Constructor for home screen
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Method for HelloWorld button to switch to the hello world screen.
        /// </summary>
     
        private void Button_Clicked(object sender, EventArgs e)
        {
            
            App.Current.MainPage = new HelloWorldPage();

        }
    }
}
