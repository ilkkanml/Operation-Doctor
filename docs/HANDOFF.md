# Operation: Doctor — Handoff

## Amaç
Bu dosya sohbetler, agent oturumları ve GitHub issue akışları arasında proje durumunu taşımak için kullanılır.

## Aktif Durum
Proje: Operation: Doctor
Aşama: Milestone Sequencing Cleanup
Durum: Foundation sistemi kuruldu. Department automation çalışıyor. Milestone issue akışında duplicate/loop riski tespit edildi ve yeni sıralı ilerleme kuralı eklendi.

## Repo
`https://github.com/ilkkanml/Operation-Doctor.git`

## Aktif Sistemler
- Department Orchestrator workflow kuruldu.
- Department prompt dosyaları kuruldu.
- Director Command issue template kuruldu.
- OPENAI_API_KEY secret kullanıcı tarafından eklendi.
- Test issue ile bot çalışma kontrolü başarılı oldu.
- Bible / Handoff / Freeze / Decisions sistemi kuruldu.
- İlham dosyası sisteme dahil edildi.

## Okunması Gereken Dosyalar
1. `docs/START_HERE.md`
2. `docs/PROJECT_BIBLE.md`
3. `docs/HANDOFF.md`
4. `docs/MILESTONE_FREEZE.md`
5. `docs/DECISIONS.md`
6. `00_OPERATION_DOCTOR_MASTER_BIBLE.md`
7. `01_MILESTONE_ROADMAP.md`
8. `02_DEPARTMENT_RULES.md`
9. `.github/workflows/department-orchestrator.yml`
10. `00_DoctorSim_2_5D_Oyun_Evreni_Referans.md`

## İlham Dosyası
`00_DoctorSim_2_5D_Oyun_Evreni_Referans.md` projeye dahil edilmiştir. Kanon değildir. Tasarımda ihtiyaç halinde fikir alınacak referans kaynaktır.

## Son Kararlar
- Minimum department sayısı 6 olarak belirlendi.
- Clinical Content adı kullanıldı; gerçek tıbbi tavsiye dili yasaklandı.
- Issue bot sistemi department label üzerinden çalışacak.
- Hash guard duplicate cevapları engelleyecek.
- Her milestone için tek aktif review/freeze issue kullanılacak.
- Bir milestone tamamlanmadan, freeze edilmeden ve handoff güncellenmeden yeni milestone açılmayacak.
- Aynı milestone için duplicate issue açılırsa eski/yanlış olan duplicate olarak kapatılacak.

## Milestone İlerleme Kuralı
Yeni kural kesindir:

```text
1. Aktif milestone issue açılır.
2. Department bot cevabı beklenir.
3. Eksik varsa aynı issue içinde body editlenerek devam edilir.
4. Hazır kararı geldikten sonra QA / Release kontrolü yapılır.
5. `docs/MILESTONE_FREEZE.md` güncellenir.
6. `docs/DECISIONS.md` gerekiyorsa güncellenir.
7. `docs/HANDOFF.md` güncellenir.
8. Ancak bundan sonra yeni milestone issue açılır.
```

## Açık Riskler
- Milestone issue'ları daha önce hızlı açıldığı için bazı duplicate review issue'ları oluştu.
- Duplicate issue'lar kapatılmalı ve tek aktif milestone zinciri korunmalı.
- Bazı içerik katalogları güvenlik filtresine takıldığı için daha nötr dille parça parça eklenmeli.
- Oyun motoru henüz seçilmedi.
- Kod yazımı henüz başlamadı.

## Sıradaki Adım
Mevcut açık milestone issue'ları kontrol edilecek. En erken tamamlanmamış milestone seçilecek. Onun freeze kaydı bitmeden yeni milestone açılmayacak.

## Sonraki Geliştirme Notları
- Handoff her önemli karar sonrası güncellenmeli.
- Milestone freeze tamamlanınca bu dosyaya kısa özet eklenmeli.
- Issue açmadan önce aynı milestone için açık issue var mı kontrol edilmeli.
