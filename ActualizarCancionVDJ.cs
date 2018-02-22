using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;

namespace ActualizarCancion
{
    public partial class ActualizarCancionVDJ : Form
    {
        private FileSystemWatcher _watcher;



        /// <summary>
        /// Basic constructor.
        /// </summary>
        public ActualizarCancionVDJ()
        {
            InitializeComponent();

            _watcher = new FileSystemWatcher();
            _watcher.SynchronizingObject = this;
            this.FolderInput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VirtualDJ\\History\\";
            _watcher.Changed += new FileSystemEventHandler(LogFileSystemChanges);
            _watcher.Created += new FileSystemEventHandler(LogFileSystemChanges);
            _watcher.Deleted += new FileSystemEventHandler(LogFileSystemChanges);
            _watcher.Renamed += new RenamedEventHandler(LogFileSystemRenaming);
            _watcher.Error += new ErrorEventHandler(LogBufferError);
        }



        /// <summary>
        /// Log buffer overloading errors.
        /// </summary>
        void LogBufferError(object sender, ErrorEventArgs e)
        {
            //string log = string.Format("{0:G} | Buffer limit exceeded", DateTime.Now);
            //ChangeLogList.Items.Add(log);
        }



        /// <summary>
        /// </summary>
        void LogFileSystemRenaming(object sender, RenamedEventArgs e)
        {
            //string log = string.Format("{0:G} | {1} | Renamed from {2}", DateTime.Now, e.FullPath, e.OldName);
            //ChangeLogList.Items.Add(log);
        }



        /// <summary>
        /// </summary>
        void LogFileSystemChanges(object sender, FileSystemEventArgs e)
        {
            string djalaire = textBox1.Text;
            //string log = string.Format("{0:G} | {1} | {2}", DateTime.Now, e.FullPath, e.ChangeType);
            string MisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VirtualDJ\\History\\tracklist.txt";
            string rola = File.ReadLines(MisDocumentos).Last();
            string log = rola.Substring(8);
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8181");

            var postData = "artist="+log+" - "+"(("+djalaire+"))";
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            ChangeLogList.Items.Add(log);
        }



        /// <summary>

        /// </summary>
        private void MonitoringInput_CheckedChanged(object sender, EventArgs e)
        {
            string monitoredFolder = FolderInput.Text;
            bool folderExists = Directory.Exists(monitoredFolder);

            if (folderExists)
            {
                _watcher.Path = monitoredFolder;
                _watcher.Filter = FileFilterInput.Text;
                _watcher.IncludeSubdirectories = SubfoldersInput.Checked;


                NotifyFilters notificationFilters = new NotifyFilters();
                if (AttributesInput.Checked) notificationFilters = notificationFilters | NotifyFilters.Attributes;
                if (CreationTimeInput.Checked) notificationFilters = notificationFilters | NotifyFilters.CreationTime;
                if (DirectoryNameInput.Checked) notificationFilters = notificationFilters | NotifyFilters.DirectoryName;
                if (FileNameInput.Checked) notificationFilters = notificationFilters | NotifyFilters.FileName;
                if (LastAccessInput.Checked) notificationFilters = notificationFilters | NotifyFilters.LastAccess;
                if (LastWriteInput.Checked) notificationFilters = notificationFilters | NotifyFilters.LastWrite;
                if (SecurityInput.Checked) notificationFilters = notificationFilters | NotifyFilters.Security;
                if (SizeInput.Checked) notificationFilters = notificationFilters | NotifyFilters.Size;
                _watcher.NotifyFilter = notificationFilters;

                _watcher.EnableRaisingEvents = MonitoringInput.Checked;
            }
            else if (MonitoringInput.Checked)
            {
                MessageBox.Show(this, "Esta carpeta no existe.", "Directorio Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MonitoringInput.Checked = false;
            }

            FolderInput.Enabled = FileFilterInput.Enabled = NotificationsGroup.Enabled = !MonitoringInput.Checked;
        }



        /// <summary>
        /// </summary>
        private void BlackWaspLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://neteando.club/");
        }

        private void ControlGroup_Enter(object sender, EventArgs e)
        {

        }

        private void FolderInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarCancionVDJ_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PathLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NotificationsGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
