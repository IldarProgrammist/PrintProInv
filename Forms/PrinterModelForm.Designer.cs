namespace PrintPro.Forms
{
    partial class PrinterModelForm
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
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.PrinterModelNameTB = new MetroFramework.Controls.MetroTextBox();
            this.PrinterFirmNameCB = new MetroFramework.Controls.MetroComboBox();
            this.PrinterModelIDLab = new MetroFramework.Controls.MetroLabel();
            this.dgvPrinterModelList = new MetroFramework.Controls.MetroGrid();
            this.ClearBtn = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterModelList)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnDelete);
            this.metroPanel1.Controls.Add(this.ClearBtn);
            this.metroPanel1.Controls.Add(this.saveBtn);
            this.metroPanel1.Controls.Add(this.PrinterModelNameTB);
            this.metroPanel1.Controls.Add(this.PrinterFirmNameCB);
            this.metroPanel1.Controls.Add(this.PrinterModelIDLab);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(560, 213);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(125, 155);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 33);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // PrinterModelNameTB
            // 
            // 
            // 
            // 
            this.PrinterModelNameTB.CustomButton.Image = null;
            this.PrinterModelNameTB.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.PrinterModelNameTB.CustomButton.Name = "";
            this.PrinterModelNameTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PrinterModelNameTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PrinterModelNameTB.CustomButton.TabIndex = 1;
            this.PrinterModelNameTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrinterModelNameTB.CustomButton.UseSelectable = true;
            this.PrinterModelNameTB.CustomButton.Visible = false;
            this.PrinterModelNameTB.Lines = new string[0];
            this.PrinterModelNameTB.Location = new System.Drawing.Point(125, 64);
            this.PrinterModelNameTB.MaxLength = 32767;
            this.PrinterModelNameTB.Name = "PrinterModelNameTB";
            this.PrinterModelNameTB.PasswordChar = '\0';
            this.PrinterModelNameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PrinterModelNameTB.SelectedText = "";
            this.PrinterModelNameTB.SelectionLength = 0;
            this.PrinterModelNameTB.SelectionStart = 0;
            this.PrinterModelNameTB.ShortcutsEnabled = true;
            this.PrinterModelNameTB.Size = new System.Drawing.Size(306, 23);
            this.PrinterModelNameTB.TabIndex = 7;
            this.PrinterModelNameTB.UseSelectable = true;
            this.PrinterModelNameTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PrinterModelNameTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PrinterFirmNameCB
            // 
            this.PrinterFirmNameCB.FormattingEnabled = true;
            this.PrinterFirmNameCB.ItemHeight = 23;
            this.PrinterFirmNameCB.Location = new System.Drawing.Point(125, 111);
            this.PrinterFirmNameCB.Name = "PrinterFirmNameCB";
            this.PrinterFirmNameCB.Size = new System.Drawing.Size(306, 29);
            this.PrinterFirmNameCB.TabIndex = 5;
            this.PrinterFirmNameCB.UseSelectable = true;
            // 
            // PrinterModelIDLab
            // 
            this.PrinterModelIDLab.AutoSize = true;
            this.PrinterModelIDLab.Location = new System.Drawing.Point(125, 25);
            this.PrinterModelIDLab.Name = "PrinterModelIDLab";
            this.PrinterModelIDLab.Size = new System.Drawing.Size(16, 19);
            this.PrinterModelIDLab.TabIndex = 4;
            this.PrinterModelIDLab.Text = "0";
            // 
            // dgvPrinterModelList
            // 
            this.dgvPrinterModelList.AllowUserToResizeRows = false;
            this.dgvPrinterModelList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterModelList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinterModelList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrinterModelList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterModelList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrinterModelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrinterModelList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrinterModelList.EnableHeadersVisualStyles = false;
            this.dgvPrinterModelList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrinterModelList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterModelList.Location = new System.Drawing.Point(23, 294);
            this.dgvPrinterModelList.Name = "dgvPrinterModelList";
            this.dgvPrinterModelList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterModelList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrinterModelList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrinterModelList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinterModelList.Size = new System.Drawing.Size(471, 199);
            this.dgvPrinterModelList.TabIndex = 1;
            this.dgvPrinterModelList.SelectionChanged += new System.EventHandler(this.dgvPrinterModelList_SelectionChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(234, 155);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(94, 33);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseSelectable = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(337, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PrinterModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 528);
            this.Controls.Add(this.dgvPrinterModelList);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PrinterModelForm";
            this.Text = "PrinterModel";
            this.Load += new System.EventHandler(this.PrinterModel_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterModelList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroTextBox PrinterModelNameTB;
        private MetroFramework.Controls.MetroComboBox PrinterFirmNameCB;
        private MetroFramework.Controls.MetroLabel PrinterModelIDLab;
        private MetroFramework.Controls.MetroGrid dgvPrinterModelList;
        private MetroFramework.Controls.MetroButton ClearBtn;
        private MetroFramework.Controls.MetroButton btnDelete;
    }
}