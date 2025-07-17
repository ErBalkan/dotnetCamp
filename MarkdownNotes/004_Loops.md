# Döngüler – for, while, foreach
Döngüler, belirli bir işi tekrar tekrar yapmak için kullanılır.
Kod yazmayı minimuma indirir, işi makineye yıkarız. 😎

## 🔁 1. for Döngüsü

```csharp
for (başlangıç; koşul; artış)
{
    // tekrar edilecek kod
}
```

`🧪 Örnek: 1'den 5'e kadar yazdır`

```csharp
using System;

namespace IlkProjem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Sayı: " + i);
            }
        }
    }
}
```

```
🧠 Açıklama
int i = 1; → i 1’den başlıyor.

i <= 5; → 5'e kadar dönecek.

i++ → her seferinde 1 artır.
```

## 🔁 2. while Döngüsü

Koşul doğru olduğu sürece döner.

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine("Sayı: " + i);
    i++;
}
```

## 🔁 3. foreach Döngüsü

Diziler ve listeler gibi koleksiyonlar üzerinde dolaşmak için kullanılır. Çok sık kullanacağız.

```csharp
string[] isimler = { "Erhan", "Zeynep", "Ahmet" };

foreach (string isim in isimler)
{
    Console.WriteLine("İsim: " + isim);
}
```

