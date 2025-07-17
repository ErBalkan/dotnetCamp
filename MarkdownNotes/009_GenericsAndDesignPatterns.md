# Generic Yapılar & Tasarım Kalıpları (Design Patterns)

`Neden Önemli?`

- __Generic Yapılar:__ Tip bağımsız, yeniden kullanılabilir kod yazmanı sağlar. Kod tekrarı önlenir, performans artar.

- __Design Patterns:__ Yazılım geliştirmede kanıtlanmış, tekrarlanabilir çözümler. Takım çalışmasını hızlandırır, kodun sürdürülebilirliğini artırır.

## Generic Yapılar

### Temel kavram:

Generic yapı, __T__ gibi placeholder __(yer tutucu)__ kullanarak farklı veri tipleriyle çalışabilen yapılar yazmana izin verir.

`🧪 Örnek: Generic Sınıf`

```csharp
class Depo<T>
{
    private T[] elemanlar = new T[10];
    private int indeks = 0;

    public void Ekle(T eleman)
    {
        if (indeks < elemanlar.Length)
        {
            elemanlar[indeks] = eleman;
            indeks++;
        }
        else
        {
            Console.WriteLine("Depo dolu!");
        }
    }

    public T Getir(int i)
    {
        if (i >= 0 && i < indeks)
            return elemanlar[i];
        else
            throw new IndexOutOfRangeException();
    }
}
```

`Kullanım:`

```csharp
class Program
{
    static void Main(string[] args)
    {
        Depo<int> sayiDeposu = new Depo<int>();
        sayiDeposu.Ekle(100);
        sayiDeposu.Ekle(200);

        Console.WriteLine(sayiDeposu.Getir(1));  // 200

        Depo<string> stringDeposu = new Depo<string>();
        stringDeposu.Ekle("Erhan");
        stringDeposu.Ekle("ChatGPT");

        Console.WriteLine(stringDeposu.Getir(0));  // Erhan
    }
}
```

## Tasarım Kalıpları (Design Patterns)

Başlangıç için aşağıdaki 3 kalıbı öğreneceğiz:

| Kalıp          | Amaç                                     |
| -------------- | ---------------------------------------- |
| Singleton      | Bir sınıftan sadece 1 nesne oluşturulur. |
| Factory Method | Nesne oluşturmayı alt sınıflara bırakır. |
| Observer       | Nesneler arası haberleşmeyi sağlar.      |

### Singleton Design Pattern

#### 📌 Amaç:
Bir sınıftan yalnızca bir tane nesne oluşturulmasını garanti eder.

#### 📌 Neden Kullanılır?
- Örneğin, bir __LogService__, __DatabaseConnection__ ya da __ConfigurationManager__ gibi yapılar tek bir merkezden kontrol edilmelidir.
- Fazladan nesne oluşumunu engelleyerek kaynak tüketimini azaltır.
- Global erişim noktası sunar.

`🧪 Singleton Örneği`

```csharp
public class Logger
{
    private static Logger _instance;

    private Logger() 
    {
        Console.WriteLine("Logger oluşturuldu.");
    }

    public static Logger Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Logger();
            return _instance;
        }
    }

    public void Log(string mesaj)
    {
        Console.WriteLine($"Log: {mesaj}");
    }
}
```

`🔁 Kullanımı:`

```csharp
class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;

        logger1.Log("Erhan sistemi başlattı.");
        logger2.Log("Veri güncellendi.");

        Console.WriteLine(Object.ReferenceEquals(logger1, logger2));  // True
    }
}
```

__Açıklama:__
- Logger.Instance → her çağrıldığında aynı nesneyi döner.
- Constructor private → dışarıdan new ile oluşturulamaz.
- Nesne sadece içeriden ve tek seferde oluşur.

### Factory Method Design Pattern

#### 📌 Amaç:
Nesne oluşturma sorumluluğunu sınıfların içine gömmek yerine, dışarıdan kontrol edilen bir yapıyla çözmek.

Nesne üretimini soyutlayarak, bağımlılığı azaltır.

#### 📌 Ne İşe Yarar?
- Yeni sınıf eklendiğinde mevcut kodu değiştirmeden genişletilebilir.
- Kodun yeni türlerle çalışabilmesini sağlar.
- “Açık- Kapalı Prensibi”ne (Open/Closed Principle) uyar.

