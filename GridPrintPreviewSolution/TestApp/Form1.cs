using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;
using GridPrintPreviewLib;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("testdata.xml");
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1[2, 2].Style.ForeColor = Color.Red;
            this.dataGridView1[2, 2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1[2, 3].Style.BackColor = Color.Cyan;
            this.dataGridView1[2, 3].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                dataGridView1[17, i].Style.Alignment = DataGridViewContentAlignment.BottomRight;
                dataGridView1[18, i].Style.Alignment = DataGridViewContentAlignment.TopCenter;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridSelectedArea selArea = new GridSelectedArea(1, 2, 10, dataGridView1.RowCount - 3);
            GridPrintDocument doc = new GridPrintDocument(this.dataGridView1, this.dataGridView1.Font, true);
            doc.SelectedArea = selArea;
            doc.DocumentName = "Preview Test";
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();
            doc.Dispose();
            doc = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridPrintDocument doc = new GridPrintDocument(this.dataGridView1, this.dataGridView1.Font, true);
            doc.DocumentName = "Preview Test";
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();

            float scale = doc.CalcScaleForFit();
            doc.ScaleFactor = scale;

            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "PrintPreviewDialog1";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();

            doc.Dispose();
            doc = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GridPrintDocument doc = new GridPrintDocument(this.dataGridView1, this.dataGridView1.Font, true);
            doc.DocumentName = "Preview Test";
            doc.DefaultPageSettings.Landscape = true;
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();

            float scale = doc.CalcScaleForFit();
            doc.ScaleFactor = scale;

            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "PrintPreviewDialog1";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();

            doc.Dispose();
            doc = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GridPrintDocument doc = new GridPrintDocument(this.dataGridView1, this.dataGridView1.Font, true);
            doc.DocumentName = "Preview Test";
            doc.DefaultPageSettings.Landscape = true;
            doc.DefaultPageSettings.PrinterSettings.FromPage = 1;
            doc.DefaultPageSettings.PrinterSettings.ToPage = 3;
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();

            doc.Dispose();
            doc = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyGridDoc doc = new MyGridDoc(this.dataGridView1, this.dataGridView1.Font, true);
            doc.DocumentName = "Preview Test";
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();

            doc.Dispose();
            doc = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GridPrintDocument doc = new GridPrintDocument(this.dataGridView1, this.dataGridView1.Font, true);
            doc.DocumentName = "Preview Test";
            doc.DrawCellBox = true;
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();
            doc.Dispose();
            doc = null;
        }
    }
}
