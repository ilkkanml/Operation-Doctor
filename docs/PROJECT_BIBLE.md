# Operation: Doctor — Project Bible

## Belge Amacı
Bu belge Operation: Doctor projesinin ana hafıza ve governance kaydıdır. Yeni sohbet, yeni issue veya yeni agent bu dosyayı okuyarak projenin ne olduğunu, ne olmadığını ve nasıl yönetileceğini anlamalıdır.

## Proje Kimliği
Operation: Doctor, 2.5D klinik / muayene simülasyonu oyunudur. Oyuncu küçük bir klinikte başlar ve zamanla hasta akışı, test süreçleri, personel, departman kapasitesi, takip randevuları ve hasta odalarını yöneten doktor-yöneticiye dönüşür.

## Ana Hedef
Oyuncuya şu hissi vermek:

- Önce doktor olarak hastayı bizzat yönetiyorum.
- Sonra kliniğim büyüyor.
- İşleri personele devrediyorum.
- Test, cihaz, kapasite ve takip süreçlerini optimize ediyorum.
- Daha karmaşık vakalara hazırlanıyorum.

## Kanon Belgeler
Ana kararlar aşağıdaki sıraya göre değerlendirilir:

1. `docs/PROJECT_BIBLE.md`
2. `00_OPERATION_DOCTOR_MASTER_BIBLE.md`
3. `docs/DECISIONS.md`
4. `docs/MILESTONE_FREEZE.md`
5. `01_MILESTONE_ROADMAP.md`
6. `02_DEPARTMENT_RULES.md`
7. Sistem katalogları
8. İlham dosyası

## İlham Dosyası
`00_DoctorSim_2_5D_Oyun_Evreni_Referans.md` resmi ilham kaynağıdır. Kanon değildir. Fikir, atmosfer, sistem yönü ve tasarım referansı olarak kullanılabilir.

## Aktif Sistemler
- Department Orchestrator aktif.
- GitHub issue açıldığında department label varsa bot cevap verir.
- Issue body editlenirse bot yeni talimatı cevaplar.
- Aynı metne duplicate cevap verilmez.

## Minimum Department Model
- Studio Director
- Game & Systems Designer
- Clinical Content Designer
- UI/UX & 2.5D Experience Designer
- Technical Architect
- QA & Release Director

## Scope Kilitleri
Şimdilik yapılmayacaklar:

- Kod yazımı
- Oyun motoru seçimi
- Prototype üretimi
- Asset üretimi
- Store / yayın hazırlığı
- Detaylı monetization fiyatlandırması
- Gerçek tıbbi tavsiye dili

## Milestone Yönetimi
Her milestone küçük, test edilebilir ve geri alınabilir olmalıdır. Büyük sistemler parçalara bölünmeden issue veya implementasyon aşamasına alınmaz.

## Freeze Mantığı
Milestone tamamlandığında `docs/MILESTONE_FREEZE.md` içine freeze kaydı eklenir. Freeze sonrası değişiklik yapılacaksa yeni karar kaydı gerekir.

## Handoff Mantığı
Sohbetler arası geçişlerde `docs/HANDOFF.md` güncellenir. Aktif durum, son kararlar, açık riskler ve sıradaki görev net yazılır.

## Sonraki Geliştirme Notları
- Issue template yapısı genişletilebilir.
- Label standardı GitHub üzerinde manuel kontrol edilmelidir.
- Foundation Review için Studio Director issue açılmalıdır.
