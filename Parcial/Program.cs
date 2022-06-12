using Entidad.Instrumento;
using Entidad.Servicio;


Console.WriteLine("Digite el tipo de servicio. ");
Console.WriteLine("1. Orden de compra. ");
Console.WriteLine("2. Pedido. ");
Console.WriteLine("3. Facturación. ");
Console.WriteLine("4. Cotización. ");
int opcionServicio = int.Parse(Console.ReadLine()!);

FabricaServicio fabricaServicio = new FabricaServicio();
var servicio = fabricaServicio.ObtenerServicio(opcionServicio);

Console.WriteLine("Digite el tipo de elección. ");
Console.WriteLine("1. Aleatorio. ");
Console.WriteLine("2. Específico. ");
int opcionEleccion = int.Parse(Console.ReadLine()!);

FabricaInstrumento fabricaInstrumento = new FabricaInstrumento();

int opcionInstrumento = 0, opcionTipo = 0;

if (opcionEleccion == 1)
{
    servicio.instrumento = fabricaInstrumento.ObtenerAleatorio();
}
else
{
    Console.WriteLine("Digite el instrumento. ");
    Console.WriteLine("1. Guitarra. ");
    Console.WriteLine("2. Bajo. ");
    Console.WriteLine("3. Piano. ");
    opcionInstrumento = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite el tipo. ");
    Console.WriteLine("1. Eléctrico. ");
    Console.WriteLine("2. No eléctrico. ");
    opcionTipo = int.Parse(Console.ReadLine()!);

}

Console.WriteLine("¿Agregar accesorio? S/N");
string respuesta = Console.ReadLine()!;

if (respuesta.ToUpper() == "S")
{
    servicio.instrumento = fabricaInstrumento.ObtenerInstrumento(opcionInstrumento, opcionTipo, "Calcomanía");
}else
{
    servicio.instrumento = fabricaInstrumento.ObtenerInstrumento(opcionInstrumento, opcionTipo);
}

Console.WriteLine("----------------------");
Console.WriteLine("Servicio: "+ servicio.Nombre);
Console.WriteLine("Instrumento: "+ servicio.instrumento?.Nombre + " " + servicio.instrumento?.tipoDeInstrumento?.NombreTipo);
Console.WriteLine("Accesorio: "+ servicio.instrumento?.accesorio?.Nombre);


Console.WriteLine(servicio.instrumento?.Afinar());
Console.WriteLine(servicio.instrumento?.Interpretar());

