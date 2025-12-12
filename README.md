
# 📚 RANGKUMAN PROJEK
## Aplikasi Glosarium Interaktif & Quiz WinForms

merupakan aplikasi desktop berbasis **Windows Forms (WinForms)** yang dikembangkan menggunakan **Visual Studio**. Aplikasi ini menggunakan studi kasus **E-Education**, untuk membantu mahasiswa memahami istilah-istilah dasar dalam pemrograman melalui:

* **Glosarium lengkap dengan CRUD**
* **Mode Quiz Pilihan Ganda** (acak setiap kali dibuka)

Aplikasi terdiri dari beberapa form: `MainForm`, `AddForm`, `EditForm`, `QuizForm`, dan `ViewAllForm`, yang saling terhubung melalui controller dan service internal.

Agar memenuhi ketentuan mata kuliah, aplikasi ini menerapkan seluruh elemen wajib, di antaranya:

---

### 1. Common Controls – (Letak di Source Code & Fungsinya)
Common controls digunakan untuk membangun antarmuka utama. Semua terdapat dalam:
📍 `MainForm.cs`, `AddForm.cs`, `EditForm.cs`, `QuizForm.cs`, `ViewAllForm.cs`

| Kontrol | Penggunaan/Lokasi | Fungsi Utama |
| :--- | :--- | :--- |
| **Label** | Digunakan untuk judul, heading, dan penanda input. Contoh lokasi: `MainForm.cs` → Label “Total Istilah”, “Kategori”. | Membuat informasi UI jelas dan terstruktur. |
| **TextBox** | Digunakan untuk memasukkan nama istilah dan definisi. Lokasi: `AddForm.cs` & `EditForm.cs`. | Input teks dari pengguna (istilah & definisi). |
| **Button** | Dipakai untuk: Tambah, Edit, Hapus, Mulai Quiz, Cek Jawaban, Tampilkan Definisi. Lokasi: semua form. | Memicu event utama aplikasi (aksi pengguna). |
| **ComboBox** | Digunakan untuk memilih kategori glosarium. Lokasi: `AddForm.cs`, `EditForm.cs`, `MainForm.cs`. | Pemilihan kategori glosarium (**enum**). |
| **DataGridView** | Digunakan untuk menampilkan seluruh istilah dalam bentuk tabel. Lokasi: `ViewAllForm.cs`. | Tampilan tabel data glosarium secara terstruktur. |
| **RadioButton** | Digunakan pada quiz sebagai opsi jawaban. Lokasi: `QuizForm.cs`. | Memilih jawaban *multiple-choice* (hanya satu). |

---

### 2. Container Controls – (Letak di Source Code & Fungsinya)
Container controls digunakan untuk mengatur tata letak.
📍 `MainForm.cs`, `QuizForm.cs`, `AddForm.cs`

| Kontrol | Lokasi | Fungsi Utama |
| :--- | :--- | :--- |
| **Panel** | `MainForm.cs`. | Mengatur layout modern dan membagi area UI. |
| **GroupBox** | `QuizForm.cs`. | Mengelompokkan radio button pada quiz (memastikan hanya satu jawaban dipilih). |
| **Form** (sebagai container utama) | Seluruh `.cs` form. | Tampilan layar utama dan dialog aplikasi. |

---

### 3. Button & Menu Events – (Letak di Source Code & Fungsinya)
Semua event ditulis dalam bentuk: `private void btnNamaTombol_Click(object sender, EventArgs e)`.
📍 `MainForm.cs`, `AddForm.cs`, `EditForm.cs`, `QuizForm.cs`

| Event | File | Fungsi Utama |
| :--- | :--- | :--- |
| **Tombol Tambah** | `AddForm.cs` | Menambah istilah baru ke daftar glosarium. |
| **Tombol Edit** | `EditForm.cs` | Memperbarui istilah yang telah dipilih. |
| **Tombol Hapus** | `MainForm.cs` | Menghapus data dengan permintaan konfirmasi. |
| **Tombol Mulai Quiz** | `MainForm.cs` | Membuka `QuizForm` dan mengacak soal quiz. |
| **Tombol Cek Jawaban** | `QuizForm.cs` | Memeriksa apakah jawaban yang dipilih pengguna benar/salah. |

