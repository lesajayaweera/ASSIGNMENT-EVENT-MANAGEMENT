namespace Assignment_Sdam
{
    partial class ParticipantDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipantDashboard));
            label1 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            Unassign_EventsBtn_Pdashboard = new Button();
            JoinBtn_PDashboard = new Button();
            ViewEventsbtn_PDashboard_participant = new Button();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            userGreetingLabel = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 0;
            label1.Text = "EventX -  Participant DashBoard";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(Unassign_EventsBtn_Pdashboard);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(JoinBtn_PDashboard);
            panel5.Controls.Add(ViewEventsbtn_PDashboard_participant);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(button1);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 588);
            panel5.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(87, 543);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Sign out";
            // 
            // Unassign_EventsBtn_Pdashboard
            // 
            Unassign_EventsBtn_Pdashboard.BackColor = Color.Black;
            Unassign_EventsBtn_Pdashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            Unassign_EventsBtn_Pdashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            Unassign_EventsBtn_Pdashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Unassign_EventsBtn_Pdashboard.ForeColor = SystemColors.ActiveCaption;
            Unassign_EventsBtn_Pdashboard.Location = new Point(5, 311);
            Unassign_EventsBtn_Pdashboard.Name = "Unassign_EventsBtn_Pdashboard";
            Unassign_EventsBtn_Pdashboard.Size = new Size(293, 75);
            Unassign_EventsBtn_Pdashboard.TabIndex = 5;
            Unassign_EventsBtn_Pdashboard.Text = "Unassign Events";
            Unassign_EventsBtn_Pdashboard.UseVisualStyleBackColor = false;
            Unassign_EventsBtn_Pdashboard.Click += Unassign_EventsBtn_Pdashboard_Click;
            // 
            // JoinBtn_PDashboard
            // 
            JoinBtn_PDashboard.BackColor = Color.Black;
            JoinBtn_PDashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            JoinBtn_PDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            JoinBtn_PDashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            JoinBtn_PDashboard.ForeColor = SystemColors.ActiveCaption;
            JoinBtn_PDashboard.Location = new Point(3, 244);
            JoinBtn_PDashboard.Name = "JoinBtn_PDashboard";
            JoinBtn_PDashboard.Size = new Size(293, 61);
            JoinBtn_PDashboard.TabIndex = 7;
            JoinBtn_PDashboard.Text = "Join Events";
            JoinBtn_PDashboard.UseVisualStyleBackColor = false;
            JoinBtn_PDashboard.Click += JoinBtn_PDashboard_Click;
            // 
            // ViewEventsbtn_PDashboard_participant
            // 
            ViewEventsbtn_PDashboard_participant.BackColor = Color.Black;
            ViewEventsbtn_PDashboard_participant.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            ViewEventsbtn_PDashboard_participant.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            ViewEventsbtn_PDashboard_participant.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            ViewEventsbtn_PDashboard_participant.ForeColor = SystemColors.ActiveCaption;
            ViewEventsbtn_PDashboard_participant.Location = new Point(5, 171);
            ViewEventsbtn_PDashboard_participant.Name = "ViewEventsbtn_PDashboard_participant";
            ViewEventsbtn_PDashboard_participant.Size = new Size(293, 67);
            ViewEventsbtn_PDashboard_participant.TabIndex = 6;
            ViewEventsbtn_PDashboard_participant.Text = "Veiw Events";
            ViewEventsbtn_PDashboard_participant.UseVisualStyleBackColor = false;
            ViewEventsbtn_PDashboard_participant.Click += ViewEventsbtn_PDashboard_participant_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(28, 526);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(5, 102);
            button1.Name = "button1";
            button1.Size = new Size(293, 63);
            button1.TabIndex = 3;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // userGreetingLabel
            // 
            userGreetingLabel.AutoSize = true;
            userGreetingLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            userGreetingLabel.Location = new Point(307, 9);
            userGreetingLabel.Name = "userGreetingLabel";
            userGreetingLabel.Size = new Size(111, 31);
            userGreetingLabel.TabIndex = 2;
            userGreetingLabel.Text = "Hi ! User,";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(674, 436);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(548, 68);
            label2.Name = "label2";
            label2.Size = new Size(167, 31);
            label2.TabIndex = 3;
            label2.Text = "Joinned Events";
            // 
            // ParticipantDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(userGreetingLabel);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ParticipantDashboard";
            Text = "ParticipantDashboard";
            Load += ParticipantDashboard_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Label userGreetingLabel;
        private Label label5;
        private Button Unassign_EventsBtn_Pdashboard;
        private Button JoinBtn_PDashboard;
        private Button ViewEventsbtn_PDashboard_participant;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
    }
}