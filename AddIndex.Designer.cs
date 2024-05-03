namespace ЛР_15_ListBox_
{
    partial class AddIndex
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddIndex = new System.Windows.Forms.TextBox();
            this.buttonIndexAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть індекс";
            // 
            // textBoxAddIndex
            // 
            this.textBoxAddIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddIndex.Location = new System.Drawing.Point(147, 41);
            this.textBoxAddIndex.Name = "textBoxAddIndex";
            this.textBoxAddIndex.Size = new System.Drawing.Size(100, 34);
            this.textBoxAddIndex.TabIndex = 1;
            // 
            // buttonIndexAdd
            // 
            this.buttonIndexAdd.BackColor = System.Drawing.Color.IndianRed;
            this.buttonIndexAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIndexAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndexAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIndexAdd.Location = new System.Drawing.Point(159, 81);
            this.buttonIndexAdd.Name = "buttonIndexAdd";
            this.buttonIndexAdd.Size = new System.Drawing.Size(75, 33);
            this.buttonIndexAdd.TabIndex = 2;
            this.buttonIndexAdd.Text = "OK";
            this.buttonIndexAdd.UseVisualStyleBackColor = false;
            this.buttonIndexAdd.Click += new System.EventHandler(this.buttonIndexAdd_Click);
            // 
            // AddIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(398, 172);
            this.Controls.Add(this.buttonIndexAdd);
            this.Controls.Add(this.textBoxAddIndex);
            this.Controls.Add(this.label1);
            this.Name = "AddIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання по індексу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddIndex;
        private System.Windows.Forms.Button buttonIndexAdd;
    }
}