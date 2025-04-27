using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Editor : Form
    {
        private int userId;

        public Editor(int userId) // 🔥 Constructor que recibe el ID
        {
            InitializeComponent();
            this.userId = userId;
        }

        private async void Editor_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            string urlWithUser = $"http://localhost:3001/?userId={userId}";
            webView21.CoreWebView2.Navigate(urlWithUser);


            // 🔥 Cuando el WebView intenta abrir nueva ventana
            webView21.CoreWebView2.NewWindowRequested += (s, args) =>
            {
                // 🔥 Cancelamos la apertura en el WebView
                args.Handled = true;

                // 🔥 Abrimos la URL con el navegador predeterminado
                var url = args.Uri;
                if (!string.IsNullOrEmpty(url))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true // 🔥 Esto es lo que hace que use Chrome, Edge, Firefox, lo que tenga predeterminado
                    });
                }
            };
        }
    }
}
