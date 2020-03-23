namespace PrintPro
{
    partial class PrinterFirmForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrinterFirmList = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.PrinterFirmIDLab = new MetroFramework.Controls.MetroLabel();
            this.PrinterFirmNameTB = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterFirmList)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrinterFirmList
            // 
            this.dgvPrinterFirmList.AllowUserToResizeRows = false;
            this.dgvPrinterFirmList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterFirmList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinterFirmList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrinterFirmList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterFirmList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrinterFirmList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrinterFirmList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrinterFirmList.EnableHeadersVisualStyles = false;
            this.dgvPrinterFirmList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrinterFirmList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterFirmList.Location = new System.Drawing.Point(128, 260);
            this.dgvPrinterFirmList.Name = "dgvPrinterFirmList";
            this.dgvPrinterFirmList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterFirmList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrinterFirmList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrinterFirmList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinterFirmList.Size = new System.Drawing.Size(251, 225);
            this.dgvPrinterFirmList.TabIndex = 1;
            this.dgvPrinterFirmList.SelectionChanged += new System.EventHandler(this.dgvPrinterFirmList_SelectionChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.deleteBtn);
            this.metroPanel1.Controls.Add(this.saveBtn);
            this.metroPanel1.Controls.Add(this.PrinterFirmIDLab);
            this.metroPanel1.Controls.Add(this.PrinterFirmNameTB);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(489, 161);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(307, 98);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 34);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Очистить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(189, 98);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 34);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(71, 98);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 34);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // PrinterFirmIDLab
            // 
            this.PrinterFirmIDLab.AutoSize = true;
            this.PrinterFirmIDLab.Location = new System.Drawing.Point(99, 13);
            this.PrinterFirmIDLab.Name = "PrinterFirmIDLab";
            this.PrinterFirmIDLab.Size = new System.Drawing.Size(16, 19);
            this.PrinterFirmIDLab.TabIndex = 5;
            this.PrinterFirmIDLab.Text = "0";
            // 
            // PrinterFirmNameTB
            // 
            // 
            // 
            // 
            this.PrinterFirmNameTB.CustomButton.Image = null;
            this.PrinterFirmNameTB.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.PrinterFirmNameTB.CustomButton.Name = "";
            this.PrinterFirmNameTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PrinterFirmNameTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PrinterFirmNameTB.CustomButton.TabIndex = 1;
            this.PrinterFirmNameTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrinterFirmNameTB.CustomButton.UseSelectable = true;
            this.PrinterFirmNameTB.CustomButton.Visible = false;
            this.PrinterFirmNameTB.Lines = new string[0];
            this.PrinterFirmNameTB.Location = new System.Drawing.Point(99, 52);
            this.PrinterFirmNameTB.MaxLength = 32767;
            this.PrinterFirmNameTB.Name = "PrinterFirmNameTB";
            this.PrinterFirmNameTB.PasswordChar = '\0';
            this.PrinterFirmNameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PrinterFirmNameTB.SelectedText = "";
            this.PrinterFirmNameTB.SelectionLength = 0;
            this.PrinterFirmNameTB.SelectionStart = 0;
            this.PrinterFirmNameTB.ShortcutsEnabled = true;
            this.PrinterFirmNameTB.Size = new System.Drawing.Size(320, 23);
            this.PrinterFirmNameTB.TabIndex = 4;
            this.PrinterFirmNameTB.UseSelectable = true;
            this.PrinterFirmNameTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PrinterFirmNameTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PrinterFirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 517);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dgvPrinterFirmList);
            this.Name = "PrinterFirmForm";
            this.Text = "Фирмы принтеров";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterFirmList)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvPrinterFirmList;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroLabel PrinterFirmIDLab;
        private MetroFramework.Controls.MetroTextBox PrinterFirmNameTB;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

