namespace Peces;

public interface IDireccion
{
    void Sentido();
}

public interface IMismoSexo
{
    void ElMismoSexo();
}

public interface ISexoOpuesto
{
    Pez SexoOpuesto();
}

public abstract class Pez
{
    public bool Vivo;
    public string Sexo;
    public int Posx;
    public int Posy;
    public int Direccion;
    

    public Pez(bool vivo, string sexo, int posx, int posy, int direccion)
    {
        Vivo = vivo;
        Sexo = sexo;
        Posx = posx;
        Posy = posy;
        Direccion = direccion;
    }
    
    
    
    
    
    
}