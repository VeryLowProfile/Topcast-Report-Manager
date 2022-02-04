using System.Windows.Forms;

namespace Topcast_Report_Manager.Workers
{
    static class FormVisualizationManagement
    {
        public static Form OpenFormInPanel(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel.Controls.Add(form);
            panel.Tag = form.Tag;

            form.BringToFront();
            form.Show();

            return form;
        }

        public static void CloseForm(Form form)
        {
            if (form != null)
            {
                form.Close();
            }
        }
    }
}
