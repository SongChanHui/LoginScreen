namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            btnLogin = new Button();
            txtID = new TextBox();
            txtPW = new TextBox();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = SystemColors.Highlight;
            lblAppName.Location = new Point(291, 55);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(410, 170);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientInactiveCaption;
            btnLogin.Font = new Font("맑은 고딕", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Highlight;
            btnLogin.Location = new Point(346, 673);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(329, 109);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(96, 305);
            txtID.Name = "txtID";
            txtID.Size = new Size(800, 107);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(96, 476);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(800, 107);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("맑은 고딕", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(96, 598);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(518, 37);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 873);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(btnLogin);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Button btnLogin;
        private TextBox txtID;
        private TextBox txtPW;
        private Label lblErrorMsg;
    }
}
