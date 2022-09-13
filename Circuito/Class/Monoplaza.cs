namespace Circuito.Class;
using Circuito.Interfaces;


public class Monoplaza : IMonoplazaInterface{
    private string escuderia;
    protected bool Encendido, Apagado, Movimiento, Detenido;

    public Monoplaza(string _escuderia){
        Apagado = true;
        Encendido = false;
        Movimiento = false;
        Detenido = true;
        escuderia = _escuderia;
    }

    public string Encender(){
        if(Apagado){
            Encendido = true;
            Apagado = false;
            return ("El monoplaza está Encendido");
        }else{
            return ("El monoplaza no se pudo encender ");
        }
        
    }

    public string Apagar(){
        if(Encendido && Detenido){
            Encendido = false;
            Apagado = true;
            return ("El monoplaza está Apagado");
        }else{
        return ("El monoplaza no se pudo apagar");
        }
    }

    public string Mover(){
        if(Encendido && Detenido){
            Movimiento = true;
            Detenido = false;
            return ("El monoplaza está en movimiento");
        }else{
        return ("El monoplaza no se pudo mover");
        }
    }

    public string Detener(){
        if(Encendido && Movimiento){
            Movimiento = false;
            Detenido = true;
            return ("El monoplaza está Detenido");
        }else{
        return ("El monoplaza no se pudo detener");
        }
    }
    

}