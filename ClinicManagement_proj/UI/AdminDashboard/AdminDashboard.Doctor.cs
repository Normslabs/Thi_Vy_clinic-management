using ClinicManagement_proj.BLL.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    partial class AdminDashboard
    {
        // private List<User> users = new List<User>();
        // private User selectedUser = null;
        private void ResetDoctorForm()
        {
            txtDoctorFName.Text = string.Empty;
            txtDoctorLName.Text = string.Empty;

            // Removed BLL calls
            List<string> usernames = new List<string>();
            /* foreach (var user in users)
            {
                usernames.Add(user.Username);
            }
            */

            comboDoctorUserId.DataSource = usernames;
            comboDoctorUserId.SelectedIndex = -1;

            // Removed non-existent enum
            // comboSpecialization.DataSource = Enum.GetValues(typeof(DoctorEnum));
            comboSpecialization.SelectedIndex = -1;

            isEditMode = false;
            btnDoctorCancel.Visible = false;
            btnDoctorDelete.Visible = false;
            // Removed BLL call
            // dgvDoctors.DataSource = Doctor.GetAllDoctors();
            dgvDoctors.DataSource = null;
            dgvDoctors.ClearSelection();
            btnDoctorSubmit.Text = "Create";
            grpDoctorMgmt.Text = "Create Doctor";
        }

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

        private void EnterDoctorEditMode()
        {
            isEditMode = true;
            btnDoctorCancel.Visible = true;
            btnDoctorDelete.Visible = true;
            btnDoctorSubmit.Text = "Update";
            grpDoctorMgmt.Text = "Edit Doctor";
        }

        private void dgvDoctors_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow != null)
            {
                // Removed BLL logic
                // int userIndex = users.FindIndex(u => u.Id.ToString() == dgvDoctors.CurrentRow.Cells["Id"].Value.ToString());
                // comboDoctorUserId.SelectedItem = users[userIndex].Username;
                txtDoctorFName.Text = dgvDoctors.CurrentRow.Cells["FirstName"].Value.ToString();
                txtDoctorLName.Text = dgvDoctors.CurrentRow.Cells["LastName"].Value.ToString();
                EnterDoctorEditMode();
            }
        }

        private void comboDoctorUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Removed BLL logic
            lblDocUserId.Text = "User Associated";
        }

        private void btnDoctorCancel_Click(object sender, EventArgs e)
        {
            ResetDoctorForm();
        }

        private void btnDoctorSubmit_Click(object sender, EventArgs e)
        {
            // Removed BLL logic
            NotificationManager.AddNotification("Doctor operation simulated!", NotificationType.Info);
            ResetDoctorForm();
        }

        private void btnDoctorDelete_Click(object sender, EventArgs e)
        {
            // Removed BLL logic
            NotificationManager.AddNotification("Doctor delete simulated!", NotificationType.Info);
            ResetDoctorForm();
        }
    }
}
