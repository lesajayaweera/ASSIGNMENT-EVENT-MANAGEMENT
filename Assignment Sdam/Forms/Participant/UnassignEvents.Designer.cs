namespace Assignment_Sdam.Forms.Participant
{
    partial class UnassignEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnassignEvents));
            label1 = new Label();
            JoinEventBtn_UnassignEvents_participant = new Button();
            VeiwEventBtn_UnassignEvents_participant = new Button();
            HomwEventBtn_UnassignEvents_participant = new Button();
            panel1 = new Panel();
            label5 = new Label();
            signoutButton = new PictureBox();
            label2 = new Label();
            UnassignEvent_DataGrid_Participant = new DataGridView();
            Unassignbtn_UnassignPage = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UnassignEvent_DataGrid_Participant).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 47);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 1;
            label1.Text = "EventX -  Unassign Events\r\n";
            // 
            // JoinEventBtn_UnassignEvents_participant
            // 
            JoinEventBtn_UnassignEvents_participant.BackColor = Color.Black;
            JoinEventBtn_UnassignEvents_participant.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            JoinEventBtn_UnassignEvents_participant.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            JoinEventBtn_UnassignEvents_participant.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            JoinEventBtn_UnassignEvents_participant.ForeColor = SystemColors.ActiveCaption;
            JoinEventBtn_UnassignEvents_participant.Location = new Point(3, 250);
            JoinEventBtn_UnassignEvents_participant.Name = "JoinEventBtn_UnassignEvents_participant";
            JoinEventBtn_UnassignEvents_participant.Size = new Size(293, 61);
            JoinEventBtn_UnassignEvents_participant.TabIndex = 2;
            JoinEventBtn_UnassignEvents_participant.Text = "Join  Event";
            JoinEventBtn_UnassignEvents_participant.UseVisualStyleBackColor = false;
            JoinEventBtn_UnassignEvents_participant.Click += JoinEventBtn_UnassignEvents_participant_Click;
            // 
            // VeiwEventBtn_UnassignEvents_participant
            // 
            VeiwEventBtn_UnassignEvents_participant.BackColor = Color.Black;
            VeiwEventBtn_UnassignEvents_participant.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            VeiwEventBtn_UnassignEvents_participant.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            VeiwEventBtn_UnassignEvents_participant.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            VeiwEventBtn_UnassignEvents_participant.ForeColor = SystemColors.ActiveCaption;
            VeiwEventBtn_UnassignEvents_participant.Location = new Point(3, 177);
            VeiwEventBtn_UnassignEvents_participant.Name = "VeiwEventBtn_UnassignEvents_participant";
            VeiwEventBtn_UnassignEvents_participant.Size = new Size(293, 67);
            VeiwEventBtn_UnassignEvents_participant.TabIndex = 1;
            VeiwEventBtn_UnassignEvents_participant.Text = "View Event";
            VeiwEventBtn_UnassignEvents_participant.UseVisualStyleBackColor = false;
            VeiwEventBtn_UnassignEvents_participant.Click += VeiwEventBtn_UnassignEvents_participant_Click;
            // 
            // HomwEventBtn_UnassignEvents_participant
            // 
            HomwEventBtn_UnassignEvents_participant.BackColor = Color.Black;
            HomwEventBtn_UnassignEvents_participant.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            HomwEventBtn_UnassignEvents_participant.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            HomwEventBtn_UnassignEvents_participant.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            HomwEventBtn_UnassignEvents_participant.ForeColor = SystemColors.ActiveCaption;
            HomwEventBtn_UnassignEvents_participant.Location = new Point(3, 108);
            HomwEventBtn_UnassignEvents_participant.Name = "HomwEventBtn_UnassignEvents_participant";
            HomwEventBtn_UnassignEvents_participant.Size = new Size(293, 63);
            HomwEventBtn_UnassignEvents_participant.TabIndex = 0;
            HomwEventBtn_UnassignEvents_participant.Text = "Home";
            HomwEventBtn_UnassignEvents_participant.UseVisualStyleBackColor = false;
            HomwEventBtn_UnassignEvents_participant.Click += HomwEventBtn_UnassignEvents_participant_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(JoinEventBtn_UnassignEvents_participant);
            panel1.Controls.Add(VeiwEventBtn_UnassignEvents_participant);
            panel1.Controls.Add(HomwEventBtn_UnassignEvents_participant);
            panel1.Location = new Point(3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 595);
            panel1.TabIndex = 12;
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
            signoutButton.Click += signoutButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(326, 44);
            label2.Name = "label2";
            label2.Size = new Size(148, 31);
            label2.TabIndex = 14;
            label2.Text = "Select Events";
            // 
            // UnassignEvent_DataGrid_Participant
            // 
            UnassignEvent_DataGrid_Participant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            UnassignEvent_DataGrid_Participant.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            UnassignEvent_DataGrid_Participant.BackgroundColor = SystemColors.ButtonFace;
            UnassignEvent_DataGrid_Participant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UnassignEvent_DataGrid_Participant.Location = new Point(307, 89);
            UnassignEvent_DataGrid_Participant.Name = "UnassignEvent_DataGrid_Participant";
            UnassignEvent_DataGrid_Participant.RowHeadersWidth = 51;
            UnassignEvent_DataGrid_Participant.Size = new Size(690, 362);
            UnassignEvent_DataGrid_Participant.TabIndex = 13;
            UnassignEvent_DataGrid_Participant.CellContentClick += JoinEvent_DataGrid_Participant_CellContentClick;
            // 
            // Unassignbtn_UnassignPage
            // 
            Unassignbtn_UnassignPage.BackColor = SystemColors.ActiveCaptionText;
            Unassignbtn_UnassignPage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            Unassignbtn_UnassignPage.ForeColor = SystemColors.ButtonHighlight;
            Unassignbtn_UnassignPage.Location = new Point(397, 507);
            Unassignbtn_UnassignPage.Name = "Unassignbtn_UnassignPage";
            Unassignbtn_UnassignPage.Size = new Size(179, 53);
            Unassignbtn_UnassignPage.TabIndex = 15;
            Unassignbtn_UnassignPage.Text = "Unassign The Event";
            Unassignbtn_UnassignPage.UseVisualStyleBackColor = false;
            Unassignbtn_UnassignPage.Click += Unassignbtn_UnassignPage_Click;
            // 
            // UnassignEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(Unassignbtn_UnassignPage);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(UnassignEvent_DataGrid_Participant);
            Name = "UnassignEvents";
            Text = "UnassignEvents";
            Load += UnassignEvents_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)UnassignEvent_DataGrid_Participant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button JoinEventBtn_UnassignEvents_participant;
        private Button VeiwEventBtn_UnassignEvents_participant;
        private Button HomwEventBtn_UnassignEvents_participant;
        private Panel panel1;
        private Label label5;
        private PictureBox signoutButton;
        private Label label2;
        private DataGridView UnassignEvent_DataGrid_Participant;
        private Button Unassignbtn_UnassignPage;
    }
}