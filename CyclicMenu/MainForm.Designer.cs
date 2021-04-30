namespace CyclicMenu
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктыПитанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаСоставаМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonForming = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьToolStripMenuItem,
            this.продуктыПитанияToolStripMenuItem,
            this.настройкаСоставаМенюToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сменитьToolStripMenuItem
            // 
            this.сменитьToolStripMenuItem.Name = "сменитьToolStripMenuItem";
            this.сменитьToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.сменитьToolStripMenuItem.Text = "Смена логина и пароля";
            this.сменитьToolStripMenuItem.Click += new System.EventHandler(this.сменитьToolStripMenuItem_Click);
            // 
            // продуктыПитанияToolStripMenuItem
            // 
            this.продуктыПитанияToolStripMenuItem.Name = "продуктыПитанияToolStripMenuItem";
            this.продуктыПитанияToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.продуктыПитанияToolStripMenuItem.Text = "Продукты питания";
            this.продуктыПитанияToolStripMenuItem.Click += new System.EventHandler(this.продуктыПитанияToolStripMenuItem_Click);
            // 
            // настройкаСоставаМенюToolStripMenuItem
            // 
            this.настройкаСоставаМенюToolStripMenuItem.Name = "настройкаСоставаМенюToolStripMenuItem";
            this.настройкаСоставаМенюToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.настройкаСоставаМенюToolStripMenuItem.Text = "Настройка состава меню";
            this.настройкаСоставаМенюToolStripMenuItem.Click += new System.EventHandler(this.настройкаСоставаМенюToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 513);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonForming
            // 
            this.buttonForming.Location = new System.Drawing.Point(681, 550);
            this.buttonForming.Name = "buttonForming";
            this.buttonForming.Size = new System.Drawing.Size(144, 30);
            this.buttonForming.TabIndex = 2;
            this.buttonForming.Text = "Сформировать";
            this.buttonForming.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить меню в xls";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonForming);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главная - Цикличное десятидневное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктыПитанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаСоставаМенюToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button buttonForming;
        private System.Windows.Forms.Button button1;
    }
}