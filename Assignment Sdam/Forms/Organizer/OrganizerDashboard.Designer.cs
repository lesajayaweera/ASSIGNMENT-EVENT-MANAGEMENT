namespace Assignment_Sdam
{
    partial class OrganizerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizerDashboard));
            panel1 = new Panel();
            DeleteEvent_ODashboard = new Button();
            label5 = new Label();
            label1 = new Label();
            signoutButton = new PictureBox();
            VeiwEvents_ODashboard = new Button();
            EditEvents_ODashboard = new Button();
            button2 = new Button();
            button1 = new Button();
            UsernameLabel_ODashboard = new Label();
            dataGridView_ODashboard = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ODashboard).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(DeleteEvent_ODashboard);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(VeiwEvents_ODashboard);
            panel1.Controls.Add(EditEvents_ODashboard);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 595);
            panel1.TabIndex = 0;
            // 
            // DeleteEvent_ODashboard
            // 
            DeleteEvent_ODashboard.BackColor = Color.Black;
            DeleteEvent_ODashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            DeleteEvent_ODashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            DeleteEvent_ODashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            DeleteEvent_ODashboard.ForeColor = SystemColors.ActiveCaption;
            DeleteEvent_ODashboard.Location = new Point(3, 381);
            DeleteEvent_ODashboard.Name = "DeleteEvent_ODashboard";
            DeleteEvent_ODashboard.Size = new Size(293, 58);
            DeleteEvent_ODashboard.TabIndex = 8;
            DeleteEvent_ODashboard.Text = "Delete Events";
            DeleteEvent_ODashboard.UseVisualStyleBackColor = false;
            DeleteEvent_ODashboard.Click += DeleteEvent_ODashboard_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(68, 543);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 6;
            label5.Text = "Sign out";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(214, 20);
            label1.TabIndex = 1;
            label1.Text = "EventX -  Organizer DashBoard";
            label1.Click += label1_Click;
            // 
            // signoutButton
            // 
            signoutButton.Image = (Image)resources.GetObject("signoutButton.Image");
            signoutButton.Location = new Point(12, 526);
            signoutButton.Name = "signoutButton";
            signoutButton.Size = new Size(50, 50);
            signoutButton.SizeMode = PictureBoxSizeMode.StretchImage;
            signoutButton.TabIndex = 5;
            signoutButton.TabStop = false;
            signoutButton.Click += signoutButton_Click;
            // 
            // VeiwEvents_ODashboard
            // 
            VeiwEvents_ODashboard.BackColor = Color.Black;
            VeiwEvents_ODashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            VeiwEvents_ODashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            VeiwEvents_ODashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            VeiwEvents_ODashboard.ForeColor = SystemColors.ActiveCaption;
            VeiwEvents_ODashboard.Location = new Point(3, 317);
            VeiwEvents_ODashboard.Name = "VeiwEvents_ODashboard";
            VeiwEvents_ODashboard.Size = new Size(293, 58);
            VeiwEvents_ODashboard.TabIndex = 1;
            VeiwEvents_ODashboard.Text = "Veiw Events";
            VeiwEvents_ODashboard.UseVisualStyleBackColor = false;
            VeiwEvents_ODashboard.Click += VeiwEvents_ODashboard_Click;
            // 
            // EditEvents_ODashboard
            // 
            EditEvents_ODashboard.BackColor = Color.Black;
            EditEvents_ODashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            EditEvents_ODashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            EditEvents_ODashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EditEvents_ODashboard.ForeColor = SystemColors.ActiveCaption;
            EditEvents_ODashboard.Location = new Point(3, 250);
            EditEvents_ODashboard.Name = "EditEvents_ODashboard";
            EditEvents_ODashboard.Size = new Size(293, 61);
            EditEvents_ODashboard.TabIndex = 2;
            EditEvents_ODashboard.Text = "Edit Event";
            EditEvents_ODashboard.UseVisualStyleBackColor = false;
            EditEvents_ODashboard.Click += EditEvents_ODashboard_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(3, 177);
            button2.Name = "button2";
            button2.Size = new Size(293, 67);
            button2.TabIndex = 1;
            button2.Text = "Create Event";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(3, 108);
            button1.Name = "button1";
            button1.Size = new Size(293, 63);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // UsernameLabel_ODashboard
            // 
            UsernameLabel_ODashboard.AutoSize = true;
            UsernameLabel_ODashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UsernameLabel_ODashboard.Location = new Point(317, 22);
            UsernameLabel_ODashboard.Name = "UsernameLabel_ODashboard";
            UsernameLabel_ODashboard.Size = new Size(111, 31);
            UsernameLabel_ODashboard.TabIndex = 1;
            UsernameLabel_ODashboard.Text = "Hi ! User,";
            // 
            // dataGridView_ODashboard
            // 
            dataGridView_ODashboard.BackgroundColor = SystemColors.ButtonFace;
            dataGridView_ODashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ODashboard.Location = new Point(305, 84);
            dataGridView_ODashboard.Name = "dataGridView_ODashboard";
            dataGridView_ODashboard.RowHeadersWidth = 51;
            dataGridView_ODashboard.Size = new Size(683, 492);
            dataGridView_ODashboard.TabIndex = 2;
            // 
            // OrganizerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(dataGridView_ODashboard);
            Controls.Add(UsernameLabel_ODashboard);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrganizerDashboard";
            Text = "Organizer Dashboard";
            Load += OrganizerDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ODashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button VeiwEvents_ODashboard;
        private Button EditEvents_ODashboard;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label5;
        private PictureBox signoutButton;
        private Label UsernameLabel_ODashboard;
        private Button DeleteEvent_ODashboard;
        private DataGridView dataGridView_ODashboard;
    }
}