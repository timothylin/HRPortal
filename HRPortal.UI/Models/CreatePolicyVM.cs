using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using HRPortal.Models;
using System.Web.Mvc;

namespace HRPortal.UI.Models
{
    public class CreatePolicyVM : IValidatableObject
    {
        public Policy Policy { get; set; }

        public List<SelectListItem> PolicyCategoriesList { get; set; }


        public CreatePolicyVM()
        {
            Policy = new Policy();
            PolicyCategoriesList = new List<SelectListItem>();
        }


        public void CreatePolicyCatList(List<PolicyCategory> listOfPolicyCategories)
        {
            foreach (var cat in listOfPolicyCategories)
            {
                var newItem = new SelectListItem();
                newItem.Text = cat.Category;
                newItem.Value = cat.Category;

                PolicyCategoriesList.Add(newItem);
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Policy.Title))
            {
                errors.Add(new ValidationResult("Please enter a title...", new[] { "Policy.Title" }));
            }

            if (string.IsNullOrEmpty(Policy.ContentText))
            {
                errors.Add(new ValidationResult("Please enter some context text...", new[] { "Policy.ContextText" }));
            }

            if (string.IsNullOrEmpty(Policy.Category))
            {
                errors.Add(new ValidationResult("Please enter a category...", new[] { "Policy.Category" }));
            }

            return errors;
        }
    }
}