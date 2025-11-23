using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    public partial class AdminDashboard
    {
        /// <summary>
        /// Refresh the scheduling list views to adapt to window size changes
        /// </summary>
        private void RefreshSchedulingListViews()
        {
            List<ListBox> dayListBoxes = new List<ListBox>
            {
                lbSunday, lbMonday, lbTuesday, lbWednesday,
                lbThursday, lbFriday, lbSaturday
            };

            foreach (ListBox lb in dayListBoxes)
            {
                if (lb.Items.Count != 24)
                {
                    lb.Items.Clear();
                    for (int i = 0; i < 24; i++)
                    {
                        lb.Items.Add("");
                    }
                }

                lb.ItemHeight = lb.ClientSize.Height / 24;
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
                lb.DrawItem += (s, e) =>
                {
                    e.DrawBackground();

                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Bounds);
                    else
                        e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);

                    e.Graphics.DrawRectangle(Pens.Gray, e.Bounds);
                };
            }
        }
    }
}