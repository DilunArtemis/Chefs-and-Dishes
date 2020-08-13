using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace ChefsDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}

        [Required]
        [Display(Name = "First Name: ")]
        public string FirstName {get; set;}

        [Required]
        [Display(Name = "Last Name: ")]
        public string LastName {get; set;}

        [Required]
        // [Range (0,double.PositiveInfinity, ErrorMessage = "Not old enough, bruh.")]
        [Display(Name = "Date of Birth: ")]
        public DateTime DateOfBirth {get;set;}

        public List<Dish> ThisChefsDishes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }

        public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required(ErrorMessage = "Dish name is required")]
        [Display(Name = "Name of Dish:")]
        public string Name { get; set; }


        [Display(Name = "Description:")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Calories is required")]
        [Display(Name = "Calories:")]
        [Range(1, int.MaxValue,ErrorMessage = "Calories must be greater then 0")]
        public int Calories { get; set; }


        [Required(ErrorMessage = "Tastiness is required")]
        [Display(Name = "Tastiness:")]
        [Range(1, 5)]
        public int Tastiness { get; set; }
        

        public int ChefId {get;set;}
        public Chef Creator {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}