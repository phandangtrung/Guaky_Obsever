using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHDT
{
    public partial class Form_Main : Form
    {
        BindingSource listproduct = new BindingSource();
        Dataprovider mydb = new Dataprovider();
       
        public Form_Main()
        {
            InitializeComponent();
            dataGridView2.DataSource = listproduct;
            loadgridproduct();          
            loadproduct();
            
        }
              

       
        void loadgridproduct()
        {
            SqlCommand command = new SqlCommand("SELECT*FROM Product");
            listproduct.DataSource =getdata(command);
        }
        void loadgridcuscare()
        {
            int idpro = Int32.Parse(tbid.Text);
            SqlCommand command = new SqlCommand("SELECT Name, Email from customer where PRODUCTCARE = " + idpro);
            dtgvcus.DataSource = getdata(command);
            DataGridViewColumn column1 = dtgvcus.Columns[0];
            column1.Width = 150;
            DataGridViewColumn column2 = dtgvcus.Columns[1];
            column2.Width = 350;
        }
        public DataTable getdata(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        void loadproduct()
        {  
           tbid.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "ID", true, DataSourceUpdateMode.Never));
           tbcategory.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "IDCATEGORY", true, DataSourceUpdateMode.Never));
           tbname.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "NAME", true, DataSourceUpdateMode.Never));
           nmprice.DataBindings.Add(new Binding("Value", dataGridView2.DataSource, "PRICE", true, DataSourceUpdateMode.Never));
           tbdes.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "DESCRIPT", true, DataSourceUpdateMode.Never));
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            loadgridcuscare();
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbid.Text);
            int idcate = Int32.Parse(tbcategory.Text);
            string name = tbname.Text;
            float price = (float)nmprice.Value;
            string des = tbdes.Text;
            Product_Class sp = new Product_Class("Sản phẩm :" + name + " Có giá :" + price + " Chi tiết : " + des);
            SqlCommand command = new SqlCommand("SELECT * from customer where PRODUCTCARE = " + id, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int id1 = Int32.Parse(table.Rows[i]["id"].ToString());
                string ten = table.Rows[i]["name"].ToString();
                string phone = table.Rows[i]["phone"].ToString();
                string email = table.Rows[i]["email"].ToString();
                Customer_Class kh = new Customer_Class(id, ten, phone, email);
                sp.addcus(kh);
            }
            sp.ObserverInfo("");
            sp.updateProduct(id, idcate, name, price, des);
            loadgridproduct();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

    }
}
