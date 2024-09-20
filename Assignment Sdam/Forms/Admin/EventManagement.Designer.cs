namespace Assignment_Sdam.Forms.Admin
{
    partial class EventManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventManagement));
            label1 = new Label();
            panel1 = new Panel();
            UserManagement_EventManagement = new Button();
            label5 = new Label();
            signoutButton = new PictureBox();
            Home_EventManagement = new Button();
            ViewDatabase_EventManagement = new Button();
            label2 = new Label();
            dataGridView_Eventmanagement = new DataGridView();
            UsernameLabel_EventManagement = new Label();
            DeleteEventbtn_EventManagement = new Button();
            ViewEventDetail_EventManagement = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Eventmanagement).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 10;
            label1.Text = "EventX -  Admin Event Managment";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(UserManagement_EventManagement);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(Home_EventManagement);
            panel1.Controls.Add(ViewDatabase_EventManagement);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 595);
            panel1.TabIndex = 5;
            // 
            // UserManagement_EventManagement
            // 
            UserManagement_EventManagement.BackColor = Color.Black;
            UserManagement_EventManagement.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            UserManagement_EventManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            UserManagement_EventManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            UserManagement_EventManagement.ForeColor = SystemColors.ActiveCaption;
            UserManagement_EventManagement.Location = new Point(15, 258);
            UserManagement_EventManagement.Name = "UserManagement_EventManagement";
            UserManagement_EventManagement.Size = new Size(293, 67);
            UserManagement_EventManagement.TabIndex = 11;
            UserManagement_EventManagement.Text = "User Management";
            UserManagement_EventManagement.UseVisualStyleBackColor = false;
            UserManagement_EventManagement.Click += UserManagement_EventManagement_Click;
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
            // Home_EventManagement
            // 
            Home_EventManagement.BackColor = Color.Black;
            Home_EventManagement.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            Home_EventManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            Home_EventManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Home_EventManagement.ForeColor = SystemColors.ActiveCaption;
            Home_EventManagement.Location = new Point(16, 116);
            Home_EventManagement.Name = "Home_EventManagement";
            Home_EventManagement.Size = new Size(293, 63);
            Home_EventManagement.TabIndex = 3;
            Home_EventManagement.Text = "Home";
            Home_EventManagement.UseVisualStyleBackColor = false;
            Home_EventManagement.Click += Home_EventManagement_Click;
            // 
            // ViewDatabase_EventManagement
            // 
            ViewDatabase_EventManagement.BackColor = Color.Black;
            ViewDatabase_EventManagement.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            ViewDatabase_EventManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            ViewDatabase_EventManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            ViewDatabase_EventManagement.ForeColor = SystemColors.ActiveCaption;
            ViewDatabase_EventManagement.Location = new Point(15, 185);
            ViewDatabase_EventManagement.Name = "ViewDatabase_EventManagement";
            ViewDatabase_EventManagement.Size = new Size(293, 67);
            ViewDatabase_EventManagement.TabIndex = 6;
            ViewDatabase_EventManagement.Text = "View Database";
            ViewDatabase_EventManagement.UseVisualStyleBackColor = false;
            ViewDatabase_EventManagement.Click += ViewDatabase_EventManagement_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(614, 68);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 8;
            label2.Text = "All Events";
            // 
            // dataGridView_Eventmanagement
            // 
            dataGridView_Eventmanagement.BackgroundColor = SystemColors.ButtonFace;
            dataGridView_Eventmanagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Eventmanagement.GridColor = SystemColors.ScrollBar;
            dataGridView_Eventmanagement.Location = new Point(342, 113);
            dataGridView_Eventmanagement.Name = "dataGridView_Eventmanagement";
            dataGridView_Eventmanagement.RowHeadersWidth = 51;
            dataGridView_Eventmanagement.Size = new Size(647, 383);
            dataGridView_Eventmanagement.TabIndex = 7;
            dataGridView_Eventmanagement.CellContentClick += dataGridView_Eventmanagement_CellContentClick;
            // 
            // UsernameLabel_EventManagement
            // 
            UsernameLabel_EventManagement.AutoSize = true;
            UsernameLabel_EventManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UsernameLabel_EventManagement.Location = new Point(342, 31);
            UsernameLabel_EventManagement.Name = "UsernameLabel_EventManagement";
            UsernameLabel_EventManagement.Size = new Size(111, 31);
            UsernameLabel_EventManagement.TabIndex = 6;
            UsernameLabel_EventManagement.Text = "Hi ! User,";
            // 
            // DeleteEventbtn_EventManagement
            // 
            DeleteEventbtn_EventManagement.BackColor = Color.Red;
            DeleteEventbtn_EventManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            DeleteEventbtn_EventManagement.ForeColor = SystemColors.ButtonHighlight;
            DeleteEventbtn_EventManagement.Location = new Point(647, 515);
            DeleteEventbtn_EventManagement.Name = "DeleteEventbtn_EventManagement";
            DeleteEventbtn_EventManagement.Size = new Size(195, 60);
            DeleteEventbtn_EventManagement.TabIndex = 9;
            DeleteEventbtn_EventManagement.Text = "Delete Event";
            DeleteEventbtn_EventManagement.UseVisualStyleBackColor = false;
            DeleteEventbtn_EventManagement.Click += DeleteEventbtn_EventManagement_Click;
            // 
            // ViewEventDetail_EventManagement
            // 
            ViewEventDetail_EventManagement.BackColor = Color.Black;
            ViewEventDetail_EventManagement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            ViewEventDetail_EventManagement.ForeColor = SystemColors.ButtonHighlight;
            ViewEventDetail_EventManagement.Location = new Point(342, 515);
            ViewEventDetail_EventManagement.Name = "ViewEventDetail_EventManagement";
            ViewEventDetail_EventManagement.Size = new Size(210, 60);
            ViewEventDetail_EventManagement.TabIndex = 10;
            ViewEventDetail_EventManagement.Text = "View Event Detail";
            ViewEventDetail_EventManagement.UseVisualStyleBackColor = false;
            ViewEventDetail_EventManagement.Click += ViewEventDetail_EventManagement_Click;
            // 
            // EventManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(ViewEventDetail_EventManagement);
            Controls.Add(DeleteEventbtn_EventManagement);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dataGridView_Eventmanagement);
            Controls.Add(UsernameLabel_EventManagement);
            Name = "EventManagement";
            Text = "Admin-Event Management";
            Load += EventManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Eventmanagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button UserManagement_EventManagement;
        private Label label5;
        private PictureBox signoutButton;
        private Button Home_EventManagement;
        private Button ViewDatabase_EventManagement;
        private Label label2;
        private DataGridView dataGridView_Eventmanagement;
        private Label UsernameLabel_EventManagement;
        private Button DeleteEventbtn_EventManagement;
        private Button ViewEventDetail_EventManagement;
    }
}