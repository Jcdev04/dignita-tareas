using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita
{
    public static class Placeholder
    {
        public static void AddPlaceholderToTextBoxes(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enter += TextBox_Enter;
                    textBox.Leave += TextBox_Leave;
                    textBox.Text = "Escribe aquí...";
                    textBox.ForeColor = Color.Silver;
                }
            }
        }

        private static void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Escribe aquí...")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private static void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = "Escribe aquí...";
                textBox.ForeColor = Color.Silver;
            }
        }

        public static void AddPlaceholderToComboBoxes(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is ComboBox comboBox)
                {
                    comboBox.DropDown += ComboBox_DropDown;
                    comboBox.DropDownClosed += ComboBox_DropDownClosed;
                    comboBox.Text = "--Selecciona--";
                    comboBox.ForeColor = Color.Silver;
                }
            }
        }

        private static void ComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.Text == "--Selecciona--")
            {
                comboBox.Text = "";
                comboBox.ForeColor = Color.Black;
            }
        }

        private static void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.Text == "")
            {
                comboBox.Text = "--Selecciona--";
                comboBox.ForeColor = Color.Silver;
            }
        }
    }
}
