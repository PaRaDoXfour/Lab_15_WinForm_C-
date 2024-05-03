using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;

namespace ЛР_15_ListBox_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox.Items.AddRange(new string[] { "Рядок 1", "Рядок 2", "Рядок 3" });

            UpdateItemCount();

            // Підписка на події
            subscription_to_events(clearTextBox);
            subscription_to_events(buttonAdd);
            subscription_to_events(buttonClear);
            subscription_to_events(buttonRemove);
            subscription_to_events(buttonRemoveIndex);
            subscription_to_events(buttonIndexAdd);
            subscription_to_events(sentenseCheck);
            subscription_to_events(buttonAdd);          

            // Додавання підказки до кнопки "Перевірка"
            toolTip1.SetToolTip(sentenseCheck, "Перевірка існування заданого рядка в списку.\n" +
                "(Введіть рядок у поле \"Введіть\")");
            
            // Додавання підказки до кнопки "Додати рядок за індексом"
            toolTip1.SetToolTip(buttonIndexAdd, "Додавання рядка за індексом.\n" +
                "(Введіть рядок у поле \"Введіть\")");
            toolTip1.AutoPopDelay = 5000;  // Час відображення підказки у мілісекундах
            toolTip1.InitialDelay = 1000;  // Затримка перед першим відображенням підказки
            toolTip1.ReshowDelay = 500;    // Затримка перед повторним відображенням підказки
            toolTip1.ShowAlways = true;    // Показувати підказку незалежно від того, чи активне вікно
        }
        private void subscription_to_events(Button e)
        {
            e.GotFocus += Button_GotFocus;
            e.LostFocus += Button_LostFocus;
            e.MouseEnter += Button_MouseEnter;
            e.MouseLeave += Button_MouseLeave;
        }
        private void Button_GotFocus(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.Blue;
        }
        private void Button_LostFocus(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.Gray;
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.White;
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.Gray;
        }

        // Функція для виведення кількості рядків 
        private void UpdateItemCount()
        {
            textBoxCount.Text = listBox.Items.Count.ToString();
        }

        // Виведення вибраного рядка в textBox та тип в textBoxType
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Виведення вибраного рядка у TextBox
            if (listBox.SelectedItem != null)
            {
                textBox.Text = listBox.SelectedItem.ToString();
            }

            // Виведення типу виділеного елемента в textBoxtype
            System.Type w = listBox.Items.GetType();
            textBoxType.Text = w.ToString();            
        }

        // Додавання рядка
        private void buttonAdd_Click(object sender, EventArgs e)
        {            
            // Перевірка, чи пустий текст
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Введено пустий рядок", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                // Додавання нового рядка в кінець списку
                listBox.Items.Add(textBox.Text);
                textBox.Clear();
                UpdateItemCount();
            }
        }

        // Видалення вибраного рядка
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Видалення вибраного рядка
            if(listBox.SelectedIndex >= 0) 
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                UpdateItemCount();
            }
        }
        private void buttonIndexAdd_Click(object sender, EventArgs e)
        {
            AddIndex addIndex = new AddIndex();
            addIndex.SendIndexAdd += AddIndex_SendIndexAdd;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Введено пустий рядок", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                addIndex.ShowDialog();
        }
        private void AddIndex_SendIndexAdd(int index)
        {
            if (index >= 0 && index <= listBox.Items.Count) // перевірка на допустимість індексу
            {
                listBox.Items.Insert(index, textBox.Text);
                UpdateItemCount();
            }
            else
            {
                MessageBox.Show("Некоректний індекс");
            }
        }
        // Видалення рядка по індексу
        private void buttonRemoveIndex_Click(object sender, EventArgs e)
        {
            RemoveIndex removeIndex = new RemoveIndex();
            removeIndex.SendIndex += RemoveIndex_SendIndex; // Підписка на подію
            removeIndex.ShowDialog(); // Показ форми як діалогове вікно
        }
        private void RemoveIndex_SendIndex(int index)
        {
            // Перевірка на коректність індексу
            if (index >= 0 && index < listBox.Items.Count)
            {
                listBox.Items.RemoveAt(index);
                UpdateItemCount();
            }
            else
            {
                MessageBox.Show("Індекс за межами діапазону", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Очищення списку
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Очищення списку
            listBox.Items.Clear();
            UpdateItemCount();
        }

        // Очищення поля textBox "Введіть"
        private void clearTextBox_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        // Перевірка існування заданого рядку в списку
        private void sentenseCheck_Click(object sender, EventArgs e)
        {
            // Перевірка, чи пустий текст
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Введено пустий рядок", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (listBox.Items.Contains(textBox.Text))
                    MessageBox.Show($"Рядок '{textBox.Text}' існує в списку.");
                else //(string.IsNullOrWhiteSpace(textBox.Text)
                    MessageBox.Show($"Рядок '{textBox.Text}' не знайдено в списку.");
            }
            
        }

        // Номер рядка, який розшукується
        private void buttonSearchNumber_Click(object sender, EventArgs e)
        {
            int index = listBox.Items.IndexOf(textBox.Text);
            if (index != -1)
                MessageBox.Show($"Рядок '{textBox.Text}' знаходиться на позиції: {index}");
            else
                MessageBox.Show($"Рядок '{textBox.Text}' не знайдено.");
        }        
    }
}