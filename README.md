<li><strong>BusinessRules</strong> Classı oluşturularak t&uuml;m iş kuralları buradan &ccedil;ağrılması sağlandı.</li>
<li>Resim Ekleme Base işlemleri yapıldı.</li>
<li>Resimler GUID ile proje i&ccedil;erisine kopyalanması ve veri tabanına Path in yazılması sağlandı.&nbsp;</li>
<li>Validasyon Testi her ara&ccedil; i&ccedil;in 5 resim olacak şekilde sınırlandırıldı.</li>
<li>Resim olmayan ara&ccedil;lara default logo g&ouml;sterilmesi sağlandı.</li>
<li>Farklı senaryolar ile t&uuml;m testler yapıldı sorunsuz &ccedil;alışıyor.</li>
</ol>
<hr />
<p><strong><span style="text-decoration: underline;"><span style="color: #ff0000; text-decoration: underline;">[Bilinen Hatalar]</span></span></strong></p>
<ul>
<li><strong><span style="color: #ff0000;">[Sorun 1]</span> </strong>Validasyon başarılı olsa da olmasa da dosya klas&ouml;re kopyalanıyor fakat veri tabanına yazmıyor.</li>
</ul>
<p style="padding-left: 80px;"><strong><em><span style="color: #008000;">[&Ccedil;&ouml;z&uuml;mlendi 1]</span></em></strong> Dosya kopyalama işlemi validasyon sonrasına par&ccedil;alanarak dağıtıldı.</p>
<ul>
<li><strong><span style="color: #ff0000;">[Sorun 2]</span></strong> Resim G&uuml;ncelleme işlemi sonrasında path veri tabanına yansıyor yeni dosyayı kopyalıyor fakat eski dosya silinmiyor.</li>
</ul>
<p style="padding-left: 80px;"><em><strong><span style="color: #008000;">[&Ccedil;&ouml;z&uuml;mlendi 2]</span> </strong></em>Kopyalama sonrası &ouml;nceki resim yolundan silinmesi sağlandı.</p>
<ul>
<li><strong><span style="color: #ff0000;">[Sorun 3]</span> </strong>T&uuml;m işlemler ImageUpload tarafında yapılarak Api tarafına sadece CarImage nesnesi d&ouml;nd&uuml;rmeye &ccedil;alışılıyor.</li>
</ul>
<p style="padding-left: 80px;"><em><strong><span style="color: #008000;">[&Ccedil;&ouml;z&uuml;mlendi 3]</span></strong></em> Code refactor edilerek işlemlerin tamamen class tarafında yapılması sağlandı.</p>
<ul>
<li><strong><span style="color: #ff0000;">[Sorun 4]</span> </strong>Araca ait resim olmaması durumunda default image d&ouml;nm&uuml;yor.</li>
</ul>
<p style="padding-left: 80px;"><em><strong><span style="color: #008000;">[&Ccedil;&ouml;z&uuml;mlendi 4]</span> </strong></em>Veri tabanı kaynaklı Null Exception hatası &ccedil;&ouml;z&uuml;ld&uuml;.</p>
<ul>
<li><span style="color: #ff0000;"><strong>[Sorun 5]</strong> </span>ImageUpload işlemlerinin yapıldığı class web abi tarafında newlenerek kullanılabiliyor. Olması gereken yapıya g&ouml;re değiştirilmeye &ccedil;alışılıyor.</li>
</ul>
<p style="padding-left: 80px;"><span style="color: #ff6600;"><em><strong>[&Ccedil;&ouml;z&uuml;lmedi 5]</strong></em></span> Araştırılıyor.</p>
