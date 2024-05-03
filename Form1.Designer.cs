namespace ЛР_15_ListBox_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.list = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemoveIndex = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Label();
            this.clearTextBox = new System.Windows.Forms.Button();
            this.elementType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.arrayCount = new System.Windows.Forms.Label();
            this.sentenseCheck = new System.Windows.Forms.Button();
            this.buttonIndexAdd = new System.Windows.Forms.Button();
            this.buttonSearchNumber = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox.Location = new System.Drawing.Point(154, 41);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(579, 34);
            this.textBox.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(154, 120);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(579, 179);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.Location = new System.Drawing.Point(12, 119);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(104, 29);
            this.list.TabIndex = 3;
            this.list.Text = "Список";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(739, 120);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(345, 39);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Додати новий рядок";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemoveIndex
            // 
            this.buttonRemoveIndex.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveIndex.FlatAppearance.BorderSize = 0;
            this.buttonRemoveIndex.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.buttonRemoveIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveIndex.Location = new System.Drawing.Point(1090, 165);
            this.buttonRemoveIndex.Name = "buttonRemoveIndex";
            this.buttonRemoveIndex.Size = new System.Drawing.Size(345, 39);
            this.buttonRemoveIndex.TabIndex = 5;
            this.buttonRemoveIndex.Text = "Видалити рядок за індексом";
            this.buttonRemoveIndex.UseVisualStyleBackColor = false;
            this.buttonRemoveIndex.Click += new System.EventHandler(this.buttonRemoveIndex_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(739, 165);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(345, 39);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Видалити обраний рядок";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(1090, 40);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(345, 34);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистити список";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(12, 40);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(115, 29);
            this.enter.TabIndex = 8;
            this.enter.Text = "Введіть:";
            // 
            // clearTextBox
            // 
            this.clearTextBox.BackColor = System.Drawing.Color.Yellow;
            this.clearTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearTextBox.FlatAppearance.BorderSize = 0;
            this.clearTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearTextBox.Location = new System.Drawing.Point(739, 40);
            this.clearTextBox.Name = "clearTextBox";
            this.clearTextBox.Size = new System.Drawing.Size(345, 34);
            this.clearTextBox.TabIndex = 9;
            this.clearTextBox.Text = "Очистити рядок";
            this.clearTextBox.UseVisualStyleBackColor = false;
            this.clearTextBox.Click += new System.EventHandler(this.clearTextBox_Click);
            // 
            // elementType
            // 
            this.elementType.AutoSize = true;
            this.elementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementType.Location = new System.Drawing.Point(12, 316);
            this.elementType.Name = "elementType";
            this.elementType.Size = new System.Drawing.Size(345, 29);
            this.elementType.TabIndex = 10;
            this.elementType.Text = "Тип виділеного елементу:";
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(400, 313);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(620, 34);
            this.textBoxType.TabIndex = 11;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount.Location = new System.Drawing.Point(400, 360);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(110, 34);
            this.textBoxCount.TabIndex = 12;
            // 
            // arrayCount
            // 
            this.arrayCount.AutoSize = true;
            this.arrayCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.arrayCount.Location = new System.Drawing.Point(12, 360);
            this.arrayCount.Name = "arrayCount";
            this.arrayCount.Size = new System.Drawing.Size(366, 29);
            this.arrayCount.TabIndex = 13;
            this.arrayCount.Text = "Кількість елементів масиву:";
            // 
            // sentenseCheck
            // 
            this.sentenseCheck.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sentenseCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sentenseCheck.FlatAppearance.BorderSize = 0;
            this.sentenseCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sentenseCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sentenseCheck.Location = new System.Drawing.Point(739, 210);
            this.sentenseCheck.Name = "sentenseCheck";
            this.sentenseCheck.Size = new System.Drawing.Size(345, 39);
            this.sentenseCheck.TabIndex = 16;
            this.sentenseCheck.Text = "Перевірка";
            this.sentenseCheck.UseVisualStyleBackColor = false;
            this.sentenseCheck.Click += new System.EventHandler(this.sentenseCheck_Click);
            // 
            // buttonIndexAdd
            // 
            this.buttonIndexAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonIndexAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIndexAdd.FlatAppearance.BorderSize = 0;
            this.buttonIndexAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndexAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIndexAdd.Location = new System.Drawing.Point(1090, 119);
            this.buttonIndexAdd.Name = "buttonIndexAdd";
            this.buttonIndexAdd.Size = new System.Drawing.Size(345, 39);
            this.buttonIndexAdd.TabIndex = 17;
            this.buttonIndexAdd.Text = "Додати рядок за індексом";
            this.buttonIndexAdd.UseVisualStyleBackColor = false;
            this.buttonIndexAdd.Click += new System.EventHandler(this.buttonIndexAdd_Click);
            // 
            // buttonSearchNumber
            // 
            this.buttonSearchNumber.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSearchNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchNumber.FlatAppearance.BorderSize = 0;
            this.buttonSearchNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchNumber.Location = new System.Drawing.Point(1090, 210);
            this.buttonSearchNumber.Name = "buttonSearchNumber";
            this.buttonSearchNumber.Size = new System.Drawing.Size(343, 39);
            this.buttonSearchNumber.TabIndex = 18;
            this.buttonSearchNumber.Text = "Номер розшукуваного рядка";
            this.buttonSearchNumber.UseVisualStyleBackColor = false;
            this.buttonSearchNumber.Click += new System.EventHandler(this.buttonSearchNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1445, 494);
            this.Controls.Add(this.buttonSearchNumber);
            this.Controls.Add(this.buttonIndexAdd);
            this.Controls.Add(this.sentenseCheck);
            this.Controls.Add(this.arrayCount);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.elementType);
            this.Controls.Add(this.clearTextBox);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonRemoveIndex);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.list);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обробник списку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label list;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemoveIndex;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label enter;
        private System.Windows.Forms.Button clearTextBox;
        private System.Windows.Forms.Label elementType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label arrayCount;
        private System.Windows.Forms.Button sentenseCheck;
        private System.Windows.Forms.Button buttonIndexAdd;
        private System.Windows.Forms.Button buttonSearchNumber;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

