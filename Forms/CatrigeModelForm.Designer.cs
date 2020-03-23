namespace PrintPro.Forms
{
    partial class CatrigeModelForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PrinterModelCB = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ColorCB = new MetroFramework.Controls.MetroComboBox();
            this.CatrigeModelNameTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.LabID = new MetroFramework.Controls.MetroLabel();
            this.dgvModelCatrige = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelCatrige)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.PrinterModelCB);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.SaveBtn);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.ColorCB);
            this.metroPanel1.Controls.Add(this.CatrigeModelNameTB);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.LabID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(50, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(528, 288);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 150);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Модель принтера:";
            // 
            // PrinterModelCB
            // 
            this.PrinterModelCB.FormattingEnabled = true;
            this.PrinterModelCB.ItemHeight = 23;
            this.PrinterModelCB.Location = new System.Drawing.Point(190, 140);
            this.PrinterModelCB.Name = "PrinterModelCB";
            this.PrinterModelCB.Size = new System.Drawing.Size(282, 29);
            this.PrinterModelCB.TabIndex = 10;
            this.PrinterModelCB.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(382, 188);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(90, 37);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Очистить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(286, 188);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(90, 37);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Удалить";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(190, 188);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 37);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Цвет:";
            // 
            // ColorCB
            // 
            this.ColorCB.FormattingEnabled = true;
            this.ColorCB.ItemHeight = 23;
            this.ColorCB.Location = new System.Drawing.Point(190, 90);
            this.ColorCB.Name = "ColorCB";
            this.ColorCB.Size = new System.Drawing.Size(282, 29);
            this.ColorCB.TabIndex = 5;
            this.ColorCB.UseSelectable = true;
            // 
            // CatrigeModelNameTB
            // 
            // 
            // 
            // 
            this.CatrigeModelNameTB.CustomButton.Image = null;
            this.CatrigeModelNameTB.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.CatrigeModelNameTB.CustomButton.Name = "";
            this.CatrigeModelNameTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CatrigeModelNameTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CatrigeModelNameTB.CustomButton.TabIndex = 1;
            this.CatrigeModelNameTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CatrigeModelNameTB.CustomButton.UseSelectable = true;
            this.CatrigeModelNameTB.CustomButton.Visible = false;
            this.CatrigeModelNameTB.Lines = new string[0];
            this.CatrigeModelNameTB.Location = new System.Drawing.Point(190, 45);
            this.CatrigeModelNameTB.MaxLength = 32767;
            this.CatrigeModelNameTB.Name = "CatrigeModelNameTB";
            this.CatrigeModelNameTB.PasswordChar = '\0';
            this.CatrigeModelNameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CatrigeModelNameTB.SelectedText = "";
            this.CatrigeModelNameTB.SelectionLength = 0;
            this.CatrigeModelNameTB.SelectionStart = 0;
            this.CatrigeModelNameTB.ShortcutsEnabled = true;
            this.CatrigeModelNameTB.Size = new System.Drawing.Size(282, 23);
            this.CatrigeModelNameTB.TabIndex = 4;
            this.CatrigeModelNameTB.UseSelectable = true;
            this.CatrigeModelNameTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CatrigeModelNameTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Название модели:";
            // 
            // LabID
            // 
            this.LabID.AutoSize = true;
            this.LabID.Location = new System.Drawing.Point(190, 21);
            this.LabID.Name = "LabID";
            this.LabID.Size = new System.Drawing.Size(16, 19);
            this.LabID.TabIndex = 2;
            this.LabID.Text = "0";
            // 
            // dgvModelCatrige
            // 
            this.dgvModelCatrige.AllowUserToResizeRows = false;
            this.dgvModelCatrige.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvModelCatrige.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModelCatrige.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvModelCatrige.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModelCatrige.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModelCatrige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModelCatrige.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModelCatrige.EnableHeadersVisualStyles = false;
            this.dgvModelCatrige.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvModelCatrige.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvModelCatrige.Location = new System.Drawing.Point(50, 392);
            this.dgvModelCatrige.Name = "dgvModelCatrige";
            this.dgvModelCatrige.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModelCatrige.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvModelCatrige.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvModelCatrige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelCatrige.Size = new System.Drawing.Size(528, 184);
            this.dgvModelCatrige.TabIndex = 1;
            this.dgvModelCatrige.SelectionChanged += new System.EventHandler(this.dgvModelCatrige_SelectionChanged);
            // 
            // CatrigeModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 618);
            this.Controls.Add(this.dgvModelCatrige);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CatrigeModelForm";
            this.Text = "Модель картриджа";
            this.Load += new System.EventHandler(this.CatrigeModelForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelCatrige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton SaveBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox ColorCB;
        private MetroFramework.Controls.MetroTextBox CatrigeModelNameTB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel LabID;
        private MetroFramework.Controls.MetroGrid dgvModelCatrige;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox PrinterModelCB;
    }
}