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

namespace SelectFileEncryptor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EncryptFileListView.View = View.List;
        }

        void EncryptFileListView_DragDrop(object sender, DragEventArgs e)
        {
            string[] Filelist = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            EncryptFileListView.BeginUpdate();
            
            foreach (string listitem in Filelist)
            {
                FileAttributes attr = File.GetAttributes(listitem);

                if (EncryptFileListView.Items.ContainsKey(listitem) == false)
                {
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                        EncryptFileListView.Items.Add(listitem, listitem, 1);
                    else
                        EncryptFileListView.Items.Add(listitem, listitem, 0);
                }
            }
            EncryptFileListView.EndUpdate();
        }
        void EncryptFileListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void DirectInputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                AddExtension = true
            };

            String selectedpath;
            if (fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                selectedpath = fileDialog.InitialDirectory + fileDialog.FileName;
            }
        }
    }
}
