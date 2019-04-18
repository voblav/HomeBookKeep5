using HomeBookKeep5.Models;
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
    public partial class CostSCatPage : ContentPage
    {
        string dbPath;
        public CostSCatPage()
        {
            InitializeComponent();
            dbPath = DependencyService.Get<IPath>().GetDatabasePath(App.DBFILENAME);
        }

        private void SaveCostSCat(object sender, EventArgs e)
        {
            var costSCat = (CostSubCat)BindingContext;
            if (!String.IsNullOrEmpty(costSCat.Name))
            {
                using (ApplicationContext db = new ApplicationContext(dbPath))
                {
                    if (costSCat.Id == 0)
                        db.CostSubCats.Add(costSCat);
                    else
                    {
                        db.CostSubCats.Update(costSCat);
                    }
                    db.SaveChanges();
                }
            }
            this.Navigation.PopAsync();
        }

        private void DeleteCostSCat(object sender, EventArgs e)
        {
            var costSCat = (CostSubCat)BindingContext;
            using (ApplicationContext db = new ApplicationContext(dbPath))
            {
                db.CostSubCats.Remove(costSCat);
                db.SaveChanges();
            }
            this.Navigation.PopAsync();
        }
    }
}