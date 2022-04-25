using M2;

Car car1 = new Car();


car1.Brand = "Toyota";
car1.NumberPlate = "4545";
car1.Speed = 20;


string carName = car1.Brand;
string carNumberPlate = car1.NumberPlate;
double carSpeed = car1.Speed;

Console.WriteLine($"Auto {carName} numurs {carNumberPlate}!");

car1.StartToDrive();
car1.GoFaster();
car1.Beep();
car1.SlowDown();
car1.Stop();