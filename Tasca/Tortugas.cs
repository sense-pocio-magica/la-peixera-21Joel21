namespace Peces;

public class Tortugas : Pez,IDireccion,ISexoOpuesto
{
    public Tortugas(bool vivo, string sexo, int posx, int posy, int direccion) : base(vivo, sexo, posx, posy, direccion)
    {
        
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
        
        Tortugas tortuga = new Tortugas(true,SexoHijo,this.Posx,this.Posy, DireccionAleatoria);
        return tortuga;
    }
    
    
}