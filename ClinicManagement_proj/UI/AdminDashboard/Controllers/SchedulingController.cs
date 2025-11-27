using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the Doctor Scheduling panel
    /// </summary>
    public class SchedulingController : IPanelController
    {
        private readonly Panel panel;
        private AdminDashboard adminDashboard => (AdminDashboard)panel.FindForm();
        private GroupBox grpScheduling => (GroupBox)panel.Controls["grpDoctorScheduling"];
        private TableLayoutPanel schedulingLayout => (TableLayoutPanel)grpScheduling.Controls["layoutSchedulingContent"];
        private ListBox lbSunday => (ListBox)schedulingLayout.Controls["lbSunday"];
        private ListBox lbMonday => (ListBox)schedulingLayout.Controls["lbMonday"];
        private ListBox lbTuesday => (ListBox)schedulingLayout.Controls["lbTuesday"];
        private ListBox lbWednesday => (ListBox)schedulingLayout.Controls["lbWednesday"];
        private ListBox lbThursday => (ListBox)schedulingLayout.Controls["lbThursday"];
        private ListBox lbFriday => (ListBox)schedulingLayout.Controls["lbFriday"];
        private ListBox lbSaturday => (ListBox)schedulingLayout.Controls["lbSaturday"];

        public Panel Panel => panel;

        public SchedulingController(Panel panel)
        {
            this.panel = panel;
        }

        public void Initialize()
        {
            SetupSchedulingListViews();
            adminDashboard.ResizeEnd += new System.EventHandler(AdminDashboard_ResizeEnd);
        }

        public void OnShow()
        {
            RefreshSchedulingListViews();
        }

        private void AdminDashboard_ResizeEnd(object sender, System.EventArgs e)
        {
            if (panel.Visible)
                RefreshSchedulingListViews();
        }

        /// <summary>
        /// Refresh the scheduling list views to adapt to window size changes
        /// </summary>
        public void RefreshSchedulingListViews()
        {
            List<ListBox> dayListBoxes = new List<ListBox>
            {
                lbSunday, lbMonday, lbTuesday, lbWednesday,
                lbThursday, lbFriday, lbSaturday
            };

            foreach (ListBox lb in dayListBoxes)
            {
                lb.Items.Clear();
                for (int i = 0; i < 24; i++)
                {
                    lb.Items.Add("");
                }
            }
        }

        /// <summary>
        /// Setup the scheduling list views with custom drawing
        /// </summary>
        private void SetupSchedulingListViews()
        {
            List<ListBox> dayListBoxes = new List<ListBox>
            {
                lbSunday, lbMonday, lbTuesday, lbWednesday,
                lbThursday, lbFriday, lbSaturday
            };

            RefreshSchedulingListViews();

            foreach (ListBox lb in dayListBoxes)
            {
                lb.DrawMode = DrawMode.OwnerDrawVariable;
                lb.MeasureItem += (s, e) =>
                {
                    int totalHeight = lb.ClientSize.Height;
                    int baseHeight = totalHeight / 24;
                    int remainder = totalHeight % 24;
                    e.ItemHeight = baseHeight + (e.Index < remainder ? 1 : 0);
                };

                lb.DrawItem += (s, e) =>
                {
                    e.DrawBackground();

                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Bounds);
                    else
                        e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);

                    e.Graphics.DrawRectangle(Pens.Gray, e.Bounds);
                };

                lb.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        lb.SelectedIndex = -1;
                    }
                };
            }
        }

        public void OnHide()
        {
            // Cleanup when leaving panel
        }

        public void Cleanup()
        {
            // Dispose resources if needed
        }
    }
}
