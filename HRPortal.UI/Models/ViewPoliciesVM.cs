using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Models;

namespace HRPortal.UI.Models
{
    public class ViewPoliciesVM : IValidatableObject
    {
        public List<Policy> Policies { get; set; }
        public PolicyCategory PolicyCategory { get; set; }  

        public List<SelectListItem> PolicyCategoriesList { get; set; }


        public ViewPoliciesVM()
        {
            Policies = new List<Policy>();
            PolicyCategory = new PolicyCategory();
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

            return errors;
        }
    }
}