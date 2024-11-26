# Product Manager - README

## Genel Bakış
**Product Manager**, kategoriler, ürünler ve istatistiklerin bir veritabanında yönetilmesi için tasarlanmış bir Windows Forms uygulamasıdır. Bu proje, veritabanı işlemleri için Entity Framework kullanır ve kullanıcı dostu bir arayüz sunar. Uygulama üç ana modülden oluşmaktadır:
1. **Kategori Yönetimi**
2. **Ürün Yönetimi**
3. **İstatistik Panosu**

Aşağıda, her modülün işlevleri ve uygulamanın görsel arayüzüne dair detaylar bulabilirsiniz.

---

## Özellikler
### 1. **Kategori Yönetimi**
- Tüm kategorileri listeleme.
- Yeni bir kategori ekleme.
- Mevcut kategorileri güncelleme.
- Kategorileri silme.
- Formdaki girdileri tek bir buton ile temizleme.

**Ekran Görüntüsü:**
![KategoriYonetimi](https://github.com/user-attachments/assets/9210e7d4-7643-429a-9e1e-ce8be101add6)

---

### 2. **Ürün Yönetimi**
- Tüm ürünleri kategori isimleriyle birlikte listeleme.
- Yeni bir ürün ekleme ve bir kategoriye atama.
- Mevcut ürün bilgilerini düzenleme.
- Ürünleri silme.
- Çift tıklama ile ürün bilgilerini forma aktarma.
- Girdileri temizleme butonu ile sıfırlama.

**Ekran Görüntüsü:**
![UrunYonetimi](https://github.com/user-attachments/assets/7e98c903-e15b-472a-b280-4048e9be8744)


---

### 3. **İstatistik Panosu**
- Kategori sayısını görüntüleme.
- Ürün sayısını görüntüleme.
- Aktif ve pasif müşteri sayılarını listeleme.
- Beyaz eşya kategorisindeki ürün sayısını görme.
- Toplam stok miktarını hesaplama.
- Fiyatı en yüksek ve en düşük ürünleri listeleme.
- Farklı şehirlerdeki müşteri sayılarını listeleme.

**Ekran Görüntüsü:**
![Istatistik](https://github.com/user-attachments/assets/31ac485f-0c66-47f8-a934-6ef2e3c33894)


---

## Kullanılan Teknolojiler
- **C#:** Uygulama geliştirme.
- **Windows Forms:** Kullanıcı arayüzü tasarımı.
- **Entity Framework:** Veritabanı işlemleri.
- **SQL Server:** Veritabanı yönetimi.

---

## Modüller ve İşlevler

### Kategori Modülü
| İşlev        | Açıklama                                                         |
|--------------|------------------------------------------------------------------|
| Listeleme    | Tüm kategorileri DataGridView'da listeler.                       |
| Ekleme       | Yeni bir kategori oluşturur.                                     |
| Güncelleme   | Seçili kategorinin bilgilerini günceller.                        |
| Silme        | Seçili kategoriyi veritabanından kaldırır.                       |
| Temizleme    | Formdaki tüm girdileri sıfırlar.                                 |

---

### Ürün Modülü
| İşlev        | Açıklama                                                         |
|--------------|------------------------------------------------------------------|
| Listeleme    | Tüm ürünleri kategori bilgileriyle birlikte listeler.            |
| Ekleme       | Yeni bir ürün oluşturur ve kategoriye atar.                      |
| Güncelleme   | Seçili ürünün bilgilerini düzenler.                              |
| Silme        | Seçili ürünü veritabanından kaldırır.                            |
| Çift Tıklama | Ürünün bilgilerini forma doldurur.                               |
| Temizleme    | Formdaki tüm girdileri sıfırlar.                                 |

---

### İstatistik Modülü
| İstatistik               | Açıklama                                             |
|--------------------------|-----------------------------------------------------|
| Toplam Kategori Sayısı   | Veritabanındaki kategori sayısını görüntüler.        |
| Toplam Ürün Sayısı       | Veritabanındaki ürün sayısını görüntüler.            |
| Aktif/Pasif Müşteri Sayısı| Müşterilerin durumlarına göre sayısını gösterir.    |
| Beyaz Eşya Sayısı        | Beyaz eşya kategorisindeki ürün sayısını listeler.   |
| Toplam Stok              | Tüm ürünlerin stok miktarlarının toplamını hesaplar. |
| En Yüksek/Düşük Fiyatlı Ürün | Ürün isimlerini sıralar ve en yüksek/düşük fiyatlı olanı gösterir. |

---

## Kurulum ve Çalıştırma
1. Projeyi [GitHub](https://github.com/vahap-18/ProductManager) üzerinden klonlayın.
2. **SQL Server** üzerinde gerekli veritabanını oluşturun ve bağlantı ayarlarını `App.config` dosyasında düzenleyin.
3. Projeyi Visual Studio ile açın ve derleyin.
4. Uygulamayı başlatmak için `AnaForm` formunu çalıştırın.


