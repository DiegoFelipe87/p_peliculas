using proyFinal_g63.Shared.Model;
using System.Collections.Generic;

namespace proyFinal_g63.Client.Services

{
    
    
    
    //Service Movie hereda de IServiceMovie
    public class ServiceMovie:IServiceMovie
    {
        public List <Movie> GetMovies()
        {
            return new List<Movie>(){
                new Movie(){Id=1, Name="Pelicula 1"},
                new Movie(){Id=2, Name="Pelicula 2"},
                new Movie(){Id=3, Name="Pelicula 3"}


            };
        }
    }

}