---

### 4. MessageBox – (Letak di Source Code & Fungsinya)
`MessageBox` digunakan untuk interaksi notifikasi.
📍 `MainForm.cs`, `QuizForm.cs`, `AddForm.cs`, `EditForm.cs`

**Fungsi:**
* Memberi tahu data berhasil ditambah/diedit.
* Memperingatkan jika input kosong/tidak valid.
* Menanyakan konfirmasi penghapusan.
* Memberi tahu hasil akhir quiz.

Contoh penggunaan:
``csharp
MessageBox.Show("Istilah berhasil ditambahkan!"); `

### 5. Form & Custom Dialog – (Letak di Source Code & Fungsinya)
Aplikasi menggunakan beberapa `Form` untuk modularitas:

* `MainForm.cs` – Tampilan utama/dashboard.
* `AddForm.cs` – Dialog untuk menambah istilah.
* `EditForm.cs` – Dialog untuk mengubah istilah.
* `QuizForm.cs` – Tampilan mode quiz.


**Fungsi:** Memisahkan fitur agar lebih rapi, menjadi *container* UI, dan mengelola input secara modular.

---

### 6. Variabel – (Letak di Source Code & Fungsinya)
Variabel digunakan untuk menyimpan data dinamis.
📍 `QuizForm.cs`, `MainForm.cs`, `GlossaryService.cs`

Contoh variabel:
```csharp
private int currentQuizIndex;
private List<GlossaryItem> items;
private string selectedAnswer;
```
Fungsinya: Menyimpan data quiz, data sementara untuk CRUD, pilihan user, dan jumlah istilah.

### 7. Konstanta – (Letak di Source Code & Fungsinya)
Konstanta digunakan untuk nilai yang tetap dan konsisten.
📍 `QuizForm.cs`

Contoh:
```csharp
private const int OptionCount = 4;
```
**Fungsi:** Menentukan jumlah pilihan jawaban pada quiz (misalnya, selalu 4), memastikan nilai tetap konsisten.

### 8. Operator Aritmatika – (Letak di Source Code & Fungsinya)
Operator aritmatika digunakan untuk perhitungan statistik.
📍 `MainForm.cs` → bagian statistik istilah

Contoh:
```csharp
int countProgramming = items.Count(x => x.Category == Category.Programming);
int total = countProgramming + countCloud + countOS;
```
**Fungsinya:** Menghitung jumlah istilah per kategori (menggunakan operator penghitungan/fungsi agregasi) dan menjumlahkan total istilah (menggunakan operator `+`) untuk ditampilkan pada dashboard/statistik.

### 9. Enumeration (Enum) – (Letak di Source Code & Fungsinya)
Enum digunakan untuk mengatur pilihan kategori yang terbatas.
📍 Models/Category.cs
```csharp
public enum Category
{
    Programming,
    Network,
    Database,
    Cloud,
    OperatingSystem
}
```
Fungsinya: Mengatur kategori glosarium, memastikan input kategori selalu valid, dan menyederhanakan filtering data.

### 10. Fitur Utama Aplikasi

a. Glosarium (CRUD)
Fitur inti ini dikelola melalui GlossaryService.cs (Service Layer):
Tambah istilah
Lihat daftar istilah
Edit istilah
Hapus istilah

b. Quiz Pilihan Ganda
Mengacak soal dari daftar istilah.
Menampilkan pertanyaan dan jawaban acak.
Menyediakan tombol cek jawaban dan lihat definisi.
Soal berubah setiap kali quiz dibuka (dinamis).
Logika quiz berada di: 📍 QuizForm.cs + GlossaryService.cs.
