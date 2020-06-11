using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjectCore.Logica.Models.BindingModel
{
    public class ProjectsCreateBindingModel
    {
        [Required(ErrorMessage = "The field Title is Required")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field Title is Required")]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Required(ErrorMessage = "The field Title is Required")]
        [Display(Name = "Expected Completion Date")]
        public DateTime? ExpectedCompletionDate { get; set; }
    }

    public class ProjectsEditBindingModel
    {
        [Required(ErrorMessage = "The field Id is Required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Title is Required")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field Title is Required")]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Required(ErrorMessage = "The field Title is Required")]
        [Display(Name = "Expected Completion Date")]
        public DateTime? ExpectedCompletionDate { get; set; }
    }

}

