using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Topcast_Report_Manager.Controls
{
    public partial class cursorValue : UserControl
    {

        public Series Series { get; set; }

        public cursorValue(Series series, string userUnit)
        {
            InitializeComponent();
            Series = series;
            labelSeriesName.Text = Series.Name;
            labelSeriesName.ForeColor = series.Color;
            labelUnit.Text = userUnit;
            textBoxCursorValue.Text = "0";
        }

        public void updateCursorValue(int cursorIndex)
        {
            textBoxCursorValue.Text = Series.Points[cursorIndex].YValues[0].ToString();
        }

        private void buttonHide_Click(object sender, System.EventArgs e)
        {
            if (Series.Enabled)
            {
                Series.Enabled = false;
                buttonHide.ForeColor = Color.DarkGray;
            } else
            {
                Series.Enabled = true;
                buttonHide.ForeColor = Color.Gray;
            }
        }
    }
}
