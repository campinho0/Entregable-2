namespace Pasteleria
{
    public class Pastel
    {
        public string Nombre { get; set; } = "";

        /// Cantidad de personas
        public int Tamano { get; set; }
        public List<Ingrediente> Ingredientes { get; set; } = new();

        // calcular el costo
        public double CalcularCosto()
        {
            double costoTotal = 0.0;
            foreach(Ingrediente ingrediente in Ingredientes){
                double costo = ingrediente.Cantidad * ingrediente.Precio;
                costoTotal = costoTotal + costo;                
            }
            return costoTotal;
        }

        public string ObtenerIngredientes(){
            string listaIngredientes =  "";
            foreach(Ingrediente ingrediente in Ingredientes){
                listaIngredientes = listaIngredientes + ingrediente.ToString() + "\n";

            }
            return listaIngredientes;
        }

        public int RetornarCantidad (){
            int cantidad = 0;
            cantidad = Ingredientes.Count;

            return cantidad;
        }
          
        public void AgregarIngrediente(Ingrediente ingrediente ){
            Ingredientes.Add(ingrediente);
        }
    }
}