using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeFirstDotNetCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserDBContext userDbContext = new UserDBContext();
            userDbContext.Database.EnsureCreated();


            User user = new User();
            user.FirstName = "Matthias";
            user.LastName = "Druwé";

            userDbContext.Users.Add(user);
            userDbContext.SaveChanges();

            Car car = new Car();
            car.Model = "Ford";
            car.Color = "Groen";
            car.User = user;

            userDbContext.Cars.Add(car);
            userDbContext.SaveChanges();
        }
    }
}
