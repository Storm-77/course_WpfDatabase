using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DbProject.dbContexts;
using Microsoft.EntityFrameworkCore;

namespace DbProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                //DataContext = new viewModels.MainViewModel(new viewModels.LoginViewModel())
                DataContext = new viewModels.MainViewModel(new viewModels.TableCreationViewModel())
            };

            DbContextFactory factory = new("server=localhost;user=root;database=test;password=;port=3306");

            using(PrimaryDbContext context = factory.CreateDbContext())
            {
                context.Database.Migrate();
            }

 
            MainWindow.Show();





            base.OnStartup(e);
        }
    }
}
