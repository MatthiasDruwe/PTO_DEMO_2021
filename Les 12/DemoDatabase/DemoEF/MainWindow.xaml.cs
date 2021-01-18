using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace DemoEF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NorthWindDbContext dbContext = new NorthWindDbContext();
        
            // SELECT 
            List<Customer> customers = dbContext.Customers.ToList();
            foreach (Customer customer in customers)
            {
                ListBoxItem item = new ListBoxItem();

                item.Content = customer.CompanyName;

                customerListBox.Items.Add(item);
            }


            // CREATE
            //Customer newCustomer = new Customer();
            //newCustomer.CustomerID = "Druwe";
            //newCustomer.CompanyName = "Druwé NV";

            //dbContext.Customers.Add(newCustomer);
            //dbContext.SaveChanges();

            // DELETE

            //Customer customerToDelete = dbContext.Customers.Where((x) => x.CompanyName == "Druwé NV").First();
            //dbContext.Customers.Remove(customerToDelete);
            //dbContext.SaveChanges();


            // EDIT
            NorthWindDbContext dbContext2 = new NorthWindDbContext();
           
            Customer customerToEdit = dbContext.Customers.First();
            Customer customerToEdit2 = dbContext2.Customers.Include((z) => z.CustomerDemographics).Include((j) => j.Orders).First((y) => y.CustomerID == "Druwe" );
            
            customerToEdit.CompanyName = "Prog Is Fun2";
            customerToEdit2.CompanyName = "Prog Is Fun3";
            customerToEdit2.Orders = null;
            customerToEdit2.CustomerDemographics = null;
            var x = dbContext.Entry(customerToEdit2);
            x.State = EntityState.Modified;
            MessageBox.Show(x.State.ToString());
            MessageBox.Show(dbContext2.Entry(customerToEdit2).State.ToString());
            dbContext.SaveChanges();

        }
    }
}
