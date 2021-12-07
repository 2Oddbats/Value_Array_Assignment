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

namespace Value_Array_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string[] temp = new string[5];

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            //string[] values = new string[5];

            //values[0] = textBox0.Text;
            //values[1] = textBox1.Text;
            //values[2] = textBox2.Text;
            //values[3] = textBox3.Text;
            //values[4] = textBox4.Text;
            //values[5] = textBox0.Text;

            //labelResult.Content = values[2];

            //labelResult.Content = values.Length.ToString();

            string[] values = new string[5] { "Bif", "Kovinsk", "Zerxik", "Ted", "Elfman" };

            //labelResult.Content = values[2];

            temp = values;
            //You can bring things from one array to another
        }

        private void buttonRetrieve_Click(object sender, RoutedEventArgs e)
        {

            textBox0.Text = temp[0];
            textBox1.Text = temp[1];
            textBox2.Text = temp[2];
            textBox3.Text = temp[3];
            textBox4.Text = temp[4];

            //You can bring things from one array to another
        }
    }
}
