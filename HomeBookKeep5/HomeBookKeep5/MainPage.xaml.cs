using HomeBookKeep5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HomeBookKeep5
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
			Detail = new NavigationPage(new OneSpendingPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new CostSCatPage())
            {
                BarBackgroundColor = Color.FromHex("#008000")
            };

            IsPresented = false;
        }
        
        private void ButtonSpending_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new OneSpendingPage())
            {
                BarBackgroundColor = Color.FromHex("#008000")
            };

            IsPresented = false;
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new CostSubCatCats())
            {
                BarBackgroundColor = Color.FromHex("#008000")
                
            };

            IsPresented = false;
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new OneSpendingPage())
            {
                BarBackgroundColor = Color.FromHex("#008000")
            };

            IsPresented = false;
        }

        private void ButtonCostCats_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new CostCatsAll())
            {
                BarBackgroundColor = Color.FromHex("#008000")
            };

            IsPresented = false;
        }
    }
}

//CostSubCatCats  OneSpendingPage
