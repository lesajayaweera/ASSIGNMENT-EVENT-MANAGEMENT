namespace Assignment_Sdam.Forms.Admin
{
    partial class UserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            label1 = new Label();
            panel1 = new Panel();
            EventManagement_UserManagement = new Button();
            label5 = new Label();
            signoutButton = new PictureBox();
            Home_UserManagement = new Button();
            ViewDatabase_UserManagement = new Button();
            DeleteUser_UserManagement = new Button();
            label2 = new Label();
            dataGridView_Usermanagement = new DataGridView();
            UsernameLabel_EventManagement = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Usermanagement).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(233, 20);
            label1.TabIndex = 10;
            label1.Text = "EventX -  Admin User Managment";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(EventManagement_UserManagement);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(Home_UserManagement);
            panel1.Controls.Add(ViewDatabase_UserManagement);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(11, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 595);
            panel1.TabIndex = 11;
            // 
            // EventManagement_UserManagement
            // 
            EventManagement_UserManagement.BackColor = Color.Black;
            EventManagement_UserManagement.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            EventManagement_UserManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            EventManagement_UserManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EventManagement_UserManagement.ForeColor = SystemColors.ActiveCaption;
            EventManagement_UserManagement.Location = new Point(15, 258);
            EventManagement_UserManagement.Name = "EventManagement_UserManagement";
            EventManagement_UserManagement.Size = new Size(293, 67);
            EventManagement_UserManagement.TabIndex = 11;
            EventManagement_UserManagement.Text = "Event Management";
            EventManagement_UserManagement.UseVisualStyleBackColor = false;
            EventManagement_UserManagement.Click += EventManagement_UserManagement_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(74, 545);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 9;
            label5.Text = "Sign out";
            // 
            // signoutButton
            // 
            signoutButton.Image = (Image)resources.GetObject("signoutButton.Image");
            signoutButton.Location = new Point(18, 528);
            signoutButton.Name = "signoutButton";
            signoutButton.Size = new Size(50, 50);
            signoutButton.SizeMode = PictureBoxSizeMode.StretchImage;
            signoutButton.TabIndex = 8;
            signoutButton.TabStop = false;
            signoutButton.Click += signoutButton_Click;
            // 
            // Home_UserManagement
            // 
            Home_UserManagement.BackColor = Color.Black;
            Home_UserManagement.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            Home_UserManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            Home_UserManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Home_UserManagement.ForeColor = SystemColors.ActiveCaption;
            Home_UserManagement.Location = new Point(16, 116);
            Home_UserManagement.Name = "Home_UserManagement";
            Home_UserManagement.Size = new Size(293, 63);
            Home_UserManagement.TabIndex = 3;
            Home_UserManagement.Text = "Home";
            Home_UserManagement.UseVisualStyleBackColor = false;
            Home_UserManagement.Click += Home_UserManagement_Click;
            // 
            // ViewDatabase_UserManagement
            // 
            ViewDatabase_UserManagement.BackColor = Color.Black;
            ViewDatabase_UserManagement.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            ViewDatabase_UserManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            ViewDatabase_UserManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            ViewDatabase_UserManagement.ForeColor = SystemColors.ActiveCaption;
            ViewDatabase_UserManagement.Location = new Point(15, 185);
            ViewDatabase_UserManagement.Name = "ViewDatabase_UserManagement";
            ViewDatabase_UserManagement.Size = new Size(293, 67);
            ViewDatabase_UserManagement.TabIndex = 6;
            ViewDatabase_UserManagement.Text = "View Database";
            ViewDatabase_UserManagement.UseVisualStyleBackColor = false;
            ViewDatabase_UserManagement.Click += ViewDatabase_UserManagement_Click;
            // 
            // DeleteUser_UserManagement
            // 
            DeleteUser_UserManagement.BackColor = Color.Red;
            DeleteUser_UserManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            DeleteUser_UserManagement.ForeColor = SystemColors.ButtonHighlight;
            DeleteUser_UserManagement.Location = new Point(834, 518);
            DeleteUser_UserManagement.Name = "DeleteUser_UserManagement";
            DeleteUser_UserManagement.Size = new Size(143, 60);
            DeleteUser_UserManagement.TabIndex = 15;
            DeleteUser_UserManagement.Text = "Delete User";
            DeleteUser_UserManagement.UseVisualStyleBackColor = false;
            DeleteUser_UserManagement.Click += DeleteUser_UserManagement_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(614, 68);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 14;
            label2.Text = "All Users";
            // 
            // dataGridView_Usermanagement
            // 
            dataGridView_Usermanagement.BackgroundColor = SystemColors.ButtonFace;
            dataGridView_Usermanagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Usermanagement.GridColor = SystemColors.ScrollBar;
            dataGridView_Usermanagement.Location = new Point(328, 113);
            dataGridView_Usermanagement.Name = "dataGridView_Usermanagement";
            dataGridView_Usermanagement.RowHeadersWidth = 51;
            dataGridView_Usermanagement.Size = new Size(661, 399);
            dataGridView_Usermanagement.TabIndex = 13;
            dataGridView_Usermanagement.CellContentClick += dataGridView_Usermanagement_CellContentClick;
            // 
            // UsernameLabel_EventManagement
            // 
            UsernameLabel_EventManagement.AutoSize = true;
            UsernameLabel_EventManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UsernameLabel_EventManagement.Location = new Point(342, 31);
            UsernameLabel_EventManagement.Name = "UsernameLabel_EventManagement";
            UsernameLabel_EventManagement.Size = new Size(111, 31);
            UsernameLabel_EventManagement.TabIndex = 12;
            UsernameLabel_EventManagement.Text = "Hi ! User,";
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(panel1);
            Controls.Add(DeleteUser_UserManagement);
            Controls.Add(label2);
            Controls.Add(dataGridView_Usermanagement);
            Controls.Add(UsernameLabel_EventManagement);
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Usermanagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button EventManagement_UserManagement;
        private Label label5;
        private PictureBox signoutButton;
        private Button Home_UserManagement;
        private Button ViewDatabase_UserManagement;
        private Button ViewEventDetail_UserManagement;
        private Button DeleteUser_UserManagement;
        private Label label2;
        private DataGridView dataGridView_Usermanagement;
        private Label UsernameLabel_EventManagement;
    }
}