namespace GerenciadorTarefasTrabalho
{
    partial class frmLogin
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
            btnRegister = new Button();
            btnLogin = new Button();
            panel1 = new Panel();
            lbllogin = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblusuario = new Label();
            lblsenha = new Label();
            checkLembrarsenha = new CheckBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(507, 388);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 34);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(640, 388);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 34);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbllogin);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 450);
            panel1.TabIndex = 2;
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbllogin.Location = new Point(3, 22);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(230, 80);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "login \r\ncamila e Agatha ";
            lbllogin.Click += lbllogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(288, 115);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(452, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(288, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(441, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = Color.Transparent;
            lblusuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusuario.Location = new Point(288, 68);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(64, 21);
            lblusuario.TabIndex = 5;
            lblusuario.Text = "Usuario";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.BackColor = Color.Transparent;
            lblsenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsenha.Location = new Point(288, 215);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(53, 21);
            lblsenha.TabIndex = 6;
            lblsenha.Text = "Senha";
            // 
            // checkLembrarsenha
            // 
            checkLembrarsenha.AutoSize = true;
            checkLembrarsenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkLembrarsenha.Location = new Point(288, 310);
            checkLembrarsenha.Name = "checkLembrarsenha";
            checkLembrarsenha.Size = new Size(114, 21);
            checkLembrarsenha.TabIndex = 7;
            checkLembrarsenha.Text = "Lembrar senha";
            checkLembrarsenha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(433, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 40);
            label1.TabIndex = 1;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblsenha);
            Controls.Add(lblusuario);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(checkLembrarsenha);
            Name = "frmLogin";
            Text = "Gerenciador de Tarefas";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Button btnLogin;
        private Panel panel1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblusuario;
        private Label lblsenha;
        private CheckBox checkLembrarsenha;
        private Label lbllogin;
        private Label label1;
    }
}
