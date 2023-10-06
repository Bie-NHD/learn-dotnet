using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaManagement.Model
{
    internal class Movie
    {
        public string OrderID;
        public string MovieName;
        public string MovieOrigin;
        public string MovieCategory;
        public int RestrictAge = 3;
        public DateTime AiringDate;
        public string MovieFormat;
        public int AdditionalFee = 0;

      
        public Movie(string id, string name)
        {
            OrderID = id;
            MovieName = name;
        }
        public Movie(string id, string name, string movieCategory, DateTime airingDate
            )
        {
            OrderID = id;
            MovieName = name;
            AiringDate = airingDate;
            MovieCategory = movieCategory;
        }
        public Movie(string id, string name,  DateTime airingDate, string movieCategory = "", string movieFormat = "", int age = 3,
            int fee = 0, string origin = "")
        {
            OrderID = id;
            MovieName = name;
            MovieCategory = movieCategory;
            RestrictAge = age;
            MovieFormat = movieFormat;
            AiringDate = airingDate;
            AdditionalFee = fee;
            MovieOrigin = origin;
        }



    }

    enum MovieCategory { ACTION , ROMANCE }
    enum MovieFormat { M_2D, M_3D }

    public static class Constants
    {
        public const string ACTIONS = "Hành động";
        public const string ROMANCE = "Tình cảm";
        public const string M_2D = "2D";
        public const string M_3D = "3D";
    }
    

}
