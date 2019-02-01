using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestManagement.Forms
{
    public class FormControls
    {
        public static void AddTextBox(Control parent, int ID, string text, Point point)
        {
            var txt = new TextBox
            {
                Name = "Step" + ID,
                Text = text,
                Location = point
            };
            parent.Controls.Add(txt);
        }

        public static void AddTestCaseField(Control parent, int ID, string text, Point point, EventHandler addTarget, EventHandler removeTarget)
        {
            AddTextBox(parent, ID, text, point);
            point.X += 200;
            AddButton(parent, "-", ID, point, removeTarget);
            point.X += 25;
            AddButton(parent, "+", ID, point, addTarget);
        }

        public static void AddButton(Control parent, string name, int ID, Point point, EventHandler targetEvent)
        {
            var but = new Button
            {
                Name = name + ID,
                Location = point,
                Text = name,
                Width = 20,
                Height = 20
            };
            but.Click += targetEvent;
            parent.Controls.Add(but);
        }
    }
}
