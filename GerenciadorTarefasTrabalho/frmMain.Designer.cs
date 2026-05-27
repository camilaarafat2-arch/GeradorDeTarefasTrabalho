namespace GerenciadorTarefasTrabalho
{
    partial class frmMain
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
            lblWelcome = new Label();
            txtTask = new TextBox();
            btnAdd = new Button();
            btnComplete = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            dgvTasks = new DataGridView();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(186, 110);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(186, 144);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(408, 23);
            txtTask.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(197, 196);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(278, 196);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(75, 23);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Concluir";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(359, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Excluir";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(440, 196);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Deslogar";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvTasks
            // 
            dgvTasks.BackgroundColor = Color.FromArgb(255, 192, 192);
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(186, 236);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.Size = new Size(408, 150);
            dgvTasks.TabIndex = 6;     
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(521, 196);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(dgvTasks);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnComplete);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Controls.Add(lblWelcome);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TextBox txtTask;
        private Button btnAdd;
        private Button btnComplete;
        private Button btnDelete;
        private Button btnLogout;
        private DataGridView dgvTasks;
        private Button btnEdit;
    }
}