// Realizar un programa que lea por teclado dos números, si el primero es mayor
// al segundo informar su suma y diferencia, en caso contrario informar el producto
// y la división del primero respecto al segundo.

int num1 = 0;
int num2 = 0;
int suma = 0;
int diferencia = 0;
int producto = 0;
decimal division = 0;

string linea = string.Empty;

//ingresar los numeros
Console.WriteLine("ingrese un prrimer numero ");
linea = Console.ReadLine();
num1 = Convert.ToInt32(linea);

Console.WriteLine("ingresa el segundo numero ");
linea = Console.ReadLine();
num2 = Convert.ToInt32(linea);

// Uso de la instruccion if...else

if (num1 > num2)
{
    suma = num1 + num2;
    diferencia = num1 - num2;

    Console.WriteLine(" la suma de los dos numeros es " + suma + " y la diferecia es " + diferencia);
}
else
{
    producto = num1 * num2;
    division = num1 / num2;
    Console.WriteLine("El poducto es " + producto + " y la division es" + division);
}
