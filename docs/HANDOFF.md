# Operation: Doctor — Handoff

## Amaç
Bu dosya sohbetler, agent oturumları ve GitHub issue akışları arasında proje durumunu taşımak için kullanılır.

## Aktif Durum
Proje: Operation: Doctor
Aşama: Milestone 0 — Foundation Documents
Durum: Bible, roadmap, department rules ve automation sistemi kuruluyor.

## Repo
`https://github.com/ilkkanml/Operation-Doctor.git`

## Aktif Sistemler
- Department Orchestrator workflow kuruldu.
- Department prompt dosyaları kuruldu.
- Director Command issue template kuruldu.
- OPENAI_API_KEY secret kullanıcı tarafından eklendi.
- Test issue ile bot çalışma kontrolü başarılı oldu.

## Okunması Gereken Dosyalar
1. `docs/START_HERE.md`
2. `docs/PROJECT_BIBLE.md`
3. `00_OPERATION_DOCTOR_MASTER_BIBLE.md`
4. `01_MILESTONE_ROADMAP.md`
5. `02_DEPARTMENT_RULES.md`
6. `.github/workflows/department-orchestrator.yml`
7. `00_DoctorSim_2_5D_Oyun_Evreni_Referans.md`

## İlham Dosyası
`00_DoctorSim_2_5D_Oyun_Evreni_Referans.md` projeye dahil edilmiştir. Kanon değildir. Tasarımda ihtiyaç halinde fikir alınacak referans kaynaktır.

## Son Kararlar
- Minimum department sayısı 6 olarak belirlendi.
- Clinical Content adı kullanıldı; gerçek tıbbi tavsiye dili yasaklandı.
- Issue bot sistemi department label üzerinden çalışacak.
- Hash guard duplicate cevapları engelleyecek.

## Açık Riskler
- GitHub labels manuel kontrol edilmeli.
- Bazı içerik katalogları güvenlik filtresine takıldığı için daha nötr dille parça parça eklenmeli.
- Oyun motoru henüz seçilmedi.
- Kod yazımı henüz başlamadı.

## Sıradaki Adım
Studio Director issue açılarak Milestone 0 Foundation Review yapılmalı. Ardından eksik kataloglar nötr oyun diliyle tamamlanmalı.

## Sonraki Geliştirme Notları
- Handoff her önemli karar sonrası güncellenmeli.
- Milestone freeze tamamlanınca bu dosyaya kısa özet eklenmeli.
