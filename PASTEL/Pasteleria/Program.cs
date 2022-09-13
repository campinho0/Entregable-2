

using Pasteleria;

Ingrediente harina = new Ingrediente();
harina.Nombre = "Harina de trigo";
harina.Cantidad = 500;
harina.Precio = 2000.0;

Ingrediente azucar = new ()
{
    Nombre = "Azúcar",
    Cantidad = 250,
    Precio = 2700.0
};

Ingrediente chocolate = new Ingrediente ();

chocolate.Nombre = "chocolate";
chocolate.Cantidad = 200;
chocolate.Precio = 1000;

Pastel pastel = new()
{
    Nombre = "Pastel cumpleaños",
    Tamano = 20
};
pastel.AgregarIngrediente(harina);
pastel.AgregarIngrediente(azucar);
pastel.AgregarIngrediente(chocolate);

foreach(Ingrediente ingrediente in pastel.Ingredientes)
{
    Console.WriteLine(ingrediente);
}

Console.WriteLine($"Costo total es {pastel.CalcularCosto()}");
Console.WriteLine(pastel.ObtenerIngredientes());
Console.WriteLine($"cantidad de ingredientes es {pastel.RetornarCantidad()}");