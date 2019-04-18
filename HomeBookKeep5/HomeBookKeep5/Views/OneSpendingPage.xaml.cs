using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeBookKeep5.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OneSpendingPage : ContentPage
	{



		public OneSpendingPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(App.DBFILENAME);
            using (ApplicationContext db = new ApplicationContext(dbPath))
            {
                //var result = from costCat in db.CostCats
                //                 //join costSubCat in db.CostSubCats on costCat.Id equals costSubCat.CostCatId
                //                select costCat;
                //CatPicker.ItemsSource = result.ToList();

                var resSubCat = from rsc in db.CostSubCats
                                select rsc;
                SubCatPicker.ItemsSource = resSubCat.ToList();
                //var resultUnits = from resUn in db.Units
                //                select resUn;
                //UnitsPicker.ItemsSource = resultUnits.ToList();

                //var currencies = from curr in db.Currencies
                //                 select curr;
                //CurrPicker.ItemsSource = currencies.ToList();
            }
            //using (ApplicationContext db2 = new ApplicationContext(dbPath))
            //{
            //    var currencies = from cur in db2.Currencies
            //                     select cur;
            //    CurrPicker.ItemsSource = currencies.ToList();
            //}
            base.OnAppearing();
        }

        private void BtnCatPicker_Clicked(object sender, EventArgs e)
        {
            CatPicker.Focus();
        }

        private void BtnSubCatPicker_Clicked(object sender, EventArgs e)
        {
            SubCatPicker.Focus();
        }

        private void BtnCurrPicker_Clicked(object sender, EventArgs e)
        {
            CurrPicker.Focus();
        }

        private void BtnUnitsPicker_Clicked(object sender, EventArgs e)
        {
            UnitsPicker.Focus();
        }

        void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntryCat.Text = CatPicker.Items[CatPicker.SelectedIndex];
        }

        void SubCatPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntrySubCat.Text = SubCatPicker.Items[SubCatPicker.SelectedIndex];
        }

        void CurrPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntryCurr.Text = CurrPicker.Items[CurrPicker.SelectedIndex];
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (labelDate.Text != null)
                labelDate.Text = e.NewDate.ToString("dd/MM/yyyy");
        }

        void UnitsPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntryUnit.Text = UnitsPicker.Items[UnitsPicker.SelectedIndex];
        }

        private void DatePicker_Click(object sender, EventArgs e)
        {
        }
    }
}