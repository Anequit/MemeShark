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

namespace MemeShark
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

        private void Ui_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Ui_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        #region Title bar
        private void Titlebar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Titlebar_Title_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Minimize_Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Close_Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        #region Browser Buttons
        bool ChromeState = false;
        bool FirefoxState = false;
        bool EdgeState = false;

        private void GoogleChrome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ChromeState)
            {
                ToggleButton(GoogleChrome, GoogleChromeText, false);
                ChromeState = false;
            }
            else
            {
                ToggleButton(GoogleChrome, GoogleChromeText, true);
                ChromeState = true;

                ToggleButton(Firefox, FirefoxText, false);
                FirefoxState = false;

                ToggleButton(Edge, EdgeText, false);
                EdgeState = false;
            }
            
        }

        private void GoogleChromeText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ChromeState)
            {
                ToggleButton(GoogleChrome, GoogleChromeText, false);
                ChromeState = false;
            }
            else
            {
                ToggleButton(GoogleChrome, GoogleChromeText, true);
                ChromeState = true;

                ToggleButton(Firefox, FirefoxText, false);
                FirefoxState = false;

                ToggleButton(Edge, EdgeText, false);
                EdgeState = false;
            }
        }

        private void Firefox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (FirefoxState)
            {
                ToggleButton(Firefox, FirefoxText, false);
                FirefoxState = false;
            }
            else
            {
                ToggleButton(GoogleChrome, GoogleChromeText, false);
                ChromeState = false;

                ToggleButton(Firefox, FirefoxText, true);
                FirefoxState = true;

                ToggleButton(Edge, EdgeText, false);
                EdgeState = false;
            }
        }

        private void FirefoxText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (FirefoxState)
            {
                ToggleButton(Firefox, FirefoxText, false);
                FirefoxState = false;
            }
            else
            {
                ToggleButton(GoogleChrome, GoogleChromeText, false);
                ChromeState = false;

                ToggleButton(Firefox, FirefoxText, true);
                FirefoxState = true;

                ToggleButton(Edge, EdgeText, false);
                EdgeState = false;
            }
        }

        private void Edge_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (EdgeState)
            {
                ToggleButton(Edge, EdgeText, false);
                EdgeState = false;
            }
            else
            {
                ToggleButton(GoogleChrome, GoogleChromeText, false);
                ChromeState = false;

                ToggleButton(Firefox, FirefoxText, false);
                FirefoxState = false;

                ToggleButton(Edge, EdgeText, true);
                EdgeState = true;
            }
        }

        private void EdgeText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (EdgeState)
            {
                ToggleButton(Edge, EdgeText, false);
                EdgeState = false;
            }
            else
            {
                ToggleButton(GoogleChrome, GoogleChromeText, false);
                ChromeState = false;

                ToggleButton(Firefox, FirefoxText, false);
                FirefoxState = false;

                ToggleButton(Edge, EdgeText, true);
                EdgeState = true;
            }
        }

        private void ToggleButton(Image Button, TextBlock ButtonText, bool State)
        {
            if (State)
            {
                Button.Source = (ImageSource)FindResource("ThinChecked");
                ButtonText.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }
            else if (!State)
            {
                Button.Source = (ImageSource)FindResource("ThinUnchecked");
                ButtonText.Foreground = new SolidColorBrush(Color.FromRgb(98, 98, 98));
            }
            
        }

        #endregion
    }
}
