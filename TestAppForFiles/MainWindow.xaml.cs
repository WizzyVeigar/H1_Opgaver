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
namespace TestAppForFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IOController controller = new IOController();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBoxView.Items.Clear();
            foreach (string file in controller.DisplayFiles())
            {
                listBoxView.Items.Add(file);
            }
        }

        private void Button_Create(object sender, RoutedEventArgs e)
        {
            controller.CreateFile(directoryTxtBox.Text, dataTxtBox.Text);
        }
    }
}
