namespace TESTE1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Titolo1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.titulo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Titolo1
            // 
            this.Titolo1.AutoSize = true;
            this.Titolo1.Location = new System.Drawing.Point(179, 79);
            this.Titolo1.Name = "Titolo1";
            this.Titolo1.Size = new System.Drawing.Size(129, 20);
            this.Titolo1.TabIndex = 2;
            this.Titolo1.Text = "Nome de usuario";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(183, 111);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(169, 26);
            this.usuario.TabIndex = 3;
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(183, 199);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(169, 26);
            this.senha.TabIndex = 5;
            // 
            // titulo2
            // 
            this.titulo2.AutoSize = true;
            this.titulo2.Location = new System.Drawing.Point(179, 167);
            this.titulo2.Name = "titulo2";
            this.titulo2.Size = new System.Drawing.Size(56, 20);
            this.titulo2.TabIndex = 4;
            this.titulo2.Text = "Senha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.titulo2);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.Titolo1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Titolo1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label titulo2;
    }
}

