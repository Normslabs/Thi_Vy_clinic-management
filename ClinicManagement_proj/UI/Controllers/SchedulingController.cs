using ClinicManagement_proj.BLL;
using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.BLL.Services;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    

    /// <summary>
    /// Controller for the Doctor Scheduling panel
    /// </summary>
    public class SchedulingController : IPanelController
    {
        private readonly Panel panel;
        private DoctorService doctorService;
        private bool isUpdatingDoctorCombo = false;
        private AdminDashboard adminDashboard => (AdminDashboard)(panel.FindForm()
                ?? throw new Exception("Form not found for panel."));
        private GroupBox grpScheduling => (GroupBox)(panel.Controls["grpDoctorScheduling"]
                ?? throw new Exception("No control named [grpDoctorScheduling] found in panel controls collection."));
        private TableLayoutPanel schedulingLayout => (TableLayoutPanel)(grpScheduling.Controls["layoutSchedulingContent"]
                ?? throw new Exception("No control named [layoutSchedulingContent] found in grpScheduling controls collection."));
        private TableLayoutPanel schedulingHeaderLayout => (TableLayoutPanel)(grpScheduling.Controls["layoutSchedulingHeader"]
                ?? throw new Exception("No control named [layoutSchedulingHeader] found in grpScheduling controls collection."));
        private TableLayoutPanel layoutSchedulingActions => (TableLayoutPanel)(schedulingHeaderLayout.Controls["layoutSchedulingActions"]
                ?? throw new Exception("No control named [layoutSchedulingActions] found in layoutSchedulingHeader controls collection."));
        private Panel pnlDoctorPicker => (Panel)(schedulingHeaderLayout.Controls["pnlDoctorPicker"]
                ?? throw new Exception("No control named [pnlDoctorPicker] found in layoutSchedulingHeader controls collection."));
        private ListBox lbSunday => (ListBox)(schedulingLayout.Controls["lbSunday"]
                ?? throw new Exception("No control named [lbSunday] found in schedulingLayout controls collection."));
        private ListBox lbMonday => (ListBox)(schedulingLayout.Controls["lbMonday"]
                ?? throw new Exception("No control named [lbMonday] found in schedulingLayout controls collection."));
        private ListBox lbTuesday => (ListBox)(schedulingLayout.Controls["lbTuesday"]
                ?? throw new Exception("No control named [lbTuesday] found in schedulingLayout controls collection."));
        private ListBox lbWednesday => (ListBox)(schedulingLayout.Controls["lbWednesday"]
                ?? throw new Exception("No control named [lbWednesday] found in schedulingLayout controls collection."));
        private ListBox lbThursday => (ListBox)(schedulingLayout.Controls["lbThursday"]
                ?? throw new Exception("No control named [lbThursday] found in schedulingLayout controls collection."));
        private ListBox lbFriday => (ListBox)(schedulingLayout.Controls["lbFriday"]
                ?? throw new Exception("No control named [lbFriday] found in schedulingLayout controls collection."));
        private ListBox lbSaturday => (ListBox)(schedulingLayout.Controls["lbSaturday"]
                ?? throw new Exception("No control named [lbSaturday] found in schedulingLayout controls collection."));
        private ComboBox cmbDoctorSelect => (ComboBox)(pnlDoctorPicker.Controls["cmbDoctorSelect"]
               ?? throw new Exception("No control named [cmbRoles] found in grpAdminForm controls collection."));
        private Button btnScheduleSave => (Button)(layoutSchedulingActions.Controls["btnScheduleSave"]
                ?? throw new Exception("No control named [btnScheduleSave] found in layoutSchedulingActions controls collection."));
        private Button btnScheduleRevert => (Button)(layoutSchedulingActions.Controls["btnScheduleRevert"]
                ?? throw new Exception("No control named [btnScheduleRevert] found in layoutSchedulingActions controls collection."));

        public Panel Panel => panel;

        public SchedulingController(Panel panel)
        {
            this.panel = panel;
            
        }

        public void Initialize()
        {
            adminDashboard.ResizeEnd += new System.EventHandler(AdminDashboard_ResizeEnd);
            btnScheduleSave.Click += new EventHandler(btnScheduleSave_Click);
            btnScheduleRevert.Click += new EventHandler(btnScheduleRevert_Click);
            SetupSchedulingListViews();
            
            // Populate doctor ComboBox here
            doctorService = new DoctorService(new ClinicDbContext());
            List<DoctorDTO> doctors = doctorService.GetAllDoctors();

            cmbDoctorSelect.DataSource = doctors;
            cmbDoctorSelect.DisplayMember = "ToString"; 
            cmbDoctorSelect.ValueMember = null;
            cmbDoctorSelect.SelectedIndex = -1;
            cmbDoctorSelect.Text = "Please select a doctor";


            cmbDoctorSelect.SelectedIndexChanged += cmbDoctorSelect_SelectedIndexChanged;
            cmbDoctorSelect.TextChanged += cmbDoctorSelect_TextChanged;

        }

        private void cmbDoctorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctorSelect.SelectedValue is int doctorId)
            {
                var scheduleService = new DoctorScheduleService(new ClinicDbContext());
                var schedules = scheduleService.GetAllSchedules()
                                               .Where(s => s.DoctorId == doctorId)
                                               .ToList();

                RefreshSchedulingListViews();

                foreach (var schedule in schedules)
                {
                    ListBox targetListBox = null;
                    switch (schedule.DayOfWeek)
                    {
                        case "SUNDAY": targetListBox = lbSunday; break;
                        case "MONDAY": targetListBox = lbMonday; break;
                        case "TUESDAY": targetListBox = lbTuesday; break;
                        case "WEDNESDAY": targetListBox = lbWednesday; break;
                        case "THURSDAY": targetListBox = lbThursday; break;
                        case "FRIDAY": targetListBox = lbFriday; break;
                        case "SATURDAY": targetListBox = lbSaturday; break;
                    }

                    if (targetListBox != null)
                    {
                        int startHour = schedule.WorkStartTime.Hours;
                        int endHour = schedule.WorkEndTime.Hours;

                        for (int hour = startHour; hour < endHour; hour++)
                        {
                            targetListBox.Items[hour] = $"{hour}:00 - {(hour + 1)}:00";
                            targetListBox.SetSelected(hour, true); // highlight
                        }
                    }
                }
            }
        }

        private void cmbDoctorSelect_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingDoctorCombo) return;

            isUpdatingDoctorCombo = true;

            string currentText = cmbDoctorSelect.Text;
            int selStart = cmbDoctorSelect.SelectionStart;
            int selLen = cmbDoctorSelect.SelectionLength;
            var trimmed = currentText.Trim();
            List<DoctorDTO> filtered;
            if (string.IsNullOrEmpty(trimmed))
            {
                filtered = doctorService.GetAllDoctors();
            }
            else
            {
                filtered = doctorService.Search(trimmed);
                if (filtered.Count == 0)
                {
                    filtered = doctorService.GetAllDoctors();
                }
            }
            cmbDoctorSelect.DataSource = filtered;
            cmbDoctorSelect.SelectedIndex = -1;
            if (cmbDoctorSelect.Text != trimmed)
            {
                cmbDoctorSelect.Text = trimmed;
                int newSelStart = Math.Min(selStart, trimmed.Length);
                int newSelLen = Math.Min(selLen, trimmed.Length - newSelStart);
                cmbDoctorSelect.SelectionStart = newSelStart;
                cmbDoctorSelect.SelectionLength = newSelLen;
            }
            if (filtered.Count == 1 && !string.IsNullOrEmpty(trimmed))
            {
                cmbDoctorSelect.SelectedIndex = 0;
                btnScheduleSave.Focus();
            }

            isUpdatingDoctorCombo = false;
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

        private void btnScheduleSave_Click(object sender, EventArgs e)
        {
            if (cmbDoctorSelect.SelectedValue is int doctorId)
            {
                var scheduleService = new DoctorScheduleService(new ClinicDbContext());

                // Map each day’s listbox to its enum
                var dayListBoxes = new Dictionary<DaysOfWeekEnum, ListBox>
        {
            { DaysOfWeekEnum.SUNDAY,    lbSunday },
            { DaysOfWeekEnum.MONDAY,    lbMonday },
            { DaysOfWeekEnum.TUESDAY,   lbTuesday },
            { DaysOfWeekEnum.WEDNESDAY, lbWednesday },
            { DaysOfWeekEnum.THURSDAY,  lbThursday },
            { DaysOfWeekEnum.FRIDAY,    lbFriday },
            { DaysOfWeekEnum.SATURDAY,  lbSaturday }
        };

                foreach (var kvp in dayListBoxes)
                {
                    DaysOfWeekEnum dayEnum = kvp.Key;
                    ListBox listBox = kvp.Value;

                    // Remove existing schedule rows for this doctor/day
                    var existing = scheduleService.GetAllSchedules()
                        .Where(s => s.DoctorId == doctorId && s.DayOfWeek == dayEnum.ToString())
                        .ToList();
                    foreach (var s in existing)
                        scheduleService.DeleteSchedule(s);

                    // Group contiguous selections into blocks
                    var selectedIndices = listBox.SelectedIndices.Cast<int>().OrderBy(i => i).ToList();
                    if (selectedIndices.Count == 0) continue;

                    int blockStart = selectedIndices[0];
                    int prevIndex = blockStart;

                    for (int i = 1; i <= selectedIndices.Count; i++)
                    {
                        bool endOfBlock = (i == selectedIndices.Count) || (selectedIndices[i] != prevIndex + 1);

                        if (endOfBlock)
                        {
                            // Convert indices to times
                            TimeSpan start = TimeSpan.FromHours(blockStart);
                            TimeSpan end = TimeSpan.FromHours(prevIndex + 1);

                            var scheduleDto = new DoctorScheduleDTO(
                                doctorId,
                                dayEnum,
                                start,
                                end,
                                DateTime.Now,
                                DateTime.Now
                            );
                            scheduleService.CreateSchedule(scheduleDto);

                            if (i < selectedIndices.Count)
                            {
                                blockStart = selectedIndices[i];
                                prevIndex = blockStart;
                            }
                        }
                        else
                        {
                            prevIndex = selectedIndices[i];
                        }
                    }
                }

                MessageBox.Show("Weekly schedule saved successfully!");
            }
        }

        private void btnScheduleRevert_Click(object sender, EventArgs e)
        {
            if (cmbDoctorSelect.SelectedValue is int doctorId)
            {
                var scheduleService = new DoctorScheduleService(new ClinicDbContext());
                var schedules = scheduleService.GetAllSchedules()
                                               .Where(s => s.DoctorId == doctorId)
                                               .ToList();

                RefreshSchedulingListViews();

                foreach (var schedule in schedules)
                {
                    ListBox targetListBox = null;
                    switch (schedule.DayOfWeek)
                    {
                        case "SUNDAY": targetListBox = lbSunday; break;
                        case "MONDAY": targetListBox = lbMonday; break;
                        case "TUESDAY": targetListBox = lbTuesday; break;
                        case "WEDNESDAY": targetListBox = lbWednesday; break;
                        case "THURSDAY": targetListBox = lbThursday; break;
                        case "FRIDAY": targetListBox = lbFriday; break;
                        case "SATURDAY": targetListBox = lbSaturday; break;
                    }

                    if (targetListBox != null)
                    {
                        int startHour = schedule.WorkStartTime.Hours;
                        int endHour = schedule.WorkEndTime.Hours;

                        for (int hour = startHour; hour < endHour; hour++)
                        {
                            targetListBox.Items[hour] = $"{hour}:00 - {(hour + 1)}:00";
                            targetListBox.SetSelected(hour, true); // highlight
                        }
                    }
                }
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
