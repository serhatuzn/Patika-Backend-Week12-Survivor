# Survivor Project 🎯

## 📖 Proje Hakkında
Bu proje, **Patika Backend Week12 Survivor** kapsamında geliştirilmiş bir uygulamadır. Proje, çeşitli kategorilerde yarışmacıların yönetimi ve veritabanı işlemlerini içerir.

---

## 📂 Dizin Yapısı
```
Patika Backend Week12 Survivor/
├── Survivor/
│   ├── appsettings.Development.json         # Geliştirme ortamı için ayarlar
│   ├── appsettings.json                     # Genel yapılandırma dosyası
│   ├── Program.cs                           # Uygulama giriş noktası
│   ├── Controllers/                         # API kontrolörleri
│   │   ├── CategoryController.cs            # Kategori yönetimi API'si
│   │   ├── CompetitorController.cs          # Yarışmacı yönetimi API'si
│   ├── Data/                                # Veritabanı bağlamı
│   │   ├── SurvivorDbContext.cs             # Veritabanı yapılandırma ve işlemleri
│   ├── Models/                              # Veri modelleri
│   │   ├── BaseEntity.cs                    # Taban sınıfı
│   │   ├── Category.cs                      # Kategori modeli
│   │   ├── Competitiors.cs                  # Yarışmacı modeli
│   ├── Migrations/                          # Veritabanı migrasyonları
│   ├── Properties/                          # Proje ayarları
│   │   ├── launchSettings.json              # Çalıştırma ayarları
├── .vs/                                     # Visual Studio ile ilgili dosyalar
└── Survivor.sln                             # Visual Studio çözüm dosyası
```

---

## 🛠 Gereksinimler
Projeyi çalıştırmak için aşağıdaki yazılımlara ihtiyaç vardır:
- [.NET 8.0 SDK](https://dotnet.microsoft.com/)
- Veritabanı yönetim sistemi (PostgreSQL önerilir).

---

## 🚀 Nasıl Çalıştırılır?
1. Proje dizinine gidin:
   ```bash
   cd Survivor
   ```
2. Gerekli bağımlılıkları yükleyin:
   ```bash
   dotnet restore
   ```
3. Veritabanı migrasyonlarını çalıştırın:
   ```bash
   dotnet ef database update
   ```
4. Uygulamayı başlatın:
   ```bash
   dotnet run
   ```

---

## 👥 Katkıda Bulunma
Katkıda bulunmak için aşağıdaki adımları izleyin:
1. Projeyi forklayın.
2. Kendi branch'inizi oluşturun (`feature/AmazingFeature`).
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`).
4. Branch'inize push edin (`git push origin feature/AmazingFeature`).
5. Bir Pull Request oluşturun.

---

## 📧 İletişim
Herhangi bir sorunuz varsa, proje sahibine ulaşabilirsiniz.

---

Happy Coding! 💻🚀
