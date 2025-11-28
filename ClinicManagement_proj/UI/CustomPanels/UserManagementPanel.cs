using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.BLL.Services;
using ClinicManagement_proj.UI.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI.CustomPanels {
    public partial class UserManagementPanel : UserControl {

        private static string SearchBoxPlaceholderText = "Search users...";
        private static string SearchListNewUserText = "New user...";
        private UserService userService;
        private RoleService roleService;

        public UserManagementPanel(UserService userService, RoleService roleService) {
            this.userService = userService;
            this.roleService = roleService;
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize() {
            this.searchUserTextBox.Text = SearchBoxPlaceholderText;
            this.SetupForUserCreation();
        }

        private void actionButtonCreate_Click(object sender, EventArgs e) {

            // TODO: validate all input fields for valid user creation

            this.userService.CreateUser(
                this.userUsernameField.Text, 
                this.userPasswordField.Text, 
                this.userRolesField.SelectedItems.Cast<RoleDTO>().ToList());
        }

        private void actionButtonSave_Click(object sender, EventArgs e) {

        }

        private void actionButtonDelete_Click(object sender, EventArgs e) {

        }

        private void actionButtonCancel_Click(object sender, EventArgs e) {

        }

        private void userPasswordChangeButton_Click(object sender, EventArgs e) {

        }

        private void searchUserTextBox_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(this.searchUserTextBox.Text) 
                && !(this.searchUserTextBox.Text == SearchBoxPlaceholderText)) {

                ICollection<UserDTO> searchResults = this.userService.SearchUsers(this.searchUserTextBox.Text);
                this.userSearchList.Items.Clear();
                _ = this.userSearchList.Items.Add(SearchListNewUserText);
                this.userSearchList.Items.AddRange(searchResults.ToArray());

            }
        }

        private void searchUserTextBox_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(this.searchUserTextBox.Text)) {
                this.searchUserTextBox.Text = SearchBoxPlaceholderText;
                this.searchUserTextBox.ForeColor = Color.Gray;
            }
        }

        private void searchUserTextBox_Enter(object sender, EventArgs e) {
            if (this.searchUserTextBox.Text == SearchBoxPlaceholderText) {
                this.searchUserTextBox.Text = "";
                this.searchUserTextBox.ForeColor = Color.Black;
            }
        }

        private void userSearchList_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.userSearchList.SelectedItem is string && (string)this.userSearchList.SelectedItem == SearchListNewUserText) {
                // selected item is a string (the 'new user...' special item)
                this.SetupForUserCreation();

            } else {
                // selected item should be a UserDTO object.
                UserDTO selectedUser = this.userSearchList.SelectedItem as UserDTO 
                    ?? throw new Exception($"Invalid user list item: selected item at index " +
                    $"{this.userSearchList.SelectedIndex} is not of type [{typeof(UserDTO).Name}];" +
                    $" found [{this.userSearchList.SelectedItem.GetType().Name}].");

                this.SetupForUserEdition(selectedUser);

            }
        }

        private void SetupForUserCreation() {
            this.ResetFields();
            this.deactivatePasswordChangeButton();
            this.userPasswordField.Enabled = true;
            this.activateUserCreateButton();
            this.deactivateUserUpdateButton();
            this.deactivateUserDeleteButton();

        }

        private void SetupForUserEdition(UserDTO user) {
            this.LoadUserDataInFields(user);
            this.activatePasswordChangeButton();
            this.userPasswordField.Enabled = false;
            this.deactivateUserCreateButton();
            this.activateUserUpdateButton();
            this.activateUserDeleteButton();
        }

        private void populateRolesList() {
            List<RoleDTO> allRoles = this.roleService.GetAllRoles();
            this.userRolesField.Items.Clear();
            this.userRolesField.Items.AddRange(allRoles.ToArray());
        }

        private void LoadUserDataInFields(UserDTO user) {
            this.userIdField.Value = user.Id;
            this.userUsernameField.Text = user.Username;
            this.userPasswordField.Text = string.Empty;
            this.userPasswordField.Enabled = false;
            this.actionButtonPasswordChange.Enabled = true;
            this.userCreatedAtField.Text = user.CreatedAt.ToString("dddd, MMMM dd, yyyy hh:mm:ss");
            this.userModifiedAtField.Text = user.ModifiedAt.ToString("dddd, MMMM dd, yyyy hh:mm:ss");
            this.userRolesField.SelectedItems.Clear();
            foreach (RoleDTO role in user.Roles) {
                this.userRolesField.SelectedItems.Add(role);
            }
        }

        private void ResetFields() {
            this.userIdField.Value = 0;
            this.userUsernameField.Text = string.Empty;
            this.userPasswordField.Text= string.Empty;
            this.userCreatedAtField.Text= string.Empty;
            this.userModifiedAtField.Text= string.Empty;
            this.userRolesField.SelectedItems.Clear();
        }

        private void activatePasswordChangeButton() {
            this.actionButtonPasswordChange.BackColor = Theme.OK_COLOR;
            this.actionButtonPasswordChange.Enabled = true;
            this.actionButtonPasswordChange.Cursor = Cursors.Hand;
        }

        private void activateUserCreateButton() {
            this.actionButtonCreate.BackColor = Theme.OK_COLOR;
            this.actionButtonCreate.Enabled = true;
            this.actionButtonCreate.Cursor = Cursors.Hand;
        }

        private void activateUserUpdateButton() {
            this.actionButtonSave.BackColor = Theme.OK_COLOR;
            this.actionButtonSave.Enabled = true;
            this.actionButtonSave.Cursor = Cursors.Hand;
        }

        private void activateUserDeleteButton() {
            this.actionButtonDelete.BackColor = Theme.ERROR_COLOR;
            this.actionButtonDelete.Enabled = true;
            this.actionButtonDelete.Cursor = Cursors.Hand;
        }


        private void deactivatePasswordChangeButton() {
            this.actionButtonPasswordChange.BackColor = Theme.DISABLED_COLOR;
            this.actionButtonPasswordChange.Enabled = false;
            this.actionButtonPasswordChange.Cursor = Cursors.No;
        }

        private void deactivateUserCreateButton() {
            this.actionButtonCreate.BackColor = Theme.DISABLED_COLOR;
            this.actionButtonCreate.Enabled = false;
            this.actionButtonCreate.Cursor = Cursors.No;
        }

        private void deactivateUserUpdateButton() {
            this.actionButtonSave.BackColor = Theme.DISABLED_COLOR;
            this.actionButtonSave.Enabled = false;
            this.actionButtonSave.Cursor = Cursors.No;
        }

        private void deactivateUserDeleteButton() {
            this.actionButtonDelete.BackColor = Theme.DISABLED_COLOR;
            this.actionButtonDelete.Enabled = false;
            this.actionButtonDelete.Cursor = Cursors.No;
        }
    }
}
