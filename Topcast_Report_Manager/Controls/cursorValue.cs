using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Topcast_Report_Manager.Controls
{
    public partial class cursorValue : UserControl
    {

        public Series Series { get; set; }

        public cursorValue(Series series)
        {
            InitializeComponent();
            Series = series;
            labelSeriesName.Text = Series.Name;
            BackColor = series.Color;
            textBoxCursorValue.Text = "0";
        }

        public void updateCursorValue(int cursorIndex)
        {
            textBoxCursorValue.Text = Series.Points[cursorIndex].YValues[0].ToString();
        }
    }
}
