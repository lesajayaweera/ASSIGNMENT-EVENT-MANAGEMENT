namespace Assignment_Sdam
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            UserManagement_Admin = new Button();
            label1 = new Label();
            label5 = new Label();
            signoutButton = new PictureBox();
            VeiwDatabase_Admin = new Button();
            EventManagement_Admin = new Button();
            UsernameLabel_ADashboard = new Label();
            dataGridView_ADashboard = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ADashboard).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(UserManagement_Admin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(VeiwDatabase_Admin);
            panel1.Controls.Add(EventManagement_Admin);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 595);
            panel1.TabIndex = 0;
            // 
            // UserManagement_Admin
            // 
            UserManagement_Admin.BackColor = Color.Black;
            UserManagement_Admin.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            UserManagement_Admin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            UserManagement_Admin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            UserManagement_Admin.ForeColor = SystemColors.ActiveCaption;
            UserManagement_Admin.Location = new Point(15, 336);
            UserManagement_Admin.Name = "UserManagement_Admin";
            UserManagement_Admin.Size = new Size(293, 67);
            UserManagement_Admin.TabIndex = 11;
            UserManagement_Admin.Text = "User Management";
            UserManagement_Admin.UseVisualStyleBackColor = false;
            UserManagement_Admin.Click += UserManagement_Admin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 10;
            label1.Text = "EventX -  Admin DashBoard";
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
            // VeiwDatabase_Admin
            // 
            VeiwDatabase_Admin.BackColor = Color.Black;
            VeiwDatabase_Admin.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            VeiwDatabase_Admin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            VeiwDatabase_Admin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            VeiwDatabase_Admin.ForeColor = SystemColors.ActiveCaption;
            VeiwDatabase_Admin.Location = new Point(15, 185);
            VeiwDatabase_Admin.Name = "VeiwDatabase_Admin";
            VeiwDatabase_Admin.Size = new Size(293, 67);
            VeiwDatabase_Admin.TabIndex = 6;
            VeiwDatabase_Admin.Text = "View Database";
            VeiwDatabase_Admin.UseVisualStyleBackColor = false;
            VeiwDatabase_Admin.Click += VeiwDatabase_Admin_Click;
            // 
            // EventManagement_Admin
            // 
            EventManagement_Admin.BackColor = Color.Black;
            EventManagement_Admin.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            EventManagement_Admin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            EventManagement_Admin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EventManagement_Admin.ForeColor = SystemColors.ActiveCaption;
            EventManagement_Admin.Location = new Point(15, 258);
            EventManagement_Admin.Name = "EventManagement_Admin";
            EventManagement_Admin.Size = new Size(293, 72);
            EventManagement_Admin.TabIndex = 7;
            EventManagement_Admin.Text = "Event Management";
            EventManagement_Admin.UseVisualStyleBackColor = false;
            EventManagement_Admin.Click += EventManagement_Admin_Click;
            // 
            // UsernameLabel_ADashboard
            // 
            UsernameLabel_ADashboard.AutoSize = true;
            UsernameLabel_ADashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UsernameLabel_ADashboard.Location = new Point(327, 32);
            UsernameLabel_ADashboard.Name = "UsernameLabel_ADashboard";
            UsernameLabel_ADashboard.Size = new Size(111, 31);
            UsernameLabel_ADashboard.TabIndex = 2;
            UsernameLabel_ADashboard.Text = "Hi ! User,";
            // 
            // dataGridView_ADashboard
            // 
            dataGridView_ADashboard.BackgroundColor = SystemColors.ButtonFace;
            dataGridView_ADashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ADashboard.GridColor = SystemColors.ScrollBar;
            dataGridView_ADashboard.Location = new Point(327, 114);
            dataGridView_ADashboard.Name = "dataGridView_ADashboard";
            dataGridView_ADashboard.RowHeadersWidth = 51;
            dataGridView_ADashboard.Size = new Size(647, 428);
            dataGridView_ADashboard.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(599, 69);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 4;
            label2.Text = "All Events";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(label2);
            Controls.Add(dataGridView_ADashboard);
            Controls.Add(UsernameLabel_ADashboard);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ADashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button Admin_Home;
        private Button button4;
        private Button VeiwDatabase_Admin;
        private Button EventManagement_Admin;
        private Label label5;
        private PictureBox signoutButton;
        private Label label1;
        private Label UsernameLabel_ADashboard;
        private Button UserManagement_Admin;
        private DataGridView dataGridView_ADashboard;
        private Label label2;
    }
}