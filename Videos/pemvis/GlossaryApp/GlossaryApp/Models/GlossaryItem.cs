// ini model utama glosarium
// menyimpan istilah, definisi, dan kategori
namespace GlossaryApp.Models
{
    public class GlossaryItem
    {
        public int Id { get; set; } // id unik
        public string Term { get; set; } = ""; // istilah
        public string Definition { get; set; } = ""; // definisi
        public GlossaryCategory Category { get; set; } // kategori
    }
}
