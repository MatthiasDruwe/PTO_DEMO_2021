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
using System.Windows.Shapes;

namespace Les_13
{
    /// <summary>
    /// Interaction logic for CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        private Author author;
        public CreateWindow(Author author)
        {
            InitializeComponent();
            this.author = author;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Post post = new Post();
            post.author_id = author.id;
            post.content = contentTextBox.Text;
            post.date = DateTime.Now;
            post.description = descriptionTextBox.Text;
            post.title = titleTextBox.Text;

            MessagesDbContext messagesDbContext = new MessagesDbContext();
            messagesDbContext.Posts.Add(post);
            messagesDbContext.SaveChanges();

            DialogResult = true;
            Close();
        }
    }
}
