# Metotlar (Fonksiyonlar)
Metotlar, bir işi yapmak için yazılmış, tekrar tekrar çağrılabilen kod bloklarıdır.

Kod tekrarını azaltır, okunabilirliği artırır ve uygulamayı modülerleştirir.


`📌 Temel Yapı:`

```csharp
erişim_tipi geri_donus_tipi MetotAdi(parametreler)
{
    // çalışacak kod
    return deger; // (geri dönüş tipi void değilse)
}
```

`🧪 Örnek 1: Parametresiz ve Geri Dönüşsüz Metot (void)`

```csharp
using System;

namespace IlkProjem
{
    class Program
    {
        static void Selamla()
        {
            Console.WriteLine("Merhaba Erhan!");
        }

        static void Main(string[] args)
        {
            Selamla(); // metot çağrılıyor
        }
    }
}
```

`🧪 Örnek 2: Parametreli ve Geri Dönüşsüz Metot`

```csharp
static void Yazdir(string mesaj)
{
    Console.WriteLine("Mesaj: " + mesaj);
}

static void Main(string[] args)
{
    Yazdir("Bugün harika bir gün!");
    Yazdir("Yarın backend yazmaya devam.");
}
```

`🧪 Örnek 3: Geri Dönüş Değeri Olan Metot`

```csharp
static int Topla(int a, int b)
{
    return a + b;
}

static void Main(string[] args)
{
    int sonuc = Topla(3, 5);
    Console.WriteLine("Toplam: " + sonuc);
}
```

```
🧠 Notlar:
void: Geriye bir değer döndürmeyen metottur.

Metotlar Main dışında tanımlanır ama oradan çağrılır.

Parametreler sayesinde metotlara dinamik veri gönderilir.

return ifadesi, bir değeri dışarı döndürür.
```

