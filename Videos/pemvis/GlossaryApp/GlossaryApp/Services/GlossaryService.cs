// ini service untuk menyimpan data glosarium secara non-database
// menggunakan list agar mudah di-crud
// juga menyediakan fungsi random untuk quiz

using GlossaryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GlossaryApp.Services
{
    public class GlossaryService
    {
        private List<GlossaryItem> _items = new List<GlossaryItem>();
        private int _counter = 1; // untuk id

        public GlossaryService()
        {
            // data awal sesuai permintaan
            SeedData();
        }

        private void SeedData()
        {
            // programming
            Add(new GlossaryItem { Term = "Variable", Definition = "wadah untuk menyimpan nilai", Category = GlossaryCategory.Programming });
            Add(new GlossaryItem { Term = "Function", Definition = "blok kode yang dapat dipanggil", Category = GlossaryCategory.Programming });
            Add(new GlossaryItem { Term = "Class", Definition = "template untuk membuat objek", Category = GlossaryCategory.Programming });
            Add(new GlossaryItem { Term = "Loop", Definition = "perulangan menjalankan kode berulang", Category = GlossaryCategory.Programming });
            Add(new GlossaryItem { Term = "Array", Definition = "kumpulan nilai dalam satu variabel", Category = GlossaryCategory.Programming });

            // network
            Add(new GlossaryItem { Term = "IP Address", Definition = "alamat unik pada jaringan", Category = GlossaryCategory.Network });
            Add(new GlossaryItem { Term = "Router", Definition = "perangkat untuk menghubungkan jaringan", Category = GlossaryCategory.Network });
            Add(new GlossaryItem { Term = "DNS", Definition = "sistem penamaan domain", Category = GlossaryCategory.Network });
            Add(new GlossaryItem { Term = "Firewall", Definition = "pengaman jaringan dari akses ilegal", Category = GlossaryCategory.Network });
            Add(new GlossaryItem { Term = "Bandwidth", Definition = "kapasitas transfer data", Category = GlossaryCategory.Network });

            // os
            Add(new GlossaryItem { Term = "Kernel", Definition = "inti dari sistem operasi", Category = GlossaryCategory.OperatingSystem });
            Add(new GlossaryItem { Term = "Process", Definition = "program yang sedang berjalan", Category = GlossaryCategory.OperatingSystem });
            Add(new GlossaryItem { Term = "Thread", Definition = "unit kecil dari proses", Category = GlossaryCategory.OperatingSystem });
            Add(new GlossaryItem { Term = "File System", Definition = "struktur penyimpanan file", Category = GlossaryCategory.OperatingSystem });
            Add(new GlossaryItem { Term = "Scheduler", Definition = "pengatur eksekusi proses", Category = GlossaryCategory.OperatingSystem });

            // cloud
            Add(new GlossaryItem { Term = "IaaS", Definition = "layanan infrastruktur cloud", Category = GlossaryCategory.Cloud });
            Add(new GlossaryItem { Term = "PaaS", Definition = "layanan platform cloud", Category = GlossaryCategory.Cloud });
            Add(new GlossaryItem { Term = "SaaS", Definition = "layanan software cloud", Category = GlossaryCategory.Cloud });
            Add(new GlossaryItem { Term = "Scalability", Definition = "kemampuan menambah resource", Category = GlossaryCategory.Cloud });
            Add(new GlossaryItem { Term = "Virtualization", Definition = "abstraksi hardware menjadi virtual", Category = GlossaryCategory.Cloud });
        }

        public List<GlossaryItem> GetAll() => _items;

        public List<GlossaryItem> GetByCategory(GlossaryCategory category)
            => _items.Where(i => i.Category == category).ToList();

        public void Add(GlossaryItem item)
        {
            item.Id = _counter++;
            _items.Add(item);
        }

        public void Update(GlossaryItem item)
        {
            var exist = _items.FirstOrDefault(x => x.Id == item.Id);
            if (exist == null) return;
            exist.Term = item.Term;
            exist.Definition = item.Definition;
            exist.Category = item.Category;
        }

        public void Delete(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item != null) _items.Remove(item);
        }

        public GlossaryItem GetRandomItem()
        {
            Random rnd = new Random();
            return _items[rnd.Next(_items.Count)];
        }

        public List<string> GetRandomOptions(string correct, int jumlah)
        {
            Random rnd = new Random();
            return _items
                .Where(i => i.Definition != correct)
                .Select(i => i.Definition)
                .OrderBy(_ => rnd.Next())
                .Take(jumlah)
                .ToList();
        }
    }
}
