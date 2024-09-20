namespace Assignment_Sdam.Forms
{
    partial class EditEvents_Organizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEvents_Organizer));
            panel1 = new Panel();
            DeleteEvent_ODashboard = new Button();
            label5 = new Label();
            label1 = new Label();
            signoutButton = new PictureBox();
            EventEdit_VeiwEventBtn = new Button();
            EventEdit_CreateEventBtn = new Button();
            EventEdit_DashBoardBtn = new Button();
            EditEventBtn_EditEvent = new Button();
            label2 = new Label();
            EditEvent_datagrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditEvent_datagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(DeleteEvent_ODashboard);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(EventEdit_VeiwEventBtn);
            panel1.Controls.Add(EventEdit_CreateEventBtn);
            panel1.Controls.Add(EventEdit_DashBoardBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 595);
            panel1.TabIndex = 1;
            // 
            // DeleteEvent_ODashboard
            // 
            DeleteEvent_ODashboard.BackColor = Color.Black;
            DeleteEvent_ODashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            DeleteEvent_ODashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            DeleteEvent_ODashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            DeleteEvent_ODashboard.ForeColor = SystemColors.ActiveCaption;
            DeleteEvent_ODashboard.Location = new Point(3, 327);
            DeleteEvent_ODashboard.Name = "DeleteEvent_ODashboard";
            DeleteEvent_ODashboard.Size = new Size(293, 66);
            DeleteEvent_ODashboard.TabIndex = 8;
            DeleteEvent_ODashboard.Text = "Delete Events";
            DeleteEvent_ODashboard.UseVisualStyleBackColor = false;
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
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 1;
            label1.Text = "EventX -  Edit Event\r\n";
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
            // EventEdit_VeiwEventBtn
            // 
            EventEdit_VeiwEventBtn.BackColor = Color.Black;
            EventEdit_VeiwEventBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            EventEdit_VeiwEventBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            EventEdit_VeiwEventBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EventEdit_VeiwEventBtn.ForeColor = SystemColors.ActiveCaption;
            EventEdit_VeiwEventBtn.Location = new Point(3, 250);
            EventEdit_VeiwEventBtn.Name = "EventEdit_VeiwEventBtn";
            EventEdit_VeiwEventBtn.Size = new Size(293, 71);
            EventEdit_VeiwEventBtn.TabIndex = 1;
            EventEdit_VeiwEventBtn.Text = "Veiw Events";
            EventEdit_VeiwEventBtn.UseVisualStyleBackColor = false;
            EventEdit_VeiwEventBtn.Click += EventEdit_VeiwEventBtn_Click;
            // 
            // EventEdit_CreateEventBtn
            // 
            EventEdit_CreateEventBtn.BackColor = Color.Black;
            EventEdit_CreateEventBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            EventEdit_CreateEventBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            EventEdit_CreateEventBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EventEdit_CreateEventBtn.ForeColor = SystemColors.ActiveCaption;
            EventEdit_CreateEventBtn.Location = new Point(3, 177);
            EventEdit_CreateEventBtn.Name = "EventEdit_CreateEventBtn";
            EventEdit_CreateEventBtn.Size = new Size(293, 67);
            EventEdit_CreateEventBtn.TabIndex = 1;
            EventEdit_CreateEventBtn.Text = "Create Event";
            EventEdit_CreateEventBtn.UseVisualStyleBackColor = false;
            EventEdit_CreateEventBtn.Click += EventEdit_CreateEventBtn_Click;
            // 
            // EventEdit_DashBoardBtn
            // 
            EventEdit_DashBoardBtn.BackColor = Color.Black;
            EventEdit_DashBoardBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            EventEdit_DashBoardBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            EventEdit_DashBoardBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EventEdit_DashBoardBtn.ForeColor = SystemColors.ActiveCaption;
            EventEdit_DashBoardBtn.Location = new Point(3, 108);
            EventEdit_DashBoardBtn.Name = "EventEdit_DashBoardBtn";
            EventEdit_DashBoardBtn.Size = new Size(293, 63);
            EventEdit_DashBoardBtn.TabIndex = 0;
            EventEdit_DashBoardBtn.Text = "Home";
            EventEdit_DashBoardBtn.UseVisualStyleBackColor = false;
            EventEdit_DashBoardBtn.Click += EventEdit_DashBoardBtn_Click;
            // 
            // EditEventBtn_EditEvent
            // 
            EditEventBtn_EditEvent.BackColor = SystemColors.ActiveCaptionText;
            EditEventBtn_EditEvent.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            EditEventBtn_EditEvent.ForeColor = SystemColors.ActiveCaption;
            EditEventBtn_EditEvent.Location = new Point(547, 510);
            EditEventBtn_EditEvent.Name = "EditEventBtn_EditEvent";
            EditEventBtn_EditEvent.Size = new Size(186, 66);
            EditEventBtn_EditEvent.TabIndex = 3;
            EditEventBtn_EditEvent.Text = "Edit Event";
            EditEventBtn_EditEvent.UseVisualStyleBackColor = false;
            EditEventBtn_EditEvent.Click += EditEventBtn_EditEvent_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(319, 53);
            label2.Name = "label2";
            label2.Size = new Size(182, 31);
            label2.TabIndex = 5;
            label2.Text = "Select The Event";
            // 
            // EditEvent_datagrid
            // 
            EditEvent_datagrid.BackgroundColor = SystemColors.ButtonFace;
            EditEvent_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EditEvent_datagrid.Location = new Point(319, 108);
            EditEvent_datagrid.Name = "EditEvent_datagrid";
            EditEvent_datagrid.RowHeadersWidth = 51;
            EditEvent_datagrid.Size = new Size(669, 360);
            EditEvent_datagrid.TabIndex = 6;
            EditEvent_datagrid.CellContentClick += EditEvent_datagrid_CellContentClick;
            // 
            // EditEvents_Organizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(EditEvent_datagrid);
            Controls.Add(label2);
            Controls.Add(EditEventBtn_EditEvent);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditEvents_Organizer";
            Text = "Edit Event -Organizer";
            Load += EditEvents_Organizer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditEvent_datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button DeleteEvent_ODashboard;
        private Label label5;
        private Label label1;
        private PictureBox signoutButton;
        private Button EventEdit_VeiwEventBtn;
        private Button EventEdit_CreateEventBtn;
        private Button EventEdit_DashBoardBtn;
        private Button EditEventBtn_EditEvent;
        private Label label2;
        private DataGridView EditEvent_datagrid;
    }
}