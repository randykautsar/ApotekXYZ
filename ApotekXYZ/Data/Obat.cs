using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApotekXYZ.Data
{
    public class Obat
    {
        [Key]
        public string kodeObat { get; set; }
        public string namaObat { get; set; }
        public double HargaObat { get; set; }
        public Int64 sisaObat { get; set; }
        public DateTime tanggalKadaluarsa { get; set; }
    }
}
