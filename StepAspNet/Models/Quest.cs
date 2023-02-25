using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StepAspNet.Models
{
    public class Quest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This is required field")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Min = 2, Max=15 simbols for field")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This is required field")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Min = 5, Max=100 simbols for field")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This is required field")]
        
        public int Duration { get; set; }

        [Required(ErrorMessage = "This is required field")]
        
        public string TeamNum { get; set; }

        [Required(ErrorMessage = "This is required field")]
        
        public int PlayerAge { get; set; }

        [Required(ErrorMessage = "This is required field")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Min = 2, Max=50 simbols for field")]
        public string Address { get; set; }

        [Required(ErrorMessage = "This is required field")]
        [RegularExpression("^((\\+7|7|8)+([0-9]){10})$", ErrorMessage = "Incorrect phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "This is required field")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This is required field")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Min = 2, Max=15 simbols for field")]
        public string Company { get; set; }

        [Required(ErrorMessage = "This is required field")]
        
        public double Raiting { get; set; }

        [Required(ErrorMessage = "This is required field")]
        
        public int FearLevel { get; set; }

        [Required(ErrorMessage = "This is required field")]
        
        public int DifficultyLevel { get; set; }
        public string LogoImg { get; set; }
        public List<string>Images { get; set; }

    }
}
