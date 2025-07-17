# Koşullu İfadeler – if, else, else if

Programın bir duruma göre farklı davranmasını istiyorsan if kullanırsın.
Mantık şu şekilde işler:

```csharp
if (koşul)
{
    // koşul doğruysa çalışır
}
else
{
    // koşul yanlışsa çalışır
}
```

`🧪 Örnek 1: Yaş Kontrolü`

```csharp
using System;

namespace IlkProjem
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 18;

            if (yas >= 18)
            {
                Console.WriteLine("Reşitsiniz.");
            }
            else
            {
                Console.WriteLine("Reşit değilsiniz.");
            }
        }
    }
}
```

`🧠 Açıklama`
- `yas >= 18` Bu bir mantıksal ifade. true veya false döner.

- `>=, ==, !=, <, >` gibi karşılaştırma operatörlerini kullanırız.

`🧪 Örnek 2: Not Durumu (if – else if – else)`

```csharp
using System;

namespace IlkProjem
{
    class Program
    {
        static void Main(string[] args)
        {
            int not = 70;

            if (not >= 85)
            {
                Console.WriteLine("Tebrikler! Pekiyi");
            }
            else if (not >= 70)
            {
                Console.WriteLine("İyi");
            }
            else if (not >= 50)
            {
                Console.WriteLine("Geçer");
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }
        }
    }
}
```

