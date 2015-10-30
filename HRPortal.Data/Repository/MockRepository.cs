using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models;
using HRPortal.Models.Interfaces;

namespace HRPortal.Data.Repository
{
    public class MockRepository : IRepository
    {
        public List<Resume> AppsList { get; set; }
        public List<PolicyCategory> ListofPolicyCategories { get; set; }

        public MockRepository()
        {
            AppsList = new List<Resume>();
        } 

        public List<Resume> GetAll()
        {
            return AppsList;
        }

        public Resume GetById(int id)
        {
            return AppsList.FirstOrDefault(a => a.AppId == id);
        }

        public void Add(Resume newApp)
        {
            AppsList.Add(newApp);
        }

        public List<State> GetListOfStates()
        {
            var listOfStates = new List<State>
            {
                
                new State() {StateName = "Alaska", StateAbbreviation = "AK"},
                new State() {StateName = "Alabama", StateAbbreviation = "AL"},
                new State() {StateName = "Arkansas", StateAbbreviation = "AR"},
                new State() {StateName = "Arizona", StateAbbreviation = "AZ"},
                new State() {StateName = "California", StateAbbreviation = "CA"},
                new State() {StateName = "Colorado", StateAbbreviation = "CO"},
                new State() {StateName = "Connecticut", StateAbbreviation = "CT"},
                new State() {StateName = "Washington D.C.", StateAbbreviation = "DC"},
                new State() {StateName = "Delaware", StateAbbreviation = "DE"},
                new State() {StateName = "Florida", StateAbbreviation = "FL"},
                new State() {StateName = "Georgia", StateAbbreviation = "GA"},
                new State() {StateName = "Hawaii", StateAbbreviation = "HI"},
                new State() {StateName = "Iowa", StateAbbreviation = "IA"},
                new State() {StateName = "Idaho", StateAbbreviation = "ID"},
                new State() {StateName = "Illinois", StateAbbreviation = "IL"},
                new State() {StateName = "Indiana", StateAbbreviation = "IN"},
                new State() {StateName = "Kansas", StateAbbreviation = "KS"},
                new State() {StateName = "Kentucky", StateAbbreviation = "KY"},
                new State() {StateName = "Louisiana", StateAbbreviation = "LA"},
                new State() {StateName = "Massachusetts", StateAbbreviation = "MA"},
                new State() {StateName = "Maryland", StateAbbreviation = "MD"},
                new State() {StateName = "Maine", StateAbbreviation = "ME"},
                new State() {StateName = "Michigan", StateAbbreviation = "MI"},
                new State() {StateName = "Minnesota", StateAbbreviation = "MN"},
                new State() {StateName = "Missouri", StateAbbreviation = "MO"},
                new State() {StateName = "Mississippi", StateAbbreviation = "MS"},
                new State() {StateName = "Montana", StateAbbreviation = "MT"},
                new State() {StateName = "North Carolina", StateAbbreviation = "NC"},
                new State() {StateName = "North Dakota", StateAbbreviation = "ND"},
                new State() {StateName = "Nebraska", StateAbbreviation = "NE"},
                new State() {StateName = "New Hampshire", StateAbbreviation = "NH"},
                new State() {StateName = "New Jersey", StateAbbreviation = "NJ"},
                new State() {StateName = "New Mexico", StateAbbreviation = "NM"},
                new State() {StateName = "Nevada", StateAbbreviation = "NV"},
                new State() {StateName = "New York", StateAbbreviation = "NY"},
                new State() {StateName = "Ohio", StateAbbreviation = "OH"},
                new State() {StateName = "Oklahoma", StateAbbreviation = "OK"},
                new State() {StateName = "Oregon", StateAbbreviation = "OR"},
                new State() {StateName = "Pennsylvania", StateAbbreviation = "PA"},
                new State() {StateName = "Rhode Island", StateAbbreviation = "RI"},
                new State() {StateName = "South Carolina", StateAbbreviation = "SC"},
                new State() {StateName = "South Dakota", StateAbbreviation = "SD"},
                new State() {StateName = "Tennessee", StateAbbreviation = "TN"},
                new State() {StateName = "Texas", StateAbbreviation = "TX"},
                new State() {StateName = "Utah", StateAbbreviation = "UT"},
                new State() {StateName = "Virginia", StateAbbreviation = "VA"},
                new State() {StateName = "Vermont", StateAbbreviation = "VT"},
                new State() {StateName = "Washington", StateAbbreviation = "WA"},
                new State() {StateName = "Wisconsin", StateAbbreviation = "WI"},
                new State() {StateName = "West Virginia", StateAbbreviation = "WV"},
                new State() {StateName = "Wyoming", StateAbbreviation = "WY"}
            };

            return listOfStates;
        }

        public List<Position> GetListOfPositions()
        {
            var listOfPositions = new List<Position>
            {
                new Position()
                {
                    PositionId = 1,
                    PositionName = "Manager",
                    Description = "Manager of The Guild",
                    PostedDate = DateTime.Parse("10/01/2015"),
                    ClosingDate = DateTime.Parse("12/01/2015")
                },
                new Position()
                {
                    PositionId = 2,
                    PositionName = "Instructor",
                    Description = "Instructor of The Guild",
                    PostedDate = DateTime.Parse("09/01/2015"),
                    ClosingDate = DateTime.Parse("01/01/2016")
                },
                new Position()
                {
                    PositionId = 3,
                    PositionName = "Janitor",
                    Description = "Janitor of The Guild :(",
                    PostedDate = DateTime.Parse("08/01/2015"),
                    ClosingDate = DateTime.Parse("12/01/2015")
                },
                new Position()
                {
                    PositionId = 4,
                    PositionName = "New Victor",
                    Description = "The \"New\" Victor of The Guild",
                    PostedDate = DateTime.Parse("10/01/2015"),
                    ClosingDate = DateTime.Parse("12/01/2015")
                }
            };

            return listOfPositions;
        }

        public List<PolicyCategory> GetListOfCategories()
        {
            ListofPolicyCategories = new List<PolicyCategory>
            {
                new PolicyCategory()
                {
                    Category = "Attendance",
                    CategoryNumber = 1
                },
                new PolicyCategory()
                {
                    Category = "Benefits",
                    CategoryNumber = 2
                },
                new PolicyCategory()
                {
                    Category = "Code of Conduct",
                    CategoryNumber = 3
                },
                new PolicyCategory()
                {
                    Category = "Dress Code",
                    CategoryNumber = 4
                },
                new PolicyCategory()
                {
                    Category = "Time Off",
                    CategoryNumber = 5
                },
                new PolicyCategory()
                {
                    Category = "Training",
                    CategoryNumber = 6
                }
            };
            return ListofPolicyCategories;
        }

        public List<Policy> GetListOfPolicies()
        {
            var listOfPolicies = new List<Policy>
            {
                new Policy()
                {
                    Title = "Sexual Harrassment",
                    Category = new PolicyCategory()
                    {
                        Category = "Code of Conduct"
                    },

                }
            };
            return listOfPolicies;
        } 
    }
}
