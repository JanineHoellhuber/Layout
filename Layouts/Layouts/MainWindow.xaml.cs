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

namespace Layouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            stackpanel.Click += Button_Click;
            dock.Click += Button_Click;
            grid.Click += Button_Click;
            gridsplitter.Click += Button_Click;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button getCorrectWindow = (Button)sender;

            switch (getCorrectWindow.Content.ToString())
            {
                case "StackPanel":
                    {
                        StackPanel stackpanel = new StackPanel();
                        stackpanel.Show();
                        break;
                    }
                case "Dock":
                    {
                        Dock dock = new Dock();
                        dock.Show();

                        break;
                    }
                case "Grid":
                    {
                        Grid grid = new Grid();
                        grid.Show();
                        break;
                    }
                case "Grid Splitter":
                    {
                        GridSplitter gridSplitter = new GridSplitter();
                        gridSplitter.Show();
                        break;
                    }
            }

           
        }

    }
}
