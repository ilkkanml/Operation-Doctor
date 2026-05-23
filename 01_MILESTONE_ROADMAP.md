# Operation: Doctor — Milestone Roadmap

## Amaç
Bu roadmap, oyunu küçük, test edilebilir ve geri alınabilir parçalara bölmek için hazırlanmıştır. Her milestone tek başına anlaşılır olmalı ve yeni sohbet penceresinde kolayca devralınabilmelidir.

## Milestone 0 — Foundation Documents
Hedef: Master Bible, departman kuralları, core loop ve içerik kataloglarını kurmak.

Çıktılar:
- Master Bible
- Department Rules
- Core Gameplay Loop
- Progression Plan
- Hasta, hastalık, test, tedavi katalogları

Test Checklist:
- Dosyalar main branch içinde var mı?
- Her dosya tek amaç taşıyor mu?
- Kod yazılmadı mı?

## Milestone 1 — Core Patient Flow Prototype
Hedef: Bir hastanın kliniğe gelişi, seçilmesi, muayenesi ve kapatılması.

Kapsam:
- Hasta kuyruğu
- Hasta kartı
- Basit belirtiler
- Basit sonuç ekranı

Dışarıda:
- Asistan sistemi
- Premium sistem
- Hasta odaları

Test Checklist:
- Hasta seçilebiliyor mu?
- Hasta durumu okunabiliyor mu?
- Akış kırılmadan tamamlanıyor mu?

## Milestone 2 — Basic Diagnosis & Treatment
Hedef: Basit hastalık, temel ölçüm ve tedavi kararını çalıştırmak.

Kapsam:
- Ateş
- Tansiyon
- Nabız
- Basit hastalık havuzu
- Tedavi seçimi
- XP / para ödülü

## Milestone 3 — Manual Department Routing
Hedef: Başlangıçta oyuncunun hastayı EKG, tahlil veya film gibi departmanlara kendisi götürmesi.

Kapsam:
- Departman seçimi
- Hasta taşıma / yönlendirme mantığı
- Test sonucu bekleme
- Geri dönüş akışı

## Milestone 4 — Test Timer & Equipment Levels
Hedef: Test süreleri ve cihaz level etkilerini kurmak.

Kapsam:
- Test bekleme süresi
- Cihaz level
- Süre azalması
- Hata riski

## Milestone 5 — First Staff Hire
Hedef: İlk asistan işe alım sistemi.

Kapsam:
- İş başvuruları
- Maaş
- Random yetenekler
- Departman ataması

## Milestone 6 — Staff Skill, Shift & Rest
Hedef: Personelin çalıştığı bölümde gelişmesi ve dinlenme ihtiyacı.

Kapsam:
- Enerji
- Moral
- Yorgunluk
- Shift
- Dinlenme odası
- Eğitim slotları

## Milestone 7 — Department Capacity
Hedef: Departmanların işlem ve bekleme kapasitesini kurmak.

Kapsam:
- Aynı anda işlem kapasitesi
- Bekleme kuyruğu
- Kapasite upgrade
- Memnuniyet etkisi

## Milestone 8 — Appointment & Follow-Up
Hedef: Kontrol randevuları ve özel hasta sistemi.

Kapsam:
- Takip hastası
- Kontrol günü
- Tedavi süreci
- Tekrar test
- Bonus XP / itibar

## Milestone 9 — Patient Rooms & Recovery
Hedef: Gözlem odaları ve kısa yatış sistemi.

Kapsam:
- Hasta odası
- Yatak kapasitesi
- Hasta bakıcı ataması
- İyileşme süresi
- Oda eşyaları

## Milestone 10 — Economy & Premium Guidelines
Hedef: Premium sistemleri pay-to-win olmadan tasarlamak.

Kapsam:
- Hızlı sonuç kartı
- Kozmetik paketler
- Premium çalışan varyantları
- Konfor odaklı kolaylıklar

## Milestone 11 — First Vertical Slice
Hedef: Küçük ama oynanabilir bölüm.

Minimum içerik:
- 1 klinik
- 5 hasta arketipi
- 8 hastalık
- 8 test
- 8 tedavi
- 1 asistan
- 2 cihaz upgrade
- 1 takip hasta zinciri

## Sonraki Geliştirme Notları
- Motor seçimi Milestone 0 tamamlandıktan sonra ayrı karar olarak açılmalı.
- Her milestone sonunda GitHub issue checklist kullanılmalı.
- Büyük sistemler tek seferde değil, küçük pull request mantığıyla ilerlemeli.
