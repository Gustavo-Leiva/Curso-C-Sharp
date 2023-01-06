namespace ejercicio_01;
class Program
{
    static void Main(string[] args)
    {
         //1. Hacer una función llamada “producto” que reciba dos números enteros y 
        //que devuelva el producto de ambos. Luego hacer un programa que pida el 
        //precio de un artículo y la cantidad vendida y muestre por pantalla el 
        //monto total a pagar. Usar la función.

     

        int precio;
        int cantidad;
        int montoTotalAPagar;

        Console.Write("ingrese el precio de producto: ");
        precio = int.Parse(Console.ReadLine());
        Console.Write("ingrese la cantidad del producto: ");
        cantidad = int.Parse(Console.ReadLine());

        montoTotalAPagar = producto(precio,cantidad);

        Console.WriteLine("el precio total del producto es: " + montoTotalAPagar);
    }

     static int producto(int num1, int num2)
        {
            int producto;
            producto = num1 * num2;
            return producto;
        }
}

