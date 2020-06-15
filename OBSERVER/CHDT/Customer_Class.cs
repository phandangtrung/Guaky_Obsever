using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace CHDT
{
    class Customer_Class : Observer
    {
        private string name;
        private string phone;
        private string email;
        private int id;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }
        public override void ObserverInfo(string info)
        {

            sentmail(name, email, info);
            MessageBox.Show("Đã gửi mail đến " + name + " về sản phẩm " + info);
        }
              
        void sentmail(string name,string email,string info)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("kaitrung99@gmail.com", "daucoaibiet");
                MailMessage msg = new MailMessage();
                msg.To.Add(email);
                msg.From = new MailAddress("kaitrung99@gmail.com");
                msg.Subject = "Cập nhật sản phẩm từ công ty HCMUTE";
                msg.Body = "Thông báo đến : " + name + "  Thông tin sản phẩm :   " + info;
                client.Send(msg);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Customer_Class(int id,string name, string phone,string email)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }
        
    }
}
