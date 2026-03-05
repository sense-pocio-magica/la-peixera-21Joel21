namespace Peces;

public class Pulpos : Pez, IDireccion, IMismoSexo
{
    public Pulpos(bool vivo, string sexo, int posx, int posy, int direccion) : base(vivo, sexo, posx, posy, direccion)
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

        if (Posx == 0 && Posy == 0 && Direccion == 4)
        {
            Direccion = 2;
        }
        else if (Posx == 0 && Posy == 19 &&  Direccion == 2)
        {
            Direccion = 3;
        }
        else if (Posx == 19 && Posy == 19 && Direccion == 3)
        {
            Direccion = 1;
        }
        else if (Posx == 19 && Posy == 0 && Direccion == 1)
        {
            Direccion = 4;
        }
        
    }

    public void ElMismoSexo()
    { 
        Vivo = true;
    }

    
    
}