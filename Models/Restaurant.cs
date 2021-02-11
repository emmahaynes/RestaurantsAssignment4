using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Emma Haynes 2-10-21

namespace RestaurantsAssignment4.Models
{
    public class Restaurant
    {
        //attribute list for the restaurant class
        public Restaurant(int rank) //constructor to make rank read only
        {
            Rank = rank;
        }
        [Required]
        public int Rank { get; }
        [Required]
        public string Name { get; set; }
        public string? FavDish { get; set; } = "It's all tasty!"; //sets it's all tasty as default
        [Required]
        public string Address { get; set; }
        public string? Phone { get; set; } //? allows for nulls
        public string? Website { get; set; } = "Coming Soon";

        public static Restaurant[] GetRestaurants()
        {
            //Sets the attributes for the top 5 restaurants
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Spicy Thai",
                FavDish = "Pineapple Fried Rice",
                Address = "University Ave. Provo",
                Phone = "801-369-6744",
                Website = "spicythai.com"
            };
            Restaurant r2 = new Restaurant(2)
            {
                Name = "Bombay House",
                FavDish = "Garlic Naan Bread",
                Address = "University Ave. Provo",
                Phone = "801-369-6744",
                Website = "bombayhouse.com"
            };
            Restaurant r3 = new Restaurant(3)
            {
                Name = "Black Sheep Diner",
                FavDish = "Soup",
                Address = "University Ave. Provo",
                Phone = "801-369-6744",
                Website = "blacksheep.com"
            };
            Restaurant r4 = new Restaurant(4)
            {
                Name = "Magelby Fresh",
                FavDish = "Strawberries and Cream",
                Address = "University Ave. Provo",
                Phone = "801-369-6744",
                Website = "magelbys.com"
            };
            Restaurant r5 = new Restaurant(5)
            {
                Name = "Seven Bros",
                FavDish = "Hawaiian Burger",
                Address = "University Ave. Provo",
                Phone = "801-369-6744",
                Website = "sevenbros.com"
            };
            //loads array with inputs
            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
