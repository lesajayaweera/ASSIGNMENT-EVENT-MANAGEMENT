namespace Assignment_Sdam.Forms.Admin
{
    partial class ViewDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDatabase));
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            signoutButton = new PictureBox();
            UsernameLabel_ViewDatabase = new Label();
            Home_ViewDatabase = new Button();
            EventManagement_VeiwDatabase = new Button();
            UserManagement_ViewDashboard = new Button();
            dataGridView_Events = new DataGridView();
            dataGridView_User = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Events).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_User).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 10;
            label1.Text = "EventX -  Admin Veiw Database";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(UsernameLabel_ViewDatabase);
            panel1.Controls.Add(Home_ViewDatabase);
            panel1.Controls.Add(EventManagement_VeiwDatabase);
            panel1.Controls.Add(UserManagement_ViewDashboard);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 725);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(68, 680);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 9;
            label5.Text = "Sign out";
            // 
            // signoutButton
            // 
            signoutButton.Image = (Image)resources.GetObject("signoutButton.Image");
            signoutButton.Location = new Point(12, 659);
            signoutButton.Name = "signoutButton";
            signoutButton.Size = new Size(50, 50);
            signoutButton.SizeMode = PictureBoxSizeMode.StretchImage;
            signoutButton.TabIndex = 8;
            signoutButton.TabStop = false;
            signoutButton.Click += signoutButton_Click;
            // 
            // UsernameLabel_ViewDatabase
            // 
            UsernameLabel_ViewDatabase.AutoSize = true;
            UsernameLabel_ViewDatabase.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UsernameLabel_ViewDatabase.Location = new Point(21, 102);
            UsernameLabel_ViewDatabase.Name = "UsernameLabel_ViewDatabase";
            UsernameLabel_ViewDatabase.Size = new Size(111, 31);
            UsernameLabel_ViewDatabase.TabIndex = 6;
            UsernameLabel_ViewDatabase.Text = "Hi ! User,";
            // 
            // Home_ViewDatabase
            // 
            Home_ViewDatabase.BackColor = Color.Black;
            Home_ViewDatabase.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            Home_ViewDatabase.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            Home_ViewDatabase.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Home_ViewDatabase.ForeColor = SystemColors.ActiveCaption;
            Home_ViewDatabase.Location = new Point(13, 178);
            Home_ViewDatabase.Name = "Home_ViewDatabase";
            Home_ViewDatabase.Size = new Size(293, 63);
            Home_ViewDatabase.TabIndex = 3;
            Home_ViewDatabase.Text = "Home";
            Home_ViewDatabase.UseVisualStyleBackColor = false;
            Home_ViewDatabase.Click += Home_ViewDatabase_Click;
            // 
            // EventManagement_VeiwDatabase
            // 
            EventManagement_VeiwDatabase.BackColor = Color.Black;
            EventManagement_VeiwDatabase.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            EventManagement_VeiwDatabase.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            EventManagement_VeiwDatabase.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EventManagement_VeiwDatabase.ForeColor = SystemColors.ActiveCaption;
            EventManagement_VeiwDatabase.Location = new Point(12, 247);
            EventManagement_VeiwDatabase.Name = "EventManagement_VeiwDatabase";
            EventManagement_VeiwDatabase.Size = new Size(293, 67);
            EventManagement_VeiwDatabase.TabIndex = 6;
            EventManagement_VeiwDatabase.Text = "Event Management";
            EventManagement_VeiwDatabase.UseVisualStyleBackColor = false;
            EventManagement_VeiwDatabase.Click += EventManagement_VeiwDatabase_Click;
            // 
            // UserManagement_ViewDashboard
            // 
            UserManagement_ViewDashboard.BackColor = Color.Black;
            UserManagement_ViewDashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            UserManagement_ViewDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            UserManagement_ViewDashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            UserManagement_ViewDashboard.ForeColor = SystemColors.ActiveCaption;
            UserManagement_ViewDashboard.Location = new Point(12, 320);
            UserManagement_ViewDashboard.Name = "UserManagement_ViewDashboard";
            UserManagement_ViewDashboard.Size = new Size(293, 72);
            UserManagement_ViewDashboard.TabIndex = 7;
            UserManagement_ViewDashboard.Text = "User Management";
            UserManagement_ViewDashboard.UseVisualStyleBackColor = false;
            UserManagement_ViewDashboard.Click += UserManagement_ViewDashboard_Click;
            // 
            // dataGridView_Events
            // 
            dataGridView_Events.BackgroundColor = SystemColors.ButtonFace;
            dataGridView_Events.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Events.GridColor = SystemColors.ScrollBar;
            dataGridView_Events.Location = new Point(328, 50);
            dataGridView_Events.Name = "dataGridView_Events";
            dataGridView_Events.RowHeadersWidth = 51;
            dataGridView_Events.Size = new Size(868, 294);
            dataGridView_Events.TabIndex = 7;
            // 
            // dataGridView_User
            // 
            dataGridView_User.BackgroundColor = SystemColors.Control;
            dataGridView_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_User.Location = new Point(328, 397);
            dataGridView_User.Name = "dataGridView_User";
            dataGridView_User.RowHeadersWidth = 51;
            dataGridView_User.Size = new Size(868, 293);
            dataGridView_User.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(328, 16);
            label2.Name = "label2";
            label2.Size = new Size(192, 31);
            label2.TabIndex = 9;
            label2.Text = "View Event Table";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(328, 363);
            label3.Name = "label3";
            label3.Size = new Size(182, 31);
            label3.TabIndex = 10;
            label3.Text = "View User Table";
            // 
            // ViewDatabase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 723);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView_User);
            Controls.Add(panel1);
            Controls.Add(dataGridView_Events);
            Name = "ViewDatabase";
            Text = "View Database";
            Load += ViewDatabase_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Events).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_User).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label5;
        private PictureBox signoutButton;
        private Button Home_ViewDatabase;
        private Button EventManagement_VeiwDatabase;
        private Button UserManagement_ViewDashboard;
        private DataGridView dataGridView_Events;
        private Label UsernameLabel_ViewDatabase;
        private DataGridView dataGridView_User;
        private Label label2;
        private Label label3;
    }
}