using System;
using System.Collections.Generic;

namespace Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombresDePelicula = new List<string>(); 
            nombresDePelicula.Add("Toy Story");
            nombresDePelicula.Add("Avengers"); 
            nombresDePelicula.Add("Bicentenial Man"); 
            nombresDePelicula.Add("Silencce of the Lambs"); 
            nombresDePelicula.Add("Corpse Bride");  
            nombresDePelicula.Add("Bad Boys");   
            nombresDePelicula.Add("Bad Boys");   
            nombresDePelicula.Add("Aladdin");   
            nombresDePelicula.Add("Aladdin");

            HashSet<String> nombresDePeliculasSet = new HashSet<string>();
            nombresDePeliculasSet.Add("Toy Story");
            nombresDePeliculasSet.Add("Avengers"); 
            nombresDePeliculasSet.Add("Bicentenial Man"); 
            nombresDePeliculasSet.Add("Silencce of the Lambs"); 
            nombresDePeliculasSet.Add("Corpse Bride");  
            nombresDePeliculasSet.Add("Bad Boys");   
            nombresDePeliculasSet.Add("Bad Boys");   
            nombresDePeliculasSet.Add("Aladdin");   
            nombresDePeliculasSet.Add("Aladdin");

            Console.WriteLine("Cant. de peliculas en nommbreDePeliculas: " + nombresDePelicula.Count);
            Console.WriteLine("Cant. de peliculas en nommbreDePeliculasSet: " + nombresDePeliculasSet.Count);


            HashSet<Pelicula> peliculasSet = new HashSet<Pelicula>();
            peliculasSet.Add(new Pelicula("Bad Boys", 1995));
            peliculasSet.Add(new Pelicula("Bad Boys", 1983));
            peliculasSet.Add(new Pelicula("Aladdin", 1992));
            peliculasSet.Add(new Pelicula("Aladdin", 1992));


            Console.WriteLine("Cant. de peliculas en peliculasSet: " + peliculasSet.Count);

            Dictionary<string,string> nombreDePeliculasFavoritas = new Dictionary<string, string>();
            nombreDePeliculasFavoritas.Add("Pablo", "Titanic"); 
            nombreDePeliculasFavoritas.Add("Esteban", "The Fast and the Furios: Tokyo Drift"); 
            nombreDePeliculasFavoritas.Add("Octavio", "Barbie in the 12 Dancing Princesses");

            string nommbreDePeliculasFavoritaPablo = nombreDePeliculasFavoritas.GetValueOrDefault("Pablo");  
            Console.WriteLine("nommbreDePeliculasFavoritaPablo: " + nommbreDePeliculasFavoritaPablo);
            

            string nommbreDePeliculasFavoritaRamiro = nombreDePeliculasFavoritas.GetValueOrDefault("Ramiro");  
            Console.WriteLine("nommbreDePeliculasFavoritaRamiro: " + nommbreDePeliculasFavoritaRamiro);
            
            nommbreDePeliculasFavoritaRamiro = nombreDePeliculasFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");  
            Console.WriteLine("nommbreDePeliculasFavoritaRamiro: " + nommbreDePeliculasFavoritaRamiro);

            nombreDePeliculasFavoritas.Add("Ramiro", "Avatar");

            nommbreDePeliculasFavoritaRamiro = nombreDePeliculasFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");  
            Console.WriteLine("nommbreDePeliculasFavoritaRamiro: " + nommbreDePeliculasFavoritaRamiro);


             if (nombreDePeliculasFavoritas.TryGetValue("Maria", out string nommbreDePeliculasFavoritaMaria))
            {
                Console.WriteLine("nommbreDePeliculasFavoritaMaria:" + nommbreDePeliculasFavoritaMaria);
            }
            else
            {
                Console.WriteLine("Maria no tiene pelicula favorita.");
            }


            Console.WriteLine("---------");
            Console.WriteLine("Lista:"); 

            for (int i = 0; i < nombresDePelicula.Count; i++)
            {
                Console.WriteLine(nombresDePelicula[i]);
            }

            Console.WriteLine("---------");
            Console.WriteLine("HashSet:"); 
            
            foreach (String nombrePelicula in nombresDePeliculasSet )
            {
                Console.WriteLine(nombrePelicula);
            }

             
            Console.WriteLine("---------");
            Console.WriteLine("Dictionary:"); 

             foreach (var key in nombreDePeliculasFavoritas.Keys)
            {
                Console.WriteLine(key); 
            }

            foreach (var value in nombreDePeliculasFavoritas.Values)
            {
                Console.WriteLine(value); 
            }

             foreach (var key in nombreDePeliculasFavoritas.Keys)
            {
                Console.WriteLine(key + ":" +nombreDePeliculasFavoritas.GetValueOrDefault(key)); 
            }
        }
    }
}
