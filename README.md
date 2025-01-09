# CarClass Projesi

Bu proje, basit bir **C#** uygulaması olarak tasarlanmış bir araba sınıfı (“Car”) örneğidir. Programda, araba nesnelerinin özelliklerini ve bu özellikler üzerindeki doğrulama mantığını kapsayan bir sınıf oluşturulmuştur.

---

## Proje Hedefleri
1. **Encapsulation (Kapsülleme):**
   - Araba nesnesinin özelliklerini ve davranışlarını bir sınıfta birleştirerek özellikler üzerindeki doğrulamaları gerçekleştirmek.

2. **Doğrulama Mantığı:**
   - Kapı sayısı (“NumberOfDoors”) özelliği için sadece geçerli değerlerin (2 veya 4) atanmasını sağlamak.
   - Geçersiz bir değer girildiğinde kullanıcıyı uyarmak ve varsayılan bir hata değeri atamak.

3. **Sınıf Kullanımı:**
   - Araba nesneleri oluşturup, bu nesnelerin bilgilerini yazdırmak.

---

## Proje Dosyaları

### **Program.cs**
- Ana program dosyası. Burada araba nesneleri oluşturulmakta ve bu nesnelerin detayları ekrana yazdırılmaktadır.

#### Örnek Kod:
```csharp
using System;
namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Brand = "Volkswagen",
                Model = "Caddy",
                Color = "Azul Mavisi",
                NumberOfDoors = 4
            };
            car1.CarDetails();

            Car car2 = new Car
            {
                Brand = "Volkswagen",
                Model = "Tiguan",
                Color = "Siyah",
                NumberOfDoors = 3
            };
            car2.CarDetails();

        }
    }
}
```

### **Car.cs**
- Araba sınıfını tanımlar.
- Özellikler:
  - `Brand`: Arabanın markası.
  - `Model`: Arabanın modeli.
  - `Color`: Arabanın rengi.
  - `NumberOfDoors`: Arabanın kapı sayısı. Geçerli değerler 2 ve 4'tür.

#### Doğrulama Mantığı:
Kapı sayısı geçerli bir değer olmadığında kullanıcıya uyarı mesajı gösterilir ve kapı sayısına `-1` atanır.

#### Örnek Kod:
```csharp
using System;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    private int _numberOfDoors;
    public int NumberOfDoors
    {
        get { return _numberOfDoors; }
        set
        {
            if (value == 2 || value == 4)
            {
                _numberOfDoors = value;
            }
            else
            {
                Console.WriteLine("Geçersiz kapı sayısı! Kapı sayısı yalnızca 2 veya 4 olabilir.");
                _numberOfDoors = -1;
            }
        }
    }

    public void CarDetails()
    {
        Console.WriteLine($"Marka: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Renk: {Color}");
        Console.WriteLine($"Kapı Sayısı: {NumberOfDoors}");
    }
}
```

---

## Nasıl Çalıştırılır?

1. **Proje Ortamını Hazırlama:**
   - Visual Studio veya Visual Studio Code gibi bir C# IDE'si kurulu olmalıdır.
   - .NET SDK yüklenmiş olmalıdır.

2. **Kodu Çalıştırma:**
   - Yukarıdaki kodu bir proje dosyasına yapıştırın.
   - Programı derleyip çalıştırın.

3. **Beklenen Çıktı:**
   - Birinci araba için geçerli kapı sayısı bilgilerinin yazıldığı ve ikinci araba için uyarı mesajının görüntülendiği bir ekran.

---

## Çıktı Örneği

### Geçerli Kapı Sayısı:
```
Marka: Volkswagen
Model: Caddy
Renk: Azul Mavisi
Kapı Sayısı: 4
```

### Geçersiz Kapı Sayısı:
```
Geçersiz kapı sayısı! Kapı sayısı yalnızca 2 veya 4 olabilir.
Marka: Volkswagen
Model: Tiguan
Renk: Siyah
Kapı Sayısı: -1
```

---

## Geliştirme Notları
- **Hata Yönetimi:** Kapı sayısı üzerinde daha fazla hata yönetimi eklenebilir.
- **Test Durumları:** Daha fazla test durumu eklenerek sistemin esnekliği artırılabilir.
- **Dil Desteği:** Uyarı mesajlarını çoklu dil desteği ile genişletebilirsiniz.

