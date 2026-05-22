# Doctor Sim 2.5D Oyun Evreni Referans Belgesi

> **Belge amacı:** Bu dosya, Doctor Sim / Muayene Game tasarım ve geliştirme sürecinde departmanların ihtiyaç halinde ilham almak için başvuracağı referans belgedir.  
> **Kanon durumu:** Bu belge doğrudan kesin kural kitabı değildir. Oyun evreni, progression, hasta akışı, test sistemi, departmanlar, ekonomi ve 2.5D sunum için yön gösterici tasarım kaynağıdır.  
> **Kullanım:** Gameplay, UI/UX, Art, Content, Economy ve Narrative tarafları bu dosyadan fikir alabilir; nihai karar proje yöneticisi / tasarım kararı ile netleşir.

---

## 1. Yüksek Seviye Oyun Fantezisi

Oyuncu küçük ve bağımsız bir muayenehaneyle başlar. Başlangıçta birkaç temel cihaz, sınırlı hasta kapasitesi ve basit rahatsızlıklar vardır. Zamanla oyuncu kliniğini büyütür, yeni tahlil departmanları açar, cihazları upgrade eder, daha karmaşık hastalıkları teşhis eder ve küçük muayenehaneyi gelişmiş bir tanı merkezine dönüştürür.

Ana oyuncu fantezisi sadece “doktor olmak” değildir. Asıl fantezi şudur:

**Belirsizlik altında doğru karar veren, kaynaklarını yöneten ve kliniğini büyüten doktor-yönetici olmak.**

Oyuncu her hastada şu kararları verir:

- Önce hangi muayene yapılmalı?
- Hangi test gerçekten gerekli?
- Hangi test zaman ve para kaybı olur?
- Hasta bekletilebilir mi, yoksa acil mi?
- Klinik içinde mi çözülmeli, yoksa sevk mi edilmeli?
- Upgrade yatırımı cihaza mı, laboratuvara mı, personele mi yapılmalı?

---

## 2. Referans Alınabilecek Oyun Yaklaşımları

Bu proje doğrudan bir oyunun kopyası olmayacak. Ancak şu türlerden ilham alınabilir:

### Two Point Hospital / Theme Hospital çizgisi
- Hastane akışı
- Oda ve cihaz yönetimi
- Hasta kuyruğu
- Para, itibar ve operasyon dengesi
- Eğlenceli ama okunabilir görsel yapı

### Project Hospital çizgisi
- Daha ciddi tanı zinciri
- Branşlar ve departmanlar
- Test / tahlil / görüntüleme mantığı
- Ayırıcı tanı hissi
- Hekimlik kararlarının ağırlığı

### Happy Clinic / Heart’s Medicine çizgisi
- Kısa oturumlu görev yapısı
- Timer baskısı
- Upgrade edilebilir ekipman
- Paket / booster ekonomisi
- Mobil ve tablet dostu oynanış ritmi

**Doctor Sim yönü:** Bu üç çizginin ortasında durmalı: ciddi ama boğucu değil, eğlenceli ama karikatürize değil, derin ama erken oyunda karmaşık değil.

---

## 3. 2.5D Evren Yapısı

Oyun 2.5D bir klinik kesiti üzerinden ilerler. Oyuncu tam serbest büyük hastane yerine, kontrollü ve okunabilir bir klinik alanı yönetir.

### Ana sahne
- İzometrik / 2.5D klinik görünümü
- Bekleme alanı
- Muayene odası
- Triage alanı
- Laboratuvar köşesi
- Görüntüleme / dış kaynak paneli
- Resepsiyon / randevu paneli

### UI ana bölümleri
- Sol panel: hasta kuyruğu, sabır barı, aciliyet seviyesi
- Orta ekran: 2.5D klinik sahnesi
- Sağ panel: hasta kartı, öykü, semptomlar, vital bulgular
- Alt panel: muayene, test, ilaç, sevk ve takip aksiyonları
- Üst HUD: para, XP, itibar, vardiya süresi, event uyarıları

---

## 4. Ana Oyun Döngüsü

```text
Hasta gelir
→ Resepsiyon / triage
→ Vital bulgular alınır
→ Semptomlar değerlendirilir
→ Gerekirse test / tahlil istenir
→ Sonuç beklenir
→ Tanı konur
→ Tedavi / ilaç / sevk kararı verilir
→ Hasta memnuniyeti, ödeme, XP ve itibar hesaplanır
→ Klinik upgrade edilir
→ Daha karmaşık vakalar açılır
```

