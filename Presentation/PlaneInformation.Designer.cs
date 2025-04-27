namespace Presentation
{
    partial class PlaneInformation
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.rchFeedback = new System.Windows.Forms.RichTextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pbModel = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStudentName.Location = new System.Drawing.Point(46, 40);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(290, 20);
            this.txtStudentName.TabIndex = 77;
            this.txtStudentName.Text = "NOMBRE DE ESTUDIANTE";
            this.txtStudentName.Enter += new System.EventHandler(this.txtStudentName_Enter);
            this.txtStudentName.Leave += new System.EventHandler(this.txtStudentName_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRegister.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegister.Location = new System.Drawing.Point(46, 390);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(290, 29);
            this.btnRegister.TabIndex = 65;
            this.btnRegister.Text = "REGISTRAR";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPoints
            // 
            this.txtPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoints.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.ForeColor = System.Drawing.Color.DimGray;
            this.txtPoints.Location = new System.Drawing.Point(46, 84);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(290, 20);
            this.txtPoints.TabIndex = 66;
            this.txtPoints.Text = "PUNTOS OBTENIDOS";
            this.txtPoints.Enter += new System.EventHandler(this.txtPoints_Enter);
            this.txtPoints.Leave += new System.EventHandler(this.txtPoints_Leave);
            // 
            // rchFeedback
            // 
            this.rchFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.rchFeedback.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rchFeedback.ForeColor = System.Drawing.Color.DimGray;
            this.rchFeedback.Location = new System.Drawing.Point(46, 124);
            this.rchFeedback.Name = "rchFeedback";
            this.rchFeedback.Size = new System.Drawing.Size(290, 121);
            this.rchFeedback.TabIndex = 80;
            this.rchFeedback.Text = "FEEDBACK";
            this.rchFeedback.Enter += new System.EventHandler(this.rchFeedback_Enter);
            this.rchFeedback.Leave += new System.EventHandler(this.rchFeedback_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(46, 63);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(290, 1);
            this.pictureBox5.TabIndex = 78;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.Location = new System.Drawing.Point(48, 423);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(290, 1);
            this.pictureBox10.TabIndex = 76;
            this.pictureBox10.TabStop = false;
            // 
            // pbModel
            // 
            this.pbModel.Image = global::Presentation.Properties.Resources.subirImagen;
            this.pbModel.Location = new System.Drawing.Point(46, 264);
            this.pbModel.Name = "pbModel";
            this.pbModel.Size = new System.Drawing.Size(290, 107);
            this.pbModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbModel.TabIndex = 72;
            this.pbModel.TabStop = false;
            this.pbModel.Click += new System.EventHandler(this.pbModel_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(46, 107);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(290, 1);
            this.pictureBox8.TabIndex = 67;
            this.pictureBox8.TabStop = false;
            // 
            // pb_Exit
            // 
            this.pb_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Exit.Image = global::Presentation.Properties.Resources.rectangulo_xmark;
            this.pb_Exit.Location = new System.Drawing.Point(348, 2);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(39, 28);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Exit.TabIndex = 83;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // PlaneInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(386, 475);
            this.Controls.Add(this.pb_Exit);
            this.Controls.Add(this.rchFeedback);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pbModel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.txtPoints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaneInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaneInformation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pbModel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.RichTextBox rchFeedback;
        private System.Windows.Forms.PictureBox pb_Exit;
    }
}