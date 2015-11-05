﻿using System;
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

            return errors;
        }
    }
}