Bu döngü her seviyede aynı kalır ama içerik derinleşir.

---

## 5. Progression Evreleri

Oyunun hemen bitmemesi için progression sadece 3-4 seviye bandı değil, uzun evreli yapı şeklinde kurulmalıdır.

| Seviye | Evre | Ana Açılım | Baskı Türü |
|---|---|---|---|
| 1–5 | Küçük Muayenehane | Ateş, nabız, tansiyon, basit muayene | Temel akış öğrenme |
| 6–10 | Genişleyen Klinik | CBC, CRP, idrar, hızlı testler | Test süresi ve maliyet |
| 11–15 | Poliklinik | EKG, X-ray, kronik hastalar | Paralel hasta yönetimi |
| 16–20 | Gündüz Hastanesi | Ultrason, kültür, acil protokol | Kritik karar ve sevk |
| 21–25 | Uzmanlık Merkezi | CT, MR, patoloji, genetik | Nadir vaka ve yüksek maliyet |
| 26+ | Sonsuz Uzmanlık Bandı | Sezonluk vaka havuzu, eventler | Mastery ve tekrar oynanabilirlik |

---

## 6. Hasta Arketipleri

Hastalar sadece hastalık taşıyan kartlar olmamalı. Her hasta oyun davranışı taşımalı.

| Hasta Tipi | Özellik | Oyun Etkisi |
|---|---|---|
| Mahalle sakini | Düzenli hasta | Sadakat ve tekrar ziyaret bonusu |
| Vardiya işçisi | Sabırsız, hızlı çözüm ister | Bekleme cezası yüksek |
| Öğrenci | Düşük bütçeli | Uygun maliyetli çözüm ister |
| Yaşlı kronik hasta | Birden fazla hastalığı olabilir | Takip ve ilaç uyumu önemli |
| Ebeveyn + çocuk | Panik seviyesi yüksek | Bekleme cezası sert |
| Turist | Dil / iletişim zorluğu olabilir | Hızlı ama pahalı hizmete yatkın |
| VIP hasta | Memnuniyet etkisi büyük | İtibar çarpanı yüksek |
| Hipokondriyak hasta | Gereksiz test ister | Oyuncuyu fazla test tuzağına düşürür |
| Nadir vaka hastası | Belirtiler atipik | Endgame ayırıcı tanı gerektirir |

---

## 7. Test ve Tahlil Departmanları

Testlerin gerçek dünyadaki süreleri birebir uygulanmamalı; oyun için sıkıştırılmış süreler kullanılmalı. Ama göreli mantık korunmalı: basit test hızlı, kültür/patoloji/genetik yavaş olmalı.

| Departman | Testler | Açılım Evresi | Oyun Rolü |
|---|---|---|---|
| Triage | Ateş, nabız, tansiyon, oksijen | Başlangıç | İlk risk ayrımı |
| Hematoloji | CBC, anemi paneli | Erken-Orta | Enfeksiyon/anemi ayrımı |
| Biyokimya | CRP, glukoz, HbA1c, elektrolit | Orta | Kronik ve inflamasyon takibi |
| İdrar Analizi | İdrar stripi, tam idrar | Orta | UTI, böbrek taşı, diyabet ipucu |
| Mikrobiyoloji | Hızlı grip, strep, kültür | Orta-İleri | Enfeksiyon doğrulama |
| Kardiyoloji | EKG, Holter, EKO | İleri | Göğüs ağrısı / ritim bozukluğu |
| Radyoloji | X-ray, USG, CT, MR | Orta-Endgame | Görüntüleme kararları |
| Patoloji | Biyopsi, doku inceleme | Endgame | Kanser / nadir vaka doğrulama |
| Genetik | Genetik panel | Endgame | Nadir ve özel hastalıklar |

---

## 8. Örnek Test Süreleri ve Oyun Ekonomisi

| Test | Oyun Süresi | Maliyet | Açılım |
|---|---:|---:|---|
| Ateş ölçümü | 5 sn | 8 kredi | L1 |
| Tansiyon | 8 sn | 12 kredi | L1 |
| Oksijen satürasyonu | 8 sn | 15 kredi | L2 |
| Glukometre | 12 sn | 22 kredi | L3 |
| Hızlı grip/strep | 25 sn | 40–45 kredi | L4 |
| İdrar stripi | 20 sn | 35 kredi | L6 |
| CBC | 45 sn | 85 kredi | L6 |
| CRP | 45 sn | 70 kredi | L6 |
| HbA1c | 75 sn | 120 kredi | L8 |
| EKG | 20 sn | 80 kredi | L11 |
| X-ray | 45 sn | 150 kredi | L8 |
| Ultrason | 75 sn | 180 kredi | L12 |
| Kültür | 180–240 sn | 140–220 kredi | L8+ |
| CT | 90 sn | 300 kredi | L16 |
| MR | 150 sn | 450 kredi | L18 |
| Patoloji | 420 sn | 600 kredi | L17 |
| Genetik panel | 600 sn | 900 kredi | L18 |

