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

namespace Reorder_item_WPF
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        private void ScrollVwr_for_main_content_GotFocus(object sender,RoutedEventArgs e)
        {

        }

        private void BTN_add_new_button_Click(object sender,RoutedEventArgs e)
        {
        }

        private void BTN_close_this_window_Click(object sender,RoutedEventArgs e)
        {
            this.Close ();
        }

        private void BTN_new_file_Click(object sender,RoutedEventArgs e)
        {
            ((MainViewModel)this.DataContext).add_new_element ();
        }

        private void Drop_button(object sender,DragEventArgs e)
        {
            int x = 1;
        }

        private void Button_Drop(object sender,DragEventArgs e)
        {
            int x = 1;
        }

        private void Button_drag_Drop(object sender,DragEventArgs e)
        {
            int x = 0;
        }

        int a_cnt = 0;
        private void Button_DragLeave(object sender,DragEventArgs e)
        {
            a_cnt++;
        }

        private void Button_Click(object sender,RoutedEventArgs e)
        {
            int x=0;
            a_cnt=0;
        }

private void Grid_DragOver(object sender, DragEventArgs e)
{
    //e.AcceptedOperation = DataPackageOperation.Copy;
    //e.AllowedEffects = DragDropEffects.Move;
}

    }
}
