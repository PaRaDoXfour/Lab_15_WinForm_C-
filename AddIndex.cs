using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_15_ListBox_
{
    public partial class AddIndex : Form
    {
        public AddIndex()
        {
            InitializeComponent();
        }

        // Визначення делегата
        public delegate void IndexHandler(int index);
        // Подія, яка буде тригерити передачу даних
        public event IndexHandler SendIndexAdd;

        public void SetTextBoxText(string text)
        {
            textBoxAddIndex.Text = text;
        }

        private void buttonIndexAdd_Click(object sender, EventArgs e)
        {
            // Зчитування індексу з TextBox
            if (int.TryParse(textBoxAddIndex.Text, out int index))
            {
                // Виклик події
                SendIndexAdd?.Invoke(index);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введіть коректний індекс.");
            }
        }
    }
}
