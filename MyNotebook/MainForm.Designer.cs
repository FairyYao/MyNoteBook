using System;
using System.Data.SqlClient;

namespace MyNotebook
{
    partial class MyForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textEditor = new System.Windows.Forms.Label();
            this.textList = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.noteList = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.richTextBox = new MyNotebook.mRichBox();
            this.SuspendLayout();
            // 
            // textEditor
            // 
            this.textEditor.AutoSize = true;
            this.textEditor.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textEditor.Location = new System.Drawing.Point(147, 5);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(66, 19);
            this.textEditor.TabIndex = 4;
            this.textEditor.Text = "编辑区";
            // 
            // textList
            // 
            this.textList.AutoSize = true;
            this.textList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textList.Location = new System.Drawing.Point(12, 5);
            this.textList.Name = "textList";
            this.textList.Size = new System.Drawing.Size(85, 19);
            this.textList.TabIndex = 5;
            this.textList.Text = "笔记列表";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.Location = new System.Drawing.Point(408, 336);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(59, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelButton.Location = new System.Drawing.Point(482, 336);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(61, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "撤回";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // noteList
            // 
            this.noteList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noteList.FullRowSelect = true;
            this.noteList.Location = new System.Drawing.Point(5, 27);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(129, 299);
            this.noteList.TabIndex = 9;
            this.noteList.TileSize = new System.Drawing.Size(128, 28);
            this.noteList.UseCompatibleStateImageBehavior = false;
            this.noteList.View = System.Windows.Forms.View.Details;
            this.noteList.SelectedIndexChanged += new System.EventHandler(this.noteList_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(9, 335);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(53, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "增加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(81, 336);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(48, 23);
            this.delButton.TabIndex = 11;
            this.delButton.Text = "删除";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(141, 27);
            this.title.Multiline = true;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(148, 24);
            this.title.TabIndex = 12;
            // 
            // richTextBox
            // 
            this.richTextBox.id = 0;
            this.richTextBox.Location = new System.Drawing.Point(140, 57);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(403, 269);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(555, 366);
            this.Controls.Add(this.title);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.noteList);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.textList);
            this.Controls.Add(this.textEditor);
            this.Name = "MyForm";
            this.Text = "笔记本";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textEditor;
        private System.Windows.Forms.Label textList;
        //private System.Windows.Forms.RichTextBox richTextBox;
        private mRichBox richTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView noteList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.TextBox title;
    }
}

