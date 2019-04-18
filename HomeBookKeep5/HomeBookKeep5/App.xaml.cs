using HomeBookKeep5.Models;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HomeBookKeep5
{
    public partial class App : Application
    {
        public const string DBFILENAME = "bookkeeper.db";
        public App()
        {
            InitializeComponent();

            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(DBFILENAME);
            using (var db = new ApplicationContext(dbPath))
            {
                // Создаем бд, если она отсутствует
                db.Database.EnsureCreated();
                if (db.CostSubCats.Count() == 0)
                {
                    db.CostCats.Add(new CostCat { Name = "Продукты" });
                    db.CostCats.Add(new CostCat { Name = "Одежда" });
                    db.CostSubCats.Add(new CostSubCat { Name = "Хлеб", CostCatId = 1 });
                    db.CostSubCats.Add(new CostSubCat { Name = "Туфли", CostCatId = 2 });
                    db.CostSubCats.Add(new CostSubCat { Name = "Водка", CostCatId = 1});
                    db.Currencies.Add(new Currency { Name = "Доллар" });
                    db.Currencies.Add(new Currency { Name = "Гривна" });
                    db.Units.Add(new Unit { Name = "штук" });
                    db.Units.Add(new Unit { Name = "литров" });
                    db.CostCats.Add(new CostCat { Name = "Одежда" });
                    db.SaveChanges();
                }
            }
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
