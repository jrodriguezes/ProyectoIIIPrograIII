namespace Presentation
{
    partial class UserManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pageControl = new System.Windows.Forms.TabControl();
            this.usersPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.rolePage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGenre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userBirthdayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userClientType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pageControl.SuspendLayout();
            this.usersPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pageControl
            // 
            this.pageControl.Controls.Add(this.usersPage);
            this.pageControl.Controls.Add(this.rolePage);
            this.pageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageControl.ItemSize = new System.Drawing.Size(53, 0);
            this.pageControl.Location = new System.Drawing.Point(0, 0);
            this.pageControl.Margin = new System.Windows.Forms.Padding(0);
            this.pageControl.Name = "pageControl";
            this.pageControl.SelectedIndex = 0;
            this.pageControl.Size = new System.Drawing.Size(684, 561);
            this.pageControl.TabIndex = 0;
            // 
            // usersPage
            // 
            this.usersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.usersPage.BackgroundImage = global::Presentation.Properties.Resources.principall;
            this.usersPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.usersPage.Controls.Add(this.panel4);
            this.usersPage.Controls.Add(this.panel3);
            this.usersPage.Controls.Add(this.pictureBox1);
            this.usersPage.Location = new System.Drawing.Point(4, 22);
            this.usersPage.Name = "usersPage";
            this.usersPage.Size = new System.Drawing.Size(676, 535);
            this.usersPage.TabIndex = 0;
            this.usersPage.Text = "Usuarios";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 497);
            this.panel1.TabIndex = 20;
            // 
            // dgvInformation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInformation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInformation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInformation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userEmail,
            this.userGenre,
            this.userBirthdayDate,
            this.userAge,
            this.userRole,
            this.userClientType,
            this.userStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInformation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInformation.EnableHeadersVisualStyles = false;
            this.dgvInformation.Location = new System.Drawing.Point(0, 0);
            this.dgvInformation.Name = "dgvInformation";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInformation.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInformation.Size = new System.Drawing.Size(440, 497);
            this.dgvInformation.TabIndex = 18;
            this.dgvInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformation_CellContentClick);
            // 
            // rolePage
            // 
            this.rolePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.rolePage.BackgroundImage = global::Presentation.Properties.Resources.principall;
            this.rolePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rolePage.Location = new System.Drawing.Point(4, 22);
            this.rolePage.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rolePage.Name = "rolePage";
            this.rolePage.Size = new System.Drawing.Size(676, 535);
            this.rolePage.TabIndex = 1;
            this.rolePage.Text = "Rol";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dgvInformation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(235, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 497);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 535);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_LogIn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 38);
            this.panel3.TabIndex = 1;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_LogIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_LogIn.Location = new System.Drawing.Point(0, 0);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(166, 38);
            this.btn_LogIn.TabIndex = 3;
            this.btn_LogIn.Text = "AGREGAR";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(166, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(332, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 497);
            this.panel4.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.userId});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(235, 497);
            this.dataGridView1.TabIndex = 19;
            // 
            // Id
            // 
            this.Id.HeaderText = "Cédula";
            this.Id.Name = "Id";
            this.Id.Width = 75;
            // 
            // userId
            // 
            this.userId.HeaderText = "Nombre de usuario";
            this.userId.Name = "userId";
            this.userId.Width = 197;
            // 
            // userEmail
            // 
            this.userEmail.HeaderText = "Email";
            this.userEmail.Name = "userEmail";
            this.userEmail.Width = 300;
            // 
            // userGenre
            // 
            this.userGenre.HeaderText = "Género";
            this.userGenre.Name = "userGenre";
            this.userGenre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userGenre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userGenre.Width = 150;
            // 
            // userBirthdayDate
            // 
            this.userBirthdayDate.HeaderText = "Fecha nacimiento";
            this.userBirthdayDate.Name = "userBirthdayDate";
            this.userBirthdayDate.Width = 200;
            // 
            // userAge
            // 
            this.userAge.HeaderText = "Edad";
            this.userAge.Name = "userAge";
            // 
            // userRole
            // 
            this.userRole.HeaderText = "Rol";
            this.userRole.Name = "userRole";
            this.userRole.Width = 150;
            // 
            // userClientType
            // 
            this.userClientType.HeaderText = "Tipo de cliente";
            this.userClientType.Name = "userClientType";
            this.userClientType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userClientType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userClientType.Width = 150;
            // 
            // userStatus
            // 
            this.userStatus.HeaderText = "Estado de usuario";
            this.userStatus.Name = "userStatus";
            this.userStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userStatus.Width = 150;
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.pageControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagment";
            this.pageControl.ResumeLayout(false);
            this.usersPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pageControl;
        private System.Windows.Forms.TabPage usersPage;
        private System.Windows.Forms.TabPage rolePage;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmail;
        private System.Windows.Forms.DataGridViewComboBoxColumn userGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn userBirthdayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRole;
        private System.Windows.Forms.DataGridViewComboBoxColumn userClientType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userStatus;
    }
}