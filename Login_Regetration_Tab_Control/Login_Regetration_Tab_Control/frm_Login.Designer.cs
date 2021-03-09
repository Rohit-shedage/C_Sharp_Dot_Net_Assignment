namespace Login_Regetration_Tab_Control
{
    partial class frm_Login
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tabcontrol_Main = new System.Windows.Forms.TabControl();
            this.tabpage_Login = new System.Windows.Forms.TabPage();
            this.chb_Show_Password = new System.Windows.Forms.CheckBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tabPage_Add_New_User = new System.Windows.Forms.TabPage();
            this.chb_Add_Confirm_Password = new System.Windows.Forms.CheckBox();
            this.chb_Add_Show_Password = new System.Windows.Forms.CheckBox();
            this.lbl_Password_Error = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_Msg_Valid_or_Invalid = new System.Windows.Forms.Label();
            this.tb_Add_Admin_Hint = new System.Windows.Forms.TextBox();
            this.lbl_Add_Admin_Hint = new System.Windows.Forms.Label();
            this.tb_Add_Confirm = new System.Windows.Forms.TextBox();
            this.lbl_Add_Confirm = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Add_Password = new System.Windows.Forms.TextBox();
            this.tb_Add_Username = new System.Windows.Forms.TextBox();
            this.lbl_Add_Password = new System.Windows.Forms.Label();
            this.lbl_Add_Username = new System.Windows.Forms.Label();
            this.tabPage_Forgot_Password = new System.Windows.Forms.TabPage();
            this.lbl_Forgot_Error_Password = new System.Windows.Forms.Label();
            this.lbl_Forgot_Error_AdminKey = new System.Windows.Forms.Label();
            this.lbl_Forgot_Error_Username = new System.Windows.Forms.Label();
            this.tb_Forgot_Admin_Hint = new System.Windows.Forms.TextBox();
            this.lbl_Forgot_Admin_Hint = new System.Windows.Forms.Label();
            this.tb_Forgot_Confirm_Password = new System.Windows.Forms.TextBox();
            this.lbl_Forgot_Confirm_Password = new System.Windows.Forms.Label();
            this.btn_Forgot_Save = new System.Windows.Forms.Button();
            this.tb_Forgot_New_Password = new System.Windows.Forms.TextBox();
            this.tb_Forgot_Username = new System.Windows.Forms.TextBox();
            this.lbl_Forgot_New_Password = new System.Windows.Forms.Label();
            this.lbl_Forgot_Username = new System.Windows.Forms.Label();
            this.chb_Add_Admin_Key_Show = new System.Windows.Forms.CheckBox();
            this.chb_Forgot_AdminKey_Show = new System.Windows.Forms.CheckBox();
            this.chb_Forgot_NewPassword_Show = new System.Windows.Forms.CheckBox();
            this.chb_Forgot_ConfirmPassword_Show = new System.Windows.Forms.CheckBox();
            this.pnl_Header.SuspendLayout();
            this.tabcontrol_Main.SuspendLayout();
            this.tabpage_Login.SuspendLayout();
            this.tabPage_Add_New_User.SuspendLayout();
            this.tabPage_Forgot_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1356, 113);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(530, 43);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(312, 41);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Fork Infosystems";
            // 
            // tabcontrol_Main
            // 
            this.tabcontrol_Main.Controls.Add(this.tabpage_Login);
            this.tabcontrol_Main.Controls.Add(this.tabPage_Add_New_User);
            this.tabcontrol_Main.Controls.Add(this.tabPage_Forgot_Password);
            this.tabcontrol_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol_Main.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrol_Main.Location = new System.Drawing.Point(0, 113);
            this.tabcontrol_Main.Name = "tabcontrol_Main";
            this.tabcontrol_Main.SelectedIndex = 0;
            this.tabcontrol_Main.Size = new System.Drawing.Size(1356, 786);
            this.tabcontrol_Main.TabIndex = 1;
            // 
            // tabpage_Login
            // 
            this.tabpage_Login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabpage_Login.Controls.Add(this.chb_Show_Password);
            this.tabpage_Login.Controls.Add(this.btn_Submit);
            this.tabpage_Login.Controls.Add(this.tb_Password);
            this.tabpage_Login.Controls.Add(this.tb_Username);
            this.tabpage_Login.Controls.Add(this.lbl_Password);
            this.tabpage_Login.Controls.Add(this.lbl_Username);
            this.tabpage_Login.Location = new System.Drawing.Point(4, 40);
            this.tabpage_Login.Name = "tabpage_Login";
            this.tabpage_Login.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_Login.Size = new System.Drawing.Size(1348, 742);
            this.tabpage_Login.TabIndex = 0;
            this.tabpage_Login.Text = "Login";
            this.tabpage_Login.Click += new System.EventHandler(this.tabpage_Login_Click);
            // 
            // chb_Show_Password
            // 
            this.chb_Show_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_Show_Password.AutoSize = true;
            this.chb_Show_Password.Location = new System.Drawing.Point(723, 448);
            this.chb_Show_Password.Name = "chb_Show_Password";
            this.chb_Show_Password.Size = new System.Drawing.Size(222, 35);
            this.chb_Show_Password.TabIndex = 16;
            this.chb_Show_Password.Text = "Show Password";
            this.chb_Show_Password.UseVisualStyleBackColor = true;
            this.chb_Show_Password.CheckedChanged += new System.EventHandler(this.chb_Show_Password_CheckedChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(595, 562);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(153, 57);
            this.btn_Submit.TabIndex = 14;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(723, 378);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(303, 45);
            this.tb_Password.TabIndex = 13;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // tb_Username
            // 
            this.tb_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(723, 214);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(303, 45);
            this.tb_Username.TabIndex = 12;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Password.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(389, 378);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(158, 38);
            this.lbl_Password.TabIndex = 11;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Username.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(389, 221);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(166, 38);
            this.lbl_Username.TabIndex = 10;
            this.lbl_Username.Text = "Username";
            // 
            // tabPage_Add_New_User
            // 
            this.tabPage_Add_New_User.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage_Add_New_User.Controls.Add(this.chb_Add_Admin_Key_Show);
            this.tabPage_Add_New_User.Controls.Add(this.chb_Add_Confirm_Password);
            this.tabPage_Add_New_User.Controls.Add(this.chb_Add_Show_Password);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Password_Error);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Error);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Msg_Valid_or_Invalid);
            this.tabPage_Add_New_User.Controls.Add(this.tb_Add_Admin_Hint);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Add_Admin_Hint);
            this.tabPage_Add_New_User.Controls.Add(this.tb_Add_Confirm);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Add_Confirm);
            this.tabPage_Add_New_User.Controls.Add(this.btn_Save);
            this.tabPage_Add_New_User.Controls.Add(this.tb_Add_Password);
            this.tabPage_Add_New_User.Controls.Add(this.tb_Add_Username);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Add_Password);
            this.tabPage_Add_New_User.Controls.Add(this.lbl_Add_Username);
            this.tabPage_Add_New_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Add_New_User.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Add_New_User.Name = "tabPage_Add_New_User";
            this.tabPage_Add_New_User.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Add_New_User.Size = new System.Drawing.Size(1348, 742);
            this.tabPage_Add_New_User.TabIndex = 1;
            this.tabPage_Add_New_User.Text = "Add New User";
            this.tabPage_Add_New_User.Click += new System.EventHandler(this.tabPage_Add_New_User_Click);
            // 
            // chb_Add_Confirm_Password
            // 
            this.chb_Add_Confirm_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_Add_Confirm_Password.AutoSize = true;
            this.chb_Add_Confirm_Password.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Add_Confirm_Password.Location = new System.Drawing.Point(1153, 369);
            this.chb_Add_Confirm_Password.Name = "chb_Add_Confirm_Password";
            this.chb_Add_Confirm_Password.Size = new System.Drawing.Size(185, 29);
            this.chb_Add_Confirm_Password.TabIndex = 28;
            this.chb_Add_Confirm_Password.Text = "Show Password";
            this.chb_Add_Confirm_Password.UseVisualStyleBackColor = true;
            this.chb_Add_Confirm_Password.CheckedChanged += new System.EventHandler(this.chb_Add_Confirm_Password_CheckedChanged);
            // 
            // chb_Add_Show_Password
            // 
            this.chb_Add_Show_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_Add_Show_Password.AutoSize = true;
            this.chb_Add_Show_Password.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Add_Show_Password.Location = new System.Drawing.Point(1158, 227);
            this.chb_Add_Show_Password.Name = "chb_Add_Show_Password";
            this.chb_Add_Show_Password.Size = new System.Drawing.Size(185, 29);
            this.chb_Add_Show_Password.TabIndex = 27;
            this.chb_Add_Show_Password.Text = "Show Password";
            this.chb_Add_Show_Password.UseVisualStyleBackColor = true;
            this.chb_Add_Show_Password.CheckedChanged += new System.EventHandler(this.chb_Add_Show_Password_CheckedChanged);
            // 
            // lbl_Password_Error
            // 
            this.lbl_Password_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Password_Error.AutoSize = true;
            this.lbl_Password_Error.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password_Error.Location = new System.Drawing.Point(808, 409);
            this.lbl_Password_Error.Name = "lbl_Password_Error";
            this.lbl_Password_Error.Size = new System.Drawing.Size(127, 20);
            this.lbl_Password_Error.TabIndex = 26;
            this.lbl_Password_Error.Text = "Password_Error";
            this.lbl_Password_Error.Visible = false;
            // 
            // lbl_Error
            // 
            this.lbl_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(808, 560);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(84, 20);
            this.lbl_Error.TabIndex = 25;
            this.lbl_Error.Text = "AdminKey";
            this.lbl_Error.Visible = false;
            // 
            // lbl_Msg_Valid_or_Invalid
            // 
            this.lbl_Msg_Valid_or_Invalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Msg_Valid_or_Invalid.AutoSize = true;
            this.lbl_Msg_Valid_or_Invalid.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Msg_Valid_or_Invalid.Location = new System.Drawing.Point(818, 278);
            this.lbl_Msg_Valid_or_Invalid.Name = "lbl_Msg_Valid_or_Invalid";
            this.lbl_Msg_Valid_or_Invalid.Size = new System.Drawing.Size(121, 20);
            this.lbl_Msg_Valid_or_Invalid.TabIndex = 24;
            this.lbl_Msg_Valid_or_Invalid.Text = "Invalid or Valid";
            this.lbl_Msg_Valid_or_Invalid.Visible = false;
            // 
            // tb_Add_Admin_Hint
            // 
            this.tb_Add_Admin_Hint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Add_Admin_Hint.Enabled = false;
            this.tb_Add_Admin_Hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Add_Admin_Hint.Location = new System.Drawing.Point(803, 497);
            this.tb_Add_Admin_Hint.MaxLength = 12;
            this.tb_Add_Admin_Hint.Name = "tb_Add_Admin_Hint";
            this.tb_Add_Admin_Hint.PasswordChar = '*';
            this.tb_Add_Admin_Hint.Size = new System.Drawing.Size(336, 45);
            this.tb_Add_Admin_Hint.TabIndex = 4;
            this.tb_Add_Admin_Hint.TextChanged += new System.EventHandler(this.tb_Add_Admin_Hint_TextChanged);
            // 
            // lbl_Add_Admin_Hint
            // 
            this.lbl_Add_Admin_Hint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Add_Admin_Hint.AutoSize = true;
            this.lbl_Add_Admin_Hint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Add_Admin_Hint.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Admin_Hint.Location = new System.Drawing.Point(184, 505);
            this.lbl_Add_Admin_Hint.Name = "lbl_Add_Admin_Hint";
            this.lbl_Add_Admin_Hint.Size = new System.Drawing.Size(205, 38);
            this.lbl_Add_Admin_Hint.TabIndex = 22;
            this.lbl_Add_Admin_Hint.Text = "Admin Hint";
            // 
            // tb_Add_Confirm
            // 
            this.tb_Add_Confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Add_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Add_Confirm.Location = new System.Drawing.Point(803, 361);
            this.tb_Add_Confirm.MaxLength = 12;
            this.tb_Add_Confirm.Name = "tb_Add_Confirm";
            this.tb_Add_Confirm.PasswordChar = '*';
            this.tb_Add_Confirm.Size = new System.Drawing.Size(336, 45);
            this.tb_Add_Confirm.TabIndex = 3;
            this.tb_Add_Confirm.TextChanged += new System.EventHandler(this.tb_Add_Confirm_TextChanged);
            // 
            // lbl_Add_Confirm
            // 
            this.lbl_Add_Confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Add_Confirm.AutoSize = true;
            this.lbl_Add_Confirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Add_Confirm.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Confirm.Location = new System.Drawing.Point(184, 369);
            this.lbl_Add_Confirm.Name = "lbl_Add_Confirm";
            this.lbl_Add_Confirm.Size = new System.Drawing.Size(294, 38);
            this.lbl_Add_Confirm.TabIndex = 20;
            this.lbl_Add_Confirm.Text = "Confirm Password";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(575, 631);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(153, 57);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Add_Password
            // 
            this.tb_Add_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Add_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Add_Password.Location = new System.Drawing.Point(803, 216);
            this.tb_Add_Password.MaxLength = 12;
            this.tb_Add_Password.Name = "tb_Add_Password";
            this.tb_Add_Password.PasswordChar = '*';
            this.tb_Add_Password.Size = new System.Drawing.Size(336, 45);
            this.tb_Add_Password.TabIndex = 2;
            // 
            // tb_Add_Username
            // 
            this.tb_Add_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Add_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Add_Username.Location = new System.Drawing.Point(803, 84);
            this.tb_Add_Username.MaxLength = 12;
            this.tb_Add_Username.Name = "tb_Add_Username";
            this.tb_Add_Username.Size = new System.Drawing.Size(336, 45);
            this.tb_Add_Username.TabIndex = 1;
            // 
            // lbl_Add_Password
            // 
            this.lbl_Add_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Add_Password.AutoSize = true;
            this.lbl_Add_Password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Add_Password.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Password.Location = new System.Drawing.Point(184, 227);
            this.lbl_Add_Password.Name = "lbl_Add_Password";
            this.lbl_Add_Password.Size = new System.Drawing.Size(158, 38);
            this.lbl_Add_Password.TabIndex = 16;
            this.lbl_Add_Password.Text = "Password";
            // 
            // lbl_Add_Username
            // 
            this.lbl_Add_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Add_Username.AutoSize = true;
            this.lbl_Add_Username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Add_Username.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Username.Location = new System.Drawing.Point(184, 88);
            this.lbl_Add_Username.Name = "lbl_Add_Username";
            this.lbl_Add_Username.Size = new System.Drawing.Size(166, 38);
            this.lbl_Add_Username.TabIndex = 15;
            this.lbl_Add_Username.Text = "Username";
            // 
            // tabPage_Forgot_Password
            // 
            this.tabPage_Forgot_Password.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage_Forgot_Password.Controls.Add(this.chb_Forgot_ConfirmPassword_Show);
            this.tabPage_Forgot_Password.Controls.Add(this.chb_Forgot_NewPassword_Show);
            this.tabPage_Forgot_Password.Controls.Add(this.chb_Forgot_AdminKey_Show);
            this.tabPage_Forgot_Password.Controls.Add(this.lbl_Forgot_Error_Password);
            this.tabPage_Forgot_Password.Controls.Add(this.lbl_Forgot_Error_AdminKey);
            this.tabPage_Forgot_Password.Controls.Add(this.lbl_Forgot_Error_Username);
            this.tabPage_Forgot_Password.Controls.Add(this.tb_Forgot_Admin_Hint);
            this.tabPage_Forgot_Password.Controls.Add(this.lbl_Forgot_Admin_Hint);
            this.tabPage_Forgot_Password.Controls.Add(this.tb_Forgot_Confirm_Password);
            this.tabPage_Forgot_Password.Controls.Add(this.lbl_Forgot_Confirm_Password);
            this.tabPage_Forgot_Password.Controls.Add(this.btn_Forgot_Save);
            this.tabPage_Forgot_Password.Controls.Add(this.tb_Forgot_New_Password);
            this.tabPage_Forgot_Password.Controls.Add(this.tb_Forgot_Username);
            this.tabPage_Forgot_Password.Controls.Add(this.lbl_Forgot_New_Password);
            this.tabPage_Forgot_Password.Controls.Add(this.lbl_Forgot_Username);
            this.tabPage_Forgot_Password.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Forgot_Password.Name = "tabPage_Forgot_Password";
            this.tabPage_Forgot_Password.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Forgot_Password.Size = new System.Drawing.Size(1348, 742);
            this.tabPage_Forgot_Password.TabIndex = 2;
            this.tabPage_Forgot_Password.Text = "Forgot Password";
            this.tabPage_Forgot_Password.Click += new System.EventHandler(this.tabPage_Forgot_Password_Click);
            // 
            // lbl_Forgot_Error_Password
            // 
            this.lbl_Forgot_Error_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Forgot_Error_Password.AutoSize = true;
            this.lbl_Forgot_Error_Password.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_Error_Password.Location = new System.Drawing.Point(736, 566);
            this.lbl_Forgot_Error_Password.Name = "lbl_Forgot_Error_Password";
            this.lbl_Forgot_Error_Password.Size = new System.Drawing.Size(120, 20);
            this.lbl_Forgot_Error_Password.TabIndex = 34;
            this.lbl_Forgot_Error_Password.Text = "Password Error";
            this.lbl_Forgot_Error_Password.Visible = false;
            // 
            // lbl_Forgot_Error_AdminKey
            // 
            this.lbl_Forgot_Error_AdminKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Forgot_Error_AdminKey.AutoSize = true;
            this.lbl_Forgot_Error_AdminKey.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_Error_AdminKey.Location = new System.Drawing.Point(736, 264);
            this.lbl_Forgot_Error_AdminKey.Name = "lbl_Forgot_Error_AdminKey";
            this.lbl_Forgot_Error_AdminKey.Size = new System.Drawing.Size(130, 20);
            this.lbl_Forgot_Error_AdminKey.TabIndex = 33;
            this.lbl_Forgot_Error_AdminKey.Text = "AdminKey Error";
            this.lbl_Forgot_Error_AdminKey.Visible = false;
            // 
            // lbl_Forgot_Error_Username
            // 
            this.lbl_Forgot_Error_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Forgot_Error_Username.AutoSize = true;
            this.lbl_Forgot_Error_Username.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_Error_Username.Location = new System.Drawing.Point(749, 126);
            this.lbl_Forgot_Error_Username.Name = "lbl_Forgot_Error_Username";
            this.lbl_Forgot_Error_Username.Size = new System.Drawing.Size(101, 20);
            this.lbl_Forgot_Error_Username.TabIndex = 32;
            this.lbl_Forgot_Error_Username.Text = "Forgot Error";
            this.lbl_Forgot_Error_Username.Visible = false;
            // 
            // tb_Forgot_Admin_Hint
            // 
            this.tb_Forgot_Admin_Hint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Forgot_Admin_Hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Forgot_Admin_Hint.Location = new System.Drawing.Point(729, 201);
            this.tb_Forgot_Admin_Hint.MaxLength = 12;
            this.tb_Forgot_Admin_Hint.Name = "tb_Forgot_Admin_Hint";
            this.tb_Forgot_Admin_Hint.PasswordChar = '*';
            this.tb_Forgot_Admin_Hint.Size = new System.Drawing.Size(336, 45);
            this.tb_Forgot_Admin_Hint.TabIndex = 2;
            this.tb_Forgot_Admin_Hint.TextChanged += new System.EventHandler(this.tb_Forgot_Admin_Hint_TextChanged);
            this.tb_Forgot_Admin_Hint.Leave += new System.EventHandler(this.tb_Forgot_Admin_Hint_Leave);
            // 
            // lbl_Forgot_Admin_Hint
            // 
            this.lbl_Forgot_Admin_Hint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Forgot_Admin_Hint.AutoSize = true;
            this.lbl_Forgot_Admin_Hint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Forgot_Admin_Hint.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_Admin_Hint.Location = new System.Drawing.Point(207, 201);
            this.lbl_Forgot_Admin_Hint.Name = "lbl_Forgot_Admin_Hint";
            this.lbl_Forgot_Admin_Hint.Size = new System.Drawing.Size(191, 38);
            this.lbl_Forgot_Admin_Hint.TabIndex = 31;
            this.lbl_Forgot_Admin_Hint.Text = "Admin Key";
            // 
            // tb_Forgot_Confirm_Password
            // 
            this.tb_Forgot_Confirm_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Forgot_Confirm_Password.Enabled = false;
            this.tb_Forgot_Confirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Forgot_Confirm_Password.Location = new System.Drawing.Point(729, 502);
            this.tb_Forgot_Confirm_Password.MaxLength = 12;
            this.tb_Forgot_Confirm_Password.Name = "tb_Forgot_Confirm_Password";
            this.tb_Forgot_Confirm_Password.PasswordChar = '*';
            this.tb_Forgot_Confirm_Password.Size = new System.Drawing.Size(336, 45);
            this.tb_Forgot_Confirm_Password.TabIndex = 4;
            this.tb_Forgot_Confirm_Password.TextChanged += new System.EventHandler(this.tb_Forgot_Confirm_Password_TextChanged);
            // 
            // lbl_Forgot_Confirm_Password
            // 
            this.lbl_Forgot_Confirm_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Forgot_Confirm_Password.AutoSize = true;
            this.lbl_Forgot_Confirm_Password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Forgot_Confirm_Password.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_Confirm_Password.Location = new System.Drawing.Point(207, 502);
            this.lbl_Forgot_Confirm_Password.Name = "lbl_Forgot_Confirm_Password";
            this.lbl_Forgot_Confirm_Password.Size = new System.Drawing.Size(294, 38);
            this.lbl_Forgot_Confirm_Password.TabIndex = 29;
            this.lbl_Forgot_Confirm_Password.Text = "Confirm Password";
            // 
            // btn_Forgot_Save
            // 
            this.btn_Forgot_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Forgot_Save.Enabled = false;
            this.btn_Forgot_Save.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Forgot_Save.Location = new System.Drawing.Point(522, 622);
            this.btn_Forgot_Save.Name = "btn_Forgot_Save";
            this.btn_Forgot_Save.Size = new System.Drawing.Size(153, 57);
            this.btn_Forgot_Save.TabIndex = 5;
            this.btn_Forgot_Save.Text = "Save";
            this.btn_Forgot_Save.UseVisualStyleBackColor = true;
            this.btn_Forgot_Save.Click += new System.EventHandler(this.btn_Forgot_Save_Click);
            // 
            // tb_Forgot_New_Password
            // 
            this.tb_Forgot_New_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Forgot_New_Password.Enabled = false;
            this.tb_Forgot_New_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Forgot_New_Password.Location = new System.Drawing.Point(729, 344);
            this.tb_Forgot_New_Password.MaxLength = 12;
            this.tb_Forgot_New_Password.Name = "tb_Forgot_New_Password";
            this.tb_Forgot_New_Password.PasswordChar = '*';
            this.tb_Forgot_New_Password.Size = new System.Drawing.Size(336, 45);
            this.tb_Forgot_New_Password.TabIndex = 3;
            // 
            // tb_Forgot_Username
            // 
            this.tb_Forgot_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Forgot_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Forgot_Username.Location = new System.Drawing.Point(729, 61);
            this.tb_Forgot_Username.MaxLength = 12;
            this.tb_Forgot_Username.Name = "tb_Forgot_Username";
            this.tb_Forgot_Username.Size = new System.Drawing.Size(336, 45);
            this.tb_Forgot_Username.TabIndex = 1;
            this.tb_Forgot_Username.TextChanged += new System.EventHandler(this.tb_Forgot_Username_TextChanged);
            this.tb_Forgot_Username.Leave += new System.EventHandler(this.tb_Forgot_Username_Leave);
            // 
            // lbl_Forgot_New_Password
            // 
            this.lbl_Forgot_New_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Forgot_New_Password.AutoSize = true;
            this.lbl_Forgot_New_Password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Forgot_New_Password.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_New_Password.Location = new System.Drawing.Point(207, 344);
            this.lbl_Forgot_New_Password.Name = "lbl_Forgot_New_Password";
            this.lbl_Forgot_New_Password.Size = new System.Drawing.Size(234, 38);
            this.lbl_Forgot_New_Password.TabIndex = 25;
            this.lbl_Forgot_New_Password.Text = "New Password";
            // 
            // lbl_Forgot_Username
            // 
            this.lbl_Forgot_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Forgot_Username.AutoSize = true;
            this.lbl_Forgot_Username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Forgot_Username.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot_Username.Location = new System.Drawing.Point(207, 57);
            this.lbl_Forgot_Username.Name = "lbl_Forgot_Username";
            this.lbl_Forgot_Username.Size = new System.Drawing.Size(166, 38);
            this.lbl_Forgot_Username.TabIndex = 24;
            this.lbl_Forgot_Username.Text = "Username";
            // 
            // chb_Add_Admin_Key_Show
            // 
            this.chb_Add_Admin_Key_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_Add_Admin_Key_Show.AutoSize = true;
            this.chb_Add_Admin_Key_Show.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Add_Admin_Key_Show.Location = new System.Drawing.Point(1153, 505);
            this.chb_Add_Admin_Key_Show.Name = "chb_Add_Admin_Key_Show";
            this.chb_Add_Admin_Key_Show.Size = new System.Drawing.Size(133, 29);
            this.chb_Add_Admin_Key_Show.TabIndex = 29;
            this.chb_Add_Admin_Key_Show.Text = "Show Key";
            this.chb_Add_Admin_Key_Show.UseVisualStyleBackColor = true;
            this.chb_Add_Admin_Key_Show.CheckedChanged += new System.EventHandler(this.chb_Add_Admin_Key_Show_CheckedChanged);
            // 
            // chb_Forgot_AdminKey_Show
            // 
            this.chb_Forgot_AdminKey_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_Forgot_AdminKey_Show.AutoSize = true;
            this.chb_Forgot_AdminKey_Show.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Forgot_AdminKey_Show.Location = new System.Drawing.Point(1094, 205);
            this.chb_Forgot_AdminKey_Show.Name = "chb_Forgot_AdminKey_Show";
            this.chb_Forgot_AdminKey_Show.Size = new System.Drawing.Size(133, 29);
            this.chb_Forgot_AdminKey_Show.TabIndex = 35;
            this.chb_Forgot_AdminKey_Show.Text = "Show Key";
            this.chb_Forgot_AdminKey_Show.UseVisualStyleBackColor = true;
            this.chb_Forgot_AdminKey_Show.CheckedChanged += new System.EventHandler(this.chb_Forgot_AdminKey_Show_CheckedChanged);
            // 
            // chb_Forgot_NewPassword_Show
            // 
            this.chb_Forgot_NewPassword_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_Forgot_NewPassword_Show.AutoSize = true;
            this.chb_Forgot_NewPassword_Show.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Forgot_NewPassword_Show.Location = new System.Drawing.Point(1094, 344);
            this.chb_Forgot_NewPassword_Show.Name = "chb_Forgot_NewPassword_Show";
            this.chb_Forgot_NewPassword_Show.Size = new System.Drawing.Size(185, 29);
            this.chb_Forgot_NewPassword_Show.TabIndex = 36;
            this.chb_Forgot_NewPassword_Show.Text = "Show Password";
            this.chb_Forgot_NewPassword_Show.UseVisualStyleBackColor = true;
            this.chb_Forgot_NewPassword_Show.CheckedChanged += new System.EventHandler(this.chb_Forgot_NewPassword_Show_CheckedChanged);
            // 
            // chb_Forgot_ConfirmPassword_Show
            // 
            this.chb_Forgot_ConfirmPassword_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_Forgot_ConfirmPassword_Show.AutoSize = true;
            this.chb_Forgot_ConfirmPassword_Show.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Forgot_ConfirmPassword_Show.Location = new System.Drawing.Point(1094, 502);
            this.chb_Forgot_ConfirmPassword_Show.Name = "chb_Forgot_ConfirmPassword_Show";
            this.chb_Forgot_ConfirmPassword_Show.Size = new System.Drawing.Size(185, 29);
            this.chb_Forgot_ConfirmPassword_Show.TabIndex = 37;
            this.chb_Forgot_ConfirmPassword_Show.Text = "Show Password";
            this.chb_Forgot_ConfirmPassword_Show.UseVisualStyleBackColor = true;
            this.chb_Forgot_ConfirmPassword_Show.CheckedChanged += new System.EventHandler(this.chb_Forgot_ConfirmPassword_Show_CheckedChanged);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1356, 899);
            this.Controls.Add(this.tabcontrol_Main);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.tabcontrol_Main.ResumeLayout(false);
            this.tabpage_Login.ResumeLayout(false);
            this.tabpage_Login.PerformLayout();
            this.tabPage_Add_New_User.ResumeLayout(false);
            this.tabPage_Add_New_User.PerformLayout();
            this.tabPage_Forgot_Password.ResumeLayout(false);
            this.tabPage_Forgot_Password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TabControl tabcontrol_Main;
        private System.Windows.Forms.TabPage tabpage_Login;
        private System.Windows.Forms.TabPage tabPage_Add_New_User;
        private System.Windows.Forms.TabPage tabPage_Forgot_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tb_Add_Admin_Hint;
        private System.Windows.Forms.Label lbl_Add_Admin_Hint;
        private System.Windows.Forms.TextBox tb_Add_Confirm;
        private System.Windows.Forms.Label lbl_Add_Confirm;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Add_Password;
        private System.Windows.Forms.TextBox tb_Add_Username;
        private System.Windows.Forms.Label lbl_Add_Password;
        private System.Windows.Forms.Label lbl_Add_Username;
        private System.Windows.Forms.TextBox tb_Forgot_Admin_Hint;
        private System.Windows.Forms.Label lbl_Forgot_Admin_Hint;
        private System.Windows.Forms.TextBox tb_Forgot_Confirm_Password;
        private System.Windows.Forms.Label lbl_Forgot_Confirm_Password;
        private System.Windows.Forms.Button btn_Forgot_Save;
        private System.Windows.Forms.TextBox tb_Forgot_New_Password;
        private System.Windows.Forms.TextBox tb_Forgot_Username;
        private System.Windows.Forms.Label lbl_Forgot_New_Password;
        private System.Windows.Forms.Label lbl_Forgot_Username;
        private System.Windows.Forms.CheckBox chb_Show_Password;
        private System.Windows.Forms.Label lbl_Msg_Valid_or_Invalid;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Label lbl_Password_Error;
        private System.Windows.Forms.Label lbl_Forgot_Error_Username;
        private System.Windows.Forms.Label lbl_Forgot_Error_AdminKey;
        private System.Windows.Forms.Label lbl_Forgot_Error_Password;
        private System.Windows.Forms.CheckBox chb_Add_Confirm_Password;
        private System.Windows.Forms.CheckBox chb_Add_Show_Password;
        private System.Windows.Forms.CheckBox chb_Add_Admin_Key_Show;
        private System.Windows.Forms.CheckBox chb_Forgot_ConfirmPassword_Show;
        private System.Windows.Forms.CheckBox chb_Forgot_NewPassword_Show;
        private System.Windows.Forms.CheckBox chb_Forgot_AdminKey_Show;
    }
}

