using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApotekXYZ.Data
{
    public class Transaksi
    {
        [Key]
        public string idTransaksi { get; set; }
    
        public string kodeObat { get; set; }
        public Int64 jumlahJual { get; set; }
 
        public string kodeApoteker { get; set; }
        public DateTime tanggalBeli { get; set; }
    }
}
