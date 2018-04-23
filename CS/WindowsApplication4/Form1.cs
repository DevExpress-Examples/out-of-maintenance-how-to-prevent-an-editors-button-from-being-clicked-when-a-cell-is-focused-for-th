using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable1.Rows.Add("test");
            dataTable1.Rows.Add("test");
            dataTable1.Rows.Add("test");
            dataTable1.Rows.Add("test");
            dataTable1.Rows.Add("test");
        }

        bool AllowShowEditor = true;

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = !AllowShowEditor;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            AllowShowEditor = false;
            BeginInvoke(new MethodInvoker(delegate { AllowShowEditor = true; }));
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("Button Click");
        }
    }
}