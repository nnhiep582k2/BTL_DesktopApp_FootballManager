using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaplon
{
    class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matkhau;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenTaiKhoan, string matkhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matkhau = matkhau;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