`🧪 Senaryo: Hayvan üretimi`
`1️⃣ Arayüz ve Sınıflar:`

```csharp
public interface IHayvan
{
    void SesCikar();
}

public class Kedi : IHayvan
{
    public void SesCikar()
    {
        Console.WriteLine("Miyav");
    }
}

public class Kopek : IHayvan
{
    public void SesCikar()
    {
        Console.WriteLine("Hav hav");
    }
}
```

`2️⃣ Factory Sınıfı:`

```csharp
public class HayvanFactory
{
    public static IHayvan HayvanOlustur(string tur)
    {
        if (tur == "kedi")
            return new Kedi();
        else if (tur == "kopek")
            return new Kopek();
        else
            throw new Exception("Geçersiz hayvan türü!");
    }
}
```

`3️⃣ Kullanımı:`

```csharp
class Program
{
    static void Main(string[] args)
    {
        IHayvan hayvan1 = HayvanFactory.HayvanOlustur("kedi");
        IHayvan hayvan2 = HayvanFactory.HayvanOlustur("kopek");

        hayvan1.SesCikar(); // Miyav
        hayvan2.SesCikar(); // Hav hav
    }
}
```

__🎯 Avantaj:__
- Kodun sadece arayüzlerle çalışmasını sağladık.
- Yeni hayvan türü eklerken sadece Factory’e küçük bir ekleme yapılır.
- new ile doğrudan nesne oluşturmuyoruz, oluşturmayı merkeze taşıdık.

```
🧠 Ekstra:
İleride bu pattern’i Dependency Injection (bağımlılık enjeksiyonu) ile de birleştireceğiz. Şimdilik temelini sağlam oturtalım.
```

### Observer Design Pattern

__📌 Amaç:__
Bir nesnede bir değişiklik olduğunda, bu değişikliği izleyen diğer nesnelerin otomatik olarak bilgilendirilmesini sağlar.

Bu yapı __"publisher-subscriber"__ (yayıncı-abone) modeline dayanır.

__🔧 Nerelerde Kullanılır?__

- Gerçek zamanlı sistemlerde (bildirim sistemleri, haber akışları)
- UI framework’lerinde (örneğin WPF, Blazor, WinForms)
- Event tabanlı sistemlerde

`🧪 Basit Observer Örneği`

- `1️⃣ Observer arayüzü:`

```csharp
public interface IObserver
{
    void Guncelle(string mesaj);
}
```

- `2️⃣ Subject (Publisher) arayüzü:`

```csharp
public interface ISubject
{
    void AboneEkle(IObserver abone);
    void AboneCikar(IObserver abone);
    void Bildir(string mesaj);
}
```

- `3️⃣ Concrete Publisher (Haber Merkezi):`

```csharp
public class HaberMerkezi : ISubject
{
    private List<IObserver> aboneler = new List<IObserver>();

    public void AboneEkle(IObserver abone)
    {
        aboneler.Add(abone);
    }

    public void AboneCikar(IObserver abone)
    {
        aboneler.Remove(abone);
    }

    public void Bildir(string mesaj)
    {
        foreach (var abone in aboneler)
        {
            abone.Guncelle(mesaj);
        }
    }
}
```

- `4️⃣ Concrete Subscribers (Aboneler):`

```csharp
public class Vatandas : IObserver
{
    private string isim;

    public Vatandas(string isim)
    {
        this.isim = isim;
    }

    public void Guncelle(string mesaj)
    {
        Console.WriteLine($"{isim} bildirimi aldı: {mesaj}");
    }
}
```

- `5️⃣ Kullanımı:`

```csharp
class Program
{
    static void Main(string[] args)
    {
        HaberMerkezi merkez = new HaberMerkezi();

        Vatandas ali = new Vatandas("Ali");
        Vatandas ayse = new Vatandas("Ayşe");

        merkez.AboneEkle(ali);
        merkez.AboneEkle(ayse);

        merkez.Bildir("Deprem uyarısı!");

        merkez.AboneCikar(ali);

        merkez.Bildir("Fırtına geliyor!");
    }
}
```

__🧠 Ne Öğrendin?__

- HaberMerkezi = Publisher
- Vatandas = Observer
- Bir mesaj geldiğinde abonelere otomatik bildirim gidiyor.

