namespace Assignment_Sdam
{
    partial class CreateEvent_Organizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEvent_Organizer));
            panel1 = new Panel();
            BAckBtn = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            EventName_txt = new TextBox();
            EventOrganizer_txt = new TextBox();
            EventLocation_txt = new TextBox();
            EventDate_txt = new DateTimePicker();
            CreateEventBtn = new Button();
            EventParticipant_txt = new NumericUpDown();
            EventDeadline_txt = new DateTimePicker();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BAckBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EventParticipant_txt).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(BAckBtn);
            panel1.Location = new Point(-5, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 666);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BAckBtn
            // 
            BAckBtn.BackColor = Color.Transparent;
            BAckBtn.BackgroundImageLayout = ImageLayout.Center;
            BAckBtn.Cursor = Cursors.Hand;
            BAckBtn.Image = (Image)resources.GetObject("BAckBtn.Image");
            BAckBtn.Location = new Point(11, 18);
            BAckBtn.Name = "BAckBtn";
            BAckBtn.Size = new Size(46, 43);
            BAckBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            BAckBtn.TabIndex = 0;
            BAckBtn.TabStop = false;
            BAckBtn.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(329, 21);
            label1.Name = "label1";
            label1.Size = new Size(146, 31);
            label1.TabIndex = 1;
            label1.Text = "Create Event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(329, 94);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 2;
            label2.Text = "Event Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(329, 173);
            label3.Name = "label3";
            label3.Size = new Size(159, 24);
            label3.TabIndex = 3;
            label3.Text = "Event Organizer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(329, 267);
            label4.Name = "label4";
            label4.Size = new Size(148, 24);
            label4.TabIndex = 4;
            label4.Text = "Event Location:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(329, 349);
            label5.Name = "label5";
            label5.Size = new Size(118, 24);
            label5.TabIndex = 5;
            label5.Text = "Event Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(329, 510);
            label6.Name = "label6";
            label6.Size = new Size(220, 24);
            label6.TabIndex = 6;
            label6.Text = "Number of Participants:";
            // 
            // EventName_txt
            // 
            EventName_txt.Location = new Point(329, 121);
            EventName_txt.Multiline = true;
            EventName_txt.Name = "EventName_txt";
            EventName_txt.Size = new Size(343, 34);
            EventName_txt.TabIndex = 7;
            // 
            // EventOrganizer_txt
            // 
            EventOrganizer_txt.Location = new Point(329, 200);
            EventOrganizer_txt.Multiline = true;
            EventOrganizer_txt.Name = "EventOrganizer_txt";
            EventOrganizer_txt.Size = new Size(343, 34);
            EventOrganizer_txt.TabIndex = 8;
            // 
            // EventLocation_txt
            // 
            EventLocation_txt.Location = new Point(329, 294);
            EventLocation_txt.Multiline = true;
            EventLocation_txt.Name = "EventLocation_txt";
            EventLocation_txt.Size = new Size(343, 34);
            EventLocation_txt.TabIndex = 9;
            // 
            // EventDate_txt
            // 
            EventDate_txt.Location = new Point(329, 376);
            EventDate_txt.Name = "EventDate_txt";
            EventDate_txt.Size = new Size(343, 27);
            EventDate_txt.TabIndex = 12;
            // 
            // CreateEventBtn
            // 
            CreateEventBtn.BackColor = SystemColors.ActiveCaptionText;
            CreateEventBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            CreateEventBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            CreateEventBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            CreateEventBtn.ForeColor = SystemColors.ButtonHighlight;
            CreateEventBtn.Location = new Point(385, 592);
            CreateEventBtn.Name = "CreateEventBtn";
            CreateEventBtn.Size = new Size(184, 52);
            CreateEventBtn.TabIndex = 13;
            CreateEventBtn.Text = "Create Event";
            CreateEventBtn.UseVisualStyleBackColor = false;
            CreateEventBtn.Click += CreateEventBtn_Click;
            // 
            // EventParticipant_txt
            // 
            EventParticipant_txt.Location = new Point(329, 537);
            EventParticipant_txt.Name = "EventParticipant_txt";
            EventParticipant_txt.Size = new Size(343, 27);
            EventParticipant_txt.TabIndex = 11;
            EventParticipant_txt.TextAlign = HorizontalAlignment.Center;
            // 
            // EventDeadline_txt
            // 
            EventDeadline_txt.Location = new Point(329, 456);
            EventDeadline_txt.Name = "EventDeadline_txt";
            EventDeadline_txt.Size = new Size(343, 27);
            EventDeadline_txt.TabIndex = 15;
            EventDeadline_txt.Value = new DateTime(2024, 9, 2, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.Location = new Point(329, 429);
            label7.Name = "label7";
            label7.Size = new Size(152, 24);
            label7.TabIndex = 14;
            label7.Text = "Event Deadline:";
            // 
            // CreateEvent_Organizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 656);
            Controls.Add(EventDeadline_txt);
            Controls.Add(label7);
            Controls.Add(CreateEventBtn);
            Controls.Add(EventDate_txt);
            Controls.Add(EventParticipant_txt);
            Controls.Add(EventLocation_txt);
            Controls.Add(EventOrganizer_txt);
            Controls.Add(EventName_txt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CreateEvent_Organizer";
            Text = "Create Event-Organizer";
            Load += CreateEvent_Organizer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BAckBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)EventParticipant_txt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox EventName_txt;
        private TextBox EventOrganizer_txt;
        private TextBox EventLocation_txt;
        private DateTimePicker EventDate_txt;
        private Button CreateEventBtn;
        private PictureBox BAckBtn;
        private NumericUpDown EventParticipant_txt;
        private DateTimePicker EventDeadline_txt;
        private Label label7;
    }
}