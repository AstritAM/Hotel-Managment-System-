namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.PictureBox();
            this.ManegeClient = new System.Windows.Forms.Button();
            this.ManegeRoom = new System.Windows.Forms.Button();
            this.ManegeResevertion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Image = global::WindowsFormsApp1.Properties.Resources._12094___Deco_Garbo_jpg__width_822_height_993;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(388, 431);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            // 
            // ManegeClient
            // 
            this.ManegeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.ManegeClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManegeClient.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ManegeClient.FlatAppearance.BorderSize = 2;
            this.ManegeClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.ManegeClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManegeClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManegeClient.Font = new System.Drawing.Font("Noto Serif Cond", 12F, System.Drawing.FontStyle.Italic);
            this.ManegeClient.Location = new System.Drawing.Point(59, 111);
            this.ManegeClient.Name = "ManegeClient";
            this.ManegeClient.Size = new System.Drawing.Size(265, 71);
            this.ManegeClient.TabIndex = 2;
            this.ManegeClient.Text = "Посетители";
            this.ManegeClient.UseVisualStyleBackColor = false;
            this.ManegeClient.Click += new System.EventHandler(this.ManegeClient_Click);
            // 
            // ManegeRoom
            // 
            this.ManegeRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.ManegeRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManegeRoom.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ManegeRoom.FlatAppearance.BorderSize = 2;
            this.ManegeRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.ManegeRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManegeRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManegeRoom.Font = new System.Drawing.Font("Noto Serif Cond", 12F, System.Drawing.FontStyle.Italic);
            this.ManegeRoom.Location = new System.Drawing.Point(59, 318);
            this.ManegeRoom.Name = "ManegeRoom";
            this.ManegeRoom.Size = new System.Drawing.Size(265, 76);
            this.ManegeRoom.TabIndex = 3;
            this.ManegeRoom.Text = "Добавить номер";
            this.ManegeRoom.UseVisualStyleBackColor = false;
            this.ManegeRoom.Click += new System.EventHandler(this.ManegeRoom_Click);
            // 
            // ManegeResevertion
            // 
            this.ManegeResevertion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.ManegeResevertion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManegeResevertion.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ManegeResevertion.FlatAppearance.BorderSize = 2;
            this.ManegeResevertion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.ManegeResevertion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManegeResevertion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManegeResevertion.Font = new System.Drawing.Font("Noto Serif Cond", 12F, System.Drawing.FontStyle.Italic);
            this.ManegeResevertion.Location = new System.Drawing.Point(59, 215);
            this.ManegeResevertion.Name = "ManegeResevertion";
            this.ManegeResevertion.Size = new System.Drawing.Size(265, 78);
            this.ManegeResevertion.TabIndex = 4;
            this.ManegeResevertion.Text = "Зарезервировать номер";
            this.ManegeResevertion.UseVisualStyleBackColor = false;
            this.ManegeResevertion.Click += new System.EventHandler(this.ManegeResevertion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.CloseLable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 81);
            this.panel1.TabIndex = 5;
            // 
            // CloseLable
            // 
            this.CloseLable.AutoSize = true;
            this.CloseLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLable.Location = new System.Drawing.Point(363, 0);
            this.CloseLable.Name = "CloseLable";
            this.CloseLable.Size = new System.Drawing.Size(22, 25);
            this.CloseLable.TabIndex = 3;
            this.CloseLable.Text = "x";
            this.CloseLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseLable.Click += new System.EventHandler(this.CloseLable_Click);
            this.CloseLable.MouseEnter += new System.EventHandler(this.CloseLable_MouseEnter);
            this.CloseLable.MouseLeave += new System.EventHandler(this.CloseLable_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Noto Serif Cond", 24F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "Главное меню";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ManegeResevertion);
            this.Controls.Add(this.ManegeRoom);
            this.Controls.Add(this.ManegeClient);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.Button ManegeClient;
        private System.Windows.Forms.Button ManegeRoom;
        private System.Windows.Forms.Button ManegeResevertion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseLable;
    }
}