---

## 9. Hastalık Kategorileri

### Basit hastalıklar
- Soğuk algınlığı
- Grip
- Alerjik rinit
- Viral gastroenterit
- Gerilim tipi baş ağrısı
- Basit migren
- Konjonktivit
- Basit UTI
- Reflü / gastrit

### Orta seviye hastalıklar
- Strep farenjit
- Sinüzit
- Otitis media
- Astım alevlenmesi
- Hafif pnömoni
- Demir eksikliği anemisi
- Hipertansiyon
- Tip 2 diyabet
- Böbrek taşı

### İleri hastalıklar
- Piyelonefrit
- Apandisit
- Safra koliği / kolesistit
- Aritmi
- DVT
- Pulmoner emboli şüphesi
- ACS / kalp krizi şüphesi
- İnme / TIA şüphesi

### Endgame / nadir hastalıklar
- Sepsis
- Menenjit / ensefalit
- Ağır pnömoni
- Kalp yetmezliği dekompansasyonu
- Akut pankreatit
- Malignite şüphesi
- Addison krizi
- Feokromositoma
- Myasthenia gravis

---

## 10. Tedavi ve İlaç Katmanı

İlaç sistemi gerçek klinik doz rehberi gibi kullanılmamalı. Oyun içinde soyut ve güvenli veri modeli olarak tasarlanmalı.

| İlaç / Sınıf | Oyun Rolü | Risk / Yan Etki Mekaniği |
|---|---|---|
| Parasetamol | Ateş ve hafif ağrı | Aşırı kullanımda karaciğer riski uyarısı |
| İbuprofen | Ağrı ve inflamasyon | Gastrit / mide riski |
| Antihistaminik | Alerji | Uyku hali / dikkat düşüşü |
| Omeprazol | Reflü / gastrit | Gereksiz kullanımda düşük etki |
| Salbutamol | Astım | Çarpıntı / titreme yan etkisi |
| Amoksisilin | Seçilmiş bakteriyel enfeksiyon | Gereksiz kullanımda direnç / memnuniyet cezası |
| Nitrofurantoin | Basit UTI | Yanlış vakada etkisiz |
| Ondansetron | Bulantı | Semptom rahatlatır, hastalığı çözmez |
| Metformin | Tip 2 diyabet | Takip gerektirir |
| Amlodipin | Hipertansiyon | Tansiyon takip sistemi ister |
| Antikoagülan soyut | DVT/PE hattı | Kanama riski |
| IV antibiyotik soyut | Ağır enfeksiyon | Sevk / acil protokol bağlantısı |

---

## 11. Ekipman Upgrade Sistemi

Upgrade sadece sayısal hız artışı vermemeli; yeni bilgi, daha az hata, daha iyi görsel feedback ve yeni vaka kapısı açmalı.

| Ekipman | Upgrade Yolu | Etki |
|---|---|---|
| Steteskop | Analog → çift başlıklı → gürültü filtreli → dijital | Hırıltı/üfürüm ipucu artar |
| Ateş ölçer | Dijital → kulak tipi → IR → hızlı triage sensörü | Ölçüm süresi ve hata payı azalır |
| Tansiyon cihazı | Manuel → otomatik → ritim uyarılı → ağ bağlantılı | Yanlış okuma azalır |
| Lab kit | Strip → CBC/CRP bench → biyokimya → kültür → moleküler | Yeni testler açılır |
| Görüntüleme | Outsource → X-ray → USG → CT/MR partneri | Kritik tanı gücü artar |
| Kardiyo tanı | Basic EKG → gelişmiş EKG → Holter → EKO partneri | Göğüs ağrısı havuzu açılır |

---

## 12. Ekonomi ve Paket Sistemi

Oyuncuya paket satılabilir; fakat tanı doğruluğu doğrudan satılmamalı. Etik sınır korunmalı.

### Para birimleri
| Kaynak | Kullanım |
|---|---|
| Kredi | Ekipman, test, personel, bakım |
| XP | Level progression |
| İtibar | Hasta akışı ve özel anlaşmalar |
| Araştırma Puanı | Gelişmiş test ve cihaz açılımı |
| MediToken | Premium kozmetik / konfor / sınırlı booster |

