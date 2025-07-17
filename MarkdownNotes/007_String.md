# String ve Kullanıcıdan Veri Alma

Gerçek hayattaki uygulamalarda kullanıcıyla etkileşim çok önemlidir. Bu aşamada iki şey öğreneceğiz:

- Konsoldan veri alma (Console.ReadLine)
- String işlemleri (parçalama, birleştirme, değiştirme)

`🧪 1. Kullanıcıdan Veri Alma`

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Adınızı girin: ");
        string ad = Console.ReadLine();

        Console.Write("Yaşınızı girin: ");
        string yasStr = Console.ReadLine();
        int yas = Convert.ToInt32(yasStr);

        Console.WriteLine("Merhaba " + ad + ", yaşınız: " + yas);
    }
}
```

```
🧠 Notlar:
Console.ReadLine() → kullanıcıdan metin olarak veri alır.

Convert.ToInt32(...) → string veriyi int'e dönüştürür.
```

## 🛠️ 2. String İşlemleri

```csharp
string mesaj = "Merhaba Erhan";
Console.WriteLine(mesaj.ToUpper()); // BÜYÜK HARF
Console.WriteLine(mesaj.ToLower()); // küçük harf
Console.WriteLine(mesaj.Contains("Erhan")); // true
Console.WriteLine(mesaj.Replace("Erhan", "Dünya")); // Merhaba Dünya
Console.WriteLine(mesaj.Length); // karakter sayısı
```

