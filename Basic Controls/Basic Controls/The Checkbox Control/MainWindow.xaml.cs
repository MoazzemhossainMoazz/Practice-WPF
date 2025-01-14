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

namespace The_Checkbox_Control
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

        private void cbAllFeatures_Unchecked(object sender, RoutedEventArgs e)
        {
            cbFeatureAbc.IsChecked = false;
            cbFeatureXyz.IsChecked = false;
            cbFeatureWww.IsChecked = false;
        }

        private void cbAllFeatures_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbFeatureAbc.IsChecked = true;
            cbFeatureXyz.IsChecked = true;
            cbFeatureWww.IsChecked = true;
        }

        private void cbFeatureAbc_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void cbFeatureAbc_Unchecked(object sender, RoutedEventArgs e)
        {
             
        }

        private void cbFeatureAbc_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}