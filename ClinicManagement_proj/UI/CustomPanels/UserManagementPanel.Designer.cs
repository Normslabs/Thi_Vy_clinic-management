namespace ClinicManagement_proj.UI.CustomPanels {
    partial class UserManagementPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.baseLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.actionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userPropertiesPanel = new System.Windows.Forms.Panel();
            this.userRolesField = new System.Windows.Forms.ListBox();
            this.userRolesLabel = new System.Windows.Forms.Label();
            this.userModifiedAtField = new System.Windows.Forms.Label();
            this.userCreatedAtField = new System.Windows.Forms.Label();
            this.actionButtonPasswordChange = new System.Windows.Forms.Button();
            this.userPasswordField = new System.Windows.Forms.TextBox();
            this.userUsernameField = new System.Windows.Forms.TextBox();
            this.userIdField = new System.Windows.Forms.NumericUpDown();
            this.userModifiedAtLabel = new System.Windows.Forms.Label();
            this.userCreatedAtLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userUserNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userPropertiesHeader = new System.Windows.Forms.Label();
            this.userManagementButtonsPanel = new System.Windows.Forms.Panel();
            this.actionButtonCreate = new System.Windows.Forms.Button();
            this.actionButtonSave = new System.Windows.Forms.Button();
            this.actionButtonDelete = new System.Windows.Forms.Button();
            this.actionButtonCancel = new System.Windows.Forms.Button();
            this.userListPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userSearchList = new System.Windows.Forms.ListBox();
            this.searchUserTextBox = new System.Windows.Forms.TextBox();
            this.userListHeader = new System.Windows.Forms.Label();
            this.baseLayoutPanel.SuspendLayout();
            this.actionsTableLayoutPanel.SuspendLayout();
            this.userPropertiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIdField)).BeginInit();
            this.userManagementButtonsPanel.SuspendLayout();
            this.userListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseLayoutPanel
            // 
            this.baseLayoutPanel.ColumnCount = 2;
            this.baseLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.baseLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.baseLayoutPanel.Controls.Add(this.actionsTableLayoutPanel, 0, 0);
            this.baseLayoutPanel.Controls.Add(this.userListPanel, 1, 0);
            this.baseLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.baseLayoutPanel.Name = "baseLayoutPanel";
            this.baseLayoutPanel.RowCount = 1;
            this.baseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.baseLayoutPanel.Size = new System.Drawing.Size(700, 400);
            this.baseLayoutPanel.TabIndex = 0;
            // 
            // actionsTableLayoutPanel
            // 
            this.actionsTableLayoutPanel.ColumnCount = 1;
            this.actionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.actionsTableLayoutPanel.Controls.Add(this.userPropertiesPanel, 0, 0);
            this.actionsTableLayoutPanel.Controls.Add(this.userManagementButtonsPanel, 0, 1);
            this.actionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.actionsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.actionsTableLayoutPanel.Name = "actionsTableLayoutPanel";
            this.actionsTableLayoutPanel.RowCount = 2;
            this.actionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.actionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.actionsTableLayoutPanel.Size = new System.Drawing.Size(400, 400);
            this.actionsTableLayoutPanel.TabIndex = 0;
            // 
            // userPropertiesPanel
            // 
            this.userPropertiesPanel.Controls.Add(this.userRolesField);
            this.userPropertiesPanel.Controls.Add(this.userRolesLabel);
            this.userPropertiesPanel.Controls.Add(this.userModifiedAtField);
            this.userPropertiesPanel.Controls.Add(this.userCreatedAtField);
            this.userPropertiesPanel.Controls.Add(this.actionButtonPasswordChange);
            this.userPropertiesPanel.Controls.Add(this.userPasswordField);
            this.userPropertiesPanel.Controls.Add(this.userUsernameField);
            this.userPropertiesPanel.Controls.Add(this.userIdField);
            this.userPropertiesPanel.Controls.Add(this.userModifiedAtLabel);
            this.userPropertiesPanel.Controls.Add(this.userCreatedAtLabel);
            this.userPropertiesPanel.Controls.Add(this.userPasswordLabel);
            this.userPropertiesPanel.Controls.Add(this.userUserNameLabel);
            this.userPropertiesPanel.Controls.Add(this.userIdLabel);
            this.userPropertiesPanel.Controls.Add(this.userPropertiesHeader);
            this.userPropertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPropertiesPanel.Location = new System.Drawing.Point(3, 3);
            this.userPropertiesPanel.Name = "userPropertiesPanel";
            this.userPropertiesPanel.Padding = new System.Windows.Forms.Padding(3);
            this.userPropertiesPanel.Size = new System.Drawing.Size(394, 294);
            this.userPropertiesPanel.TabIndex = 0;
            // 
            // userRolesField
            // 
            this.userRolesField.DisplayMember = "RoleName";
            this.userRolesField.FormattingEnabled = true;
            this.userRolesField.Location = new System.Drawing.Point(162, 180);
            this.userRolesField.Name = "userRolesField";
            this.userRolesField.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.userRolesField.Size = new System.Drawing.Size(226, 95);
            this.userRolesField.TabIndex = 13;
            // 
            // userRolesLabel
            // 
            this.userRolesLabel.Location = new System.Drawing.Point(6, 178);
            this.userRolesLabel.Name = "userRolesLabel";
            this.userRolesLabel.Size = new System.Drawing.Size(150, 25);
            this.userRolesLabel.TabIndex = 12;
            this.userRolesLabel.Text = "User roles :";
            this.userRolesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userModifiedAtField
            // 
            this.userModifiedAtField.Location = new System.Drawing.Point(159, 154);
            this.userModifiedAtField.Name = "userModifiedAtField";
            this.userModifiedAtField.Size = new System.Drawing.Size(229, 23);
            this.userModifiedAtField.TabIndex = 11;
            this.userModifiedAtField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userCreatedAtField
            // 
            this.userCreatedAtField.Location = new System.Drawing.Point(159, 129);
            this.userCreatedAtField.Name = "userCreatedAtField";
            this.userCreatedAtField.Size = new System.Drawing.Size(229, 23);
            this.userCreatedAtField.TabIndex = 10;
            this.userCreatedAtField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // actionButtonPasswordChange
            // 
            this.actionButtonPasswordChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actionButtonPasswordChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.actionButtonPasswordChange.Cursor = System.Windows.Forms.Cursors.No;
            this.actionButtonPasswordChange.FlatAppearance.BorderSize = 0;
            this.actionButtonPasswordChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionButtonPasswordChange.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionButtonPasswordChange.ForeColor = System.Drawing.Color.White;
            this.actionButtonPasswordChange.Location = new System.Drawing.Point(318, 104);
            this.actionButtonPasswordChange.Name = "actionButtonPasswordChange";
            this.actionButtonPasswordChange.Size = new System.Drawing.Size(70, 23);
            this.actionButtonPasswordChange.TabIndex = 9;
            this.actionButtonPasswordChange.Text = "Change";
            this.actionButtonPasswordChange.UseVisualStyleBackColor = false;
            this.actionButtonPasswordChange.Click += new System.EventHandler(this.userPasswordChangeButton_Click);
            // 
            // userPasswordField
            // 
            this.userPasswordField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPasswordField.Location = new System.Drawing.Point(162, 106);
            this.userPasswordField.Name = "userPasswordField";
            this.userPasswordField.Size = new System.Drawing.Size(150, 20);
            this.userPasswordField.TabIndex = 8;
            this.userPasswordField.UseSystemPasswordChar = true;
            // 
            // userUsernameField
            // 
            this.userUsernameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userUsernameField.Location = new System.Drawing.Point(162, 81);
            this.userUsernameField.Name = "userUsernameField";
            this.userUsernameField.Size = new System.Drawing.Size(226, 20);
            this.userUsernameField.TabIndex = 7;
            // 
            // userIdField
            // 
            this.userIdField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userIdField.Enabled = false;
            this.userIdField.Location = new System.Drawing.Point(162, 57);
            this.userIdField.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.userIdField.Name = "userIdField";
            this.userIdField.Size = new System.Drawing.Size(226, 20);
            this.userIdField.TabIndex = 6;
            // 
            // userModifiedAtLabel
            // 
            this.userModifiedAtLabel.Location = new System.Drawing.Point(6, 153);
            this.userModifiedAtLabel.Name = "userModifiedAtLabel";
            this.userModifiedAtLabel.Size = new System.Drawing.Size(150, 25);
            this.userModifiedAtLabel.TabIndex = 5;
            this.userModifiedAtLabel.Text = "User last modified on :";
            this.userModifiedAtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userCreatedAtLabel
            // 
            this.userCreatedAtLabel.Location = new System.Drawing.Point(6, 128);
            this.userCreatedAtLabel.Name = "userCreatedAtLabel";
            this.userCreatedAtLabel.Size = new System.Drawing.Size(150, 25);
            this.userCreatedAtLabel.TabIndex = 4;
            this.userCreatedAtLabel.Text = "User created on :";
            this.userCreatedAtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.Location = new System.Drawing.Point(6, 103);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(150, 25);
            this.userPasswordLabel.TabIndex = 3;
            this.userPasswordLabel.Text = "Password :";
            this.userPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userUserNameLabel
            // 
            this.userUserNameLabel.Location = new System.Drawing.Point(6, 78);
            this.userUserNameLabel.Name = "userUserNameLabel";
            this.userUserNameLabel.Size = new System.Drawing.Size(150, 25);
            this.userUserNameLabel.TabIndex = 2;
            this.userUserNameLabel.Text = "Username :";
            this.userUserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userIdLabel
            // 
            this.userIdLabel.Location = new System.Drawing.Point(6, 53);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(150, 25);
            this.userIdLabel.TabIndex = 1;
            this.userIdLabel.Text = "Id :";
            this.userIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userPropertiesHeader
            // 
            this.userPropertiesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPropertiesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPropertiesHeader.Location = new System.Drawing.Point(3, 3);
            this.userPropertiesHeader.Name = "userPropertiesHeader";
            this.userPropertiesHeader.Size = new System.Drawing.Size(388, 30);
            this.userPropertiesHeader.TabIndex = 0;
            this.userPropertiesHeader.Text = "User Properties";
            this.userPropertiesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userManagementButtonsPanel
            // 
            this.userManagementButtonsPanel.Controls.Add(this.actionButtonCreate);
            this.userManagementButtonsPanel.Controls.Add(this.actionButtonSave);
            this.userManagementButtonsPanel.Controls.Add(this.actionButtonDelete);
            this.userManagementButtonsPanel.Controls.Add(this.actionButtonCancel);
            this.userManagementButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManagementButtonsPanel.Location = new System.Drawing.Point(3, 303);
            this.userManagementButtonsPanel.Name = "userManagementButtonsPanel";
            this.userManagementButtonsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.userManagementButtonsPanel.Size = new System.Drawing.Size(394, 94);
            this.userManagementButtonsPanel.TabIndex = 1;
            // 
            // actionButtonCreate
            // 
            this.actionButtonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.actionButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.actionButtonCreate.Cursor = System.Windows.Forms.Cursors.No;
            this.actionButtonCreate.FlatAppearance.BorderSize = 0;
            this.actionButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionButtonCreate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.actionButtonCreate.ForeColor = System.Drawing.Color.White;
            this.actionButtonCreate.Location = new System.Drawing.Point(20, 6);
            this.actionButtonCreate.Name = "actionButtonCreate";
            this.actionButtonCreate.Size = new System.Drawing.Size(100, 30);
            this.actionButtonCreate.TabIndex = 3;
            this.actionButtonCreate.Text = "Create user";
            this.actionButtonCreate.UseVisualStyleBackColor = false;
            this.actionButtonCreate.Click += new System.EventHandler(this.actionButtonCreate_Click);
            // 
            // actionButtonSave
            // 
            this.actionButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.actionButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.actionButtonSave.Cursor = System.Windows.Forms.Cursors.No;
            this.actionButtonSave.FlatAppearance.BorderSize = 0;
            this.actionButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionButtonSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.actionButtonSave.ForeColor = System.Drawing.Color.White;
            this.actionButtonSave.Location = new System.Drawing.Point(126, 6);
            this.actionButtonSave.Name = "actionButtonSave";
            this.actionButtonSave.Size = new System.Drawing.Size(100, 30);
            this.actionButtonSave.TabIndex = 2;
            this.actionButtonSave.Text = "Save Changes";
            this.actionButtonSave.UseVisualStyleBackColor = false;
            this.actionButtonSave.Click += new System.EventHandler(this.actionButtonSave_Click);
            // 
            // actionButtonDelete
            // 
            this.actionButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.actionButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.actionButtonDelete.Cursor = System.Windows.Forms.Cursors.No;
            this.actionButtonDelete.FlatAppearance.BorderSize = 0;
            this.actionButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionButtonDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.actionButtonDelete.ForeColor = System.Drawing.Color.White;
            this.actionButtonDelete.Location = new System.Drawing.Point(232, 6);
            this.actionButtonDelete.Name = "actionButtonDelete";
            this.actionButtonDelete.Size = new System.Drawing.Size(75, 30);
            this.actionButtonDelete.TabIndex = 1;
            this.actionButtonDelete.Text = "Delete";
            this.actionButtonDelete.UseVisualStyleBackColor = false;
            this.actionButtonDelete.Click += new System.EventHandler(this.actionButtonDelete_Click);
            // 
            // actionButtonCancel
            // 
            this.actionButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.actionButtonCancel.BackColor = System.Drawing.Color.LightGray;
            this.actionButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actionButtonCancel.FlatAppearance.BorderSize = 0;
            this.actionButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionButtonCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.actionButtonCancel.ForeColor = System.Drawing.Color.DimGray;
            this.actionButtonCancel.Location = new System.Drawing.Point(313, 6);
            this.actionButtonCancel.Name = "actionButtonCancel";
            this.actionButtonCancel.Size = new System.Drawing.Size(75, 30);
            this.actionButtonCancel.TabIndex = 0;
            this.actionButtonCancel.Text = "Cancel";
            this.actionButtonCancel.UseVisualStyleBackColor = false;
            this.actionButtonCancel.Click += new System.EventHandler(this.actionButtonCancel_Click);
            // 
            // userListPanel
            // 
            this.userListPanel.Controls.Add(this.panel1);
            this.userListPanel.Controls.Add(this.userSearchList);
            this.userListPanel.Controls.Add(this.searchUserTextBox);
            this.userListPanel.Controls.Add(this.userListHeader);
            this.userListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userListPanel.Location = new System.Drawing.Point(403, 3);
            this.userListPanel.Name = "userListPanel";
            this.userListPanel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.userListPanel.Size = new System.Drawing.Size(294, 394);
            this.userListPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 94);
            this.panel1.TabIndex = 5;
            // 
            // userSearchList
            // 
            this.userSearchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSearchList.FormattingEnabled = true;
            this.userSearchList.Location = new System.Drawing.Point(3, 53);
            this.userSearchList.Name = "userSearchList";
            this.userSearchList.Size = new System.Drawing.Size(288, 341);
            this.userSearchList.TabIndex = 4;
            this.userSearchList.SelectedIndexChanged += new System.EventHandler(this.userSearchList_SelectedIndexChanged);
            // 
            // searchUserTextBox
            // 
            this.searchUserTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchUserTextBox.Location = new System.Drawing.Point(3, 33);
            this.searchUserTextBox.Name = "searchUserTextBox";
            this.searchUserTextBox.Size = new System.Drawing.Size(288, 20);
            this.searchUserTextBox.TabIndex = 3;
            this.searchUserTextBox.TextChanged += new System.EventHandler(this.searchUserTextBox_TextChanged);
            this.searchUserTextBox.Enter += new System.EventHandler(this.searchUserTextBox_Enter);
            this.searchUserTextBox.Leave += new System.EventHandler(this.searchUserTextBox_Leave);
            // 
            // userListHeader
            // 
            this.userListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.userListHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListHeader.Location = new System.Drawing.Point(3, 3);
            this.userListHeader.Name = "userListHeader";
            this.userListHeader.Size = new System.Drawing.Size(288, 30);
            this.userListHeader.TabIndex = 2;
            this.userListHeader.Text = "User List";
            this.userListHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.baseLayoutPanel);
            this.Name = "UserManagementPanel";
            this.Size = new System.Drawing.Size(700, 400);
            this.baseLayoutPanel.ResumeLayout(false);
            this.actionsTableLayoutPanel.ResumeLayout(false);
            this.userPropertiesPanel.ResumeLayout(false);
            this.userPropertiesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIdField)).EndInit();
            this.userManagementButtonsPanel.ResumeLayout(false);
            this.userListPanel.ResumeLayout(false);
            this.userListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel baseLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel actionsTableLayoutPanel;
        private System.Windows.Forms.Panel userPropertiesPanel;
        private System.Windows.Forms.Label userPropertiesHeader;
        private System.Windows.Forms.Panel userManagementButtonsPanel;
        private System.Windows.Forms.Panel userListPanel;
        private System.Windows.Forms.TextBox searchUserTextBox;
        private System.Windows.Forms.Label userListHeader;
        private System.Windows.Forms.ListBox userSearchList;
        private System.Windows.Forms.Label userUserNameLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.TextBox userPasswordField;
        private System.Windows.Forms.TextBox userUsernameField;
        private System.Windows.Forms.NumericUpDown userIdField;
        private System.Windows.Forms.Label userModifiedAtLabel;
        private System.Windows.Forms.Label userCreatedAtLabel;
        private System.Windows.Forms.Label userModifiedAtField;
        private System.Windows.Forms.Label userCreatedAtField;
        private System.Windows.Forms.Button actionButtonPasswordChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button actionButtonCancel;
        private System.Windows.Forms.Button actionButtonDelete;
        private System.Windows.Forms.Button actionButtonCreate;
        private System.Windows.Forms.Button actionButtonSave;
        private System.Windows.Forms.ListBox userRolesField;
        private System.Windows.Forms.Label userRolesLabel;
    }
}
