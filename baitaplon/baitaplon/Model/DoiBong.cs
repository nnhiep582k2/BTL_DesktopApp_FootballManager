using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaplon.View
{
    internal class DoiBong
    {
        private string madb;
        private string tendb;
        private string hvldb;
        private byte[] anh;
        private string masan;
        private string matinh;

        public DoiBong(string madb, string tendb, string hvldb, byte[] anh, string masan, string matinh)
        {
            this.madb = madb;
            this.tendb = tendb;
            this.hvldb = hvldb;
            this.anh = anh;
            this.masan = masan;
            this.matinh = matinh;
        }

        public string Madb { get => madb; set => madb = value; }
        public string Tendb { get => tendb; set => tendb = value; }
        public string Hvldb { get => hvldb; set => hvldb = value; }
        public byte[] Anh { get => anh; set => anh = value; }

        public string Masan { get => masan; set => masan = value; }
        public string Matinh { get => matinh; set => matinh = value; }
    }
}
