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
        private int dX, dY, angle, tW, tH, x1, x2, y1, y2;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { 8,9,10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 24, 26, 28, 30, 40});
            comboBox1.SelectedIndex = 0;
            cmbAngle.Items.AddRange(new object[] { 45, 60});
            cmbAngle.SelectedIndexChanged += cmbAngle_SelectedIndexChanged;
            cmbAngle.SelectedIndex = 0;
            txbH.Text = "150";
        }

        private void cmbAngle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _angle = (int) cmbAngle.SelectedItem;
            txbW.Text = _angle == 60 ? "80" : (_angle == 45 ? "110" : "50");
            txbH.Text = _angle == 60 ? "230" : "150";
            txbX1.Text = txbX2.Text = txbY1.Text = txbY2.Text = "0";
            x1 = x2 = y1 = y2 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dX = dY = angle = tW = tH = 0;
            txbX.Text = txbY.Text = txbX1.Text = txbX2.Text = txbY1.Text = txbY2.Text = "0";
            cmbAngle.SelectedIndex = 0;
            txbH.Text = "150";
            txbW.Text = "50";
            chbBold.Checked = false;
            chbDirection.Checked = true;
            showReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HtmlReport hr = new HtmlReport(dt, angle);
            DialogResult dialogResult = hr.ShowDialog();
        }

        private void txbH_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbH.Text))
            {
                var newY = int.Parse(txbH.Text) - 10;
                txbY.Text = newY.ToString();
            }
        }

        private DataTable GetData()
        {
            ImageConverter ic = new ImageConverter();
            DataTable _dt = new DataTable();

            _dt.Columns.Add("Name", Type.GetType("System.String"));
            _dt.Columns.Add("Type", Type.GetType("System.Int32"));            
            _dt.Columns.Add("RotatedName", typeof(byte[]));

            _dt.Rows.Add(new Object[] {"Demerol 25MG/ML", 9, new ImageConverter().ConvertTo(
                CreateImage("Demerol 25MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White, false, false),
                typeof(byte[])) });
            _dt.Rows.Add(new Object[] {"Demerol 50MG/ML", 10, new ImageConverter().ConvertTo(
                CreateImage("Demerol 50MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White, true, false),
                typeof(byte[])) });
            _dt.Rows.Add(new Object[] {"Duramorph 5MG/ML", 8, new ImageConverter().ConvertTo(
                CreateImage("Duramorph 5MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White, true, false),
                typeof(byte[])) });
            _dt.Rows.Add(new Object[] {"Ephedrin Injection 50MG/ML", 2, new ImageConverter().ConvertTo(
                CreateImage("Ephedrin Injection 50MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White, true, false),
                typeof(byte[])) });
            _dt.Rows.Add(new Object[] {"Fentanyl 100MCG/2ML", 1, new ImageConverter().ConvertTo(
                CreateImage("Fentanyl 100MCG/2ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White, true, false),
                typeof(byte[])) });
            _dt.Rows.Add(new Object[] {"Fentanyl 250MCG/5ML", 3, new ImageConverter().ConvertTo(
                CreateImage("Fentanyl 250MCG/5ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White, true, false),
                typeof(byte[])) });
            _dt.Rows.Add(new Object[] {"Ketamine HCL 25MG/ML", 4, new ImageConverter().ConvertTo(
                CreateImage("Ketamine HCL 25MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White, true, false),
                typeof(byte[])) });
            _dt.Rows.Add(new Object[] {"Pentothal 25MG/ML", 1, new ImageConverter().ConvertTo(
                CreateImage("Pentothal 25MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White, true, false),
                typeof(byte[])) });
            _dt.Rows.Add(new Object[] {"Versed 5MG/ML", 6, new ImageConverter().ConvertTo(
                CreateImage("Versed 25MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White, true, true),
                typeof(byte[])) });
            _dt.Rows.Add(new Object[] {"Versed 25MG/ML", 7, new ImageConverter().ConvertTo(
                CreateImage("Versed 5MG/ML", "Arial", (int) comboBox1.SelectedItem, angle, dX, dY, System.Drawing.Color.Black, System.Drawing.Color.White, true, false),
                typeof(byte[])) });

            return _dt;
        }

        private Bitmap CreateImage(String text, String sFont, int iFontSize, int angle, int x, int y, System.Drawing.Color textColor, System.Drawing.Color backColor, bool drawTop, bool drawLast)
        {
            if (chbDirection.Checked)
                angle = angle * -1;

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

            drawing.DrawString(text, MyFont, textBrush, 0, 0);
            Pen myPen = new Pen(System.Drawing.Color.Black, 1);
            drawing.DrawLine(myPen, 0, 0, -50, angle == (-1 * 45) ? 50 : 28);
            drawing.DrawLine(myPen, 0, 0, this.Width, 0);

            int _x1 = 0, _x2 = 0, _y1 = 0, _y2 = 0;
            if (drawTop)
            {
                if (x1 == 0)
                {
                    var value = angle == -60 ? 158 : (angle == -45 ? 155 : img.Height - 5);
                    x1 = _x1 = value;
                    txbX1.Text = value.ToString();
                } else
                    x1 = _x1 = int.Parse(txbX1.Text);

                if (y1 == 0)
                {
                    var value = angle == -60 || angle == -45 ? -1 : -10;
                    y1 = _y1 = value;
                    txbY1.Text = value.ToString();
                }
                else
                    y1 = _y1 = int.Parse(txbY1.Text);

                if (x2 == 0)
                {
                    var value = angle == -60 ? -8 : (angle == -45 ? -55 : (img.Height - 5) * -1);
                    x2 = _x2 = value;
                    txbX2.Text = value.ToString();
                }
                else
                    x2 = _x2 = int.Parse(txbX2.Text);

                if (y2 == 0)
                {
                    var value = angle == -60 ? -288 : (angle == -45 ? -210 : 158);
                    y2 = _y2 = value;
                    txbY2.Text = value.ToString();
                } else
                    y2 = _y2 = int.Parse(txbY2.Text);

                drawing.DrawLine(myPen, _x1, _y1, _x2, _y2);
            }

            if(drawLast)
            {
                var _lastY = angle == -60 ? 92 : (angle == -45 ? 154 : 58);
                drawing.DrawLine(myPen, angle == -45 ? _x1 - 1 :_x1 - 1, 0, 0, _lastY);
            }

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
                ReportDataSource ds = new ReportDataSource("DsMed", dt);

                this.reportViewer1.LocalReport.DataSources.Add(ds);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplicationTest.Report1.rdlc";
                this.reportViewer1.RefreshReport();
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            angle = (int)cmbAngle.SelectedItem;
            int.TryParse(txbX.Text, out dX);
            int.TryParse(txbY.Text, out dY);
            int.TryParse(txbW.Text, out tW);
            int.TryParse(txbH.Text, out tH);
            int.TryParse(txbX1.Text, out x1);
            int.TryParse(txbX2.Text, out x2);

            dt = GetData();
            showReport();
        }
    }
}