namespace Tasca;

internal class Program
{
    static void Main(string[] args)
    {
       namespace Peces;

class Program
{
     
    static void Main(string[] args)
    {
        List<Pez> animales = new List<Pez>();
        
        Random  rnd = new Random();
        
        int direccion = rnd.Next(1, 5);

        Random UbicacionPulpo =  new Random();
        
        
        for (int i = 0; i < 50; i++)
        {
            animales.Add(new Salmon(true,"M",rnd.Next(0,20),rnd.Next(0,20),rnd.Next(1, 5)));
            animales.Add(new Salmon(true,"F",rnd.Next(0,20),rnd.Next(0,20),rnd.Next(1, 5)));ç
        }

        for (int i = 0; i < 10; i++)
        {
            animales.Add(new Tiburones(true,"M",rnd.Next(0,20),rnd.Next(0,20),rnd.Next(1, 5),0));
            animales.Add(new Tiburones(true,"F",rnd.Next(0,20),rnd.Next(0,20),rnd.Next(1, 5),0));
        }

        for (int i = 0; i < 3; i++)
        {
            animales.Add(new Tortugas(true,"M",rnd.Next(0,19),rnd.Next(0,20),rnd.Next(1, 5)));
            animales.Add(new Tortugas(true,"F",rnd.Next(0,20),rnd.Next(0,20),rnd.Next(1, 5)));
        }

        for (int i = 0; i < 7; i++)
        {
            animales.Add(new Pulpos(true,"A",UbicacionPulpo.Next(0,20),0,3));
            animales.Add(new Pulpos(true,"A",0,UbicacionPulpo.Next(0,20),2));
        }
        
        for(int i= 0; i<100; i++)
        {
            foreach (Pez animal in animales)
            {
                if (animal is Salmon s)
                {
                    if (s.Posx == s.Posx && s.Posy == s.Posy && s.Sexo == "M")
                    {
                        s.ElMismoSexo();
                        
                    }
                }
            }
        }
        
    }
}
    }
}