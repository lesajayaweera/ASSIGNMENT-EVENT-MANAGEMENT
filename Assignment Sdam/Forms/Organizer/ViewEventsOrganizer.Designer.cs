namespace Assignment_Sdam.Forms.Organizer
{
    partial class ViewEventsOrganizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEventsOrganizer));
            label1 = new Label();
            panel1 = new Panel();
            DeleteEvent_ODashboard = new Button();
            label5 = new Label();
            signoutButton = new PictureBox();
            EditbtnViewEventO = new Button();
            CreateEventsbtn_Veiw_Events = new Button();
            HomeDashboardbtn_Veiw_Events = new Button();
            ViewEventDetailBtn_VeiwEvent = new Button();
            label2 = new Label();
            VeiwEvent_DataGrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VeiwEvent_DataGrid).BeginInit();
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
            panel1.Controls.Add(DeleteEvent_ODashboard);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(EditbtnViewEventO);
            panel1.Controls.Add(CreateEventsbtn_Veiw_Events);
            panel1.Controls.Add(HomeDashboardbtn_Veiw_Events);
            panel1.Location = new Point(3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 595);
            panel1.TabIndex = 8;
            // 
            // DeleteEvent_ODashboard
            // 
            DeleteEvent_ODashboard.BackColor = Color.Black;
            DeleteEvent_ODashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            DeleteEvent_ODashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            DeleteEvent_ODashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            DeleteEvent_ODashboard.ForeColor = SystemColors.ActiveCaption;
            DeleteEvent_ODashboard.Location = new Point(3, 317);
            DeleteEvent_ODashboard.Name = "DeleteEvent_ODashboard";
            DeleteEvent_ODashboard.Size = new Size(293, 58);
            DeleteEvent_ODashboard.TabIndex = 8;
            DeleteEvent_ODashboard.Text = "Delete Events";
            DeleteEvent_ODashboard.UseVisualStyleBackColor = false;
            DeleteEvent_ODashboard.Click += DeleteEvent_ODashboard_Click;
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
            // EditbtnViewEventO
            // 
            EditbtnViewEventO.BackColor = Color.Black;
            EditbtnViewEventO.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            EditbtnViewEventO.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            EditbtnViewEventO.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            EditbtnViewEventO.ForeColor = SystemColors.ActiveCaption;
            EditbtnViewEventO.Location = new Point(3, 250);
            EditbtnViewEventO.Name = "EditbtnViewEventO";
            EditbtnViewEventO.Size = new Size(293, 61);
            EditbtnViewEventO.TabIndex = 2;
            EditbtnViewEventO.Text = "Edit Event";
            EditbtnViewEventO.UseVisualStyleBackColor = false;
            EditbtnViewEventO.Click += EditbtnViewEventO_Click;
            // 
            // CreateEventsbtn_Veiw_Events
            // 
            CreateEventsbtn_Veiw_Events.BackColor = Color.Black;
            CreateEventsbtn_Veiw_Events.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            CreateEventsbtn_Veiw_Events.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            CreateEventsbtn_Veiw_Events.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            CreateEventsbtn_Veiw_Events.ForeColor = SystemColors.ActiveCaption;
            CreateEventsbtn_Veiw_Events.Location = new Point(3, 177);
            CreateEventsbtn_Veiw_Events.Name = "CreateEventsbtn_Veiw_Events";
            CreateEventsbtn_Veiw_Events.Size = new Size(293, 67);
            CreateEventsbtn_Veiw_Events.TabIndex = 1;
            CreateEventsbtn_Veiw_Events.Text = "Create Event";
            CreateEventsbtn_Veiw_Events.UseVisualStyleBackColor = false;
            CreateEventsbtn_Veiw_Events.Click += CreateEventsbtn_Veiw_Events_Click;
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
            // ViewEventDetailBtn_VeiwEvent
            // 
            ViewEventDetailBtn_VeiwEvent.BackColor = SystemColors.ActiveCaptionText;
            ViewEventDetailBtn_VeiwEvent.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            ViewEventDetailBtn_VeiwEvent.ForeColor = SystemColors.ActiveCaption;
            ViewEventDetailBtn_VeiwEvent.Location = new Point(481, 494);
            ViewEventDetailBtn_VeiwEvent.Name = "ViewEventDetailBtn_VeiwEvent";
            ViewEventDetailBtn_VeiwEvent.Size = new Size(186, 66);
            ViewEventDetailBtn_VeiwEvent.TabIndex = 11;
            ViewEventDetailBtn_VeiwEvent.Text = "View Event Details";
            ViewEventDetailBtn_VeiwEvent.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(327, 44);
            label2.Name = "label2";
            label2.Size = new Size(173, 31);
            label2.TabIndex = 10;
            label2.Text = "Veiw All Events";
            // 
            // VeiwEvent_DataGrid
            // 
            VeiwEvent_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            VeiwEvent_DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            VeiwEvent_DataGrid.BackgroundColor = SystemColors.ButtonFace;
            VeiwEvent_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VeiwEvent_DataGrid.Location = new Point(308, 89);
            VeiwEvent_DataGrid.Name = "VeiwEvent_DataGrid";
            VeiwEvent_DataGrid.RowHeadersWidth = 51;
            VeiwEvent_DataGrid.Size = new Size(690, 362);
            VeiwEvent_DataGrid.TabIndex = 9;
            // 
            // ViewEventsOrganizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 588);
            Controls.Add(panel1);
            Controls.Add(ViewEventDetailBtn_VeiwEvent);
            Controls.Add(label2);
            Controls.Add(VeiwEvent_DataGrid);
            Name = "ViewEventsOrganizer";
            Text = "ViewEventsOrganizer";
            Load += ViewEventsOrganizer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)VeiwEvent_DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button DeleteEvent_ODashboard;
        private Label label5;
        private PictureBox signoutButton;
        private Button EditbtnViewEventO;
        private Button CreateEventsbtn_Veiw_Events;
        private Button HomeDashboardbtn_Veiw_Events;
        private Button ViewEventDetailBtn_VeiwEvent;
        private Label label2;
        private DataGridView VeiwEvent_DataGrid;
    }
}