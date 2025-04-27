using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Presentation
{
    public partial class Principal : Form
    {
        int userId = -1;
        UserService userService = new UserService();
        public Principal(int id)
        {
            InitializeComponent();
            this.userId = id;
            hideByRole();
            customizingDesign();
            InitializeTitleBarPersonalizated();
        }

        private void customizingDesign()
        {
            PanelSubMenu2.Visible = false;
            PanelSubMenu3.Visible = false;
            panelReports.Visible = false;
        }

        private void hideByRole()
        {
            int role = userService.getRoleByUserId(userId);

            if (role == 1)
            {
                btnDashboard.Visible = false;
                btnManagment.Visible = false;
                btnReports.Visible = false;
            }
            if (role == 2)
            {
                btnDashboard.Visible = true;
                btnManagment.Visible = true;
                btnReports.Visible = true;
            }
        }

        private void hideSubMenu()
        {
            if (PanelSubMenu2.Visible == true)
            {
                PanelSubMenu2.Visible = false;
            }        
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void InitializeTitleBarPersonalizated()
        {
            // Quitar borde del sistema
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(900, 600);

            // Barra de título (Panel)
            Panel barPanel = new Panel
            {
                BackColor = Color.FromArgb(11, 7, 17),
                Height = 35,
                Dock = DockStyle.Top
            };
            barPanel.MouseDown += PanelBarra_MouseDown;
            this.Controls.Add(barPanel);

            // Título
            PictureBox picIcono = new PictureBox
            {
                Image = Properties.Resources.icon_, // Reemplazá con el nombre real del recurso
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(24, 24),
                Location = new Point(10, 5), // Ajustá para que quede bien alineado verticalmente
            };
            barPanel.Controls.Add(picIcono);

            // Botón cerrar
            Button btnClose = new Button
            {
                Text = "X",
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(35, 30),
                Location = new Point(this.Width - 40, 3),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Close();
            barPanel.Controls.Add(btnClose);

            // Botón maximizar/restaurar
            Button btnMax = new Button
            {
                Text = "◻",
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(35, 30),
                Location = new Point(this.Width - 80, 3),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.Click += (s, e) =>
            {
                this.WindowState = this.WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            };
            barPanel.Controls.Add(btnMax);

            // Botón minimizar
            Button btnMin = new Button
            {
                Text = "—",
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(35, 30),
                Location = new Point(this.Width - 120, 3),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            barPanel.Controls.Add(btnMin);
        }

        // Hacer draggable la barra personalizada
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            openChildForm(new Editor());
            showSubMenu(PanelSubMenu2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }

        private void pbSubMenuLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnManagment_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu3);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReports);
        }

        private void btnUserManagment_Click(object sender, EventArgs e)
        {
            openChildForm(new UserManagment());
        }

        private void btnPrompts_Click(object sender, EventArgs e)
        {
            openChildForm(new PromptManager());
        }

        private void btnAddPLane_Click(object sender, EventArgs e)
        {
            PlaneInformation form = new PlaneInformation();
            form.Show();
        }
    }
}
