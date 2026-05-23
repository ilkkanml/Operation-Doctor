# Operation: Doctor — Minimum Department Rules

## Amaç
Bu belge proje içindeki minimum departman yapısını tanımlar. Hedef, OpenAI API + GitHub issue tabanlı chatbot kullanımında görevleri doğru departmana yönlendirmek, yetki karmaşasını azaltmak ve gereksiz departman kalabalığını önlemektir.

## Minimum Departman Kararı
Operation: Doctor için başlangıçta 6 ana departman yeterlidir. Daha fazla departman proje büyüdükçe eklenebilir. Şimdilik amaç maksimum kontrol, minimum karmaşadır.

## 1. Studio Director
Rol: Nihai karar ve proje bütünlüğü.

Yetki Alanı:
- Master Bible uyumluluğu
- Scope kontrolü
- Milestone onayı
- Departmanlar arası çelişki çözümü
- Final kararlar

Karışmaması Gerekenler:
- Doğrudan kod yazımı
- Detay UI yerleşimi
- Tek tek hastalık veri girişi

Issue Etiketleri:
- department:studio-director
- type:decision
- type:scope

## 2. Game & Systems Designer
Rol: Oynanış, ekonomi, progression ve sistem dengesi.

Yetki Alanı:
- Core gameplay loop
- XP, para, itibar
- Upgrade sistemi
- Asistan sistemi
- Shift sistemi
- Departman kapasitesi
- Hasta odası mekanikleri
- Premium sistem sınırları

Karışmaması Gerekenler:
- Gerçek tıbbi doğruluk kararı
- Kod mimarisi
- Görsel stil finali

Issue Etiketleri:
- department:game-systems
- type:mechanic
- type:economy
- type:progression

## 3. Medical Content Designer
Rol: Hastalık, semptom, test, tahlil, tedavi ve hasta içerikleri.

Yetki Alanı:
- Hastalık kataloğu
- Semptom havuzları
- Test ve tahlil katalogları
- Tedavi ve ilaç sınıfları
- Ayırıcı tanı mantığı
- Takip hastası içerikleri

Kritik Kural:
Tıbbi içerik gerçek hayatta tedavi tavsiyesi gibi yazılamaz. Her şey oyun simülasyonu ve soyut sistem diliyle tasarlanır.

Karışmaması Gerekenler:
- Premium fiyatlandırma
- Kod mimarisi
- UI final tasarımı

Issue Etiketleri:
- department:medical-content
- type:disease
- type:test
- type:treatment

## 4. UI/UX & 2.5D Experience Designer
Rol: Oyuncunun oyunu nasıl gördüğü, okuduğu ve kontrol ettiği.

Yetki Alanı:
- 2.5D klinik ekranı
- Hasta kuyruğu
- Hasta kartı
- Test/tahlil paneli
- Tedavi paneli
- Departman kapasite göstergeleri
- Randevu ve takip ekranı
- Görsel okunabilirlik

Karışmaması Gerekenler:
- Oyun ekonomisi final kararı
- Tıbbi içerik doğruluğu
- Kod altyapısı

Issue Etiketleri:
- department:ui-ux-2_5d
- type:screen
- type:flow
- type:visual

## 5. Technical Architect
Rol: Teknik yapı, repo düzeni, motor seçimi ve implementasyon planı.

Yetki Alanı:
- Oyun motoru değerlendirmesi
- Repo yapısı
- Veri formatları
- Kod standardı
- Save/load planı
- API bağlantıları
- GitHub issue chatbot kurulumu
- Milestone implementasyon stratejisi

Karışmaması Gerekenler:
- Oyun tasarımını yeniden yazmak
- Hastalık içeriklerini uydurmak
- Premium sistemi tek başına belirlemek

Issue Etiketleri:
- department:technical-architect
- type:architecture
- type:repo
- type:api
- type:integration

## 6. QA & Release Director
Rol: Test, kalite kapısı ve release güvenliği.

Yetki Alanı:
- Milestone test checklist
- Bug sınıflandırma
- Regression kontrolü
- Playtest raporu
- Release gate
- Kabul kriterleri

Karışmaması Gerekenler:
- Yeni feature icat etmek
- Tasarım kararlarını tek başına değiştirmek
- Kod mimarisini yeniden yönlendirmek

Issue Etiketleri:
- department:qa-release
- type:bug
- type:test
- type:release-gate

## Chatbot Issue Routing Kuralı
GitHub issue chatbot önce issue içeriğini okur, sonra en uygun departmanı seçer. Bir issue birden fazla departmana temas ediyorsa ana departman + destek departmanı atanır.

Örnekler:
- “EKG test süresi çok uzun” → Game & Systems Designer
- “EKG sonucu hangi hastalığı göstermeli?” → Medical Content Designer
- “Hasta kartı okunmuyor” → UI/UX & 2.5D Experience Designer
- “Repo dosya yapısı nasıl olmalı?” → Technical Architect
- “Bu milestone geçti mi?” → QA & Release Director
- “Bu özellik oyunu büyütür mü?” → Studio Director

## Zorunlu Issue Alanları
Her issue mümkünse şu bilgileri içermeli:

- Kısa problem
- İlgili sistem
- Beklenen davranış
- Mevcut davranış
- İlgili milestone
- Önerilen departman
- Karar gerekiyor mu?

## Departman Kilit Kuralı
Hiçbir departman tek başına tüm oyunu yeniden tasarlayamaz. Her karar Master Bible, milestone ve issue bağlamına bağlıdır.

## Sonraki Geliştirme Notları
- GitHub label seti ayrıca oluşturulmalı.
- Issue template dosyaları ileride `.github/ISSUE_TEMPLATE` altında kurulmalı.
- API chatbot için department routing prompt ayrıca hazırlanmalı.
