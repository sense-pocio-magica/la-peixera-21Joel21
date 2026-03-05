namespace Peces;

public class Tiburones : Pez,IDireccion,IMismoSexo,ISexoOpuesto
{
    public int ContadorRondas;
    public Tiburones(bool vivo, string sexo, int posx, int posy, int direccion,int contadorrondas):base (vivo,sexo,posx,posy,direccion)
    {
        ContadorRondas =contadorrondas;
    }

    public void Sentido()
    {
        if (Direccion == 1) 
        {
            Posy--;
        }
        else if (Direccion == 2) 
        {
            Posy++;
        }
        else if (Direccion == 3) 
        {
            Posx++;
        }
        else if (Direccion == 4) 
        {
            Posx--;
        }

        if (Posx > 19)
        {
            Posx = 0;
        }

        if (Posy > 19)
        {
            Posy = 0;
        }

        if (Posy < 0)
        {
            Posy = 19;
        }

        if (Posx < 0)
        {
            Posx = 19;
        }

        ContadorRondas++;
    }

    public void MismaCasillaTiburonTortuga(Tortugas tortuga)
    {
        if (tortuga.Posx == this.Posx && tortuga.Posy == this.Posy)
        {
            DSendtidoTortuga();
        }
    }
    
    
    public void DSendtidoTortuga()
    {
        if (Direccion == 1)
        {
            Direccion = 2;
        }
        else if (Direccion == 2)
        {
            Direccion = 1;
        }
        else if (Direccion == 3)
        {
            Direccion = 4;
        }
        else if (Direccion == 4)
        {
            Direccion = 3;
        }
    }
    
    public void ElMismoSexo()
    {
        this.Vivo = false;
    }

    
    public void Rondas()
    {
        if (ContadorRondas >= 75)
        {
            this.Vivo = false;
        }
    }
    
    
    public Pez SexoOpuesto()
    {
        Random rnd = new Random();
      
        string SexoHijo = "";
      
        int numero = rnd.Next(1, 3);
      
        if (numero == 1)
        {
            SexoHijo = "M";
        }
        else
        {
            SexoHijo = "F";
        }
      
        int DireccionAleatoria = rnd.Next(1, 5);


        Tiburones tiburon = new Tiburones(true, SexoHijo, this.Posx, this.Posy, DireccionAleatoria, 0);
        return tiburon;
    }
    
}