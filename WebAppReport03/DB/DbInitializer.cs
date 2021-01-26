using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppReport03.Models;

namespace WebAppReport03.DB
{
    public static class DbInitializer
    {
        public static void Initialize(AplikasiSuratContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.TblSrtTugass.Any())
            {
                return;   // DB has been seeded
            }

            var srtTgss = new TblSrtTugas[]
            {
            new TblSrtTugas{No_Surat="B-55/Kk.11.35/1/KU.00/01/2020",
                            Dasar_1="Peraturan Menteri Agama nomor 19 tahun 2019 " +
                                    "tentang Organisasi dan Tata Kerja Instansi " +
                                    "Vertikal Kementerian Agama",
                            Dasar_2="Surat Kepala Kanwil Kemenag Prov. Jateng nomor " +
                                    "10846/Kw.11.1/1/KP.02.3/09/2020 tentang Undangan Peserta",
                            Nama="Naufal Perdana",
                            NIP ="198506202011011012",
                            Pangkat_Gol="Penata ( III/c )",
                            Jabatan="Perencana Pertama",
                            Unit="Kantor Kementerian Agama Kota Tegal",
                            Kegiatan="Kegiatan Koordinasi Penyusunan Pagu Anggaran Tahun 2021 " +
                                     "dan Sosialisasi e-DUPAK Perencana",
                            Hari_Tanggal_Keg="Rabu, 20 Januari 2021",
                            Tempat_Keg="Kanwil Kemenag Prov. Jateng Jl. Sisingamangaraja Semarang",
                            Waktu_Keg="10.00 WIB",
                            Tempat_ttd="Tegal",
                            Tanggal_ttd=DateTime.Parse("2020-01-20"),
                            Jabatan_ttd="Kepala",
                            Penandatangan="Akhmad Farkhan"
            },
            };
            foreach (TblSrtTugas s in srtTgss)
            {
                context.TblSrtTugass.Add(s);
            }
            context.SaveChanges();            
        }
    }
}
