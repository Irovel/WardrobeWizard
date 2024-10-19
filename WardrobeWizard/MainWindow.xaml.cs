using iNKORE.UI.WPF.Modern.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using Page = iNKORE.UI.WPF.Modern.Controls.Page;

namespace WardrobeWizard {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        public Pages.HomePage Home_Page = new Pages.HomePage();
        public Pages.FashionPage Fashion_Page = new Pages.FashionPage();
        public Pages.AddItemPage Add_Item_Page = new Pages.AddItemPage();

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args) {
            var item = sender.SelectedItem;
            Page? page = null;
            if (item == NavViewItem_Home) {
                page = Home_Page;
            }
            else if (item == NavViewItem_Closet) {
                page = Fashion_Page;
            }
            else if (item == NavViewItem_Add) {
                page = Add_Item_Page;
            }
            else {
                page = null;
            }
            
            if (page != null) {
                NavigationView_Root.Header = page.Title;
                Frame_Main.Navigate(page);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            NavigationView_Root.SelectedItem = NavViewItem_Home;
        }
    }
}
