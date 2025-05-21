using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace moja_lista_wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.Foreground = Brushes.Black;
        }

        private void SearchTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Wyszukaj zadanie..";
                searchTextBox.Foreground = Brushes.DimGray;
            }
        }

        private void AddTaskButtonClick(object sender, RoutedEventArgs e)
        {
            AddTaskWindow addTaskWindow = new AddTaskWindow();
            addTaskWindow.Show();
        }
    }
}