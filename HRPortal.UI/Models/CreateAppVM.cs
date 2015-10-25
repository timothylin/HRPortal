using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using HRPortal.Models;
using HRPortal.Models.Enums;

namespace HRPortal.UI.Models
{
    public class CreateAppVM
    {
        public Application ApplicationInfo { get; set; }

        public List<SelectListItem> States { get; set; }
        public List<SelectListItem> Degrees { get; set; }
        public List<SelectListItem> Positions { get; set; }

        public void CreateStateList(List<State> listOfStates)
        {
            States = new List<SelectListItem>();

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
            Degrees = new List<SelectListItem>();

            for (int d = 0; d < 12; d++)
            {
                DegreeType degreeType = (DegreeType)d;
                var newItem = new SelectListItem();
                newItem.Text = degreeType.ToString();
                newItem.Value = degreeType.ToString();

                Degrees.Add(newItem);
            }
        }

        public void CreatePositionsList(List<Position> listOfPositions)
        {
            Positions = new List<SelectListItem>();

            foreach (var p in listOfPositions)
            {
                var newItem = new SelectListItem();
                newItem.Text = p.PositionName;
                newItem.Value = p.PositionId.ToString();

                Positions.Add(newItem);
            }
        }

    }
}