using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UASBAP
{
    public class DataLaporan
    {
        public string NomorAkun { get; set; }
        public string NomorSubAkun { get; set; }
        public int NomorTransaksi { get; set; }
        public string NamaAkun { get; set; }
        public string? NamaSubAkun { get; set; }
        public string TipeAkun { get; set; }
        public string JenisAkun { get; set; }
        public string NamaTransaksi { get; set; }
        public int? Jumlah { get; set; }
        public DateTime? Tanggal_From { get; set; }
        public DateTime? Tanggal_To { get; set; }

        public DataLaporan(string nomorakun, string nomorsub, string tipe, string jenis,
            string namatransaksi, DateTime? tgl_from, DateTime? tgl_to, int? jumlah, string? namasubakun)
        {
            this.NomorAkun = nomorakun;
            this.NomorSubAkun = nomorsub;
            this.TipeAkun = tipe;
            this.JenisAkun = jenis;
            this.NamaTransaksi = namatransaksi;
            this.Tanggal_From = tgl_from;
            this.Tanggal_To = tgl_to; 
            this.Jumlah = jumlah;
            this.NamaSubAkun = namasubakun;
        }

    }
}
