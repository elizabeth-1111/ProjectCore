using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjectCore.Logica.Models.BindingModel
{
    public class TasksCreateBindingModel
    {
        [Display(Name = "Title")]
        [Required(ErrorMessage = "The field Title is Required")]
       
        public string Title { get; set; }

        [Display(Name = "Details")]
        [Required(ErrorMessage = "The field Details is Required")]

        public string Details { get; set; }

        [Display(Name = "ExpirationDate")]
        [Required(ErrorMessage = "The field ExpirationDate is Required")]

        public DateTime? ExpirationDate { get; set; }

        [Display(Name = "IsCompleted")]
        [Required(ErrorMessage = "The field IsCompleted is Required")]
        public bool IsCompleted { get; set; }

        [Display(Name = "Effort")]
        [Required(ErrorMessage = "The field Effort is Required")]
        public int? Effort { get; set; }

        [Display(Name = "RemainingWork")]
        [Required(ErrorMessage = "The field RemainingWork is Required")]
        public int? RemainingWork { get; set; }

        [Display(Name = "StateId")]
        [Required(ErrorMessage = "The field StateId is Required")]
        public int? StateId { get; set; }

        [Display(Name = "ActivityId")]
        [Required(ErrorMessage = "The field ActivityId is Required")]
        public int? ActivityId { get; set; }

        [Display(Name = "PriorityId")]
        [Required(ErrorMessage = "The field PriorityId is Required")]
        public int? PriorityId { get; set; }

        [Display(Name = "ProjectId")]
        [Required(ErrorMessage = "The field ProjectId is Required")]
        public int? ProjectId { get; set; }


    }
}
