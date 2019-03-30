using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicatorClient
{
    class Prompt
    {
        public static string Show(string text, string defaultText)
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 100,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                //Text = caption,
                //StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 10, Top = 10, Text = text };
            TextBox textBox = new TextBox() { Left = 100, Top = 10, Width = 70, Text = defaultText };
            Button confirmation = new Button() { Text = "OK", Left = 65, Width = 30, Top = 35, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
