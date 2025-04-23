using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Objects;

namespace Presentation
{
    public partial class PromptManager : Form
    {
        UserService userService = new UserService();
        public PromptManager()
        {
            InitializeComponent();
        }

        private void PromptManager_Load(object sender, EventArgs e)
        {
            loadAllPrompts();
        }

        private void loadAllPrompts()
        {
            List<BotPromptModel> promptList = userService.getAllPrompts();

            dgvPrompt.Rows.Clear();

            foreach (BotPromptModel prompt in promptList)
            {
                int rowIndex = dgvPrompt.Rows.Add();
                dgvPrompt.Rows[rowIndex].Cells["serialId"].Value = prompt.id;
                dgvPrompt.Rows[rowIndex].Cells["prompt"].Value = prompt.prompt;
                dgvPrompt.Rows[rowIndex].Cells["status"].Value = prompt.status == 1 ? true : false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
