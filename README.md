## HenDev Rent A Car

> ###### *engindemirog tarafından ücretsiz sunulan kursa eşzamanlı geliştirlen araç kiralama projesi*

***Güncelleme Geçmişi***

**14.Gün Sonu:**
- Authorization JWT Entegrasyonu Yapıldı.
- Login işlemleri sonrası Postman ile Token oluşturulduğu test edildi.

**13.Gün Sonu:**
- *UploadPreocessHelper* classı olusturlarak tum dosyalama işlemlerinin burda yapılması sağlandı.
- Kopyalama sonrası önceki resim yolundan dosyanın silinmesi sağlandı.
- *BusinessRules*  Classı oluşturularak tüm iş kuralları buradan çağrılması sağlandı.
- Resim Ekleme Base işlemleri yapıldı.
- Resimler GUID ile proje içerisine kopyalanması ve veri tabanına Path in yazılması sağlandı.
- Validasyon Testi her araç için 5 resim olacak şekilde sınırlandırıldı.
- Resim olmayan araçlara default logo gösterilmesi sağlandı.
- Farklı senaryolar ile tüm testler yapıldı sorunsuz çalışıyor.

----------

***Bilnen Hatalar***

### v 1.14
 - [ ] Auth Login şifre doğru olmasına rağmen hatalı dönüş yapıyor
 - [ ] Add Entity Güvenlik adımlarına takılarak ekleme işlemi yapmıyor.
 ---
### v 1.13
- [X] Validasyon başarılı olsa da olmasa da dosya klasöre kopyalanıyor fakat veri tabanına yazmıyor.
- [X] Resim Güncelleme işlemi sonrasında path veri tabanına yansıyor yeni dosyayı kopyalıyor fakat eski dosya silinmiyor.
- [X] Tüm işlemler ImageUpload tarafında yapılarak Api tarafına sadece CarImage nesnesi döndürmeye çalışılıyor.
- [X] Araca ait resim olmaması durumunda default image dönmüyor.
- [X] ImageUpload işlemlerinin yapıldığı class web abi tarafında newlenerek kullanılabiliyor. Olması gereken yapıya göre değiştirilmeye çalışılıyor.

---
***Engin Demiroğ'a Sonsuz Teşekkürler.***

[engindemirog Github](https://github.com/engindemirog)

[Engin DEMİROĞ Youtube](https://www.youtube.com/channel/UCRjiquPh4mjPNoOV9eCilXQ)

[Proje Sayfası Kodlama.io](https://www.kodlama.io)

----
***SQL Queries***

    SELECT * FROM Cars --will be added soon
