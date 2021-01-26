using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppReport03.Models
{
    public class TblSrtTugas
    {
        [Key]
        public int IdSrtTgs { get; set; }
        public string No_Surat { get; set; }
        public string Dasar_1 { get; set; }
        public string Dasar_2 { get; set; }
        public string Nama { get; set; }
        public string NIP { get; set; }
        public string Pangkat_Gol { get; set; }
        public string Jabatan { get; set; }
        public string Unit { get; set; }
        public string Kegiatan { get; set; }
        public string Hari_Tanggal_Keg { get; set; }
        public string Tempat_Keg { get; set; }
        public string Waktu_Keg { get; set; }
        public string Tempat_ttd { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime Tanggal_ttd { get; set; }
        public string Jabatan_ttd { get; set; }
        public string Penandatangan { get; set; }
    }
}
