using System.Drawing;
using System.Windows.Forms;

namespace TestManagement.Forms
{
    public class FormControls
    {
        public static void AddTextBox(Control parent, string name, string text, Point point)
        {
            var txt = new TextBox
            {
                Name = name,
                Text = text,
                Location = point
            };
            parent.Controls.Add(txt);
        }
    }
}
