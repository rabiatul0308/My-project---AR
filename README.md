# Sriwijaya AR

Media pembelajaran **Augmented Reality (AR)** interaktif berbasis Android yang menampilkan model 3D artefak dan prasasti peninggalan **Kerajaan Sriwijaya** secara *real-time*.

## Fitur Utama

* **Visualisasi Artefak & Prasasti 3D:** Memindai marker gambar secara *real-time* untuk menampilkan objek 3D peninggalan Kerajaan Sriwijaya secara interaktif.
* **Edukasi Sejarah Interaktif:** Dirancang khusus sebagai media pembelajaran digital yang menarik dan informatif.
* **Mobile Optimized:** Antarmuka ringan dan responsif untuk perangkat Android.

## Teknologi & Aset

* **Game Engine:** Unity `2022.3.62f3`
* **AR SDK:** Vuforia Engine `11.4.4`
* **3D Asset Generation:** Tripo AI
* **Bahasa Pemrograman:** C#
* **Target Platform:** Android

## Cara Menjalankan Proyek

1. **Clone repositori:**
   ```bash
   git clone https://github.com/rabiatul0308/My-project---AR.git
   ```

2. **Buka di Unity Hub:**
   * Klik **Add** > **Add project from disk**, lalu pilih folder proyek hasil *clone*.
   * Gunakan **Unity Editor `2022.3.62f3`** (atau versi 2022.3 LTS yang kompatibel) dengan modul **Android Build Support**.

3. **Konfigurasi Vuforia:**
   * Pastikan package **Vuforia Engine AR** telah terpasang di dalam proyek.
   * Masukkan *Vuforia License Key* melalui menu **Window > Vuforia Configuration**.

4. **Build ke Android:**
   * Buka **File > Build Settings**, pilih platform **Android**, lalu klik **Build And Run**.

## Struktur Proyek

```text
├── Assets/             # Scene, script C#, model 3D (Tripo), UI, dan aset AR
├── Packages/           # Konfigurasi dependency package Unity
├── ProjectSettings/    # Pengaturan proyek, input, dan player Android
└── .gitignore          # Pengecualian file sementara & build Unity
```

## Tentang Proyek

Dikembangkan sebagai bagian dari program kokurikuler kolaboratif antara siswa **Kelas X PPLG** dan Tutor Sebaya **Kelas XI (Pengurus ORENS SOLUTION) SMK Prestasi Prima**, dengan bimbingan guru dan pembimbing sekolah.

## Lisensi

Proyek ini dirilis secara terbuka di bawah lisensi **Open Source**. Lihat file `LICENSE` untuk detail ketentuan penggunaan dan distribusi.

---
*Dikembangkan oleh [rabiatul0308](https://github.com/rabiatul0308)*
