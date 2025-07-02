# PaymentSystem (Konsol Tabanlı Backend Simülasyonu)

## Proje Özeti

**PaymentSystem**, temel ödeme işlemlerini simüle etmek amacıyla geliştirilmiş, .NET tabanlı bir **backend** uygulamasıdır. Nesne yönelimli programlama prensipleri kullanılarak tasarlanmış olup, aşağıdaki yazılım mimarisi konularını içermektedir:

- Constructor tabanlı bağımlılık enjeksiyonu
- Arayüz (interface) temelli katmanlı yapı
- Koşullu iş mantığı yönetimi
- Veri gizleme (encapsulation) ve sınıf sorumlulukları

Uygulama bir **konsol projesi** olarak yazılmıştır. `Program.cs` dosyası ise, kullanıcı arayüzü görevini üstlenen basit bir tetikleyici katman olarak kullanılmış ve uygulamanın backend davranışlarını gözlemlemek amacıyla düzenlenmiştir.

---

## Kullanılan Teknolojiler ve Yazılım Prensipleri

- **.NET / C#**
- **Nesne Yönelimli Programlama (OOP)**
  - Kapsülleme, soyutlama, çok biçimlilik (interface'lerle)
- **Interface Segregation Prensibi**
  - `IPayment`, `IRefund`, `ICancel` arayüzleri
- **Manual Dependency Injection** (constructor ile bağımlılık sağlama)
- **Null kontrolü ve hata yönetimi**
- Gün sonu mantığına bağlı iş kuralları

---

## Proje Yapısı

```plaintext
PaymentSystem/
│
├── Program.cs                  --> Giriş noktası (basit konsol UI simülasyonu)
├── Models/
│   ├── Customer.cs            --> Müşteri bilgileri
│   ├── CurrentBalance.cs      --> Kullanıcının mevcut bakiyesi(Sepet)
│   └── EndOfDay.cs            --> Gün sonu durumu belirleyici sınıf
│
├── Services/
│   └── CreditCardPayment.cs   --> Ödeme, iade ve iptal işlemleri
│   ├── CurrentBalance.cs      --> Kullanıcının mevcut bakiyesi(Sepet)
│   ├── CashPayment.cs.cs      --> Ödeme ve iade işlemler
│   └── MoneyOrderPayment.cs   --> Ödeme ve iade işlemler

│
├── Interfaces/
│   ├── IPayment.cs
│   ├── IRefund.cs
│   └── ICancel.cs
