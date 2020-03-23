namespace PrintPro.Forms
{
    partial class PrinterOperationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.StatusCB = new MetroFramework.Controls.MetroComboBox();
            this.dataD = new MetroFramework.Controls.MetroDateTime();
            this.dgvPrinterOperation = new MetroFramework.Controls.MetroGrid();
            this.PrinterIDTB = new MetroFramework.Controls.MetroTextBox();
            this.labID = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dgvPrinterSearch = new MetroFramework.Controls.MetroGrid();
            this.searchSerialNamberTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(43, 278);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 39);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // StatusCB
            // 
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.ItemHeight = 23;
            this.StatusCB.Location = new System.Drawing.Point(43, 140);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(226, 29);
            this.StatusCB.TabIndex = 1;
            this.StatusCB.UseSelectable = true;
            // 
            // dataD
            // 
            this.dataD.Location = new System.Drawing.Point(43, 199);
            this.dataD.MinimumSize = new System.Drawing.Size(0, 29);
            this.dataD.Name = "dataD";
            this.dataD.Size = new System.Drawing.Size(226, 29);
            this.dataD.TabIndex = 2;
            // 
            // dgvPrinterOperation
            // 
            this.dgvPrinterOperation.AllowUserToResizeRows = false;
            this.dgvPrinterOperation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinterOperation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrinterOperation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterOperation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvPrinterOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrinterOperation.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvPrinterOperation.EnableHeadersVisualStyles = false;
            this.dgvPrinterOperation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrinterOperation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterOperation.Location = new System.Drawing.Point(57, 446);
            this.dgvPrinterOperation.Name = "dgvPrinterOperation";
            this.dgvPrinterOperation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterOperation.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvPrinterOperation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrinterOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinterOperation.Size = new System.Drawing.Size(526, 218);
            this.dgvPrinterOperation.TabIndex = 3;
            this.dgvPrinterOperation.SelectionChanged += new System.EventHandler(this.dgvPrinterOperation_SelectionChanged);
            // 
            // PrinterIDTB
            // 
            // 
            // 
            // 
            this.PrinterIDTB.CustomButton.Image = null;
            this.PrinterIDTB.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.PrinterIDTB.CustomButton.Name = "";
            this.PrinterIDTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PrinterIDTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PrinterIDTB.CustomButton.TabIndex = 1;
            this.PrinterIDTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrinterIDTB.CustomButton.UseSelectable = true;
            this.PrinterIDTB.CustomButton.Visible = false;
            this.PrinterIDTB.Lines = new string[0];
            this.PrinterIDTB.Location = new System.Drawing.Point(43, 96);
            this.PrinterIDTB.MaxLength = 32767;
            this.PrinterIDTB.Name = "PrinterIDTB";
            this.PrinterIDTB.PasswordChar = '\0';
            this.PrinterIDTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PrinterIDTB.SelectedText = "";
            this.PrinterIDTB.SelectionLength = 0;
            this.PrinterIDTB.SelectionStart = 0;
            this.PrinterIDTB.ShortcutsEnabled = true;
            this.PrinterIDTB.Size = new System.Drawing.Size(226, 23);
            this.PrinterIDTB.TabIndex = 4;
            this.PrinterIDTB.UseSelectable = true;
            this.PrinterIDTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PrinterIDTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(43, 54);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(16, 19);
            this.labID.TabIndex = 5;
            this.labID.Text = "0";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(179, 278);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 39);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Очистить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dgvPrinterSearch
            // 
            this.dgvPrinterSearch.AllowUserToResizeRows = false;
            this.dgvPrinterSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinterSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrinterSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvPrinterSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrinterSearch.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvPrinterSearch.EnableHeadersVisualStyles = false;
            this.dgvPrinterSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrinterSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterSearch.Location = new System.Drawing.Point(314, 96);
            this.dgvPrinterSearch.Name = "dgvPrinterSearch";
            this.dgvPrinterSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvPrinterSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrinterSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinterSearch.Size = new System.Drawing.Size(602, 206);
            this.dgvPrinterSearch.TabIndex = 7;
            this.dgvPrinterSearch.SelectionChanged += new System.EventHandler(this.dgvPrinterSearch_SelectionChanged);
            // 
            // searchSerialNamberTB
            // 
            // 
            // 
            // 
            this.searchSerialNamberTB.CustomButton.Image = null;
            this.searchSerialNamberTB.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.searchSerialNamberTB.CustomButton.Name = "";
            this.searchSerialNamberTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchSerialNamberTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchSerialNamberTB.CustomButton.TabIndex = 1;
            this.searchSerialNamberTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchSerialNamberTB.CustomButton.UseSelectable = true;
            this.searchSerialNamberTB.CustomButton.Visible = false;
            this.searchSerialNamberTB.Lines = new string[0];
            this.searchSerialNamberTB.Location = new System.Drawing.Point(187, 386);
            this.searchSerialNamberTB.MaxLength = 32767;
            this.searchSerialNamberTB.Name = "searchSerialNamberTB";
            this.searchSerialNamberTB.PasswordChar = '\0';
            this.searchSerialNamberTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchSerialNamberTB.SelectedText = "";
            this.searchSerialNamberTB.SelectionLength = 0;
            this.searchSerialNamberTB.SelectionStart = 0;
            this.searchSerialNamberTB.ShortcutsEnabled = true;
            this.searchSerialNamberTB.Size = new System.Drawing.Size(246, 23);
            this.searchSerialNamberTB.TabIndex = 8;
            this.searchSerialNamberTB.UseSelectable = true;
            this.searchSerialNamberTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchSerialNamberTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchSerialNamberTB.Click += new System.EventHandler(this.searchTB_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(57, 388);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Серийный номер:";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(451, 386);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // PrinterOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 757);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.searchSerialNamberTB);
            this.Controls.Add(this.dgvPrinterSearch);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.PrinterIDTB);
            this.Controls.Add(this.dgvPrinterOperation);
            this.Controls.Add(this.dataD);
            this.Controls.Add(this.StatusCB);
            this.Controls.Add(this.saveBtn);
            this.Name = "PrinterOperationForm";
            this.Text = "PrinterOperation";
            this.Load += new System.EventHandler(this.PrinterOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroComboBox StatusCB;
        private MetroFramework.Controls.MetroDateTime dataD;
        private MetroFramework.Controls.MetroGrid dgvPrinterOperation;
        private MetroFramework.Controls.MetroTextBox PrinterIDTB;
        private MetroFramework.Controls.MetroLabel labID;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid dgvPrinterSearch;
        private MetroFramework.Controls.MetroTextBox searchSerialNamberTB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}