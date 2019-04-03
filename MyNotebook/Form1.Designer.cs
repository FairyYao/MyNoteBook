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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.noteList = new System.Windows.Forms.ListView();
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
            this.textEditor.Click += new System.EventHandler(this.textEditor_Click);
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
            this.textList.Click += new System.EventHandler(this.textList_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(140, 27);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(403, 268);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.Location = new System.Drawing.Point(377, 300);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelButton.Location = new System.Drawing.Point(468, 300);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // noteList
            // 
            this.noteList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noteList.Location = new System.Drawing.Point(5, 27);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(121, 268);
            this.noteList.TabIndex = 9;
            this.noteList.TileSize = new System.Drawing.Size(128, 28);
            this.noteList.UseCompatibleStateImageBehavior = false;
            this.noteList.View = System.Windows.Forms.View.List;
            this.noteList.SelectedIndexChanged += new System.EventHandler(this.noteList_SelectedIndexChanged);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(555, 330);
            this.Controls.Add(this.noteList);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.textList);
            this.Controls.Add(this.textEditor);
            this.Name = "MyForm";
            this.Text = "笔记本";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textEditor;
        private System.Windows.Forms.Label textList;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView noteList;
    }
}

