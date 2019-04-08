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
            this.noteList.Columns.Add("序号", 40, HorizontalAlignment.Center);
            this.noteList.Columns.Add("名称",77,HorizontalAlignment.Center);

            //设置行高
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1,23);
            noteList.SmallImageList = imgList;

            //初始化列数据
            SqlCommand cmd = new SqlCommand("select Id,name from Note", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["Id"].ToString();
                lt.SubItems.Add(dr["name"].ToString());
                this.noteList.Items.Add(lt);
            }

            dr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textEditor_Click(object sender, EventArgs e)
        {

        }

        private void textList_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //列表项被选中时的操作
        private void noteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectCount = noteList.SelectedItems.Count;
            //int i = noteList.Items.IndexOf(noteList.FocusedItem)+1;
            int i = int.Parse(noteList.FocusedItem.Text);
            if(selectCount > 0)
            {
                richBox_Initial(i);
            } 
        }

        private void richBox_Initial(int i)
        {
            richTextBox.id = i;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                cmd = new SqlCommand("select content from Note where Id = " + i, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
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

        private void richBox_Save()
        {
            SqlCommand cmd = null;
            try
            {
                byte[] temp = Encoding.Default.GetBytes(richTextBox.Text);
                string str = System.Text.Encoding.Default.GetString(temp);
                cmd = new SqlCommand("update Note set content = '" + str + "'where Id =" + richTextBox.id,con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }

        }

        //保存按钮的操作
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (richTextBox.Modified)
            { 
                richBox_Save();
            }
            else
            {
                return;
            }
            
            //this.richTextBox.Text = "确定啊";
        }

        //取消按钮的操作
        private void cancelButton_Click(object sender, EventArgs e)
        {
            richBox_Initial(richTextBox.id);
        }

        //增加按钮
        private void addButton_Click(object sender, EventArgs e)
        {

        }

        //删除按钮
        private void delButton_Click(object sender, EventArgs e)
        {
            int i = int.Parse(noteList.FocusedItem.Text);
            if (i != null)
            {
                SqlCommand cmd = new SqlCommand("delete from Note where Id = "+i,con);
                cmd.ExecuteNonQuery();
                noteList.Items.Remove(noteList.FocusedItem);
            }
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
