using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MemeShark
{
    class FileHandling
    {
        /*
         * File handling will handle all file operations from decrypting the memeshark file to downloading the files.   
         */

        FileInfo file;
        DirectoryInfo folder;

        public void ImportDialog() // return the folder path as a string
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "Memeshark Files|*.Memeshark",
                Title = "Import file",
                DefaultExt = ".Memeshark",
                Multiselect = false
            };

            /*
             * plan to decrypt the file and then return a file instead of string, but want to set up other systems first.
             */

            if (fileDialog.ShowDialog() == true)
            {
                file = new FileInfo(fileDialog.FileName);
            }
            else
            {
                MessageBox.Show("You need a file with a .Memeshark extension provided by the web extension.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void FolderDialog()
        {
            CommonOpenFileDialog folderBrowser = new CommonOpenFileDialog()
            {
                IsFolderPicker = true,
                Multiselect = false,
                Title = "Download location."
            };

            if (folderBrowser.ShowDialog() == CommonFileDialogResult.Ok)
            {
                folder = new DirectoryInfo(folderBrowser.FileName);
            }
            else if (folderBrowser.ShowDialog() == CommonFileDialogResult.Cancel || folderBrowser.ShowDialog() == CommonFileDialogResult.None)
            {
                MessageBox.Show("You need a folder to download to!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public async void DownloadFiles(TextBlock SuccessfulDownloads, TextBlock FailedDownloads)
        {
            if (folder != null)
            {
                if (file != null)
                {
                    string[] fileLines = Task.Run(() => File.ReadAllLines(file.FullName)).Result;
                    HttpClient client = new HttpClient();

                    int _failedDownloads = 0;
                    int successfulDownloads = 0;

                    foreach (var line in fileLines)
                    {
                        /* 
                         * Checks if the links are valid 
                         * if they are it will proceed to download, if not then it will count up the failed download.
                         */
                        try
                        {
                            using (var result = await client.GetAsync(line))
                            {

                            } 
                        }
                        catch (Exception)
                        {
                            _failedDownloads++;
                            FailedDownloads.Text = "Failed downloads: " + _failedDownloads;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Import a memeshark file first!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Choose a folder to download to first!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
