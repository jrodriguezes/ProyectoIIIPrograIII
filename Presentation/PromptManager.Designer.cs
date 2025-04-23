namespace Presentation
{
    partial class PromptManager
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
            this.btnAddPrompt = new System.Windows.Forms.Button();
            this.dgvPrompt = new System.Windows.Forms.DataGridView();
            this.serialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prompt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrompt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnMod);
            this.panel5.Controls.Add(this.btnAddPrompt);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 523);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(684, 38);
            this.panel5.TabIndex = 21;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMod.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMod.Location = new System.Drawing.Point(166, 0);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(166, 38);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "MODIFICAR";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnAddPrompt
            // 
            this.btnAddPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddPrompt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddPrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrompt.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddPrompt.Location = new System.Drawing.Point(0, 0);
            this.btnAddPrompt.Name = "btnAddPrompt";
            this.btnAddPrompt.Size = new System.Drawing.Size(166, 38);
            this.btnAddPrompt.TabIndex = 3;
            this.btnAddPrompt.Text = "AGREGAR";
            this.btnAddPrompt.UseVisualStyleBackColor = false;
            this.btnAddPrompt.Click += new System.EventHandler(this.btnAddPrompt_Click);
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
            this.prompt,
            this.status});
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
            this.dgvPrompt.Size = new System.Drawing.Size(684, 523);
            this.dgvPrompt.TabIndex = 22;
            this.dgvPrompt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrompt_CellClick);
            // 
            // serialId
            // 
            this.serialId.HeaderText = "Código serial";
            this.serialId.Name = "serialId";
            this.serialId.Width = 193;
            // 
            // prompt
            // 
            this.prompt.HeaderText = "Mensaje";
            this.prompt.Name = "prompt";
            this.prompt.Width = 250;
            // 
            // status
            // 
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.Width = 200;
            // 
            // PromptManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.dgvPrompt);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PromptManager";
            this.Text = "PromptManager";
            this.Load += new System.EventHandler(this.PromptManager_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrompt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnAddPrompt;
        private System.Windows.Forms.DataGridView dgvPrompt;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn prompt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
    }
}