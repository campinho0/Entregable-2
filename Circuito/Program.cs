using Circuito.Class;

    Dictionary<string, int> TablaResultados = new Dictionary<string, int>();
    Circuito_ circuito = new Circuito_(3, "Monaco");
    TablaResultados.Add(circuito.AgregarMonoplaza("Ferrari"),circuito.RealizarPrueba(2));
    circuito.SacarMonoplaza();// Si no se saca el monoplaza de la pista el proximo vehiculo no puede correr y no marca tiempo para la tabla de resultados
    TablaResultados.Add(circuito.AgregarMonoplaza("Mclaren"),circuito.RealizarPrueba(2));
    TablaResultados.Add(circuito.AgregarMonoplaza("Redbull"),circuito.RealizarPrueba(3));
    circuito.SacarMonoplaza();
    TablaResultados.Add(circuito.AgregarMonoplaza("Porshe"),circuito.RealizarPrueba(2));

    
    
    
    var organizada = TablaResultados.ToList();
    organizada.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            foreach (var value in organizada)
            {   
                if(!value.Value.Equals(0)){
                    Console.WriteLine(value);
                }
            }