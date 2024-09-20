namespace Assignment_Sdam.Forms.Participant
{
    partial class JoinEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinEvents));
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            signoutButton = new PictureBox();
            UnassignEventBtn_JoinEvents_participant = new Button();
            ViewEventsbtn_Join_Events_participant = new Button();
            HomeDashboardbtn_Join_Events = new Button();
            label2 = new Label();
            JoinEvent_DataGrid_Participant = new DataGridView();
            Joinbtn_JoinPage = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)JoinEvent_DataGrid_Participant).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(UnassignEventBtn_JoinEvents_participant);
            panel1.Controls.Add(ViewEventsbtn_Join_Events_participant);
            panel1.Controls.Add(HomeDashboardbtn_Join_Events);
            panel1.Location = new Point(3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 595);
            panel1.TabIndex = 9;
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
            label1.Location = new Point(68, 58);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 1;
            label1.Text = "EventX -  Join Events\r\n";
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
            // UnassignEventBtn_JoinEvents_participant
            // 
            UnassignEventBtn_JoinEvents_participant.BackColor = Color.Black;
            UnassignEventBtn_JoinEvents_participant.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            UnassignEventBtn_JoinEvents_participant.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            UnassignEventBtn_JoinEvents_participant.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            UnassignEventBtn_JoinEvents_participant.ForeColor = SystemColors.ActiveCaption;
            UnassignEventBtn_JoinEvents_participant.Location = new Point(3, 250);
            UnassignEventBtn_JoinEvents_participant.Name = "UnassignEventBtn_JoinEvents_participant";
            UnassignEventBtn_JoinEvents_participant.Size = new Size(293, 61);
            UnassignEventBtn_JoinEvents_participant.TabIndex = 2;
            UnassignEventBtn_JoinEvents_participant.Text = "Unassign  Event";
            UnassignEventBtn_JoinEvents_participant.UseVisualStyleBackColor = false;
            UnassignEventBtn_JoinEvents_participant.Click += UnassignEventBtn_JoinEvents_participant_Click;
            // 
            // ViewEventsbtn_Join_Events_participant
            // 
            ViewEventsbtn_Join_Events_participant.BackColor = Color.Black;
            ViewEventsbtn_Join_Events_participant.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            ViewEventsbtn_Join_Events_participant.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            ViewEventsbtn_Join_Events_participant.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            ViewEventsbtn_Join_Events_participant.ForeColor = SystemColors.ActiveCaption;
            ViewEventsbtn_Join_Events_participant.Location = new Point(3, 177);
            ViewEventsbtn_Join_Events_participant.Name = "ViewEventsbtn_Join_Events_participant";
            ViewEventsbtn_Join_Events_participant.Size = new Size(293, 67);
            ViewEventsbtn_Join_Events_participant.TabIndex = 1;
            ViewEventsbtn_Join_Events_participant.Text = "View Event";
            ViewEventsbtn_Join_Events_participant.UseVisualStyleBackColor = false;
            ViewEventsbtn_Join_Events_participant.Click += ViewEventsbtn_Join_Events_participant_Click;
            // 
            // HomeDashboardbtn_Join_Events
            // 
            HomeDashboardbtn_Join_Events.BackColor = Color.Black;
            HomeDashboardbtn_Join_Events.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            HomeDashboardbtn_Join_Events.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            HomeDashboardbtn_Join_Events.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            HomeDashboardbtn_Join_Events.ForeColor = SystemColors.ActiveCaption;
            HomeDashboardbtn_Join_Events.Location = new Point(3, 108);
            HomeDashboardbtn_Join_Events.Name = "HomeDashboardbtn_Join_Events";
            HomeDashboardbtn_Join_Events.Size = new Size(293, 63);
            HomeDashboardbtn_Join_Events.TabIndex = 0;
            HomeDashboardbtn_Join_Events.Text = "Home";
            HomeDashboardbtn_Join_Events.UseVisualStyleBackColor = false;
            HomeDashboardbtn_Join_Events.Click += HomeDashboardbtn_Join_Events_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(326, 44);
            label2.Name = "label2";
            label2.Size = new Size(148, 31);
            label2.TabIndex = 11;
            label2.Text = "Select Events";
            // 
            // JoinEvent_DataGrid_Participant
            // 
            JoinEvent_DataGrid_Participant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            JoinEvent_DataGrid_Participant.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            JoinEvent_DataGrid_Participant.BackgroundColor = SystemColors.ButtonFace;
            JoinEvent_DataGrid_Participant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JoinEvent_DataGrid_Participant.Location = new Point(307, 89);
            JoinEvent_DataGrid_Participant.Name = "JoinEvent_DataGrid_Participant";
            JoinEvent_DataGrid_Participant.RowHeadersWidth = 51;
            JoinEvent_DataGrid_Participant.Size = new Size(690, 362);
            JoinEvent_DataGrid_Participant.TabIndex = 10;
            JoinEvent_DataGrid_Participant.CellContentClick += JoinEvent_DataGrid_Participant_CellContentClick;
            // 
            // Joinbtn_JoinPage
            // 
            Joinbtn_JoinPage.BackColor = SystemColors.ActiveCaptionText;
            Joinbtn_JoinPage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            Joinbtn_JoinPage.ForeColor = SystemColors.ButtonHighlight;
            Joinbtn_JoinPage.Location = new Point(428, 507);
            Joinbtn_JoinPage.Name = "Joinbtn_JoinPage";
            Joinbtn_JoinPage.Size = new Size(179, 53);
            Joinbtn_JoinPage.TabIndex = 12;
            Joinbtn_JoinPage.Text = "Join The Event";
            Joinbtn_JoinPage.UseVisualStyleBackColor = false;
            Joinbtn_JoinPage.Click += Joinbtn_JoinPage_Click;
            // 
            // JoinEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(Joinbtn_JoinPage);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(JoinEvent_DataGrid_Participant);
            Name = "JoinEvents";
            Text = "JoinEvents";
            Load += JoinEvents_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)JoinEvent_DataGrid_Participant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label1;
        private PictureBox signoutButton;
        private Button UnassignEventBtn_JoinEvents_participant;
        private Button ViewEventsbtn_Join_Events_participant;
        private Button HomeDashboardbtn_Join_Events;
        private Label label2;
        private DataGridView JoinEvent_DataGrid_Participant;
        private Button Joinbtn_JoinPage;
    }
}