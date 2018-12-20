using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Gametrucxanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int n;
        private void btn_start_Click(object sender, EventArgs e)
        {
            
            n= Int32.Parse( txt_sohinh.Text.ToString());
            ArrayList hinh = new ArrayList(); //Khai baos mangr de chua random hinh
            int k = 0, j = 0;
            for (int i = 0; i < n*2; i++)
            {
                Button btnhinh = new Button();
                btnhinh.Name = "btn" + i.ToString();
                btnhinh.Width = 150;
                btnhinh.Height = 150;
                btnhinh.Top = 10 + j * 150;
                btnhinh.Left = 10 + k * 150;
                btnhinh.Image = Image.FromFile("Anh/anhnen.png");
                btnhinh.Click += btnhinh_Click;
                if (i < n)                                      //Vì chỉ demo nên chỗ này để n (n phụ thuộc vào hình trong debug
                {                                               // Tạo random hình vào gắn cho button và arraylist
                    int stt = r.Next(0, n);                      //Phần này chỉ tạo cho nửa số button (sau đó nhân đôi)
                    btnhinh.Tag = stt;
                    hinh.Add(stt);
                }
                else
                {                                               // Một nửa button còn lại dựa vào index trong list
                    int stt = r.Next(0, hinh.Count - 1);
                    btnhinh.Tag = hinh[stt];
                    hinh.RemoveAt(stt);
                }
                gbox_trucxanh.Controls.Add(btnhinh);            //Tạo groupbox để add và foreach button sau này (Tùy sao cũng dc)
                k++;
                if (k == 6)                                     //Tạo hàng 6 hình
                {
                    k = 0; j++;
                }
            }
        }
        int solanbam = 0;
        string a, b, nut1, nut2;
        void btnhinh_Click(object sender, EventArgs e)
        {
            solanbam++;
            int id = (int)((Button)sender).Tag;
            //MessageBox.Show("Nút số \t" + id.ToString() +((Button)sender).Name.ToString() );
            ((Button)sender).Image = Image.FromFile(id.ToString() + ".jpg");
            ((Button)sender).Enabled = false;
            if (solanbam % 2 != 0)
            {
                a = ((Button)sender).Name.ToString();                       //Lấy name của button đã bấm
                nut1 = ((Button)sender).Tag.ToString();                     // Lấy tag hình của button đã bấm
            }
            else
            {
                b = ((Button)sender).Name.ToString();
                nut2 = ((Button)sender).Tag.ToString();
            }
            if (solanbam % 2 == 0)
            {
                ktrahinh(a,b,nut1,nut2);
            }
        }
        void ktrahinh(string btn_name_1, string btn_name_2, string btn_tag_1, string btn_tag_2)
        {
            if (solanbam %2==0)
            {
                foreach (Button btn in gbox_trucxanh.Controls)
                {
                    if (btn.Enabled == false)
                    {
                        System.Threading.Thread.Sleep(500);                      //Dừng màn hình khoảng 
                        if (String.Compare(b, a) != 0 && String.Compare(btn_tag_1,btn_tag_2) == 0)
                        {

                            btn.Visible = false;                            //Xử lý ẩn button
                        }                                                   //Có thể thay bằng hiện hình và tiếp tục
                        else
                        {
                             btn.Image = Image.FromFile("Anh/anhnen.png");
                             btn.Enabled = true;
                           
                        }
                    }
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_design.Text = "Trò chơi được tạo bởi nhóm Windows Nâng cao \n Trần Quang Thoại \n Trịnh Thị Anh \n Đặng Minh Dương";
        }

        private void txt_sohinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
