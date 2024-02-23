//   Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//   A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

 Console.WriteLine("Input coordination first point");
 Console.Write("x1: ");
 double x1 = double.Parse(Console.ReadLine());
 Console.Write("y1: ");
 double y1 = double.Parse(Console.ReadLine());
 Console.Write("z1: ");
 double z1 = double.Parse(Console.ReadLine());
    
 Console.WriteLine("Input coordination second point");
 Console.Write("x2: ");
 double x2 = double.Parse(Console.ReadLine());
 Console.Write("y2: ");
 double y2 = double.Parse(Console.ReadLine());
 Console.Write("z2: ");
 double z2 = double.Parse(Console.ReadLine());

 double distance = Calculate(x1, y1, z1, x2, y2, z2);

 Console.WriteLine($"distance: {distance}");


 static double Calculate(double x1, double y1, double z1, double x2, double y2, double z2)
 {
     double deltax = x2 - x1;
     double deltay = y2 - y1;
     double deltaz = z2 - z1;

     double distance = Math.Sqrt(deltax * deltax + deltay * deltay + deltaz * deltaz);
     return distance;
 }

