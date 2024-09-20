namespace Assignment_Sdam.Forms
{
    partial class DeleteEvent_Organizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEvent_Organizer));
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            signoutButton = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            HomeButton_DeleteEvent = new Button();
            dataGrid_DeleteEvent = new DataGridView();
            DeleteBtn_DeleteEvent = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_DeleteEvent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(HomeButton_DeleteEvent);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 595);
            panel1.TabIndex = 1;
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
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(233, 20);
            label1.TabIndex = 1;
            label1.Text = "EventX -  Delete Event DashBoard";
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
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = SystemColors.ActiveCaption;
            button4.Location = new Point(3, 339);
            button4.Name = "button4";
            button4.Size = new Size(293, 58);
            button4.TabIndex = 1;
            button4.Text = "Veiw Events";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Location = new Point(3, 272);
            button3.Name = "button3";
            button3.Size = new Size(293, 61);
            button3.TabIndex = 2;
            button3.Text = "Edit Event";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(3, 199);
            button2.Name = "button2";
            button2.Size = new Size(293, 67);
            button2.TabIndex = 1;
            button2.Text = "Create Event";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // HomeButton_DeleteEvent
            // 
            HomeButton_DeleteEvent.BackColor = Color.Black;
            HomeButton_DeleteEvent.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            HomeButton_DeleteEvent.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            HomeButton_DeleteEvent.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            HomeButton_DeleteEvent.ForeColor = SystemColors.ActiveCaption;
            HomeButton_DeleteEvent.Location = new Point(3, 130);
            HomeButton_DeleteEvent.Name = "HomeButton_DeleteEvent";
            HomeButton_DeleteEvent.Size = new Size(293, 63);
            HomeButton_DeleteEvent.TabIndex = 0;
            HomeButton_DeleteEvent.Text = "Home";
            HomeButton_DeleteEvent.UseVisualStyleBackColor = false;
            HomeButton_DeleteEvent.Click += HomeButton_DeleteEvent_Click;
            // 
            // dataGrid_DeleteEvent
            // 
            dataGrid_DeleteEvent.BackgroundColor = SystemColors.ButtonFace;
            dataGrid_DeleteEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_DeleteEvent.Location = new Point(305, 102);
            dataGrid_DeleteEvent.Name = "dataGrid_DeleteEvent";
            dataGrid_DeleteEvent.RowHeadersWidth = 51;
            dataGrid_DeleteEvent.Size = new Size(690, 383);
            dataGrid_DeleteEvent.TabIndex = 2;
            dataGrid_DeleteEvent.CellContentClick += dataGrid_DeleteEvent_CellContentClick;
            // 
            // DeleteBtn_DeleteEvent
            // 
            DeleteBtn_DeleteEvent.BackColor = SystemColors.ActiveCaptionText;
            DeleteBtn_DeleteEvent.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            DeleteBtn_DeleteEvent.ForeColor = SystemColors.ActiveCaption;
            DeleteBtn_DeleteEvent.Location = new Point(448, 510);
            DeleteBtn_DeleteEvent.Name = "DeleteBtn_DeleteEvent";
            DeleteBtn_DeleteEvent.Size = new Size(186, 66);
            DeleteBtn_DeleteEvent.TabIndex = 3;
            DeleteBtn_DeleteEvent.Text = "Delete Event";
            DeleteBtn_DeleteEvent.UseVisualStyleBackColor = false;
            DeleteBtn_DeleteEvent.Click += DeleteBtn_DeleteEvent_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(320, 36);
            label2.Name = "label2";
            label2.Size = new Size(182, 31);
            label2.TabIndex = 4;
            label2.Text = "Select The Event";
            // 
            // DeleteEvent_Organizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(label2);
            Controls.Add(DeleteBtn_DeleteEvent);
            Controls.Add(dataGrid_DeleteEvent);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteEvent_Organizer";
            Text = "Delete Event Organizer";
            Load += DeleteEvent_Organizer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_DeleteEvent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label1;
        private PictureBox signoutButton;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button HomeButton_DeleteEvent;
        private DataGridView dataGrid_DeleteEvent;
        private Button DeleteBtn_DeleteEvent;
        private Label label2;
    }
}