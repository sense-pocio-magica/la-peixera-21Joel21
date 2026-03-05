namespace Peces;

public class Salmon : Pez ,IDireccion,IMismoSexo,ISexoOpuesto
{
   public Salmon(bool vivo, string sexo, int posx, int posy, int direccion) : base(vivo, sexo, posx, posy, direccion)
   {
      
   }

   public void Sentido()
   {
      if (Direccion == 1) //Esto es Norte
      {
         Posy--;
      }
      else if (Direccion == 2) //Sur
      {
         Posy++;
      }
      else if (Direccion == 3) //Este 
      {
         Posx++;
      }
      else if (Direccion == 4) //Oeste
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

   public void ElMismoSexo()
   {
      this.Vivo = false;
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

      
      Salmon salmon = new Salmon(true, SexoHijo,this.Posx,this.Posy, DireccionAleatoria);
      return  salmon;
      
   }
}