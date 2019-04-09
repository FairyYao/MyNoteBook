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
    public partial class MyForm : Form
    {
        SqlConnection con = null;

        public MyForm()
        {
            InitializeComponent();
            DataBase_Conn();
            listView_Initial();

            //关闭窗口前的操作
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(MyForm_Closing);
           
        }

        //主窗体关闭
        private void MyForm_Closing(object sender, FormClosingEventArgs e)
        {
            DataBase_Conn();
        }

        //连接数据库操作
        private void DataBase_Conn()
        {
            
            //Server为SQL Server名称
            //Initial Catalog为数据库名
            //Integrated Security为是否开启windows身份验证
            string ConnectString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=NoteDB;Integrated Security=true";
     
            try
            {
                con = new SqlConnection(ConnectString);
                con.Open(); //创建连接后，需要用open打开连接，结束后要关闭连接
            }
            catch (Exception ms)
            { 
            }
        }

        //断开数据库连接
        private void DataBase_DisConn()
        {
            con.Close();
        }

        //初始化列表
        private void listView_Initial()
        {
            this.noteList.Clear();

            this.noteList.BeginUpdate();//UI暂时挂起，直到EndUpgrade绘制控件，可以有效避免闪烁，提高速度

            //添加排序列
            //this.noteList.Columns.Add("ID", 0, HorizontalAlignment.Center);
            this.noteList.Columns.Add("序号", 40, HorizontalAlignment.Center);
            this.noteList.Columns.Add("名称",77,HorizontalAlignment.Center);


            //设置行高
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1,23);
            noteList.SmallImageList = imgList;

            listView_dataInitial();
        }

        //初始化列数据
        private void listView_dataInitial()
        {
            this.noteList.Items.Clear();
            SqlCommand cmd = new SqlCommand("select Id,name from Note", con);
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 1;
            int[] id = null;
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Tag = dr["Id"].ToString();
                //lt.Text = dr["Id"].ToString();
                lt.Text = i.ToString();
                //lt.SubItems.Add(i.ToString());
                lt.SubItems.Add(dr["name"].ToString());
                //id[i] = (int)dr["ID"];

                this.noteList.Items.Add(lt);
                i++;
            }
            dr.Close();
        }

        //列表项被选中时的操作
        private void noteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectCount = noteList.SelectedItems.Count;
           
            int i = int.Parse(noteList.FocusedItem.Tag.ToString());
  
            if(selectCount > 0)
            {
                editor_Initial(i);
                
            } 
        }

        //编辑区数据初始化
        private void editor_Initial(int i)
        {
            richTextBox.id = i;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                cmd = new SqlCommand("select name,content from Note where Id = " + i, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    title.Text = dr["name"].ToString();
                    richTextBox.Text = dr["content"].ToString();
                }
                else
                {
                    richTextBox.Text = "读出为空";
                }

            }
            catch (Exception ms)
            {
            }
            finally
            {
                dr.Close();
            }   
        }

        //编辑区数据保存
        private void editor_Save()
        {
            SqlCommand cmd = null;
            try
            {
                string sql = "update Note set name = '"+ title.Text +"',content = '" + richTextBox.Text + "'where Id = " + richTextBox.id;
                cmd = new SqlCommand(sql,con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }

        }

        //增加按钮
        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(con);
            //addForm.Show();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                listView_dataInitial();
            }


        }

        //删除按钮
        private void delButton_Click(object sender, EventArgs e)
        {
            if (noteList.FocusedItem != null)
            {
                int i = int.Parse(noteList.FocusedItem.Text);
                SqlCommand cmd = new SqlCommand("delete from Note where Id = " + i, con);
                cmd.ExecuteNonQuery();
                noteList.Items.Remove(noteList.FocusedItem);
                title.Clear();
                richTextBox.Clear();
            }
            else
            {
                MessageBox.Show("请选择一个列表项再进行删除！", "警告", MessageBoxButtons.OK);
            }

        }

        //保存按钮
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (richTextBox.Modified || title.Modified)
            { 
                editor_Save();
                listView_dataInitial();
            }
            else
            {
                MessageBox.Show("没有任何修改","提示",MessageBoxButtons.OK);
            }
            
            
        }

        //取消按钮
        private void cancelButton_Click(object sender, EventArgs e)
        {
            editor_Initial(richTextBox.id);
        }

    }

    public class mRichBox : RichTextBox
    {
        public int id
        {
            get;
            set;
        }

    }
}
