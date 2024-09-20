namespace Assignment_Sdam.Forms.Admin
{
    partial class EventDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventDetails));
            BAckBtn_edit = new PictureBox();
            panel1 = new Panel();
            EventOrganizerLabel = new Label();
            EventName_label = new Label();
            dataGridView_VeiwEventDetail = new DataGridView();
            KickUserBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)BAckBtn_edit).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_VeiwEventDetail).BeginInit();
            SuspendLayout();
            // 
            // BAckBtn_edit
            // 
            BAckBtn_edit.BackColor = Color.Transparent;
            BAckBtn_edit.BackgroundImageLayout = ImageLayout.Center;
            BAckBtn_edit.Cursor = Cursors.Hand;
            BAckBtn_edit.Image = (Image)resources.GetObject("BAckBtn_edit.Image");
            BAckBtn_edit.Location = new Point(13, 15);
            BAckBtn_edit.Name = "BAckBtn_edit";
            BAckBtn_edit.Size = new Size(46, 43);
            BAckBtn_edit.SizeMode = PictureBoxSizeMode.StretchImage;
            BAckBtn_edit.TabIndex = 26;
            BAckBtn_edit.TabStop = false;
            BAckBtn_edit.Click += BAckBtn_edit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(EventOrganizerLabel);
            panel1.Controls.Add(EventName_label);
            panel1.Controls.Add(BAckBtn_edit);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 544);
            panel1.TabIndex = 0;
            // 
            // EventOrganizerLabel
            // 
            EventOrganizerLabel.AutoSize = true;
            EventOrganizerLabel.BackColor = Color.Transparent;
            EventOrganizerLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EventOrganizerLabel.ForeColor = SystemColors.ButtonHighlight;
            EventOrganizerLabel.Location = new Point(29, 198);
            EventOrganizerLabel.Name = "EventOrganizerLabel";
            EventOrganizerLabel.Size = new Size(181, 31);
            EventOrganizerLabel.TabIndex = 28;
            EventOrganizerLabel.Text = "Event Organizer";
            // 
            // EventName_label
            // 
            EventName_label.AutoSize = true;
            EventName_label.BackColor = Color.Transparent;
            EventName_label.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EventName_label.ForeColor = SystemColors.ButtonHighlight;
            EventName_label.Location = new Point(29, 119);
            EventName_label.Name = "EventName_label";
            EventName_label.Size = new Size(140, 31);
            EventName_label.TabIndex = 27;
            EventName_label.Text = "Event Name";
            // 
            // dataGridView_VeiwEventDetail
            // 
            dataGridView_VeiwEventDetail.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_VeiwEventDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_VeiwEventDetail.Location = new Point(332, 75);
            dataGridView_VeiwEventDetail.Name = "dataGridView_VeiwEventDetail";
            dataGridView_VeiwEventDetail.RowHeadersWidth = 51;
            dataGridView_VeiwEventDetail.Size = new Size(584, 369);
            dataGridView_VeiwEventDetail.TabIndex = 1;
            dataGridView_VeiwEventDetail.CellContentClick += dataGridView_VeiwEventDetail_CellContentClick;
            // 
            // KickUserBtn
            // 
            KickUserBtn.BackColor = Color.Red;
            KickUserBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            KickUserBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            KickUserBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            KickUserBtn.ForeColor = SystemColors.ButtonHighlight;
            KickUserBtn.Location = new Point(344, 476);
            KickUserBtn.Name = "KickUserBtn";
            KickUserBtn.Size = new Size(249, 52);
            KickUserBtn.TabIndex = 34;
            KickUserBtn.Text = "Kick User From the Event";
            KickUserBtn.UseVisualStyleBackColor = false;
            KickUserBtn.Click += KickUserBtn_Click;
            // 
            // EventDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 540);
            Controls.Add(KickUserBtn);
            Controls.Add(dataGridView_VeiwEventDetail);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EventDetails";
            Text = "Admin- Event  Details";
            Load += EventDetails_Load;
            ((System.ComponentModel.ISupportInitialize)BAckBtn_edit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_VeiwEventDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BAckBtn_edit;
        private Panel panel1;
        private Label EventName_label;
        private DataGridView dataGridView_VeiwEventDetail;
        private Label EventOrganizerLabel;
        private Button KickUserBtn;
    }
}