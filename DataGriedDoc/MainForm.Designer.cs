
namespace DataGriedDoctor2HW
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
            this.doctorDataGried = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.doctorScrollBar = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGried)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorDataGried
            // 
            this.doctorDataGried.BackgroundColor = System.Drawing.Color.White;
            this.doctorDataGried.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGried.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColFirstName,
            this.colLastName,
            this.colDepartmentName});
            this.doctorDataGried.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.doctorDataGried.Location = new System.Drawing.Point(10, 68);
            this.doctorDataGried.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorDataGried.Name = "doctorDataGried";
            this.doctorDataGried.RowHeadersWidth = 51;
            this.doctorDataGried.RowTemplate.Height = 29;
            this.doctorDataGried.Size = new System.Drawing.Size(679, 201);
            this.doctorDataGried.TabIndex = 0;
            this.doctorDataGried.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorDataGried_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.Width = 60;
            // 
            // ColFirstName
            // 
            this.ColFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFirstName.HeaderText = "Ім\'я";
            this.ColFirstName.MinimumWidth = 6;
            this.ColFirstName.Name = "ColFirstName";
            // 
            // colLastName
            // 
            this.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLastName.HeaderText = "Прізвище";
            this.colLastName.MinimumWidth = 6;
            this.colLastName.Name = "colLastName";
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepartmentName.HeaderText = "Назва відділу";
            this.colDepartmentName.MinimumWidth = 6;
            this.colDepartmentName.Name = "colDepartmentName";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(231, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Список лікарів";
            // 
            // doctorScrollBar
            // 
            this.doctorScrollBar.Location = new System.Drawing.Point(10, 281);
            this.doctorScrollBar.Name = "doctorScrollBar";
            this.doctorScrollBar.Size = new System.Drawing.Size(679, 26);
            this.doctorScrollBar.SmallChange = 9;
            this.doctorScrollBar.TabIndex = 9;
            this.doctorScrollBar.ValueChanged += new System.EventHandler(this.doctorScrollBar_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 338);
            this.Controls.Add(this.doctorScrollBar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.doctorDataGried);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна сторінка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGried)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorDataGried;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentName;
        private System.Windows.Forms.HScrollBar doctorScrollBar;
    }
}