### Paket örnekleri
| Paket | Etki | Etik Sınır |
|---|---|---|
| Hızlı Sonuç Kartı | Seçili test kuyruğunu hızlandırır | Sonucu değiştirmez |
| Öncelik Laboratuvarı | Bir vardiya lab önceliği verir | Günlük limitli |
| Mesai Uzatma | Level süresine küçük ek süre verir | Zorunlu olmaz |
| İkinci Görüş Jetonu | Ayırıcı tanı ipucu verir | Doğru cevabı söylemez |
| Klinik Kozmetik Paketi | Dekor / skin / tema verir | Güç vermez |
| Sezon Pass | Kozmetik + sınırlı booster | Hastalık/test paywall yapmaz |

---

## 13. Hasta Memnuniyeti Sistemi

```text
Memnuniyet = 100
- bekleme cezası
- gereksiz test cezası
- yanlış tedavi cezası
- fazla maliyet cezası
+ empati bonusu
+ ilk doğru tanı bonusu
+ temiz klinik bonusu
+ adil fiyat bonusu
```

Memnuniyet sadece puan değil, oyun ekonomisini etkileyen temel sistemdir:

- Yüksek memnuniyet → daha fazla itibar
- Düşük memnuniyet → şikâyet, düşük ödeme, kötü yorum
- Kritik hata → dava/event/sevk başarısızlığı
- Doğru sevk → para kaybı olabilir ama itibar kazandırır

---

## 14. Örnek Görev / Senaryo Yapıları

| Evre | Senaryo | Hedef | Fail Koşulu |
|---|---|---|---|
| 1–5 | İlk Muayene Günü | 8 hastadan 6 doğru yönlendirme | 3 yanlış tedavi |
| 1–5 | Okul Ateşi | Çocuk hastalarda beklemeyi düşük tut | 2 ebeveyn şikâyeti |
| 6–10 | İlk Laboratuvar Günü | CBC/CRP ile belirsiz vakaları çöz | Test kuyruğu çökmesi |
| 6–10 | Sigorta Sıkışması | Maliyet / memnuniyet dengesi | Memnuniyet < 65 |
| 11–15 | Sıcak Hava Dalgası | Astım ve yaşlı kronik vakaları yönet | Kritik vaka kaçırma |
| 11–15 | Gece Vardiyası | Yorgun personelle 12 hasta tamamla | Uzun bekleme artışı |
| 16+ | Nadir Vaka Konseyi | 3 nadir vakayı doğru yönlendir | Yanlış differential |
| 16+ | Mini Salgın | Bulaşıcı hasta zincirini izole et | Panik yayılımı |

---

## 15. Departmanlar İçin Kullanım Notu

### Gameplay / Sistem
Bu belge progression, test süreleri, hasta akışı, risk/ödül ve upgrade sistemleri için ilham kaynağıdır.

### UI / UX
Hasta kartı, test paneli, kuyruk sistemi, feedback ve 2.5D klinik kontrol paneli için referans alınabilir.

### Art / Grafik
Klinik alanları, cihaz tier görselleri, hasta avatarları ve departman renk kodları için yön verebilir.

### Content / Medical Design
Hastalık, semptom, test, ilaç ve ayırıcı tanı havuzu için başlangıç kataloğu olarak kullanılabilir.

### Economy / Monetization
Boost, paket, premium token, reklam ödülü ve etik monetizasyon sınırları için referans alınabilir.

### Narrative / Worldbuilding
Sahilkent Sağlık Ağı, küçük klinikten uzmanlık merkezine büyüme ve hasta arketipleri lore tarafına ilham verebilir.

---

## 16. Temel Tasarım İlkeleri

1. Oyun erken aşamada basit, geç aşamada derin olmalı.
2. Test süreleri oyunun ana stratejik baskılarından biri olmalı.
3. Upgrade sadece hız değil, yeni bilgi ve yeni vaka kapısı açmalı.
4. Premium paketler tanı doğruluğunu satmamalı.
5. Oyuncu gereksiz test isterse cezalandırılmalı.
6. Doğru sevk, para kaybettirse bile itibar kazandırmalı.
7. Hasta arketipleri oynanışı değiştirmeli.
8. 2.5D dünya okunabilir ve hızlı anlaşılır olmalı.
9. Oyun tek seferde bitmemeli; evre, sezon, event ve nadir vaka havuzu ile uzamalı.
10. Bu belge kanon değil, tasarım ilham deposudur.
