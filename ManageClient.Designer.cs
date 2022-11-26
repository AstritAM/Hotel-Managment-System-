namespace WindowsFormsApp1
{
    partial class ManageClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClearF = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbContry = new System.Windows.Forms.TextBox();
            this.labCountry = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.labDOB = new System.Windows.Forms.Label();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.labLastNme = new System.Windows.Forms.Label();
            this.tbPName = new System.Windows.Forms.TextBox();
            this.labPassport = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.labPatronymic = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackToMain1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonClearF);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tbContry);
            this.panel1.Controls.Add(this.labCountry);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.labDOB);
            this.panel1.Controls.Add(this.tbLName);
            this.panel1.Controls.Add(this.labLastNme);
            this.panel1.Controls.Add(this.tbPName);
            this.panel1.Controls.Add(this.labPassport);
            this.panel1.Controls.Add(this.tbPass);
            this.panel1.Controls.Add(this.labPatronymic);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.labName);
            this.panel1.Controls.Add(this.tbid);
            this.panel1.Controls.Add(this.labID);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 716);
            this.panel1.TabIndex = 0;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRemove.FlatAppearance.BorderSize = 2;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Italic);
            this.buttonRemove.Location = new System.Drawing.Point(51, 619);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(162, 41);
            this.buttonRemove.TabIndex = 17;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClearF
            // 
            this.buttonClearF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.buttonClearF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClearF.FlatAppearance.BorderSize = 2;
            this.buttonClearF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonClearF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearF.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Italic);
            this.buttonClearF.Location = new System.Drawing.Point(232, 619);
            this.buttonClearF.Name = "buttonClearF";
            this.buttonClearF.Size = new System.Drawing.Size(164, 41);
            this.buttonClearF.TabIndex = 16;
            this.buttonClearF.Text = "Очистить поля";
            this.buttonClearF.UseVisualStyleBackColor = false;
            this.buttonClearF.Click += new System.EventHandler(this.buttonClearF_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Italic);
            this.buttonEdit.Location = new System.Drawing.Point(232, 534);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(164, 45);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Italic);
            this.buttonAdd.Location = new System.Drawing.Point(51, 534);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(162, 45);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 550);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbContry
            // 
            this.tbContry.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F);
            this.tbContry.Location = new System.Drawing.Point(201, 423);
            this.tbContry.Name = "tbContry";
            this.tbContry.Size = new System.Drawing.Size(195, 31);
            this.tbContry.TabIndex = 13;
            // 
            // labCountry
            // 
            this.labCountry.AutoSize = true;
            this.labCountry.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.labCountry.Location = new System.Drawing.Point(29, 426);
            this.labCountry.Name = "labCountry";
            this.labCountry.Size = new System.Drawing.Size(68, 23);
            this.labCountry.TabIndex = 12;
            this.labCountry.Text = "Страна";
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F);
            this.tbAge.Location = new System.Drawing.Point(201, 328);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(195, 31);
            this.tbAge.TabIndex = 11;
            this.tbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAge_KeyPress);
            // 
            // labDOB
            // 
            this.labDOB.AutoSize = true;
            this.labDOB.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.labDOB.Location = new System.Drawing.Point(29, 331);
            this.labDOB.Name = "labDOB";
            this.labDOB.Size = new System.Drawing.Size(74, 23);
            this.labDOB.TabIndex = 10;
            this.labDOB.Text = "Возраст";
            // 
            // tbLName
            // 
            this.tbLName.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F);
            this.tbLName.Location = new System.Drawing.Point(201, 238);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(195, 31);
            this.tbLName.TabIndex = 8;
            // 
            // labLastNme
            // 
            this.labLastNme.AutoSize = true;
            this.labLastNme.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.labLastNme.Location = new System.Drawing.Point(29, 238);
            this.labLastNme.Name = "labLastNme";
            this.labLastNme.Size = new System.Drawing.Size(79, 23);
            this.labLastNme.TabIndex = 9;
            this.labLastNme.Text = "Фамилия";
            // 
            // tbPName
            // 
            this.tbPName.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F);
            this.tbPName.Location = new System.Drawing.Point(201, 282);
            this.tbPName.Name = "tbPName";
            this.tbPName.Size = new System.Drawing.Size(195, 31);
            this.tbPName.TabIndex = 6;
            // 
            // labPassport
            // 
            this.labPassport.AutoSize = true;
            this.labPassport.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.labPassport.Location = new System.Drawing.Point(29, 362);
            this.labPassport.Name = "labPassport";
            this.labPassport.Size = new System.Drawing.Size(104, 46);
            this.labPassport.TabIndex = 7;
            this.labPassport.Text = "Паспортные\r\nданные";
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F);
            this.tbPass.Location = new System.Drawing.Point(201, 377);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(195, 31);
            this.tbPass.TabIndex = 4;
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPass_KeyPress);
            // 
            // labPatronymic
            // 
            this.labPatronymic.AutoSize = true;
            this.labPatronymic.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.labPatronymic.Location = new System.Drawing.Point(28, 285);
            this.labPatronymic.Name = "labPatronymic";
            this.labPatronymic.Size = new System.Drawing.Size(87, 23);
            this.labPatronymic.TabIndex = 5;
            this.labPatronymic.Text = "Отчество";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F);
            this.tbName.Location = new System.Drawing.Point(201, 186);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(195, 31);
            this.tbName.TabIndex = 2;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.labName.Location = new System.Drawing.Point(29, 186);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(44, 23);
            this.labName.TabIndex = 3;
            this.labName.Text = "Имя";
            // 
            // tbid
            // 
            this.tbid.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F);
            this.tbid.Location = new System.Drawing.Point(201, 135);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(195, 31);
            this.tbid.TabIndex = 1;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.labID.Location = new System.Drawing.Point(29, 138);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(156, 23);
            this.labID.TabIndex = 1;
            this.labID.Text = "Номер посетителя";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(198)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.BackToMain1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 101);
            this.panel2.TabIndex = 0;
            // 
            // BackToMain1
            // 
            this.BackToMain1.AutoSize = true;
            this.BackToMain1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMain1.Font = new System.Drawing.Font("Noto Serif Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.BackToMain1.Location = new System.Drawing.Point(12, 9);
            this.BackToMain1.Name = "BackToMain1";
            this.BackToMain1.Size = new System.Drawing.Size(146, 23);
            this.BackToMain1.TabIndex = 1;
            this.BackToMain1.Text = "← В Главное меню";
            this.BackToMain1.Click += new System.EventHandler(this.BackToMain1_Click);
            this.BackToMain1.MouseEnter += new System.EventHandler(this.BackToMain1_MouseEnter);
            this.BackToMain1.MouseLeave += new System.EventHandler(this.BackToMain1_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Noto Serif Cond", 25.8F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1306, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Управление посетителями";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 716);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageClient";
            this.Load += new System.EventHandler(this.ManageClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.Label labLastNme;
        private System.Windows.Forms.TextBox tbPName;
        private System.Windows.Forms.Label labPassport;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label labPatronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TextBox tbContry;
        private System.Windows.Forms.Label labCountry;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label labDOB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label BackToMain1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClearF;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}