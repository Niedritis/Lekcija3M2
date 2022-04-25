using M2;

Car car1 = new Car();

Console.WriteLine("Lūdzu, ievadi Auto marku");
string CarBrand = Console.ReadLine();
car1.Brand = CarBrand;

Console.WriteLine("Lūdzu, ievadi Auto numuru");
string Number = Console.ReadLine();
car1.NumberPlate = Number;

Console.WriteLine("Lūdzu ievadi , Ātrumu ar cipariem");
string CarSpeed = Console.ReadLine();
car1.Speed = double.Parse(CarSpeed);



Console.WriteLine($"Auto {car1.Brand} numurs {car1.NumberPlate}!");

car1.StartToDrive();
car1.GoFaster();
car1.Beep();
car1.SlowDown();
car1.Stop();