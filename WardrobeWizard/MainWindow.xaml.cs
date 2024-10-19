using iNKORE.UI.WPF.Modern.Controls;
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

namespace WardrobeWizard {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            // Subscribe to the SelectionChanged event
            MyNavigationView.SelectionChanged += MyNavigationView_SelectionChanged;
        }

        private void MyNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args) {
            var selectedItem = (NavigationViewItem)args.SelectedItem;
            switch (selectedItem.Tag) {
                case "HomePage":
                    MainContent.Content = new HomePage(); // Ensure HomePage class exists
                    break;
                case "FashionPage":
                    MainContent.Content = new FashionPage(); // Ensure FashionPage class exists
                    break;
            }
        }
    }
}
