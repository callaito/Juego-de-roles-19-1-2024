// See https://aka.ms/new-console-template for more information
using Juego_de_roles_19_1_2024;


Console.WriteLine("Juego de rol");
Console.WriteLine();

Console.WriteLine("Guerrero");
Guerrero Guerrero = new Guerrero();
Console.WriteLine("Nombre: ");
Guerrero.nombre=Convert.ToString(Console.ReadLine());
Console.WriteLine("Nivel: ");
Guerrero.nivel=Convert.ToString(Console.ReadLine());
Console.WriteLine("Nombre: ");
Guerrero.atacar=Convert.ToString(Console.ReadLine());


Console.WriteLine("Mago");
Mago Mago = new Mago();



Console.WriteLine();

String Nombre_guerrero = Guerrero.Nombre();
String fuerza_fisica = Guerrero.Capacidad();


Console.WriteLine();
String Nombre_mago = Mago.Nombre();
String mana = Mago.Capacidad();




Console.WriteLine();



Console.WriteLine("El nombre del guerrero es " + Nombre_guerrero);
Console.WriteLine($"El nivel de guerrero es " + nivel_guerrero);


Console.WriteLine();
Console.WriteLine("El nombre del mago es " + Nombre_mago);
Console.WriteLine($"El nivel del mago es" + nivel_mago);







