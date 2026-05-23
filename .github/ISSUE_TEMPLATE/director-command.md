---
name: Director Command
description: Operation Doctor department bot command
title: "[Department Command] "
labels: ["department:studio-director"]
body:
  - type: markdown
    attributes:
      value: |
        Operation: Doctor department automation için issue aç.
        Tek department label kullan. Gerekirse label'ı sonradan değiştir.

  - type: dropdown
    id: department
    attributes:
      label: Target Department
      description: Issue için ana departmanı seç. Label'ı issue açıldıktan sonra manuel kontrol et.
      options:
        - Studio Director
        - Game & Systems Designer
        - Clinical Content Designer
        - UI/UX & 2.5D Experience Designer
        - Technical Architect
        - QA & Release Director
    validations:
      required: true

  - type: input
    id: milestone
    attributes:
      label: Related Milestone
      description: Örnek Milestone 0, Milestone 1, Milestone 2
      placeholder: "Milestone 0"
    validations:
      required: false

  - type: textarea
    id: command
    attributes:
      label: Command / Request
      description: Departmana verilecek net talimatı yaz.
      placeholder: "Bu sistem için karar, risk ve sonraki adımı değerlendir."
    validations:
      required: true

  - type: textarea
    id: context
    attributes:
      label: Context
      description: Gerekli proje bağlamını kısa yaz.
      placeholder: "Master Bible'a bağlı kal. Kod yazma."
    validations:
      required: false

  - type: textarea
    id: expected-output
    attributes:
      label: Expected Output
      description: Beklenen cevap formatı.
      placeholder: "Karar / Gerekçe / Risk / Sonraki adım"
    validations:
      required: false
---
