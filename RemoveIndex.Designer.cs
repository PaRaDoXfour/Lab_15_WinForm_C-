namespace ЛР_15_ListBox_
{
    partial class RemoveIndex
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
            this.textBoxRemoveIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCloseIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRemoveIndex
            // 
            this.textBoxRemoveIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRemoveIndex.Location = new System.Drawing.Point(212, 74);
            this.textBoxRemoveIndex.Name = "textBoxRemoveIndex";
            this.textBoxRemoveIndex.Size = new System.Drawing.Size(171, 34);
            this.textBoxRemoveIndex.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть індекс рядка який хочете видалити";
            // 
            // buttonCloseIndex
            // 
            this.buttonCloseIndex.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCloseIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseIndex.Location = new System.Drawing.Point(253, 127);
            this.buttonCloseIndex.Name = "buttonCloseIndex";
            this.buttonCloseIndex.Size = new System.Drawing.Size(83, 40);
            this.buttonCloseIndex.TabIndex = 2;
            this.buttonCloseIndex.Text = "OK";
            this.buttonCloseIndex.UseVisualStyleBackColor = false;
            this.buttonCloseIndex.Click += new System.EventHandler(this.buttonIndexRemove_Click);
            // 
            // RemoveIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(623, 214);
            this.Controls.Add(this.buttonCloseIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRemoveIndex);
            this.Name = "RemoveIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видалення по індексу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRemoveIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCloseIndex;
    }
}