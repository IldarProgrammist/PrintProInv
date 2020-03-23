namespace PrintPro.Forms
{
    partial class CatrigeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.dgvCatriges = new MetroFramework.Controls.MetroGrid();
            this.CatrigeModelCB = new MetroFramework.Controls.MetroComboBox();
            this.LabID = new MetroFramework.Controls.MetroLabel();
            this.SerialNumberTB = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatriges)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(163, 156);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 38);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dgvCatriges
            // 
            this.dgvCatriges.AllowUserToResizeRows = false;
            this.dgvCatriges.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatriges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatriges.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCatriges.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatriges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatriges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatriges.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatriges.EnableHeadersVisualStyles = false;
            this.dgvCatriges.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCatriges.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatriges.Location = new System.Drawing.Point(34, 341);
            this.dgvCatriges.Name = "dgvCatriges";
            this.dgvCatriges.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatriges.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatriges.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCatriges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatriges.Size = new System.Drawing.Size(408, 150);
            this.dgvCatriges.TabIndex = 1;
            this.dgvCatriges.SelectionChanged += new System.EventHandler(this.dgvCatriges_SelectionChanged);
            // 
            // CatrigeModelCB
            // 
            this.CatrigeModelCB.AccessibleDescription = "";
            this.CatrigeModelCB.FormattingEnabled = true;
            this.CatrigeModelCB.ItemHeight = 23;
            this.CatrigeModelCB.Location = new System.Drawing.Point(163, 109);
            this.CatrigeModelCB.Name = "CatrigeModelCB";
            this.CatrigeModelCB.Size = new System.Drawing.Size(382, 29);
            this.CatrigeModelCB.TabIndex = 2;
            this.CatrigeModelCB.UseSelectable = true;
            // 
            // LabID
            // 
            this.LabID.AutoSize = true;
            this.LabID.Location = new System.Drawing.Point(163, 17);
            this.LabID.Name = "LabID";
            this.LabID.Size = new System.Drawing.Size(16, 19);
            this.LabID.TabIndex = 3;
            this.LabID.Text = "0";
            // 
            // SerialNumberTB
            // 
            // 
            // 
            // 
            this.SerialNumberTB.CustomButton.Image = null;
            this.SerialNumberTB.CustomButton.Location = new System.Drawing.Point(360, 1);
            this.SerialNumberTB.CustomButton.Name = "";
            this.SerialNumberTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SerialNumberTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SerialNumberTB.CustomButton.TabIndex = 1;
            this.SerialNumberTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SerialNumberTB.CustomButton.UseSelectable = true;
            this.SerialNumberTB.CustomButton.Visible = false;
            this.SerialNumberTB.Lines = new string[0];
            this.SerialNumberTB.Location = new System.Drawing.Point(163, 66);
            this.SerialNumberTB.MaxLength = 32767;
            this.SerialNumberTB.Name = "SerialNumberTB";
            this.SerialNumberTB.PasswordChar = '\0';
            this.SerialNumberTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SerialNumberTB.SelectedText = "";
            this.SerialNumberTB.SelectionLength = 0;
            this.SerialNumberTB.SelectionStart = 0;
            this.SerialNumberTB.ShortcutsEnabled = true;
            this.SerialNumberTB.Size = new System.Drawing.Size(382, 23);
            this.SerialNumberTB.TabIndex = 4;
            this.SerialNumberTB.UseSelectable = true;
            this.SerialNumberTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SerialNumberTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.deleteBtn);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.CatrigeModelCB);
            this.metroPanel1.Controls.Add(this.SerialNumberTB);
            this.metroPanel1.Controls.Add(this.saveBtn);
            this.metroPanel1.Controls.Add(this.LabID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(34, 76);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(622, 227);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(296, 156);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 38);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Модель картриджа:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Серийный номер:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(433, 156);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 38);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Очистить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CatrigeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 514);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dgvCatriges);
            this.Name = "CatrigeForm";
            this.Text = "Картриджи";
            this.Load += new System.EventHandler(this.Catrige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatriges)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroGrid dgvCatriges;
        private MetroFramework.Controls.MetroComboBox CatrigeModelCB;
        private MetroFramework.Controls.MetroLabel LabID;
        private MetroFramework.Controls.MetroTextBox SerialNumberTB;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}