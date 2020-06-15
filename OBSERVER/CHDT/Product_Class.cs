using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHDT
{
    class Product_Class : Observer
    {
        private string proname;
        List<Customer_Class> listcustomer = new List<Customer_Class>();
        Dataprovider mydb = new Dataprovider();
        public string ProName { get => proname; set => proname = value; }

        public override void ObserverInfo(string info)
        {
           foreach(Customer_Class item in listcustomer)
            {
                if(item !=null)
                {
                    item.ObserverInfo(proname);
                }
            }
        }
        public void addcus(Customer_Class kh)
        {
            if (kh != null)
            {
                listcustomer.Add(kh);
            }
        }
        public void delcus(Customer_Class kh)
        {
            if (kh != null)
            {
                listcustomer.Remove(kh);
            }
        }
        //public static List<KHACHHANG> loadkhachhang(int idproduct)
        //{
        //    //List<string> khachhang = new List<string>();
        //    //loadlen datatable
        //    //List<KHACHHANG> listkhachhang = new List<KHACHHANG>();
        //    SqlCommand command = new SqlCommand("SELECT  from customer where PRODUCTCARE =" + idproduct);
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);

        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
        //        int id = Int32.Parse( table.Rows[i]["id"].ToString());
        //        string ten = table.Rows[i]["name"].ToString();
        //        string phone = table.Rows[i]["phone"].ToString();
        //        string email = table.Rows[i]["email"].ToString();
        //        KHACHHANG kh = new KHACHHANG(id, ten, phone, email);
        //        listkhachhang.Add(kh);
        //    }
        //    return listkhachhang;
        //}
        public Product_Class(string proname)
        {
            this.ProName = proname;
        }
        
        public bool updateProduct(int Id,int idcategory ,string name, float price, string des)
        {
            SqlCommand command = new SqlCommand("update PRODUCT set NAME=@name,PRICE=@price,DESCRIPT=@des where id =@id"
              , mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@idcategory", SqlDbType.VarChar).Value = idcategory;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@price", SqlDbType.Float).Value = price;
            command.Parameters.Add("@des", SqlDbType.NVarChar).Value = des;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        
      

       
      
    }
}
