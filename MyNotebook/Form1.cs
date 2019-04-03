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
        //SqlCommand cmd = null;
       // SqlDataReader dr = null;

        public MyForm()
        {
            InitializeComponent();
            DataBase_Conn();
            listView_Initial();

            DataBase_DisConn();
        }

        private void DataBase_Conn()
        {
            //连接数据库操作
            //Server为SQL Server名称
            //Initial Catalog为数据库名
            //Integrated Security为是否开启windows身份验证
            string ConnectString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=true";
     
            try
            {
                con = new SqlConnection(ConnectString);
                con.Open(); //创建连接后，需要用open打开连接，结束后要关闭连接
            }
            catch (Exception ms)
            { 
            }
        }

        private void DataBase_DisConn()
        {
            con.Close();
        }

    
        private void listView_Initial()
        {
            this.noteList.Clear();

            this.noteList.BeginUpdate();//UI暂时挂起，直到EndUpgrade绘制控件，可以有效避免闪烁，提高速度
            
            //添加排序列
            //this.noteList.Columns.Add("序号", 10, HorizontalAlignment.Center);

            //设置行高
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1,23);
            noteList.SmallImageList = imgList;

            //初始化列数据
            SqlCommand cmd = new SqlCommand("select name from Note", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["name"].ToString();
                this.noteList.Items.Add(lt);
            }

            dr.Close();


           /* //连接数据库操作
            //Server为SQL Server名称
            //Initial Catalog为数据库名
            //Integrated Security为是否开启windows身份验证
            string ConnectString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=true";
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                con = new SqlConnection(ConnectString);
                con.Open(); //创建连接后，需要用open打开连接，结束后要关闭连接

                cmd = con.CreateCommand();
                cmd.CommandText = "select name from dbo.Note";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem lt = new ListViewItem();
                    lt.Text = dr["name"].ToString();
                    this.noteList.Items.Add(lt);
                }

            }
            catch (Exception ms)
            {
                //Console.WriteLine(ms.Message);
            }
            finally
            {
                dr.Close();
                con.Close();
                //cmd.Clone();
                this.noteList.EndUpdate();
            }*/
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

        private void noteList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
