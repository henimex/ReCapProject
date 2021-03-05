     HenDev Rent A Car

> ###### *engindemirog tarafından ücretsiz sunulan kursa eşzamanlı geliştirilen araç kiralama projesi*

    Güncelleme Geçmişi

**16.Gün Sonu:**
- Frontend...

**15.Gün Sonu:**
- JWT Entegrasyonu düzenlemesi yapıldı.
- Caching Aspectleri devreye alınıp test edildi.
- Basit ama etkili Performans Aspecti hazırlanıp test edildi.
- Transactional işlemler için altyapı oluşturulup basit durumlar için test senrayosu eklendi.
- Api Dependency Injectionlar Core tarafında çözümlenmesi sağlandı.

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

    Bilnen Hatalar
### v 1.15
 - [X] Hata tespit edilmedi.
 ---
### v 1.14
 - [X] Auth Login şifre doğru olmasına rağmen hatalı dönüş yapıyor.
 - [X] Add Entity Güvenlik adımlarına takılarak ekleme işlemi yapmıyor.
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
[All SQL Queries](https://github.com/henimex/ReCapProject/blob/master/SQL%20Queries.sql)
	
	Last Updated Queries
	CREATE TABLE [dbo].[Users]
	(
	    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	    [FirstName] VARCHAR(50) NOT NULL, 
	    [LastName] VARCHAR(50) NOT NULL, 
	    [Email] VARCHAR(50) NOT NULL, 
	    [PasswordHash] VARBINARY(500) NOT NULL, 
	    [PasswordSalt] VARBINARY(500) NOT NULL, 
	    [Status] BIT NOT NULL
	)

	CREATE TABLE [dbo].[OperationClaims]
	(
	    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	    [Name] VARCHAR(250) NOT NULL
	)

	CREATE TABLE [dbo].[UserOperationClaims]
	(
	    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	    [UserId] INT NOT NULL, 
	    [OperationClaimId] INT NOT NULL
	)


----

     Süreç Takibi
| Gün | Ders Programı | Yayın Linki|
|--|--|--|
| 1 | Python Basic | [Day 01](https://www.youtube.com/watch?v=S_A_VVSQdpU&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&ab_channel=EnginDemiro%C4%9F)
| 2 | Değişkenler, Şart Blokları | [Day 02](https://www.youtube.com/watch?v=FB7VUYLyl1I&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=2&ab_channel=EnginDemiro%C4%9F)
| 3 | Algoritmik Örnekleme ve Altyapı Pekiştirme | [Day 03](https://www.youtube.com/watch?v=1j68gb1-qOw&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=3&ab_channel=EnginDemiro%C4%9F)
| 4 | Nesne Yönelimli Programlamaya Giriş |[Day 04](https://www.youtube.com/watch?v=G0sOB_-WkyI&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=4&ab_channel=EnginDemiro%C4%9F)
| 5 | Nesne Yönelimli Programlamada Uzmanlaşma |[Day 05](https://www.youtube.com/watch?v=MU_YQtgdkKA&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=5&ab_channel=EnginDemiro%C4%9F)
| 6 | Veritabanı Oluşturma ve Temelleri |[Day 06](https://www.youtube.com/watch?v=r_pbdopB4LU&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=6&ab_channel=EnginDemiro%C4%9F)
| 7 | LinQ Veri Sorgulama Teknikleri |[Day 07](https://www.youtube.com/watch?v=qBQOqh844Mo&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=7&ab_channel=EnginDemiro%C4%9F)
| 8 | Entity Framework |[Day 08](https://www.youtube.com/watch?v=ow-EHetuNAU&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=8&ab_channel=EnginDemiro%C4%9F)
| 9 | Çok Katmanlı Mimariler |[Day 09](https://www.youtube.com/watch?v=Hgqqoycoh9c&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=9&ab_channel=EnginDemiro%C4%9F)
| 10 | Web API Giriş |[Day 10](https://www.youtube.com/watch?v=NlAj9dT3MiA&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=10&ab_channel=EnginDemiro%C4%9F)
| 11 | Web API İleri Seviye |[Day 11](https://www.youtube.com/watch?v=LZqMmvgCNx0&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=11&ab_channel=EnginDemiro%C4%9F)
| 12 | Aspects |[Day 12](https://www.youtube.com/watch?v=cSmUHlnHOXI&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=12&ab_channel=EnginDemiro%C4%9F)
| 13 | İş Kuralları Oluşturma|[Day 13](https://www.youtube.com/watch?v=zdpPm7Q6YE0&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=13&ab_channel=EnginDemiro%C4%9F)
| 14 | Kullanıcı İşlemleri Authorization PasswordHash|[Day 14](https://www.youtube.com/watch?v=2DchBG--kAs&ab_channel=EnginDemiro%C4%9F)
| 15 | Cache, Transaction, API Injection |[Day 15](https://www.youtube.com/watch?v=mbl4BjQMX78&ab_channel=EnginDemiro%C4%9F)
