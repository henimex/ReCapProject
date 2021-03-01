## HenDev Rent A Car

> ###### *engindemirog tarafından ücretsiz sunulan kursa eşzamanlı geliştirlen araç kiralama projesi*

***Güncelleme Geçmişi***

**14.Gün Sonu:**
- Authorization JWT Entegrasyonu Yapıldı.
- Login işlemleri sonrası Postman ile Token oluşturulduğu test edildi.

**13.Gün Sonu:**
- *UploadPreocessHelper* classı olusturlarak tum dosyalama işlemlerinin burda yapılması sağlandı.
-   *BusinessRules*  Classı oluşturularak tüm iş kuralları buradan çağrılması sağlandı.
-   Resim Ekleme Base işlemleri yapıldı.
-   Resimler GUID ile proje içerisine kopyalanması ve veri tabanına Path in yazılması sağlandı.
-   Validasyon Testi her araç için 5 resim olacak şekilde sınırlandırıldı.
-   Resim olmayan araçlara default logo gösterilmesi sağlandı.
-   Farklı senaryolar ile tüm testler yapıldı sorunsuz çalışıyor.

----------

***Bilnen Hatalar***

### v 1.14
 - [ ] Auth Login şifre doğru olmasına rağmen hatalı dönüş yapıyor
 *Araştırılıyor.*
 - [ ] Add Entity Güvenlik adımlarına takılarak ekleme işlemi yapmıyor.
 *Araştırılıyor.*
 ---
### v 1.13
 - [ ] Validasyon başarılı olsa da olmasa da dosya klasöre kopyalanıyor
       fakat veri tabanına yazmıyor.
       *Dosya kopyalama işlemi validasyon sonrasına parçalanarak dağıtıldı.*
       
 - [ ] Resim Güncelleme işlemi sonrasında path veri tabanına yansıyor
       yeni dosyayı kopyalıyor fakat eski dosya silinmiyor.
*Kopyalama sonrası önceki resim yolundan silinmesi sağlandı.*
 - [ ] Tüm işlemler ImageUpload tarafında yapılarak Api tarafına sadece
       CarImage nesnesi döndürmeye çalışılıyor.
*Code refactor edilerek işlemlerin tamamen class tarafında yapılması sağlandı.*
 
 - [ ] Araca ait resim olmaması durumunda default image dönmüyor.
*Veri tabanı kaynaklı Null Exception hatası çözüldü.*
 
 - [ ] ImageUpload işlemlerinin yapıldığı class web abi tarafında
       newlenerek kullanılabiliyor. Olması gereken yapıya göre
       değiştirilmeye çalışılıyor.
*Dosyalama Islemi Business katmanına alındı Controller kısmındaki kodlar refactor edildi.*
---
***Engin Demiroğ'a Sonsuz Teşekkürler.***
[engindemirog Github](https://github.com/engindemirog)
[Engin DEMİROĞ Youtube](https://www.youtube.com/channel/UCRjiquPh4mjPNoOV9eCilXQ)
[Proje Sayfası Kodlama.io](https://www.kodlama.io)

----
***SQL Queries***

    SELECT * FROM Cars --will be added soon
