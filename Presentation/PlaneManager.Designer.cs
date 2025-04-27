namespace Presentation
{
    partial class PlaneManager
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMod = new System.Windows.Forms.Button();
            this.dgvPrompt = new System.Windows.Forms.DataGridView();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.serialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrompt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pbPhoto);
            this.panel5.Controls.Add(this.btnMod);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 452);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(684, 109);
            this.panel5.TabIndex = 22;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMod.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMod.Location = new System.Drawing.Point(0, 0);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(166, 109);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "MODIFICAR";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // dgvPrompt
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrompt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrompt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrompt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrompt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPrompt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrompt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialId,
            this.studentName,
            this.points,
            this.feedback,
            this.planeId,
            this.professorId,
            this.createDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrompt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrompt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrompt.EnableHeadersVisualStyles = false;
            this.dgvPrompt.Location = new System.Drawing.Point(0, 0);
            this.dgvPrompt.Name = "dgvPrompt";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrompt.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrompt.Size = new System.Drawing.Size(684, 452);
            this.dgvPrompt.TabIndex = 23;
            this.dgvPrompt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrompt_CellClick);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbPhoto.Location = new System.Drawing.Point(166, 0);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(170, 109);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 5;
            this.pbPhoto.TabStop = false;
            // 
            // serialId
            // 
            this.serialId.HeaderText = "Código serial";
            this.serialId.Name = "serialId";
            this.serialId.Width = 75;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Estudiante";
            this.studentName.Name = "studentName";
            this.studentName.Width = 250;
            // 
            // points
            // 
            this.points.HeaderText = "Puntos";
            this.points.Name = "points";
            this.points.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // feedback
            // 
            this.feedback.HeaderText = "Retroalimentación";
            this.feedback.Name = "feedback";
            this.feedback.Width = 400;
            // 
            // planeId
            // 
            this.planeId.HeaderText = "Código plano";
            this.planeId.Name = "planeId";
            this.planeId.Width = 75;
            // 
            // professorId
            // 
            this.professorId.HeaderText = "Cédula de profesor";
            this.professorId.Name = "professorId";
            this.professorId.Width = 150;
            // 
            // createDate
            // 
            this.createDate.HeaderText = "Fecha de creacion";
            this.createDate.Name = "createDate";
            this.createDate.Width = 150;
            // 
            // PlaneManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.dgvPrompt);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaneManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaneManager";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrompt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.DataGridView dgvPrompt;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
    }
}