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

namespace Les_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MessagesDbContext messagesDbContext = new MessagesDbContext();

        public MainWindow()
        {
            InitializeComponent();
            LoadAuthors();
        }

        private void LoadAuthors()
        {
            authorListBox.ItemsSource = messagesDbContext.Authors.ToList();
        }

        private void authorListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadPosts();    
        }

        private void LoadPosts()
        {
            if (authorListBox.SelectedItem != null)
            {
                Author author = (Author)authorListBox.SelectedItem;
                postListBox.ItemsSource = null;
                postListBox.ItemsSource = messagesDbContext.Posts.Where((post) => post.author_id == author.id).ToList();
            }
            else
            {
                postListBox.ItemsSource = null;
            }

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(postListBox.SelectedItem != null)
            {
                Post post = (Post) postListBox.SelectedItem;
                messagesDbContext.Posts.Remove(post);
                messagesDbContext.SaveChanges();
                LoadPosts();
            }
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            if(authorListBox.SelectedItem != null)
            {
                Author author = (Author)authorListBox.SelectedItem;
                CreateWindow createWindow = new CreateWindow(author);

                if(createWindow.ShowDialog() == true)
                {
                    LoadPosts();
                }
            }
        }
    }
}
