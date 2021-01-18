using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

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

        #region Title bar
        private void Titlebar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();

        private void Titlebar_Title_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();

        private void Minimize_Button_MouseDown(object sender, MouseButtonEventArgs e) => WindowState = WindowState.Minimized;

        private void Close_Button_MouseDown(object sender, MouseButtonEventArgs e) => Environment.Exit(0);
        #endregion

        #region Buttons
        FileHandling handler = new FileHandling();

        private void ImportText_MouseDown(object sender, MouseButtonEventArgs e) => handler.ImportDialog(); 

        private void DownloadButton_MouseDown(object sender, MouseButtonEventArgs e) => handler.DownloadFiles(SuccessfulDownloadText, FailedDownloadText);

        private void FolderText_MouseDown(object sender, MouseButtonEventArgs e) => handler.FolderDialog();
        #endregion
    }
}
