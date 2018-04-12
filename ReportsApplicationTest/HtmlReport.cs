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
    public partial class HtmlReport : Form
    {
        public HtmlReport(DataTable dt, int angle)
        {
            InitializeComponent();
            this.webBrowser1.DocumentText = ExportDatatableToHtml(dt, false, angle);
        }

        private void HtmlReport_Load(object sender, EventArgs e)
        {}

        protected string ExportDatatableToHtml(DataTable dt, bool isFirstColumnsRotated, int angle)
        {
            if (angle < 0)
                angle *= -1;

            StringBuilder strHTMLBuilder = new StringBuilder();
            strHTMLBuilder.Append("<!DOCTYPE html>");
            strHTMLBuilder.Append("<head><meta http-equiv='X-UA-Compatible' content='IE=edge's>");
            strHTMLBuilder.Append("<style>");
            strHTMLBuilder.Append(".table-header-rotated th.row-header{ width: auto; }");
            strHTMLBuilder.Append(".table-header-rotated td{ width: 40px; border-top: 1px solid #dddddd; border-left: 1px solid #dddddd; border-right: 1px solid #dddddd; vertical-align: middle; text-align: center;}");
            strHTMLBuilder.Append(".table-header-rotated th.rotate-45{ height: 80px; width: 40px; min-width: 40px; max-width: 40px; position: relative; vertical-align: bottom; padding: 0; font-size: 12px; line-height: 0.8;}");
            strHTMLBuilder.Append(".table-header-rotated th.rotate-45 > div{ position: relative; top: 0px; left: 40px; /* 80 * tan(45) / 2 = 40 where 80 is the height on the cell and 45 is the transform angle*/ height: 100%; -ms-transform:skew(-@angledeg,0deg); -moz-transform:skew(-@angledeg,0deg); -webkit-transform:skew(-@angledeg,0deg); -o-transform:skew(-@angledeg,0deg); transform:skew(-@angledeg,0deg); overflow: hidden; border-left: 1px solid #dddddd; border-right: 1px solid #dddddd; border-top: 1px solid #dddddd;}");
            strHTMLBuilder.Append(".table-header-rotated th.rotate-45 span { -ms-transform:skew(@angledeg,0deg) rotate(@rotated_angledeg); -moz-transform:skew(@angledeg,0deg) rotate(@rotated_angledeg); -webkit-transform:skew(@angledeg,0deg) rotate(@rotated_angledeg); -o-transform:skew(@angledeg,0deg) rotate(@rotated_angledeg); transform:skew(@angledeg,0deg) rotate(@rotated_angledeg); position: absolute; bottom: 30px; /* 40 cos(45) = 28 with an additional 2px margin*/ left: -25px; /*Because it looked good, but there is probably a mathematical link here as well*/ display: inline-block;  width: 85px; /* 80 / cos(45) - 40 cos (45) = 85 where 80 is the height of the cell, 40 the width of the cell and 45 the transform angle*/ text-align: left; // white-space: nowrap; /*whether to display in one line or not*/ }");
            strHTMLBuilder.Append("</style>");
            strHTMLBuilder.Append("</head>");
            strHTMLBuilder.Append("<body>");
            strHTMLBuilder.Append("<table class='table table-striped table-header-rotated'>");

            strHTMLBuilder.Append("<tr>");
            foreach (DataColumn myColumn in dt.Columns)
            {
                if(!isFirstColumnsRotated && dt.Columns.IndexOf(myColumn) == 0)
                    strHTMLBuilder.Append("<th><div><span>");
                else
                    strHTMLBuilder.Append("<th class='rotate-45'><div><span>");
                
                strHTMLBuilder.Append(myColumn.ColumnName);
                strHTMLBuilder.Append("</span></div></th>");

            }
            strHTMLBuilder.Append("</tr>");


            foreach (DataRow myRow in dt.Rows)
            {

                strHTMLBuilder.Append("<tr >");
                foreach (DataColumn myColumn in dt.Columns)
                {
                    strHTMLBuilder.Append("<td >");
                    strHTMLBuilder.Append(myRow[myColumn.ColumnName].ToString());
                    strHTMLBuilder.Append("</td>");

                }
                strHTMLBuilder.Append("</tr>");
            }

            //Close tags.  
            strHTMLBuilder.Append("</table>");
            strHTMLBuilder.Append("</body>");
            strHTMLBuilder.Append("</html>");

            string Htmltext = strHTMLBuilder.ToString();
            int rotated_angle = 360 - angle;

            return Htmltext.Replace("@angle", angle.ToString()).Replace("@rotated_angle", rotated_angle.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"c:\\tmp\\abc.xls", webBrowser1.DocumentText);
        }
    }
}
