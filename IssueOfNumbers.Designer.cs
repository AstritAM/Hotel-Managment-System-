namespace WindowsFormsApp1
{
    partial class IssueOfNumbers
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
            this.labCountClient = new System.Windows.Forms.Label();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbidres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNumR = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerIN = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOUT = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCountClient
            // 
            this.labCountClient.AutoSize = true;
            this.labCountClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.labCountClient.Location = new System.Drawing.Point(22, 318);
            this.labCountClient.Name = "labCountClient";
            this.labCountClient.Size = new System.Drawing.Size(170, 40);
            this.labCountClient.TabIndex = 60;
            this.labCountClient.Text = "Количество мест в\r\n комнате";
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Location = new System.Drawing.Point(209, 318);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(195, 28);
            this.comboBoxCount.TabIndex = 58;
            this.comboBoxCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxCount_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(209, 271);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(195, 28);
            this.comboBoxType.TabIndex = 57;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
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
            this.buttonRemoveR.Location = new System.Drawing.Point(42, 651);
            this.buttonRemoveR.Name = "buttonRemoveR";
            this.buttonRemoveR.Size = new System.Drawing.Size(162, 41);
            this.buttonRemoveR.TabIndex = 56;
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
            this.buttonClearFR.Location = new System.Drawing.Point(232, 651);
            this.buttonClearFR.Name = "buttonClearFR";
            this.buttonClearFR.Size = new System.Drawing.Size(164, 41);
            this.buttonClearFR.TabIndex = 55;
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
            this.buttonEditR.Location = new System.Drawing.Point(232, 566);
            this.buttonEditR.Name = "buttonEditR";
            this.buttonEditR.Size = new System.Drawing.Size(164, 45);
            this.buttonEditR.TabIndex = 54;
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
            this.buttonAddR.Location = new System.Drawing.Point(42, 566);
            this.buttonAddR.Name = "buttonAddR";
            this.buttonAddR.Size = new System.Drawing.Size(162, 45);
            this.buttonAddR.TabIndex = 53;
            this.buttonAddR.Text = "Добавить";
            this.buttonAddR.UseVisualStyleBackColor = false;
            this.buttonAddR.Click += new System.EventHandler(this.buttonAddR_Click);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(445, 151);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 24;
            this.dataGridViewRooms.Size = new System.Drawing.Size(800, 550);
            this.dataGridViewRooms.TabIndex = 49;
            this.dataGridViewRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellClick);
            this.dataGridViewRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellContentClick);
            // 
            // labTypeRoom
            // 
            this.labTypeRoom.AutoSize = true;
            this.labTypeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.labTypeRoom.Location = new System.Drawing.Point(22, 272);
            this.labTypeRoom.Name = "labTypeRoom";
            this.labTypeRoom.Size = new System.Drawing.Size(117, 20);
            this.labTypeRoom.TabIndex = 52;
            this.labTypeRoom.Text = "Тип комнаты";
            // 
            // labPatronymic
            // 
            this.labPatronymic.AutoSize = true;
            this.labPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.labPatronymic.Location = new System.Drawing.Point(47, 318);
            this.labPatronymic.Name = "labPatronymic";
            this.labPatronymic.Size = new System.Drawing.Size(0, 20);
            this.labPatronymic.TabIndex = 51;
            // 
            // tbid
            // 
            this.tbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbid.Location = new System.Drawing.Point(209, 165);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(195, 27);
            this.tbid.TabIndex = 48;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.labID.Location = new System.Drawing.Point(38, 165);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(0, 20);
            this.labID.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.BackToMain2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1286, 101);
            this.panel2.TabIndex = 47;
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
            this.BackToMain2.Click += new System.EventHandler(this.BackToMain2_Click);
            this.BackToMain2.MouseEnter += new System.EventHandler(this.BackToMain2_MouseEnter_1);
            this.BackToMain2.MouseLeave += new System.EventHandler(this.BackToMain2_MouseLeave_1);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1286, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Зарезервировать номер";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(22, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Номер посетителя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(22, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Номер резервирования";
            // 
            // tbidres
            // 
            this.tbidres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbidres.Location = new System.Drawing.Point(210, 219);
            this.tbidres.Name = "tbidres";
            this.tbidres.Size = new System.Drawing.Size(195, 27);
            this.tbidres.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(39, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 65;
            // 
            // comboBoxNumR
            // 
            this.comboBoxNumR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNumR.FormattingEnabled = true;
            this.comboBoxNumR.Location = new System.Drawing.Point(208, 374);
            this.comboBoxNumR.Name = "comboBoxNumR";
            this.comboBoxNumR.Size = new System.Drawing.Size(195, 28);
            this.comboBoxNumR.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(22, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Номер комнаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(47, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Дата выселения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(47, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "Дата вселения";
            // 
            // dateTimePickerIN
            // 
            this.dateTimePickerIN.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dateTimePickerIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIN.Location = new System.Drawing.Point(232, 453);
            this.dateTimePickerIN.Name = "dateTimePickerIN";
            this.dateTimePickerIN.Size = new System.Drawing.Size(164, 27);
            this.dateTimePickerIN.TabIndex = 71;
            // 
            // dateTimePickerOUT
            // 
            this.dateTimePickerOUT.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dateTimePickerOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOUT.Location = new System.Drawing.Point(232, 499);
            this.dateTimePickerOUT.Name = "dateTimePickerOUT";
            this.dateTimePickerOUT.Size = new System.Drawing.Size(164, 27);
            this.dateTimePickerOUT.TabIndex = 72;
            // 
            // IssueOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 716);
            this.Controls.Add(this.dateTimePickerOUT);
            this.Controls.Add(this.dateTimePickerIN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxNumR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbidres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labCountClient);
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
            this.Name = "IssueOfNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueOfNumbers";
            this.Load += new System.EventHandler(this.IssueOfNumbers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCountClient;
        private System.Windows.Forms.ComboBox comboBoxCount;
        private System.Windows.Forms.ComboBox comboBoxType;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbidres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNumR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerIN;
        private System.Windows.Forms.DateTimePicker dateTimePickerOUT;
    }
}