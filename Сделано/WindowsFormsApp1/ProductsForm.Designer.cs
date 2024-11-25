namespace WindowsFormsApp1
{
    partial class ProductsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_Button = new System.Windows.Forms.Button();
            this.descending_Button = new System.Windows.Forms.Button();
            this.ascending_Button = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.close_Button = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // search_Button
            // 
            this.search_Button.Location = new System.Drawing.Point(634, 119);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(154, 43);
            this.search_Button.TabIndex = 2;
            this.search_Button.Text = "Поиск";
            this.search_Button.UseVisualStyleBackColor = true;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // descending_Button
            // 
            this.descending_Button.Location = new System.Drawing.Point(634, 217);
            this.descending_Button.Name = "descending_Button";
            this.descending_Button.Size = new System.Drawing.Size(154, 43);
            this.descending_Button.TabIndex = 3;
            this.descending_Button.Text = "По убыванию";
            this.descending_Button.UseVisualStyleBackColor = true;
            this.descending_Button.Click += new System.EventHandler(this.descending_Button_Click);
            // 
            // ascending_Button
            // 
            this.ascending_Button.Location = new System.Drawing.Point(634, 168);
            this.ascending_Button.Name = "ascending_Button";
            this.ascending_Button.Size = new System.Drawing.Size(154, 43);
            this.ascending_Button.TabIndex = 4;
            this.ascending_Button.Text = "По возрастанию";
            this.ascending_Button.UseVisualStyleBackColor = true;
            this.ascending_Button.Click += new System.EventHandler(this.ascending_Button_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(634, 266);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(154, 43);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Сбросить изменения";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // close_Button
            // 
            this.close_Button.Location = new System.Drawing.Point(12, 395);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(154, 43);
            this.close_Button.TabIndex = 6;
            this.close_Button.Text = "Выход";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(474, 395);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 43);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(634, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 59);
            this.textBox1.TabIndex = 1;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.ascending_Button);
            this.Controls.Add(this.descending_Button);
            this.Controls.Add(this.search_Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search_Button;
        private System.Windows.Forms.Button descending_Button;
        private System.Windows.Forms.Button ascending_Button;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}