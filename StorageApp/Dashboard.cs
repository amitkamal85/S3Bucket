using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageApp
{
    public partial class Dashboard : Form
    {
        S3Buckets objBucket = null;
        public Dashboard()
        {
            InitializeComponent();
            getAllFolders();
        }


        public void getAllFolders()
        {

            objBucket = new S3Buckets();
            String path = (string)Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER" + "\\" + "MyTestKey", "UserId", String.Empty);
            path += "/";
            ListObjectsResponse response = objBucket.GetFilesInfoOffolder(path);

            foreach (S3Object entry in response.S3Objects)
            {
                String tempStr = String.Empty;
                tempStr = "root/" + entry.Key.ToLower().Replace(path, "");
                if (!entry.Key.Contains("."))
                {


                    lstDirectories.Items.Add(tempStr, entry.Key);
                    lstCreateDirTab.Items.Add(tempStr, entry.Key);
                    // dataGridView1.DataSource = response.S3Objects; 
                }
                //lstDownloadFiles.Items.Add(tempStr, entry.Key);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Multiselect = true;
            op1.ShowDialog();
            // op1.Filter = "allfiles|*.xls";
            txtFileName.Text = op1.FileName;
        }

        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            objBucket = new S3Buckets();

            Boolean status = false;
            if (!String.IsNullOrEmpty(txtFileName.Text))
            {

                if (lstDirectories.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < lstDirectories.SelectedItems.Count; i++)
                    {
                        status = objBucket.uploadFileTofolder(lstDirectories.SelectedItems[i].ImageKey, txtFileName.Text);
                    }
                }
                if (status)
                    MessageBox.Show("Files uploaded successfully!!");
                else
                    MessageBox.Show("Error occured!!");
            }
            else
            {
                MessageBox.Show("Select file to upload!");

            }
        }

        private void btnDownloadfile_Click(object sender, EventArgs e)
        {
            String s3BucketDownloadingPath = (string)Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER" + "\\" + "MyTestKey", "UserId", String.Empty) + "/";
            String localDownloadingPath = (string)Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER" + "\\" + "MyTestKey", "Path", String.Empty);
            //Create Folder first
            String tempStr = string.Empty;
            objBucket = new S3Buckets();
            ListObjectsResponse response = objBucket.GetFilesInfoOffolder(s3BucketDownloadingPath);

            DownloadprogressBar.Minimum = 0;
            DownloadprogressBar.Maximum = response.S3Objects.Count;

            foreach (S3Object entry in response.S3Objects)
            {
                tempStr = String.Empty;
                tempStr = "root/" + entry.Key.ToLower().Replace(s3BucketDownloadingPath, "");

                lstDownloadFiles.Items.Add(tempStr, entry.Key);

                DownloadAndSaveFileOnLocal(entry.Key, localDownloadingPath);
                DownloadprogressBar.Value += 1;
            }
            MessageBox.Show("Files have been saved to following url: " + localDownloadingPath + "");
            DownloadprogressBar.Value = 0;
        }


        public void DownloadAndSaveFileOnLocal(String fileKey, string localPath)
        {


            String fileName = String.Empty;
            String folderLocation = String.Empty;

            //Create file
            if (fileKey.Contains('.'))
            {
                objBucket = new S3Buckets();
                objBucket.DownloadFilesFromBucket(fileKey, localPath);
            }
            //Create folder
            else
            {
                String[] foldernameArr = fileKey.Split('/');
                String strTemp = String.Empty;
                for (int i = 0; i < foldernameArr.Length; i++)
                {
                    strTemp += "/" + foldernameArr[i];
                    if (foldernameArr[i] != "")
                    {
                        DirectoryInfo dr = new DirectoryInfo(localPath + "/" + strTemp);
                        if (!dr.Exists)
                        {
                            dr.Create();
                        }
                    }

                }
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            objBucket = new S3Buckets();

            Boolean status = false;
            if (!String.IsNullOrEmpty(txtDirName.Text))
            {
            
            if (lstCreateDirTab.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lstCreateDirTab.SelectedItems.Count; i++)
                {
                    status = objBucket.CreateFolder(lstCreateDirTab.SelectedItems[i].ImageKey, txtDirName.Text);
                }
            }
            if (status)
                MessageBox.Show("Files uploaded successfully!!");
            else
                MessageBox.Show("Error occured!!");
            }
            else
            {
                MessageBox.Show("Please enter Directoryname");

            }
        }




        private void button5_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txlFolderLocation.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MyTestKey");
            key.SetValue("Path", txlFolderLocation.Text);
            key.Close();

            MessageBox.Show("Download path updated successfully");
        }

        private void button6_Click(object sender, EventArgs e)
        {


            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MyTestKey");
            key.SetValue("UserName", "");
            key.SetValue("Password", "");
            key.SetValue("UserId", "");
            key.SetValue("Path", "");
            key.Close();

            Application.Exit();
        }


    }
}
