using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Logic;
using Objects;

namespace Presentation
{
    public partial class AddPrompt : Form
    {
        private PromptManager mainForm;
        public AddPrompt(PromptManager form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
        UserService userService = new UserService();

        private void pb_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BotPromptModel model = new BotPromptModel
            {
                prompt = txtClientType.Text,
                status = 1
            };
            userService.insertBotPrompt(model);
            MessageBox.Show("Haz agregado satisfactoriamente un mensaje.");
            cleanText();
            mainForm.loadAllPrompts();
            this.Close();
        }

        private void cleanText()
        {
            txtClientType.Clear();
        }
    }
}

