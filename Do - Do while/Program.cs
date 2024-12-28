

    {
        Console.Write("Bir limit değeri giriniz: ");
        int limit1 = int.Parse(Console.ReadLine()); // Kullanıcıdan limit değeri alıyoruz

        int sayac1 = 0; // Sayaç başlangıç değeri

        Console.WriteLine("\nWhile Döngüsü Sonucu:");
        while (sayac1 <= limit1) // Limit değeri sağlanıyorsa döngü çalışır
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac1++; // Sayaç her adımda 1 artırılır
        }
    }


Console.WriteLine("-----------------O_o-----------------");

    
        Console.Write("Bir limit değeri giriniz: ");
        int limit = int.Parse(Console.ReadLine()); // Kullanıcıdan limit değeri alıyoruz

        int sayac = 0; // Sayaç başlangıç değeri

        Console.WriteLine("\nDo-While Döngüsü Sonucu:");
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++; // Sayaç her adımda 1 artırılır
        }
        while (sayac <= limit); // Limit değeri kontrolü döngünün sonunda yapılır


// While döngüsü, koşulu baştan kontrol ettiği için şart sağlanmazsa hiç çalışmaz.
// Do-while döngüsü, koşulu döngüden sonra kontrol ettiği için en az bir kez çalışır.
// Örnek olarak, limit -5 girildiğinde while döngüsü hiç çalışmaz ama do-while döngüsü bir kez çalışır.
