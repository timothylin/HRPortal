using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models;
using HRPortal.Models.Interfaces;

namespace HRPortal.Data.Repository
{
    public class MockRepository : IRepository
    {
        public static List<Resume> AppsList { get; set; }
        public static List<PolicyCategory> ListOfPolicyCategories { get; set; }
        public static List<Policy> ListOfPolicies { get; set; }

        public MockRepository()
        {
            AppsList = new List<Resume>();
            ListOfPolicyCategories = new List<PolicyCategory>();
            ListOfPolicies = new List<Policy>();
            InitializeMockResumeList();
            InitializePolicyCategories();
            InitializeListOfPolicies();
        } 

        public List<Resume> GetAllResumes()
        {
            return AppsList;
        }

        public Resume GetResumeById(int id)
        {
            return AppsList.FirstOrDefault(a => a.AppId == id);
        }

        public void AddResume(Resume newApp)
        {
            AppsList.Add(newApp);
        }

        public List<State> GetAllStates()
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

        public void InitializeMockResumeList()
        {
            Resume newApp = new Resume()
            {
                AppId = 1,
                ApplicantContactInfo = new ContactInfo()
                {
                    FirstName = "Dean",
                    LastName = "Choi",
                    MiddleInitial = "J",
                    Prefix = "Mr.",
                    Email = "deanchoi@gmail.com",
                    PhoneNumber = "440-263-5132",
                    Address = new Address()
                    {
                        AddressLine1 = "8993 Crooked Creek Ln",
                        City = "Broadview Heights",
                        State = "OH",
                        Zipcode = "44147"
                    }
                },
                Position = new Position()
                {
                    PositionId = 4,
                    PositionName = "New Victor",
                    Description = "The \"New\" Victor of The Guild",
                    PostedDate = DateTime.Parse("10/01/2015"),
                    ClosingDate = DateTime.Parse("12/01/2015")
                },
                Experiences = new List<Experience>()
                {
                    new Experience()
                    {
                        Company = "National Institues of Health",
                        Title = "Post-bac IRTA",
                        StartDate = DateTime.Parse("08/01/2009"),
                        EndDate = DateTime.Parse("07/01/2010"),
                        Location = new Address()
                        {
                            City = "Bethesda",
                            State = "MD"
                        },
                        Description = "Neuroscience Researcher on TIP39 at the NIMH.",
                        SupervisorName = "Ted Usdin, MD-PhD",
                        SupervisorPhone = "202-867-5309",
                        SupervisorEmail = "tedusdin@nih.gov"
                    }
                },
                Education = new List<EducationInfo>()
                {
                    new EducationInfo()
                    {
                        Degree = new Degree()
                        {
                            DegreeAbbr = "B.S.",
                            DegreeName = "Bachelor's of Science"
                        },
                        Institution = "Duke University",
                        Location = new Address()
                        {
                            City = "Durham",
                            State = "NC"
                        },
                        StartDate = DateTime.Parse("08/01/2005"),
                        GraduationDate = DateTime.Parse("05/15/2009"),
                        GPA = 3.75M,
                        Concentration = "Biology & Chemistry"
                    }
                },
                DesiredSalary = 100000,
                AppDate = DateTime.Parse("10/31/2015")
            };

            AppsList.Add(newApp);

        }

        public List<Position> GetAllPositions()
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

        public void InitializePolicyCategories()
        {
            ListOfPolicyCategories = new List<PolicyCategory>
            {
                new PolicyCategory()
                {
                    Category = "Attendance",
                },
                new PolicyCategory()
                {
                    Category = "Benefits",
                },
                new PolicyCategory()
                {
                    Category = "Code of Conduct",
                },
                new PolicyCategory()
                {
                    Category = "Dress Code",
                },
                new PolicyCategory()
                {
                    Category = "Time Off",
                },
                new PolicyCategory()
                {
                    Category = "Training",
                }
            };

        }

        //add a new policycateory (also one for deleting)

        public void InitializeListOfPolicies()
        {
            ListOfPolicies = new List<Policy>
            {
                new Policy()
                {
                    PolicyId = 1,
                    Title = "Sexual Harrassment",
                    Category = "Code of Conduct",
                    ContentText = "Don't touch people inappropriately..."
                },
                new Policy()
                {
                    PolicyId = 2,
                    Title = "Casual Friday",
                    Category = "Dress Code",
                    ContentText = "On Fridays, you can where jeans as long as you donate $1."
                },
                new Policy()
                {
                    PolicyId = 3,
                    Title = "Time that you must arrive to work",
                    Category = "Attendance",
                    ContentText = "All employees must arrive at work by 8AM unless they have a valid reason."
                },
                new Policy()
                {
                    PolicyId = 4,
                    Title = "Health Care",
                    Category = "Benefits",
                    ContentText = "Every 6 months, employees may sign up for new HealthCare plans during the \"Open Season\"."
                },
                new Policy()
                {
                    PolicyId = 5,
                    Title = "Vacation Accruing",
                    Category = "Time Off",
                    ContentText = "Employees will accrue 2 weeks of vacation every 6 months of employeement."
                },
                new Policy()
                {
                    PolicyId = 6,
                    Title = "Safety Training",
                    Category = "Training",
                    ContentText = "All new employees must complete the initial safety training course within the first week of employment." +
                                  " A refresher course must be taken for all employees every 12 months."
                },
                new Policy()
                {
                    PolicyId = 7,
                    Title = "401K",
                    Category = "Benefits",
                    ContentText = "All employees will automatically have 2.5% of their salary attributed to a 401k account."
                },
                new Policy()
                {
                    PolicyId = 8,
                    Title = "Normal Work Wear",
                    Category = "Dress Code",
                    ContentText = "All employees must dress in at least business casual clothing during normal business hours."
                },

            };
        }

        public List<Policy> GetAllPolicies()
        {
            return ListOfPolicies;
        } 

        public List<PolicyCategory> GetPolicyCategories()
        {
            return ListOfPolicyCategories;
        }

        //public void AddNewPolicyCategory(string policyCategory)
        //{
        //    ListOfPolicyCategories.Add(policyCategory);
        //}

        public List<Policy> GetPoliciesListInCategory(PolicyCategory category)
        {
            return ListOfPolicies.Select(p => p).Where(p => p.Category == category.Category).ToList();
        }

        public Policy GetPolicyById(int id)
        {
            return ListOfPolicies.Select(p => p).Where(p => p.PolicyId == id).FirstOrDefault();
        }
    }
}
