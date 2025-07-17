# Diziler ve List<T> – Koleksiyonlarla Çalışmak

Verileri tek tek tutmak yerine, birden fazla veriyi tek bir değişkende tutmak için kullanılırlar.

## 📦 1. Diziler (Array)
Sabit uzunluktaki veri kümelerini tutar.

`🧪 Örnek:`

```csharp
string[] sehirler = { "İstanbul", "Ankara", "İzmir" };

foreach (string sehir in sehirler)
{
    Console.WriteLine("Şehir: " + sehir);
}
```

```
🧠 Notlar:
sehirler[0] → “İstanbul”

Length özelliğiyle kaç eleman olduğunu öğrenebilirsin.

Uzunluğu sabittir, sonradan eleman eklenemez.
```

## 🧰 2. List<T> – Dinamik Koleksiyonlar
`System.Collections.Generic` kütüphanesi kullanılır.
Diziler gibi ama esnek ve dinamik.

`🧪 Örnek:`
```csharp
using System;
using System.Collections.Generic;

namespace IlkProjem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            sehirler.Add("Bursa");

            foreach (string sehir in sehirler)
            {
                Console.WriteLine("Şehir: " + sehir);
            }

            Console.WriteLine("Toplam şehir sayısı: " + sehirler.Count);
        }
    }
}
```

## 🔄 Sık Kullanılan List Metotları

| Metot        | Açıklama                   |
| ------------ | -------------------------- |
| `Add()`      | Eleman ekler               |
| `Remove()`   | Elemanı siler              |
| `Clear()`    | Tüm elemanları siler       |
| `Contains()` | Eleman içeriyor mu?        |
| `Count`      | Eleman sayısı (özelliktir) |

