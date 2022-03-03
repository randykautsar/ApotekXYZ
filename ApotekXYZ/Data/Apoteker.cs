using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApotekXYZ.Data
{
    public class Apoteker
    {
        [Key]
        public string kodeApoteker { get; set; }
        public string namaApoteker { get; set; }
        public DateTime tanggalLahir { get; set; }
    }
}
