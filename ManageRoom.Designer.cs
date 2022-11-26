namespace WindowsFormsApp1
{
    partial class ManageRoom
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
            this.buttonRemoveR = new System.Windows.Forms.Button();
            this.buttonClearFR = new System.Windows.Forms.Button();
            this.buttonEditR = new System.Windows.Forms.Button();
            this.buttonAddR = new System.Windows.Forms.Button();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.labTypeRoom = new System.Windows.Forms.Label();
            this.labPatronymic = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackToMain2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.lableFree = new System.Windows.Forms.Label();
            this.labCountClient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButNO = new System.Windows.Forms.RadioButton();
            this.radioButYes = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRemoveR
            // 
            this.buttonRemoveR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.buttonRemoveR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRemoveR.FlatAppearance.BorderSize = 2;
            this.buttonRemoveR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonRemoveR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.buttonRemoveR.Location = new System.Drawing.Point(42, 636);
            this.buttonRemoveR.Name = "buttonRemoveR";
            this.buttonRemoveR.Size = new System.Drawing.Size(162, 41);
            this.buttonRemoveR.TabIndex = 37;
            this.buttonRemoveR.Text = "Удалить";
            this.buttonRemoveR.UseVisualStyleBackColor = false;
            this.buttonRemoveR.Click += new System.EventHandler(this.buttonRemoveR_Click);
            // 
            // buttonClearFR
            // 
            this.buttonClearFR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.buttonClearFR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClearFR.FlatAppearance.BorderSize = 2;
            this.buttonClearFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonClearFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.buttonClearFR.Location = new System.Drawing.Point(232, 636);
            this.buttonClearFR.Name = "buttonClearFR";
            this.buttonClearFR.Size = new System.Drawing.Size(164, 41);
            this.buttonClearFR.TabIndex = 36;
            this.buttonClearFR.Text = "Очистить поля";
            this.buttonClearFR.UseVisualStyleBackColor = false;
            this.buttonClearFR.Click += new System.EventHandler(this.buttonClearFR_Click);
            // 
            // buttonEditR
            // 
            this.buttonEditR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.buttonEditR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEditR.FlatAppearance.BorderSize = 2;
            this.buttonEditR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonEditR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.buttonEditR.Location = new System.Drawing.Point(232, 551);
            this.buttonEditR.Name = "buttonEditR";
            this.buttonEditR.Size = new System.Drawing.Size(164, 45);
            this.buttonEditR.TabIndex = 35;
            this.buttonEditR.Text = "Редактировать";
            this.buttonEditR.UseVisualStyleBackColor = false;
            this.buttonEditR.Click += new System.EventHandler(this.buttonEditR_Click);
            // 
            // buttonAddR
            // 
            this.buttonAddR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.buttonAddR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAddR.FlatAppearance.BorderSize = 2;
            this.buttonAddR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonAddR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.buttonAddR.Location = new System.Drawing.Point(42, 551);
            this.buttonAddR.Name = "buttonAddR";
            this.buttonAddR.Size = new System.Drawing.Size(162, 45);
            this.buttonAddR.TabIndex = 34;
            this.buttonAddR.Text = "Добавить";
            this.buttonAddR.UseVisualStyleBackColor = false;
            this.buttonAddR.Click += new System.EventHandler(this.buttonAddR_Click);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(445, 136);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 24;
            this.dataGridViewRooms.Size = new System.Drawing.Size(800, 550);
            this.dataGridViewRooms.TabIndex = 20;
            this.dataGridViewRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellClick);
            this.dataGridViewRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellContentClick);
            // 
            // labTypeRoom
            // 
            this.labTypeRoom.AutoSize = true;
            this.labTypeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.labTypeRoom.Location = new System.Drawing.Point(38, 212);
            this.labTypeRoom.Name = "labTypeRoom";
            this.labTypeRoom.Size = new System.Drawing.Size(117, 20);
            this.labTypeRoom.TabIndex = 29;
            this.labTypeRoom.Text = "Тип комнаты";
            // 
            // labPatronymic
            // 
            this.labPatronymic.AutoSize = true;
            this.labPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.labPatronymic.Location = new System.Drawing.Point(47, 258);
            this.labPatronymic.Name = "labPatronymic";
            this.labPatronymic.Size = new System.Drawing.Size(0, 20);
            this.labPatronymic.TabIndex = 25;
            // 
            // tbid
            // 
            this.tbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbid.Location = new System.Drawing.Point(209, 150);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(195, 27);
            this.tbid.TabIndex = 19;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.labID.Location = new System.Drawing.Point(38, 150);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(142, 20);
            this.labID.TabIndex = 21;
            this.labID.Text = "Номер комнаты";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.BackToMain2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1291, 101);
            this.panel2.TabIndex = 18;
            // 
            // BackToMain2
            // 
            this.BackToMain2.AutoSize = true;
            this.BackToMain2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.BackToMain2.Location = new System.Drawing.Point(12, 9);
            this.BackToMain2.Name = "BackToMain2";
            this.BackToMain2.Size = new System.Drawing.Size(168, 20);
            this.BackToMain2.TabIndex = 1;
            this.BackToMain2.Text = "← В Главное меню";
            this.BackToMain2.Click += new System.EventHandler(this.BackToMain2_Click_1);
            this.BackToMain2.MouseEnter += new System.EventHandler(this.BackToMain2_MouseEnter);
            this.BackToMain2.MouseLeave += new System.EventHandler(this.BackToMain2_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1291, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Управление номерами";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(209, 209);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(195, 28);
            this.comboBoxType.TabIndex = 38;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Location = new System.Drawing.Point(209, 258);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(195, 28);
            this.comboBoxCount.TabIndex = 39;
            // 
            // lableFree
            // 
            this.lableFree.AutoSize = true;
            this.lableFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.lableFree.Location = new System.Drawing.Point(38, 367);
            this.lableFree.Name = "lableFree";
            this.lableFree.Size = new System.Drawing.Size(93, 20);
            this.lableFree.TabIndex = 41;
            this.lableFree.Text = "Свободен";
            // 
            // labCountClient
            // 
            this.labCountClient.AutoSize = true;
            this.labCountClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.labCountClient.Location = new System.Drawing.Point(38, 258);
            this.labCountClient.Name = "labCountClient";
            this.labCountClient.Size = new System.Drawing.Size(170, 40);
            this.labCountClient.TabIndex = 43;
            this.labCountClient.Text = "Количество мест в\r\n комнате";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(38, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Телефон";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbPhone.Location = new System.Drawing.Point(209, 317);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(195, 27);
            this.tbPhone.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.radioButNO);
            this.panel1.Controls.Add(this.radioButYes);
            this.panel1.Location = new System.Drawing.Point(209, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 35);
            this.panel1.TabIndex = 46;
            // 
            // radioButNO
            // 
            this.radioButNO.AutoSize = true;
            this.radioButNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButNO.Location = new System.Drawing.Point(60, 5);
            this.radioButNO.Name = "radioButNO";
            this.radioButNO.Size = new System.Drawing.Size(66, 24);
            this.radioButNO.TabIndex = 47;
            this.radioButNO.TabStop = true;
            this.radioButNO.Text = "Нет";
            this.radioButNO.UseVisualStyleBackColor = true;
            // 
            // radioButYes
            // 
            this.radioButYes.AutoSize = true;
            this.radioButYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButYes.Location = new System.Drawing.Point(3, 3);
            this.radioButYes.Name = "radioButYes";
            this.radioButYes.Size = new System.Drawing.Size(55, 24);
            this.radioButYes.TabIndex = 0;
            this.radioButYes.TabStop = true;
            this.radioButYes.Text = "Да";
            this.radioButYes.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 470);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 47;
            // 
            // ManageRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 716);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labCountClient);
            this.Controls.Add(this.lableFree);
            this.Controls.Add(this.comboBoxCount);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonRemoveR);
            this.Controls.Add(this.buttonClearFR);
            this.Controls.Add(this.buttonEditR);
            this.Controls.Add(this.buttonAddR);
            this.Controls.Add(this.dataGridViewRooms);
            this.Controls.Add(this.labTypeRoom);
            this.Controls.Add(this.labPatronymic);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRoom";
            this.Load += new System.EventHandler(this.ManageRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveR;
        private System.Windows.Forms.Button buttonClearFR;
        private System.Windows.Forms.Button buttonEditR;
        private System.Windows.Forms.Button buttonAddR;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Label labTypeRoom;
        private System.Windows.Forms.Label labPatronymic;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BackToMain2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxCount;
        private System.Windows.Forms.Label lableFree;
        private System.Windows.Forms.Label labCountClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButNO;
        private System.Windows.Forms.RadioButton radioButYes;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}