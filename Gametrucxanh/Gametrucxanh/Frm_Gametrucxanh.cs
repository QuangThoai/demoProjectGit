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
    public partial class Frm_Gametrucxanh : Form
    {
        public Frm_Gametrucxanh()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int n;
        bool Check_Empty_Textbox(string Text)
        {
            if (string.IsNullOrEmpty(Text))
                return false;
            else
                return true;
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (Check_Empty_Textbox(txt_sohinh.Text))
            {
                n = Int32.Parse(txt_sohinh.Text.ToString());
                ArrayList Hinh = new ArrayList(); //Khai baos mangr de chua random hinh
                int k = 0, j = 0;
                for (int i = 0; i < n * 2; i++)
                {
                    Button Btnhinh = new Button();
                    Btnhinh.Name = "btn" + i.ToString();
                    Btnhinh.Width = 150;
                    Btnhinh.Height = 150;
                    Btnhinh.Top = 10 + j * 150;
                    Btnhinh.Left = 10 + k * 150;
                    Btnhinh.Image = Image.FromFile("Anh/anhnen.png");
                    Btnhinh.Click += btnhinh_Click;
                    if (i < n)                                      //Vì chỉ demo nên chỗ này để n (n phụ thuộc vào hình trong debug
                    {                                               // Tạo random hình vào gắn cho button và arraylist
                        int stt = r.Next(0, n);                      //Phần này chỉ tạo cho nửa số button (sau đó nhân đôi)
                        Btnhinh.Tag = stt;
                        Hinh.Add(stt);
                    }
                    else
                    {                                               // Một nửa button còn lại dựa vào index trong list
                        int stt = r.Next(0, Hinh.Count - 1);
                        Btnhinh.Tag = Hinh[stt];
                        Hinh.RemoveAt(stt);
                    }
                    gbox_trucxanh.Controls.Add(Btnhinh);            //Tạo groupbox để add và foreach button sau này (Tùy sao cũng dc)
                    k++;
                    if (k == 6)                                     //Tạo hàng 6 hình
                    {
                        k = 0; j++;
                    }
                }
            }
            txt_sohinh.Enabled = btn_start.Enabled = false;
            txt_sohinh.Text = string.Empty;
        }
        int SoLanBam = 0;
        string Name_Btn_1, Name_Btn_2, Btn_1, Btn_2;
        void btnhinh_Click(object sender, EventArgs e)
        {
            SoLanBam++;
            int id = (int)((Button)sender).Tag;
            //MessageBox.Show("Nút số \t" + id.ToString() +((Button)sender).Name.ToString() );
            ((Button)sender).Image = Image.FromFile(id.ToString() + ".jpg");
            ((Button)sender).Enabled = false;
            if (SoLanBam % 2 != 0)
            {
                Name_Btn_1 = ((Button)sender).Name.ToString();                       //Lấy name của button đã bấm
                Btn_1 = ((Button)sender).Tag.ToString();                     // Lấy tag hình của button đã bấm
            }
            else
            {
                Name_Btn_2 = ((Button)sender).Name.ToString();
                Btn_2 = ((Button)sender).Tag.ToString();
                ktrahinh(Name_Btn_1, Name_Btn_2, Btn_1, Btn_2);
            }
        }
        void ktrahinh(string btn_name_1, string btn_name_2, string btn_tag_1, string btn_tag_2)
        {
            if (SoLanBam %2==0)
            {
                foreach (Button btn in gbox_trucxanh.Controls)
                {
                    if (btn.Enabled == false)
                    {
                        System.Threading.Thread.Sleep(500);                      //Dừng màn hình khoảng 
                        if (String.Compare(Name_Btn_2, Name_Btn_1) != 0 && String.Compare(btn_tag_1, btn_tag_2) == 0)
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
            btn_restart.Enabled = false;
        }

        private void txt_sohinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            txt_sohinh.Enabled = btn_start.Enabled = true;
            txt_sohinh.Text = string.Empty;
            btn_restart.Enabled = false;
            gbox_trucxanh.Controls.Clear();
        }
    }
}
