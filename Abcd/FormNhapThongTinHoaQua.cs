using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abcd
{
    public partial class FormNhapThongTinHoaQua : Form
    {
        public FormNhapThongTinHoaQua()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        public HoaQua LayThongTinHoaQua()
        {
            HoaQua hoaQua = new HoaQua();
            hoaQua.Ten = Ten.Text;
            hoaQua.Loai = Loai.Text;
            hoaQua.Gia = Convert.ToDouble(Gia.Text);
            hoaQua.SoLuong = Convert.ToInt32(SoLuong.Text);
            hoaQua.HanSuDung = DateTime.Parse(HanSuDung.Text);

            return hoaQua;
        }
    }
}
