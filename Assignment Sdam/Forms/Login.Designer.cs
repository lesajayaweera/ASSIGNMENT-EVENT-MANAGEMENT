namespace Assignment_Sdam
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            RegisterButton = new Button();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Exit = new Label();
            label2 = new Label();
            UserNameLabel = new Label();
            UsernameText_login = new TextBox();
            PasswordText_login = new TextBox();
            PasswordLabel = new Label();
            ShowPasswordCheck_login = new CheckBox();
            LoginButton = new Button();
            Admin_RadioBtn = new RadioButton();
            Organizer_RadioBtn = new RadioButton();
            Participant_RadioBtn = new RadioButton();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 420);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Black;
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            RegisterButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RegisterButton.ForeColor = SystemColors.ControlLightLight;
            RegisterButton.Location = new Point(56, 346);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(198, 46);
            RegisterButton.TabIndex = 9;
            RegisterButton.Text = "Create an Account";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(65, 314);
            label3.Name = "label3";
            label3.Size = new Size(176, 20);
            label3.TabIndex = 2;
            label3.Text = "Dont Have An Account ?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(27, 187);
            label1.Name = "label1";
            label1.Size = new Size(253, 28);
            label1.TabIndex = 1;
            label1.Text = "Event Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.Transparent;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = SystemColors.ActiveCaptionText;
            Exit.Location = new Point(591, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(22, 24);
            Exit.TabIndex = 1;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(317, 29);
            label2.Name = "label2";
            label2.Size = new Size(159, 31);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.BackColor = Color.Transparent;
            UserNameLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(317, 79);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(113, 24);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "Username: ";
            // 
            // UsernameText_login
            // 
            UsernameText_login.BorderStyle = BorderStyle.FixedSingle;
            UsernameText_login.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameText_login.Location = new Point(317, 111);
            UsernameText_login.Multiline = true;
            UsernameText_login.Name = "UsernameText_login";
            UsernameText_login.Size = new Size(281, 34);
            UsernameText_login.TabIndex = 4;
            // 
            // PasswordText_login
            // 
            PasswordText_login.BorderStyle = BorderStyle.FixedSingle;
            PasswordText_login.CausesValidation = false;
            PasswordText_login.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordText_login.Location = new Point(317, 192);
            PasswordText_login.Multiline = true;
            PasswordText_login.Name = "PasswordText_login";
            PasswordText_login.PasswordChar = '*';
            PasswordText_login.Size = new Size(281, 34);
            PasswordText_login.TabIndex = 6;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(317, 160);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(107, 24);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password: ";
            // 
            // ShowPasswordCheck_login
            // 
            ShowPasswordCheck_login.AutoSize = true;
            ShowPasswordCheck_login.Cursor = Cursors.Hand;
            ShowPasswordCheck_login.Location = new Point(466, 232);
            ShowPasswordCheck_login.Name = "ShowPasswordCheck_login";
            ShowPasswordCheck_login.Size = new Size(132, 24);
            ShowPasswordCheck_login.TabIndex = 7;
            ShowPasswordCheck_login.Text = "Show Password";
            ShowPasswordCheck_login.UseVisualStyleBackColor = true;
            ShowPasswordCheck_login.CheckedChanged += ShowPasswordCheck_CheckedChanged;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Black;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            LoginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.ControlLightLight;
            LoginButton.Location = new Point(388, 362);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(133, 46);
            LoginButton.TabIndex = 8;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Admin_RadioBtn
            // 
            Admin_RadioBtn.AutoSize = true;
            Admin_RadioBtn.Location = new Point(333, 311);
            Admin_RadioBtn.Name = "Admin_RadioBtn";
            Admin_RadioBtn.Size = new Size(74, 24);
            Admin_RadioBtn.TabIndex = 9;
            Admin_RadioBtn.TabStop = true;
            Admin_RadioBtn.Text = "Admin";
            Admin_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // Organizer_RadioBtn
            // 
            Organizer_RadioBtn.AutoSize = true;
            Organizer_RadioBtn.Location = new Point(413, 311);
            Organizer_RadioBtn.Name = "Organizer_RadioBtn";
            Organizer_RadioBtn.Size = new Size(95, 24);
            Organizer_RadioBtn.TabIndex = 10;
            Organizer_RadioBtn.TabStop = true;
            Organizer_RadioBtn.Text = "Organizer";
            Organizer_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // Participant_RadioBtn
            // 
            Participant_RadioBtn.AutoSize = true;
            Participant_RadioBtn.Location = new Point(514, 311);
            Participant_RadioBtn.Name = "Participant_RadioBtn";
            Participant_RadioBtn.Size = new Size(100, 24);
            Participant_RadioBtn.TabIndex = 11;
            Participant_RadioBtn.TabStop = true;
            Participant_RadioBtn.Text = "Participant";
            Participant_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(320, 274);
            label4.Name = "label4";
            label4.Size = new Size(108, 24);
            label4.TabIndex = 12;
            label4.Text = "User Role: ";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(625, 420);
            Controls.Add(label4);
            Controls.Add(Participant_RadioBtn);
            Controls.Add(Organizer_RadioBtn);
            Controls.Add(Admin_RadioBtn);
            Controls.Add(LoginButton);
            Controls.Add(ShowPasswordCheck_login);
            Controls.Add(PasswordText_login);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameText_login);
            Controls.Add(UserNameLabel);
            Controls.Add(label2);
            Controls.Add(Exit);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Exit;
        private Label label2;
        private Label UserNameLabel;
        private TextBox UsernameText_login;
        private TextBox PasswordText_login;
        private Label PasswordLabel;
        private CheckBox ShowPasswordCheck_login;
        private Button LoginButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Button RegisterButton;
        private Label label3;
        private RadioButton Admin_RadioBtn;
        private RadioButton Organizer_RadioBtn;
        private RadioButton Participant_RadioBtn;
        private Label label4;
    }
}