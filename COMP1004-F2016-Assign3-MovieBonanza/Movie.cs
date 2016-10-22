using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1004_F2016_Assign3_MovieBonanza
{
    public class Movie
    {
        public enum MovieValue
        {
            Discount = 0,
            Standard = 1,
            Premium = 2
        }

        public enum RentTime
        {
            _24hrs = 24,
            _48hrs = 48
        }

        public Movie(
            string itemValue,
            string name,
            string description,
            Genre genre,
            MovieValue value,
            Image picture
            )
        {
            this.ItemValue = itemValue;
            this.Name = name;
            this.Description = description;
            this.Genre = genre;
            this.Value = value;
            this.Picture = picture;
        }

        public string ItemValue { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Genre Genre { get; set; }

        public MovieValue Value { get; set; }

        public Image Picture { get; set; }

        public bool IsBuying { get; set; }

        public int RentHours { get; set; }

        public double Price { get; set; }
    }
}
