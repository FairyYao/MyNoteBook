using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotebook
{
    public partial class AddForm : Form
    {
        public SqlConnection con = null;
        public Boolean saveState = false;

        public AddForm(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void title_TextChanged(object sender, EventArgs e)
        {
            saveState = false;
        }

        private void add_richTextBox_TextChanged(object sender, EventArgs e)
        {
            saveState = false;
        }

        private void add_saveButton_Click(object sender, EventArgs e)
        {
            saveState = true;
            SqlCommand cmd = null;
            if (string.IsNullOrWhiteSpace(title.Text))
            {
                MessageBox.Show("笔记标题不能为空！","提示",MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("insert into Note(name,content) values ('"+title.Text+"','"+add_richTextBox.Text+"')",con);
                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                }
            }
   
        }

        private void add_returnButton_Click(object sender, EventArgs e)
        {
            if (saveState)
            {
                this.Close();
            }
            else
            {
               DialogResult dr =  MessageBox.Show("笔记还未保存，确定返回吗？","提示",MessageBoxButtons.OKCancel);
               if (dr == DialogResult.OK)
               {
                    this.Close();
               }
            }
           
            
        }
    }
}
