namespace Assignment_Sdam.Forms.Organizer
{
    partial class ViewEventDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEventDetails));
            EventOrganizerLabel_Org = new Label();
            EventName_label_Org = new Label();
            BAckBtn_ViewEventsDetails = new PictureBox();
            dataGridView_VeiwEventDetail_Org = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)BAckBtn_ViewEventsDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_VeiwEventDetail_Org).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EventOrganizerLabel_Org
            // 
            EventOrganizerLabel_Org.AutoSize = true;
            EventOrganizerLabel_Org.BackColor = Color.Transparent;
            EventOrganizerLabel_Org.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EventOrganizerLabel_Org.ForeColor = SystemColors.ButtonHighlight;
            EventOrganizerLabel_Org.Location = new Point(29, 198);
            EventOrganizerLabel_Org.Name = "EventOrganizerLabel_Org";
            EventOrganizerLabel_Org.Size = new Size(181, 31);
            EventOrganizerLabel_Org.TabIndex = 28;
            EventOrganizerLabel_Org.Text = "Event Organizer";
            // 
            // EventName_label_Org
            // 
            EventName_label_Org.AutoSize = true;
            EventName_label_Org.BackColor = Color.Transparent;
            EventName_label_Org.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EventName_label_Org.ForeColor = SystemColors.ButtonHighlight;
            EventName_label_Org.Location = new Point(29, 119);
            EventName_label_Org.Name = "EventName_label_Org";
            EventName_label_Org.Size = new Size(140, 31);
            EventName_label_Org.TabIndex = 27;
            EventName_label_Org.Text = "Event Name";
            // 
            // BAckBtn_ViewEventsDetails
            // 
            BAckBtn_ViewEventsDetails.BackColor = Color.Transparent;
            BAckBtn_ViewEventsDetails.BackgroundImageLayout = ImageLayout.Center;
            BAckBtn_ViewEventsDetails.Cursor = Cursors.Hand;
            BAckBtn_ViewEventsDetails.Image = (Image)resources.GetObject("BAckBtn_ViewEventsDetails.Image");
            BAckBtn_ViewEventsDetails.Location = new Point(13, 15);
            BAckBtn_ViewEventsDetails.Name = "BAckBtn_ViewEventsDetails";
            BAckBtn_ViewEventsDetails.Size = new Size(46, 43);
            BAckBtn_ViewEventsDetails.SizeMode = PictureBoxSizeMode.StretchImage;
            BAckBtn_ViewEventsDetails.TabIndex = 26;
            BAckBtn_ViewEventsDetails.TabStop = false;
            // 
            // dataGridView_VeiwEventDetail_Org
            // 
            dataGridView_VeiwEventDetail_Org.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_VeiwEventDetail_Org.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_VeiwEventDetail_Org.Location = new Point(339, 76);
            dataGridView_VeiwEventDetail_Org.Name = "dataGridView_VeiwEventDetail_Org";
            dataGridView_VeiwEventDetail_Org.RowHeadersWidth = 51;
            dataGridView_VeiwEventDetail_Org.Size = new Size(584, 369);
            dataGridView_VeiwEventDetail_Org.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(EventOrganizerLabel_Org);
            panel1.Controls.Add(EventName_label_Org);
            panel1.Controls.Add(BAckBtn_ViewEventsDetails);
            panel1.Location = new Point(6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 544);
            panel1.TabIndex = 2;
            // 
            // ViewEventDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 540);
            Controls.Add(dataGridView_VeiwEventDetail_Org);
            Controls.Add(panel1);
            Name = "ViewEventDetails";
            Text = "ViewEventDetails";
            ((System.ComponentModel.ISupportInitialize)BAckBtn_ViewEventsDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_VeiwEventDetail_Org).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label EventOrganizerLabel_Org;
        private Label EventName_label_Org;
        private PictureBox BAckBtn_ViewEventsDetails;
        private DataGridView dataGridView_VeiwEventDetail_Org;
        private Panel panel1;
    }
}