namespace CyclicMenu
{
    partial class ChangePassForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.buttonSetNewAuth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новый логин:";
            // 
            // textBoxNewLogin
            // 
            this.textBoxNewLogin.Location = new System.Drawing.Point(145, 35);
            this.textBoxNewLogin.Name = "textBoxNewLogin";
            this.textBoxNewLogin.Size = new System.Drawing.Size(208, 22);
            this.textBoxNewLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Новый пароль:";
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(145, 67);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(208, 22);
            this.textBoxNewPass.TabIndex = 1;
            // 
            // buttonSetNewAuth
            // 
            this.buttonSetNewAuth.Location = new System.Drawing.Point(145, 112);
            this.buttonSetNewAuth.Name = "buttonSetNewAuth";
            this.buttonSetNewAuth.Size = new System.Drawing.Size(208, 23);
            this.buttonSetNewAuth.TabIndex = 2;
            this.buttonSetNewAuth.Text = "Сменить данные";
            this.buttonSetNewAuth.UseVisualStyleBackColor = true;
            this.buttonSetNewAuth.Click += new System.EventHandler(this.buttonSetNewAuth_Click);
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 159);
            this.Controls.Add(this.buttonSetNewAuth);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.textBoxNewLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassForm";
            this.Text = "Смена логина и пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Button buttonSetNewAuth;
    }
}