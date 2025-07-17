# Nesne Yönelimli Programlama (OOP) – Temel Kavramlar
OOP, programı nesneler ve sınıflar (class) etrafında organize eder. Gerçek dünyayı kod ile modellemenin en etkili yoludur.

`4 Temel Kavram:`

| Kavram                            | Açıklama                                            |
| --------------------------------- | --------------------------------------------------- |
| **Sınıf (Class)**                 | Nesnelerin şablonu, veri + davranışları tanımlar    |
| **Nesne (Object)**                | Sınıfın gerçek bir örneği, hafızada yer kaplar      |
| **Encapsulation (Kapsülleme)**    | Veriyi ve metotları gizleyip dışarı kontrollü açmak |
| **Inheritance (Kalıtım)**         | Bir sınıfın özelliklerini başka sınıfa aktarmak     |
| **Polymorphism (Çok Biçimlilik)** | Aynı metot isminin farklı davranışlarda olması      |


İlk adım olarak Class ve Object kavramını anlayalım.

`🧪 Örnek 1: Basit Sınıf ve Nesne`

```csharp
using System;

class Araba
{
    public string Marka;
    public string Model;

    public void Calistir()
    {
        Console.WriteLine(Marka + " " + Model + " çalıştı.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Araba benimArabam = new Araba();
        benimArabam.Marka = "Toyota";
        benimArabam.Model = "Corolla";
        benimArabam.Calistir();
    }
}
```

```
Açıklama:
class Araba → Araba şablonu.

benimArabam → Araba sınıfından oluşturduğumuz nesne.

Nesnenin özellikleri (Marka, Model) ve davranışı (Calistir) var.

benimArabam.Calistir() çağrısı nesnenin davranışını tetikler.
```

# ENCAPSULATION (Kapsülleme)

## Neden önemli?
* Nesne içindeki veriyi (field'ları) doğrudan dışardan değiştirmek hatalara yol açar.
* Kapsülleme, veriye erişimi kontrollü hale getirir.
* Böylece veri tutarlılığı ve güvenliği sağlanır.

`🧪 Örnek: Kapsülleme ve Özellikler (Properties)`

```csharp
using System;

class Araba
{
    private string _marka;

    public string Marka
    {
        get { return _marka; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _marka = value;
            else
                Console.WriteLine("Marka boş olamaz!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Araba araba = new Araba();

        araba.Marka = "BMW";  // set bloğu çalışır, değer atanır
        Console.WriteLine(araba.Marka);  // get bloğu çalışır, değer okunur

        araba.Marka = "";  // set bloğu hata verir, değer atanmaz
    }
}
```

```
Açıklama:
_marka private field (dışarıdan erişilemez).

Marka property ile kontrollü erişim sağlanır.

get → veri okuma

set → veri yazma + doğrulama

```

# INHERITANCE (Kalıtım)

## Nedir?
Bir sınıfın (child/alt sınıf) başka bir sınıfın (parent/üst sınıf) özelliklerini ve metotlarını otomatik olarak devralmasıdır.

Böylece ortak kod tekrar tekrar yazılmaz, tek bir yerde toplanır.

`🧪 Örnek: Temel Kalıtım`

```csharp
using System;

class Canli
{
    public void NefesAl()
    {
        Console.WriteLine("Nefes alınıyor...");
    }
}

class Insan : Canli
{
    public void Konus()
    {
        Console.WriteLine("Konuşuyor...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Insan insan = new Insan();
        insan.NefesAl(); // Üst sınıftan gelen metot
        insan.Konus();   // Kendi metodu
    }
}
```

```
Açıklama:
Insan : Canli → Insan sınıfı Canli sınıfından kalıtım aldı.

Insan sınıfı hem kendi metoduna sahip, hem de Canli sınıfının metoduna erişebiliyor.
```


# POLYMORPHISM (Çok Biçimlilik)

## Nedir?
Aynı isimdeki metodun, farklı nesnelerde farklı şekillerde davranmasıdır.
Böylece kod, duruma göre farklı iş yapabilir.

## Türleri:
- `Compile-time Polymorphism (Method Overloading)`: Aynı metodun farklı parametrelerle tanımlanması.

- `Runtime Polymorphism (Method Overriding)`: Alt sınıfın üst sınıf metodunu kendine göre yeniden yazması.

`🧪 Örnek: Method Overriding ile Polymorphism`

```csharp
using System;

class Hayvan
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan ses çıkarıyor...");
    }
}

class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Miyav");
    }
}

class Kopek : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Hav hav");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hayvan hayvan1 = new Kedi();
        Hayvan hayvan2 = new Kopek();

        hayvan1.SesCikar();  // Miyav
        hayvan2.SesCikar();  // Hav hav
    }
}
```

`Açıklama:`
- `virtual →` Üst sınıfta metot değiştirilebilir olarak işaretlendi.
- `override →` Alt sınıf metodu kendi ihtiyacına göre yeniden yazdı.
- Nesne tipi üst sınıf olsa bile, gerçek nesne türünün metodu çalışır.

# Interface ve Abstract Class — Profesyonel Tasarımın Temelleri

## 1. Interface

- Sadece metot imzaları (imza = metodun ismi ve parametreleri) içerir.
- Uygulama (implementation) içermez.
- Sınıflar bu interface’leri imzalayarak (implement) bu metotları tanımlamak zorundadır.
- Çoklu interface implementasyonu mümkün.
- Tasarımda bağımlılığı azaltır, esnekliği artırır.

`🧪 Interface Örneği:`

```csharp
interface IHayvan
{
    void SesCikar();
}

class Kedi : IHayvan
{
    public void SesCikar()
    {
        Console.WriteLine("Miyav");
    }
}

class Kopek : IHayvan
{
    public void SesCikar()
    {
        Console.WriteLine("Hav hav");
    }
}
```

## 2. Abstract Class
- Hem implementasyon (gövde) hem de soyut metotlar (imzası olan ama gövdesi olmayan metotlar) içerir.
- Sınıflar abstract class’ı kalıtım yoluyla kullanır.
- Abstract class’tan nesne oluşturulamaz.
- Tekli kalıtım sağlar (bir sınıf sadece bir abstract class’ı kalıtabilir).

`🧪 Abstract Class Örneği:`

```csharp
abstract class Hayvan
{
    public abstract void SesCikar();

    public void NefesAl()
    {
        Console.WriteLine("Nefes alınıyor...");
    }
}

class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Miyav");
    }
}
```

