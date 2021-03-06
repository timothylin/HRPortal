﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using HRPortal.Models;
using HRPortal.Models.Enums;

namespace HRPortal.UI.Models
{
    public class CreateAppVM : IValidatableObject
    {
        public Resume ApplicationInfo { get; set; }
        public int ExperienceItems { get; set; }
        public int EducationItems { get; set; }

        public List<SelectListItem> States { get; set; }
        public List<SelectListItem> Degrees { get; set; }
        public List<SelectListItem> Positions { get; set; }


        public CreateAppVM()
        {
            ApplicationInfo = new Resume();
            States = new List<SelectListItem>();
            Degrees = new List<SelectListItem>();
            Positions = new List<SelectListItem>();

        }

        public void CreateStateList(List<State> listOfStates)
        {


            foreach (var s in listOfStates)
            {
                var newItem = new SelectListItem();
                newItem.Text = s.StateAbbreviation;
                newItem.Value = s.StateName;

                States.Add(newItem);
            }
        }

        public void CreateDegreesList()
        {


            foreach (var d in Enum.GetValues(typeof(DegreeType)))
            {
                var newItem = new SelectListItem();
                newItem.Text = d.ToString();
                newItem.Value = d.ToString();

                Degrees.Add(newItem);
            }
        }

        public void CreatePositionsList(List<Position> listOfPositions)
        {


            foreach (var p in listOfPositions)
            {
                var newItem = new SelectListItem();
                newItem.Text = p.PositionName;
                newItem.Value = p.PositionName;

                Positions.Add(newItem);
            }
        }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(ApplicationInfo.ApplicantContactInfo.FirstName))
            {
                errors.Add(new ValidationResult("Please enter your first name...", new[] { "ApplicationInfo.ApplicantContactInfo.FirstName" }));
            }

            if (string.IsNullOrEmpty(ApplicationInfo.ApplicantContactInfo.LastName))
            {
                errors.Add(new ValidationResult("Please enter your last name...", new[] { "ApplicationInfo.ApplicantContactInfo.LastName" }));
            }


            return errors;
        }
    }
}