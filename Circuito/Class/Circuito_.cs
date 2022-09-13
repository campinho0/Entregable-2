namespace Circuito.Class;
using Circuito.Interfaces;
public  class Circuito_ {

    private IMonoplazaInterface? Monoplaza;
    private int MaxVueltas;
    private string NomCircuito;
    protected Random random = new Random();
    private int NumVueltas;
    private string escuderia;
    private bool PistaLibre, vehiculo;


    public Circuito_(int maxVueltas, string nomCircuito){
        NomCircuito = nomCircuito;
        MaxVueltas = maxVueltas;
        Monoplaza = null;
        this.PistaLibre = true;
    }

    public string AgregarMonoplaza(string _escuderia){
         if (Monoplaza == null && PistaLibre){
            Monoplaza = new Monoplaza(_escuderia);
            this.escuderia = _escuderia;
            this.PistaLibre = false;
            this.vehiculo = true;
            return _escuderia;
         }else{
            this.PistaLibre = true;
            this.escuderia = _escuderia;
            return _escuderia;
         }
    } 
    
    public void SacarMonoplaza(){
        if (Monoplaza != null && vehiculo){
            Monoplaza = null;
            this.PistaLibre = true;
            this.escuderia = "";
            this.vehiculo = false;
        }
    }

    public int RealizarPrueba(int numVueltas){
        if(!PistaLibre){
            if(numVueltas <= MaxVueltas){
                //
                Console.WriteLine(Monoplaza.Encender());
                //
                int MejorVuelta = 999999;
                //
                Console.WriteLine(Monoplaza.Mover());
                //
                for( int x = 0 ; x < numVueltas; x++ ){
                    int tiempo = random.Next(1 , 999999);
                    Console.WriteLine("Vuelta numero " + (x+1) + " Con tiempo de " + tiempo);
                    if(tiempo < MejorVuelta){
                        MejorVuelta = tiempo;
                    }
                }
                //  
                Console.WriteLine(Monoplaza.Detener());
                Console.WriteLine(Monoplaza.Apagar());
                //
                Console.WriteLine("El Mejor Tiempo de "+ escuderia +" es de: "+ MejorVuelta );
                Console.WriteLine("-----------------------------------------------------------------------");
                return MejorVuelta;
            }else{
                Console.WriteLine("Numero de vueltas mayor del maximo permitido");
                return 0;
            }
            
        }else{
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Hay un vehiculo en la pista " + escuderia + " no pudo competir");
             Console.WriteLine("*************************************************************");
             Console.WriteLine("-----------------------------------------------------------------------");
            return 0;
        }
    }
}

