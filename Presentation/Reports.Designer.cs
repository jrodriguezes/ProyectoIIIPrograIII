namespace Presentation
{
    partial class Reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.rdRep1 = new System.Windows.Forms.RadioButton();
            this.rdRep2 = new System.Windows.Forms.RadioButton();
            this.rdRep3 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 85);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdRep3);
            this.groupBox1.Controls.Add(this.rdRep2);
            this.groupBox1.Controls.Add(this.rdRep1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvReports
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReports.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.EnableHeadersVisualStyles = false;
            this.dgvReports.Location = new System.Drawing.Point(0, 85);
            this.dgvReports.Name = "dgvReports";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReports.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReports.Size = new System.Drawing.Size(684, 476);
            this.dgvReports.TabIndex = 24;
            // 
            // rdRep1
            // 
            this.rdRep1.AutoSize = true;
            this.rdRep1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdRep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdRep1.Location = new System.Drawing.Point(3, 16);
            this.rdRep1.Name = "rdRep1";
            this.rdRep1.Size = new System.Drawing.Size(678, 21);
            this.rdRep1.TabIndex = 0;
            this.rdRep1.TabStop = true;
            this.rdRep1.Text = "Información completa de usuarios y su desempeño";
            this.rdRep1.UseVisualStyleBackColor = true;
            this.rdRep1.CheckedChanged += new System.EventHandler(this.rdRep1_CheckedChanged);
            // 
            // rdRep2
            // 
            this.rdRep2.AutoSize = true;
            this.rdRep2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdRep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdRep2.Location = new System.Drawing.Point(3, 37);
            this.rdRep2.Name = "rdRep2";
            this.rdRep2.Size = new System.Drawing.Size(678, 21);
            this.rdRep2.TabIndex = 1;
            this.rdRep2.TabStop = true;
            this.rdRep2.Text = "Registro de Planos realizados por usuarios";
            this.rdRep2.UseVisualStyleBackColor = true;
            this.rdRep2.CheckedChanged += new System.EventHandler(this.rdRep2_CheckedChanged);
            // 
            // rdRep3
            // 
            this.rdRep3.AutoSize = true;
            this.rdRep3.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdRep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdRep3.Location = new System.Drawing.Point(3, 58);
            this.rdRep3.Name = "rdRep3";
            this.rdRep3.Size = new System.Drawing.Size(678, 21);
            this.rdRep3.TabIndex = 2;
            this.rdRep3.TabStop = true;
            this.rdRep3.Text = "Usuarios activos con su tipo de cliente y cantidad de planos creados";
            this.rdRep3.UseVisualStyleBackColor = true;
            this.rdRep3.CheckedChanged += new System.EventHandler(this.rdRep3_CheckedChanged);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdRep3;
        private System.Windows.Forms.RadioButton rdRep2;
        private System.Windows.Forms.RadioButton rdRep1;
        private System.Windows.Forms.DataGridView dgvReports;
    }
}