namespace Pasteleria
{
    public class Ingrediente
    {
        public string Nombre { get; set; } = "";
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return $"{Cantidad} - {Nombre}";
        }
    }
}