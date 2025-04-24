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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pageControl = new System.Windows.Forms.TabControl();
            this.usersPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rolePage = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnModRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvClientType = new System.Windows.Forms.DataGridView();
            this.SerialIdClientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientTypeClientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusClientType = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnModClientType = new System.Windows.Forms.Button();
            this.btnAddClientType = new System.Windows.Forms.Button();
            this.serialIdRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusRole = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGenre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userBirthdayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRole = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userClientType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageControl.SuspendLayout();
            this.usersPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rolePage.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientType)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageControl
            // 
            this.pageControl.Controls.Add(this.usersPage);
            this.pageControl.Controls.Add(this.rolePage);
            this.pageControl.Controls.Add(this.tabPage1);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 497);
            this.panel4.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(142, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(533, 497);
            this.panel7.TabIndex = 22;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(533, 477);
            this.panel10.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dgvInformation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 477);
            this.panel2.TabIndex = 21;
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
            this.userName,
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
            this.dgvInformation.Size = new System.Drawing.Size(533, 477);
            this.dgvInformation.TabIndex = 18;
            this.dgvInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformation_CellClick);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 487);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(533, 10);
            this.panel9.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(533, 10);
            this.panel8.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dgvUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 497);
            this.panel1.TabIndex = 20;
            // 
            // dgvUsers
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsers.Size = new System.Drawing.Size(142, 497);
            this.dgvUsers.TabIndex = 19;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMod);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 38);
            this.panel3.TabIndex = 1;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMod.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMod.Location = new System.Drawing.Point(0, 0);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(166, 38);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "MODIFICAR";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
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
            // rolePage
            // 
            this.rolePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.rolePage.BackgroundImage = global::Presentation.Properties.Resources.principall;
            this.rolePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rolePage.Controls.Add(this.panel6);
            this.rolePage.Controls.Add(this.panel5);
            this.rolePage.Location = new System.Drawing.Point(4, 22);
            this.rolePage.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rolePage.Name = "rolePage";
            this.rolePage.Size = new System.Drawing.Size(676, 535);
            this.rolePage.TabIndex = 1;
            this.rolePage.Text = "Rol";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvRole);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(676, 497);
            this.panel6.TabIndex = 21;
            // 
            // dgvRole
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRole.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRole.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialIdRole,
            this.Role,
            this.statusRole});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRole.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.EnableHeadersVisualStyles = false;
            this.dgvRole.Location = new System.Drawing.Point(0, 0);
            this.dgvRole.Name = "dgvRole";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRole.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRole.Size = new System.Drawing.Size(676, 497);
            this.dgvRole.TabIndex = 19;
            this.dgvRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnModRole);
            this.panel5.Controls.Add(this.btnAddRole);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 497);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(676, 38);
            this.panel5.TabIndex = 20;
            // 
            // btnModRole
            // 
            this.btnModRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnModRole.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModRole.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModRole.Location = new System.Drawing.Point(166, 0);
            this.btnModRole.Name = "btnModRole";
            this.btnModRole.Size = new System.Drawing.Size(166, 38);
            this.btnModRole.TabIndex = 4;
            this.btnModRole.Text = "MODIFICAR";
            this.btnModRole.UseVisualStyleBackColor = false;
            this.btnModRole.Click += new System.EventHandler(this.btnModRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddRole.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddRole.Location = new System.Drawing.Point(0, 0);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(166, 38);
            this.btnAddRole.TabIndex = 3;
            this.btnAddRole.Text = "AGREGAR";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tabPage1.Controls.Add(this.dgvClientType);
            this.tabPage1.Controls.Add(this.panel11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 535);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Tipo cliente";
            // 
            // dgvClientType
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClientType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvClientType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialIdClientType,
            this.ClientTypeClientType,
            this.statusClientType});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientType.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvClientType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientType.EnableHeadersVisualStyles = false;
            this.dgvClientType.Location = new System.Drawing.Point(3, 3);
            this.dgvClientType.Name = "dgvClientType";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientType.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvClientType.Size = new System.Drawing.Size(670, 491);
            this.dgvClientType.TabIndex = 21;
            this.dgvClientType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientType_CellClick);
            // 
            // SerialIdClientType
            // 
            this.SerialIdClientType.HeaderText = "Código serial";
            this.SerialIdClientType.Name = "SerialIdClientType";
            this.SerialIdClientType.Width = 185;
            // 
            // ClientTypeClientType
            // 
            this.ClientTypeClientType.HeaderText = "Tipo cliente";
            this.ClientTypeClientType.Name = "ClientTypeClientType";
            this.ClientTypeClientType.Width = 250;
            // 
            // statusClientType
            // 
            this.statusClientType.HeaderText = "Estado";
            this.statusClientType.Name = "statusClientType";
            this.statusClientType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusClientType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusClientType.Width = 200;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnModClientType);
            this.panel11.Controls.Add(this.btnAddClientType);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(3, 494);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(670, 38);
            this.panel11.TabIndex = 22;
            // 
            // btnModClientType
            // 
            this.btnModClientType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnModClientType.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModClientType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModClientType.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModClientType.Location = new System.Drawing.Point(166, 0);
            this.btnModClientType.Name = "btnModClientType";
            this.btnModClientType.Size = new System.Drawing.Size(166, 38);
            this.btnModClientType.TabIndex = 4;
            this.btnModClientType.Text = "MODIFICAR";
            this.btnModClientType.UseVisualStyleBackColor = false;
            this.btnModClientType.Click += new System.EventHandler(this.btnModClientType_Click);
            // 
            // btnAddClientType
            // 
            this.btnAddClientType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddClientType.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddClientType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClientType.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddClientType.Location = new System.Drawing.Point(0, 0);
            this.btnAddClientType.Name = "btnAddClientType";
            this.btnAddClientType.Size = new System.Drawing.Size(166, 38);
            this.btnAddClientType.TabIndex = 3;
            this.btnAddClientType.Text = "AGREGAR";
            this.btnAddClientType.UseVisualStyleBackColor = false;
            this.btnAddClientType.Click += new System.EventHandler(this.btnAddClientType_Click);
            // 
            // serialIdRole
            // 
            this.serialIdRole.HeaderText = "Código serial";
            this.serialIdRole.Name = "serialIdRole";
            this.serialIdRole.Width = 185;
            // 
            // Role
            // 
            this.Role.HeaderText = "Rol";
            this.Role.Name = "Role";
            this.Role.Width = 250;
            // 
            // statusRole
            // 
            this.statusRole.HeaderText = "Estado";
            this.statusRole.Name = "statusRole";
            this.statusRole.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusRole.Width = 200;
            // 
            // userName
            // 
            this.userName.HeaderText = "Nombre de usuario";
            this.userName.Name = "userName";
            this.userName.Width = 200;
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
            this.userGenre.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Prefiero no decirlo"});
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
            this.userRole.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // userId
            // 
            this.userId.HeaderText = "Cédula";
            this.userId.Name = "userId";
            this.userId.Width = 150;
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
            this.Load += new System.EventHandler(this.UserManagment_Load);
            this.pageControl.ResumeLayout(false);
            this.usersPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rolePage.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientType)).EndInit();
            this.panel11.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnModRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvClientType;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnModClientType;
        private System.Windows.Forms.Button btnAddClientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialIdClientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientTypeClientType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusClientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialIdRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmail;
        private System.Windows.Forms.DataGridViewComboBoxColumn userGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn userBirthdayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAge;
        private System.Windows.Forms.DataGridViewComboBoxColumn userRole;
        private System.Windows.Forms.DataGridViewComboBoxColumn userClientType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
    }
}