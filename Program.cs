// Calcular el area de un circulo

//radio
int radio;
Console.WriteLine("Porfavor ingrese el radio");
radio = int.Parse(Console.ReadLine());

//pi
double pi = 3.14D;

//area
double area;
area = (radio * radio * pi);
Console.Write("El area es " );
Console.Write (area);
