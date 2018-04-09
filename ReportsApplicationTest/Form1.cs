using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsApplicationTest
{
    public partial class Form1 : Form
    {
        private int dX, dY, angle, tW, tH;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { 8,9,10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 24, 26, 28, 30, 40});
            comboBox1.SelectedIndex = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void btnReset_Click(object sender, EventArgs e)
        {
            dX = dY = angle = tW = tH = 0;
            txbAngle.Text = txbX.Text = txbY.Text = "0";
            txbH.Text = "150";
            txbW.Text = "50";
            chbBold.Checked = false;
            showReport();
        }

        private DataTable GetData()
        {
            ImageConverter ic = new ImageConverter();
            DataTable dt = new DataTable();

            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Type", Type.GetType("System.Int32"));            
            dt.Columns.Add("RotatedName", typeof(byte[]));

            dt.Rows.Add(new Object[] {"Demerol 25MG/ML", 9, new ImageConverter().ConvertTo(
                CreateImage("Demerol 25MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White),
                typeof(byte[])) });
            dt.Rows.Add(new Object[] {"Demerol 50MG/ML", 10, new ImageConverter().ConvertTo(
                CreateImage("Demerol 50MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White),
                typeof(byte[])) });
            dt.Rows.Add(new Object[] {"Duramorph 5MG/ML", 8, new ImageConverter().ConvertTo(
                CreateImage("Duramorph 5MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White),
                typeof(byte[])) });
            dt.Rows.Add(new Object[] {"Ephedrin Injection 50MG/ML", 2, new ImageConverter().ConvertTo(
                CreateImage("Ephedrin Injection 50MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White),
                typeof(byte[])) });
            dt.Rows.Add(new Object[] {"Fentanyl 100MCG/2ML", 1, new ImageConverter().ConvertTo(
                CreateImage("Fentanyl 100MCG/2ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White),
                typeof(byte[])) });
            dt.Rows.Add(new Object[] {"Fentanyl 250MCG/5ML", 3, new ImageConverter().ConvertTo(
                CreateImage("Fentanyl 250MCG/5ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White),
                typeof(byte[])) });
            dt.Rows.Add(new Object[] {"Ketamine HCL 25MG/ML", 4, new ImageConverter().ConvertTo(
                CreateImage("Ketamine HCL 25MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White),
                typeof(byte[])) });
            dt.Rows.Add(new Object[] {"Pentothal 25MG/ML", 1, new ImageConverter().ConvertTo(
                CreateImage("Pentothal 25MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White),
                typeof(byte[])) });
            dt.Rows.Add(new Object[] {"Versed 5MG/ML", 6, new ImageConverter().ConvertTo(
                CreateImage("Versed 5MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White),
                typeof(byte[])) });
            dt.Rows.Add(new Object[] {"Versed 25MG/ML", 7, new ImageConverter().ConvertTo(
                CreateImage("Versed 25MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White),
                typeof(byte[])) });

            return dt;
        }

        private Bitmap CreateImage(String text, String sFont, int iFontSize, int angle, int x, int y, System.Drawing.Color textColor, System.Drawing.Color backColor)
        {
            //first, create a dummy bitmap just to get a graphics object
            System.Drawing.Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);
            Font MyFont = chbBold.Checked ? new Font(sFont, iFontSize, FontStyle.Bold) : new Font(sFont, iFontSize);            

            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, MyFont);

            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap(tW, tH);//(int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);
            drawing.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            drawing.TranslateTransform(x, y);
            drawing.RotateTransform(angle);

            //paint the background
            drawing.Clear(backColor);

            //create a brush for the text
            System.Drawing.Brush textBrush = new SolidBrush(textColor);

            //System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Black, 2);
            //pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset; //<-- this
            //drawing.DrawRectangle(pen, new System.Drawing.Rectangle(0, 0, 100, 200));
            drawing.DrawString(text, MyFont, textBrush, 0, 0);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return (Bitmap)img;
        }

        private void showReport()
        {
            this.reportViewer1.Reset();
            try
            {
                DataTable dt = GetData();
                ReportDataSource ds = new ReportDataSource("DsMed", dt);

                this.reportViewer1.LocalReport.DataSources.Add(ds);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplicationTest.Report1.rdlc";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(txbAngle.Text, out angle);
            int.TryParse(txbX.Text, out dX);
            int.TryParse(txbY.Text, out dY);
            int.TryParse(txbW.Text, out tW);
            int.TryParse(txbH.Text, out tH);

            showReport();
        }
    }
}