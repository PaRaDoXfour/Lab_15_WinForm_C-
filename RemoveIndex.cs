using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ЛР_15_ListBox_
{
    public partial class RemoveIndex : Form
    {
        public RemoveIndex()
        {
            InitializeComponent();
        }

        // Визначення делегата
        public delegate void IndexHandler(int index);
        // Подія, яка буде тригерити передачу даних
        public event IndexHandler SendIndex;

        public void SetTextBoxText(string text)
        {
            textBoxRemoveIndex.Text = text;
        }

        private void buttonIndexRemove_Click(object sender, EventArgs e)
        {
            // Зчитування індексу з TextBox
            if (int.TryParse(textBoxRemoveIndex.Text, out int index))
            {
                // Виклик події
                SendIndex?.Invoke(index);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введіть коректний індекс.");
            }
        }
    }
}
