namespace Assignment_Sdam.Forms.Participant
{
    partial class VeiwEvents_Participants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeiwEvents_Participants));
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            signoutButton = new PictureBox();
            UnassignEventBtn_ViewEvents_participant = new Button();
            JoinEventsbtn_Veiw_Events_participant = new Button();
            HomeDashboardbtn_Veiw_Events = new Button();
            label2 = new Label();
            VeiwEvent_DataGrid_Participant = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VeiwEvent_DataGrid_Participant).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 47);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 1;
            label1.Text = "EventX -  Veiw Events\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(UnassignEventBtn_ViewEvents_participant);
            panel1.Controls.Add(JoinEventsbtn_Veiw_Events_participant);
            panel1.Controls.Add(HomeDashboardbtn_Veiw_Events);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 595);
            panel1.TabIndex = 2;
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
            // signoutButton
            // 
            signoutButton.Image = (Image)resources.GetObject("signoutButton.Image");
            signoutButton.Location = new Point(12, 526);
            signoutButton.Name = "signoutButton";
            signoutButton.Size = new Size(50, 50);
            signoutButton.SizeMode = PictureBoxSizeMode.StretchImage;
            signoutButton.TabIndex = 5;
            signoutButton.TabStop = false;
            // 
            // UnassignEventBtn_ViewEvents_participant
            // 
            UnassignEventBtn_ViewEvents_participant.BackColor = Color.Black;
            UnassignEventBtn_ViewEvents_participant.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            UnassignEventBtn_ViewEvents_participant.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            UnassignEventBtn_ViewEvents_participant.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            UnassignEventBtn_ViewEvents_participant.ForeColor = SystemColors.ActiveCaption;
            UnassignEventBtn_ViewEvents_participant.Location = new Point(3, 250);
            UnassignEventBtn_ViewEvents_participant.Name = "UnassignEventBtn_ViewEvents_participant";
            UnassignEventBtn_ViewEvents_participant.Size = new Size(293, 61);
            UnassignEventBtn_ViewEvents_participant.TabIndex = 2;
            UnassignEventBtn_ViewEvents_participant.Text = "Unassign  Event";
            UnassignEventBtn_ViewEvents_participant.UseVisualStyleBackColor = false;
            UnassignEventBtn_ViewEvents_participant.Click += UnassignEventBtn_ViewEvents_participant_Click;
            // 
            // JoinEventsbtn_Veiw_Events_participant
            // 
            JoinEventsbtn_Veiw_Events_participant.BackColor = Color.Black;
            JoinEventsbtn_Veiw_Events_participant.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            JoinEventsbtn_Veiw_Events_participant.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            JoinEventsbtn_Veiw_Events_participant.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            JoinEventsbtn_Veiw_Events_participant.ForeColor = SystemColors.ActiveCaption;
            JoinEventsbtn_Veiw_Events_participant.Location = new Point(3, 177);
            JoinEventsbtn_Veiw_Events_participant.Name = "JoinEventsbtn_Veiw_Events_participant";
            JoinEventsbtn_Veiw_Events_participant.Size = new Size(293, 67);
            JoinEventsbtn_Veiw_Events_participant.TabIndex = 1;
            JoinEventsbtn_Veiw_Events_participant.Text = "Join Event";
            JoinEventsbtn_Veiw_Events_participant.UseVisualStyleBackColor = false;
            JoinEventsbtn_Veiw_Events_participant.Click += JoinEventsbtn_Veiw_Events_participant_Click;
            // 
            // HomeDashboardbtn_Veiw_Events
            // 
            HomeDashboardbtn_Veiw_Events.BackColor = Color.Black;
            HomeDashboardbtn_Veiw_Events.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            HomeDashboardbtn_Veiw_Events.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            HomeDashboardbtn_Veiw_Events.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            HomeDashboardbtn_Veiw_Events.ForeColor = SystemColors.ActiveCaption;
            HomeDashboardbtn_Veiw_Events.Location = new Point(3, 108);
            HomeDashboardbtn_Veiw_Events.Name = "HomeDashboardbtn_Veiw_Events";
            HomeDashboardbtn_Veiw_Events.Size = new Size(293, 63);
            HomeDashboardbtn_Veiw_Events.TabIndex = 0;
            HomeDashboardbtn_Veiw_Events.Text = "Home";
            HomeDashboardbtn_Veiw_Events.UseVisualStyleBackColor = false;
            HomeDashboardbtn_Veiw_Events.Click += HomeDashboardbtn_Veiw_Events_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(324, 48);
            label2.Name = "label2";
            label2.Size = new Size(173, 31);
            label2.TabIndex = 8;
            label2.Text = "Veiw All Events";
            // 
            // VeiwEvent_DataGrid_Participant
            // 
            VeiwEvent_DataGrid_Participant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            VeiwEvent_DataGrid_Participant.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            VeiwEvent_DataGrid_Participant.BackgroundColor = SystemColors.ButtonFace;
            VeiwEvent_DataGrid_Participant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VeiwEvent_DataGrid_Participant.Location = new Point(305, 93);
            VeiwEvent_DataGrid_Participant.Name = "VeiwEvent_DataGrid_Participant";
            VeiwEvent_DataGrid_Participant.RowHeadersWidth = 51;
            VeiwEvent_DataGrid_Participant.Size = new Size(690, 362);
            VeiwEvent_DataGrid_Participant.TabIndex = 7;
            // 
            // VeiwEvents_Participants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(label2);
            Controls.Add(VeiwEvent_DataGrid_Participant);
            Controls.Add(panel1);
            Name = "VeiwEvents_Participants";
            Text = "VeiwEvents_Participants";
            Load += VeiwEvents_Participants_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)VeiwEvent_DataGrid_Participant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button DeleteEvent_ODashboard;
        private Label label5;
        private PictureBox signoutButton;
        private Button UnassignEventBtn_ViewEvents_participant;
        private Button JoinEventsbtn_Veiw_Events_participant;
        private Button HomeDashboardbtn_Veiw_Events;
        private Label label2;
        private DataGridView VeiwEvent_DataGrid_Participant;
    }
}