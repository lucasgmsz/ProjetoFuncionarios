﻿namespace Funcionarios
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label1.Location = new Point(17, 54);
            label1.Name = "label1";
            label1.Size = new Size(48, 16);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label2.Location = new Point(17, 96);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 1;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.Location = new Point(17, 144);
            label3.Name = "label3";
            label3.Size = new Size(37, 16);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(17, 187);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F);
            txtNome.Location = new Point(115, 49);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(376, 26);
            txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F);
            txtEmail.Location = new Point(115, 91);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(376, 26);
            txtEmail.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Arial", 12F);
            txtCpf.Location = new Point(115, 139);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(376, 26);
            txtCpf.TabIndex = 6;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 12F);
            txtEndereco.Location = new Point(115, 182);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(376, 26);
            txtEndereco.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(178, 240);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(153, 41);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 314);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtEndereco;
        private Button btnCadastrar;
    }
}
