using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

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
            animales.Add(new Salmon(true,"F",rnd.Next(0,20),rnd.Next(0,20),rnd.Next(1, 5)));
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
                if (animal is IDireccion sentido)
                {
                    sentido.Sentido();
                }
                
                if (animal is Tiburones tiburon)
                {
                    tiburon.Rondas();
                }
            }
            List<Pez> bebes = new List<Pez>();
            
            for (int a = 0; a < animales.Count; a++)
            {
                for (int b = a + 1; b < animales.Count; b++)
                {
                    
                    Pez p1 = animales[a];
                    Pez p2 = animales[b];
                    
                    if ( p1.Posx == p2.Posx && p1.Posy == p2.Posy)
                    {
                        if (p1.GetType() == p2.GetType())
                        {
                            if (p1.Vivo && p2.Vivo)
                            {
                                if (p1.Sexo == p2.Sexo)
                                {
                                    if (p1 is IMismoSexo luchador1 && p2 is IMismoSexo luchador2)
                                    {
                                        luchador1.ElMismoSexo();
                                        luchador2.ElMismoSexo();
                                    }
                                }

                                if (p1.Sexo != p2.Sexo)
                                {
                                    if (p1 is ISexoOpuesto reproducir)
                                    {
                                        bebes.Add(reproducir.SexoOpuesto());
                                    }
                                }
                            }
                        }

                        if (p1 is Tiburones tiburones && p2 is Salmon salmon && salmon.Vivo)
                        {
                            salmon.Vivo = false;
                        }
                        else if (p2 is Salmon salmon2 && p1 is Tiburones tiburones2 && salmon2.Vivo)
                        {
                            salmon2.Vivo = false;
                        }

                        if (p1 is Tiburones tiburon && p2 is Tortugas tortuga )
                        {
                            tiburon.MismaCasillaTiburonTortuga(tortuga);
                        }
                        else if (p2 is Tortugas tortuga2 && p1 is Tiburones tiburon2)
                        {
                            tiburon2.MismaCasillaTiburonTortuga(tortuga2);
                        }
                    }
                }
                
            }
            animales.AddRange(bebes);
            animales.RemoveAll(pezmuerto => pezmuerto.Vivo == false);

        }
        
        Console.WriteLine($"Comienza La Partida Del Ciclo De Vida De La Pecera");
        Console.WriteLine($"Ha habido un total de {animales.Count} en la pecera");
        Console.WriteLine($"Salmones --> {animales.Count(p => p is Salmon) }");
        Console.WriteLine($"Tiburones --> {animales.Count(ti => ti is Tiburones)}");
        Console.WriteLine($"Tortuga -->  {animales.Count(to => to is Tortugas)}");
        Console.WriteLine($"Pulpos --> {animales.Count(pu => pu is Pulpos)}");
        
    }
}