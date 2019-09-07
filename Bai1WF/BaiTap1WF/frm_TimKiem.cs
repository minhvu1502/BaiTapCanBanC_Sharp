using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1WF
{
    public partial class frm_TimKiem : Form
    {
        List<TienDien> listTienDiens = new List<TienDien>();
        public frm_TimKiem()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            int timkiem = 0;
            foreach (TienDien i in listTienDiens)
            {
                if (i.tenKH == textBox1.Text)
                {
                    timkiem = 1;
                    MessageBox.Show("Tìm Thấy");
                    listBox1.Items.Add("Thông Tin");
                    listBox1.Items.Add("Tên Khách Hàng: " + i.tenKH);
                    listBox1.Items.Add("Số Tiền Phải Trả: " + i.tienTra.ToString());
                }

            }
            if (timkiem == 0)
                MessageBox.Show("Không Tìm Thấy Khách Hàng " + textBox1.Text);
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
