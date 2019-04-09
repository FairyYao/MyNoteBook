namespace MyNotebook
{
    partial class AddForm
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
            this.title = new System.Windows.Forms.TextBox();
            this.text_title = new System.Windows.Forms.Label();
            this.add_richTextBox = new System.Windows.Forms.RichTextBox();
            this.text_add_content = new System.Windows.Forms.Label();
            this.add_saveButton = new System.Windows.Forms.Button();
            this.add_returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(61, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 21);
            this.title.TabIndex = 0;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // text_title
            // 
            this.text_title.AutoSize = true;
            this.text_title.Location = new System.Drawing.Point(12, 9);
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(29, 12);
            this.text_title.TabIndex = 1;
            this.text_title.Text = "标题";
            // 
            // add_richTextBox
            // 
            this.add_richTextBox.Location = new System.Drawing.Point(59, 46);
            this.add_richTextBox.Name = "add_richTextBox";
            this.add_richTextBox.Size = new System.Drawing.Size(471, 191);
            this.add_richTextBox.TabIndex = 2;
            this.add_richTextBox.Text = "";
            this.add_richTextBox.TextChanged += new System.EventHandler(this.add_richTextBox_TextChanged);
            // 
            // text_add_content
            // 
            this.text_add_content.AutoSize = true;
            this.text_add_content.Location = new System.Drawing.Point(11, 46);
            this.text_add_content.Name = "text_add_content";
            this.text_add_content.Size = new System.Drawing.Size(29, 12);
            this.text_add_content.TabIndex = 3;
            this.text_add_content.Text = "内容";
            // 
            // add_saveButton
            // 
            this.add_saveButton.Location = new System.Drawing.Point(365, 243);
            this.add_saveButton.Name = "add_saveButton";
            this.add_saveButton.Size = new System.Drawing.Size(75, 23);
            this.add_saveButton.TabIndex = 4;
            this.add_saveButton.Text = "保存";
            this.add_saveButton.UseVisualStyleBackColor = true;
            this.add_saveButton.Click += new System.EventHandler(this.add_saveButton_Click);
            // 
            // add_returnButton
            // 
            this.add_returnButton.Location = new System.Drawing.Point(455, 243);
            this.add_returnButton.Name = "add_returnButton";
            this.add_returnButton.Size = new System.Drawing.Size(75, 23);
            this.add_returnButton.TabIndex = 5;
            this.add_returnButton.Text = "返回";
            this.add_returnButton.UseVisualStyleBackColor = true;
            this.add_returnButton.Click += new System.EventHandler(this.add_returnButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 278);
            this.Controls.Add(this.add_returnButton);
            this.Controls.Add(this.add_saveButton);
            this.Controls.Add(this.text_add_content);
            this.Controls.Add(this.add_richTextBox);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.title);
            this.Name = "AddForm";
            this.Text = "添加笔记";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label text_title;
        private System.Windows.Forms.RichTextBox add_richTextBox;
        private System.Windows.Forms.Label text_add_content;
        private System.Windows.Forms.Button add_saveButton;
        private System.Windows.Forms.Button add_returnButton;
    }
}