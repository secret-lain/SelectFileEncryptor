using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //ColumnHeader column = new ColumnHeader();
            //column.Text = "anyway";
            //EncryptFileListView.Columns.AddRange(new ColumnHeader[]{column});
            EncryptFileListView.View = View.List;
        }

        void EncryptFileListView_DragDrop(object sender, DragEventArgs e)
        {
            string[] Filelist = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            EncryptFileListView.BeginUpdate();
            foreach (string listitem in Filelist)
            {
                if(EncryptFileListView.Items.ContainsKey(listitem) == false)
                    EncryptFileListView.Items.Add(listitem, listitem, 0);
            }
            EncryptFileListView.EndUpdate();
        }
        void EncryptFileListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}
