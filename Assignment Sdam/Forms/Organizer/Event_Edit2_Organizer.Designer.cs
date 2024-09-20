namespace Assignment_Sdam.Forms
{
    partial class Event_Edit2_Organizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event_Edit2_Organizer));
            BAckBtn_edit = new PictureBox();
            panel1 = new Panel();
            Edit_EventLocation_txt = new TextBox();
            Edit_EventOrganizer_txt = new TextBox();
            Edit_EventName_txt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Edit_EventDeadline_txt = new DateTimePicker();
            label7 = new Label();
            EditEventBtn = new Button();
            Edit_EventParticipant_txt = new NumericUpDown();
            label6 = new Label();
            dateTimePicker_EventTime_EdiftEvents = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)BAckBtn_edit).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Edit_EventParticipant_txt).BeginInit();
            SuspendLayout();
            // 
            // BAckBtn_edit
            // 
            BAckBtn_edit.BackColor = Color.Transparent;
            BAckBtn_edit.BackgroundImageLayout = ImageLayout.Center;
            BAckBtn_edit.Cursor = Cursors.Hand;
            BAckBtn_edit.Image = (Image)resources.GetObject("BAckBtn_edit.Image");
            BAckBtn_edit.Location = new Point(3, 18);
            BAckBtn_edit.Name = "BAckBtn_edit";
            BAckBtn_edit.Size = new Size(46, 43);
            BAckBtn_edit.SizeMode = PictureBoxSizeMode.StretchImage;
            BAckBtn_edit.TabIndex = 0;
            BAckBtn_edit.TabStop = false;
            BAckBtn_edit.Click += BAckBtn_edit_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(BAckBtn_edit);
            panel1.Location = new Point(0, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 674);
            panel1.TabIndex = 1;
            // 
            // Edit_EventLocation_txt
            // 
            Edit_EventLocation_txt.Location = new Point(334, 284);
            Edit_EventLocation_txt.Multiline = true;
            Edit_EventLocation_txt.Name = "Edit_EventLocation_txt";
            Edit_EventLocation_txt.Size = new Size(343, 34);
            Edit_EventLocation_txt.TabIndex = 20;
            // 
            // Edit_EventOrganizer_txt
            // 
            Edit_EventOrganizer_txt.Location = new Point(334, 202);
            Edit_EventOrganizer_txt.Multiline = true;
            Edit_EventOrganizer_txt.Name = "Edit_EventOrganizer_txt";
            Edit_EventOrganizer_txt.Size = new Size(343, 34);
            Edit_EventOrganizer_txt.TabIndex = 19;
            // 
            // Edit_EventName_txt
            // 
            Edit_EventName_txt.Location = new Point(334, 123);
            Edit_EventName_txt.Multiline = true;
            Edit_EventName_txt.Name = "Edit_EventName_txt";
            Edit_EventName_txt.Size = new Size(343, 34);
            Edit_EventName_txt.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(334, 335);
            label5.Name = "label5";
            label5.Size = new Size(118, 24);
            label5.TabIndex = 17;
            label5.Text = "Event Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(334, 257);
            label4.Name = "label4";
            label4.Size = new Size(148, 24);
            label4.TabIndex = 16;
            label4.Text = "Event Location:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(334, 175);
            label3.Name = "label3";
            label3.Size = new Size(159, 24);
            label3.TabIndex = 15;
            label3.Text = "Event Organizer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(334, 96);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 14;
            label2.Text = "Event Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(334, 23);
            label1.Name = "label1";
            label1.Size = new Size(117, 31);
            label1.TabIndex = 13;
            label1.Text = "Edit Event";
            // 
            // Edit_EventDeadline_txt
            // 
            Edit_EventDeadline_txt.Location = new Point(334, 431);
            Edit_EventDeadline_txt.Name = "Edit_EventDeadline_txt";
            Edit_EventDeadline_txt.Size = new Size(250, 27);
            Edit_EventDeadline_txt.TabIndex = 26;
            Edit_EventDeadline_txt.Value = new DateTime(2024, 9, 2, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.Location = new Point(334, 404);
            label7.Name = "label7";
            label7.Size = new Size(152, 24);
            label7.TabIndex = 25;
            label7.Text = "Event Deadline:";
            // 
            // EditEventBtn
            // 
            EditEventBtn.BackColor = SystemColors.ActiveCaptionText;
            EditEventBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            EditEventBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            EditEventBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            EditEventBtn.ForeColor = SystemColors.ButtonHighlight;
            EditEventBtn.Location = new Point(378, 574);
            EditEventBtn.Name = "EditEventBtn";
            EditEventBtn.Size = new Size(159, 52);
            EditEventBtn.TabIndex = 24;
            EditEventBtn.Text = "Edit Event";
            EditEventBtn.UseVisualStyleBackColor = false;
            EditEventBtn.Click += EditEventBtn_Click;
            // 
            // Edit_EventParticipant_txt
            // 
            Edit_EventParticipant_txt.Location = new Point(334, 512);
            Edit_EventParticipant_txt.Name = "Edit_EventParticipant_txt";
            Edit_EventParticipant_txt.Size = new Size(343, 27);
            Edit_EventParticipant_txt.TabIndex = 23;
            Edit_EventParticipant_txt.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(334, 485);
            label6.Name = "label6";
            label6.Size = new Size(220, 24);
            label6.TabIndex = 22;
            label6.Text = "Number of Participants:";
            // 
            // dateTimePicker_EventTime_EdiftEvents
            // 
            dateTimePicker_EventTime_EdiftEvents.Location = new Point(334, 362);
            dateTimePicker_EventTime_EdiftEvents.Name = "dateTimePicker_EventTime_EdiftEvents";
            dateTimePicker_EventTime_EdiftEvents.Size = new Size(250, 27);
            dateTimePicker_EventTime_EdiftEvents.TabIndex = 28;
            // 
            // Event_Edit2_Organizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 656);
            Controls.Add(dateTimePicker_EventTime_EdiftEvents);
            Controls.Add(Edit_EventDeadline_txt);
            Controls.Add(label7);
            Controls.Add(EditEventBtn);
            Controls.Add(Edit_EventParticipant_txt);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(Edit_EventLocation_txt);
            Controls.Add(label1);
            Controls.Add(Edit_EventOrganizer_txt);
            Controls.Add(label2);
            Controls.Add(Edit_EventName_txt);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Event_Edit2_Organizer";
            Text = "Edit Event Details";
            Load += Event_Edit2_Organizer_Load;
            ((System.ComponentModel.ISupportInitialize)BAckBtn_edit).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Edit_EventParticipant_txt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BAckBtn_edit;
        private Panel panel1;
        private TextBox Edit_EventLocation_txt;
        private TextBox Edit_EventOrganizer_txt;
        private TextBox Edit_EventName_txt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker Edit_EventDeadline_txt;
        private Label label7;
        private Button EditEventBtn;
        private NumericUpDown Edit_EventParticipant_txt;
        private Label label6;
        private Button DeleteBtn_Edit;
        private DateTimePicker dateTimePicker_EventTime_EdiftEvents;
    }
}