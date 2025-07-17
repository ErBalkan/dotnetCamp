# Değişkenler ve Veri Tipleri


Bir programda verileri geçici olarak tutmak için değişkenleri kullanırız. C#’ta bir değişken tanımlarken:

`veri_tipi değişken_adi = değer;`

## 📦 Temel Veri Tipleri

| Veri Tipi | Açıklama                  | Örnek                    |
| --------- | ------------------------- | ------------------------ |
| `int`     | Tam sayı                  | `int yas = 23;`          |
| `double`  | Ondalıklı sayı            | `double boy = 1.82;`     |
| `bool`    | Doğru/Yanlış (true/false) | `bool aktifMi = true;`   |
| `char`    | Tek bir karakter          | `char cinsiyet = 'E';`   |
| `string`  | Metin (karakter dizisi)   | `string isim = "Erhan";` |


`🧪 Örnek Kod`

```csharp
using System;

namespace IlkProjem
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 23;
            double boy = 1.82;
            bool ogrenciMi = true;
            char cinsiyet = 'E';
            string isim = "Erhan";

            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Boy: " + boy);
            Console.WriteLine("Öğrenci mi?: " + ogrenciMi);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
        }
    }
}
```

## 🧠 Bilmen Gereken Detaylar
- + operatörü burada birleştirme (concatenation) işlemi yapar.
- C#’ta her satır ; ile biter.
- string, aslında bir sınıftır, ama şu an temel veri tipi gibi düşünebilirsin.

