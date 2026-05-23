# Operation: Doctor — Core Gameplay Loop

## Ana Döngü
Operation: Doctor'ın ana döngüsü hastayı doğru okumak, doğru aksiyonu seçmek, zamanı yönetmek ve kliniği büyütmek üzerine kuruludur.

```text
Hasta gelir
→ Triage / ön değerlendirme
→ Muayene
→ Gerekirse departmana yönlendirme
→ Test / tahlil / görüntüleme sonucu bekleme
→ Tanı kararı
→ Tedavi / ilaç / sevk / takip kararı
→ XP, para, itibar, memnuniyet hesaplama
→ Klinik, cihaz, personel ve kapasite upgrade'i
```

## Erken Oyun
Oyuncu hastayı kendisi yönetir. Hasta muayene odasına alınır. Gerekirse EKG, tahlil, film veya MR departmanına oyuncu götürür. Bu manuel yapı oyunun öğrenme aşamasıdır.

## Orta Oyun
Asistanlar ve teknisyenler açılır. Oyuncu bazı işleri personele devreder. Oda ve departman kapasitesi önem kazanır.

## İleri Oyun
Takip hastaları, özel randevular, hasta odaları, shift yönetimi, personel eğitimi ve nadir vakalar ana stratejiye dönüşür.

## Oyuncu Kararları
- Hangi hasta önce alınmalı?
- Test gerekli mi?
- Hasta bekleyebilir mi?
- Hangi departman dolu?
- Asistan mı yönlendirsin, oyuncu mu ilgilensin?
- Hasta taburcu mu edilmeli, kontrole mi çağrılmalı?
- Sevk etmek itibar için daha mı doğru?

## Sonraki Geliştirme Notları
- İlk prototype için sadece 1 hasta, 1 muayene, 1 test ve 1 tedavi yeterlidir.
- Manuel hasta yönlendirme oyunun erken dönem öğretici mekaniği olarak korunmalıdır.
