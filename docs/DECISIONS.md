# Operation: Doctor — Decisions Log

## Amaç
Bu dosya resmi proje kararlarını kaydeder. Kararların sohbet içinde kaybolmasını engeller.

## Karar Kaydı Formatı
```text
ID:
Tarih:
Karar:
Gerekçe:
Etkilediği Dosyalar:
Durum:
```

## DEC-001
Tarih: 2026-05-22
Karar: Proje adı Operation: Doctor olarak belirlendi.
Gerekçe: İngilizce, pazarlanabilir ve klinik simülasyon temasına uygun.
Etkilediği Dosyalar: Tüm proje dokümanları.
Durum: Aktif.

## DEC-002
Tarih: 2026-05-22
Karar: Minimum department yapısı 6 departman olarak belirlendi.
Gerekçe: GitHub issue chatbot sistemi için minimum karmaşa ve net routing gerekir.
Etkilediği Dosyalar: `02_DEPARTMENT_RULES.md`, `departments/*.md`, workflow.
Durum: Aktif.

## DEC-003
Tarih: 2026-05-22
Karar: `00_DoctorSim_2_5D_Oyun_Evreni_Referans.md` ilham dosyası olarak sisteme dahil edildi.
Gerekçe: Oyun evreni, progression ve 2.5D klinik hissi için fikir kaynağıdır. Kanon değildir.
Etkilediği Dosyalar: `docs/START_HERE.md`, `docs/PROJECT_BIBLE.md`, `docs/HANDOFF.md`.
Durum: Aktif.

## DEC-004
Tarih: 2026-05-22
Karar: Department Orchestrator issue automation sistemi kullanılacak.
Gerekçe: Issue açıldığında ilgili departman botu cevap verir ve kararlar GitHub kaydında kalır.
Etkilediği Dosyalar: `.github/workflows/department-orchestrator.yml`, `departments/*.md`.
Durum: Aktif.

## Sonraki Geliştirme Notları
- Yeni kararlar bu dosyanın altına DEC-005 şeklinde eklenmeli.
- Freeze sonrası değişiklikler mutlaka karar kaydı istemelidir.
