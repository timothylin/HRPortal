using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using HRPortal.Models;
using HRPortal.Models.Interfaces;

namespace HRPortal.Data.Repository
{
    public class ProdRepository : IRepository
    {

        //var rootPath = Server.MapPath("~/");
        //http://csharp.net-tutorials.com/xml/introduction/
        //http://forums.asp.net/t/1416938.aspx?How+to+create+add+multiple+nodes+in+xml+file+please+help
        //http://stackoverflow.com/questions/11492705/how-to-create-xml-document-using-xmldocument
        //http://www.dotnetcurry.com/linq/564/linq-to-xml-tutorials-examples


        public static string RootPath { get; set; }
        public static List<Resume> Resumes { get; set; } 


        public ProdRepository()
        {
            RootPath = System.Web.HttpContext.Current.Server.MapPath("~/Files/");
            Resumes = new List<Resume>();
        }


        public void AddResume(Resume newApp)
        {

            XDocument doc = new XDocument(new XElement("resume",
                                                new XElement("AppID", newApp.AppId),
                                                new XElement("ContactInfo",
                                                    new XElement("FirstName", newApp.ApplicantContactInfo.FirstName),
                                                    new XElement("LastName", newApp.ApplicantContactInfo.LastName),
                                                    new XElement("MiddleInitial", newApp.ApplicantContactInfo.MiddleInitial),
                                                    new XElement("Prefix", newApp.ApplicantContactInfo.Prefix),
                                                    new XElement("Suffix", newApp.ApplicantContactInfo.Suffix),
                                                    new XElement("Email", newApp.ApplicantContactInfo.Email),
                                                    new XElement("PhoneNumber", newApp.ApplicantContactInfo.PhoneNumber)),
                                                new XElement("Address",
                                                    new XElement("AddressLine1", newApp.ApplicantContactInfo.Address.AddressLine1),
                                                    new XElement("AddressLine2", newApp.ApplicantContactInfo.Address.AddressLine2),
                                                    new XElement("City", newApp.ApplicantContactInfo.Address.City),
                                                    new XElement("State", newApp.ApplicantContactInfo.Address.State),
                                                    new XElement("Zipcode", newApp.ApplicantContactInfo.Address.Zipcode)),
                                                new XElement("Position",
                                                     new XElement("PositionID", newApp.Position.PositionId),
                                                     new XElement("PositionName", newApp.Position.PositionName),
                                                     new XElement("Description", newApp.Position.Description),
                                                     new XElement("PostedDate", newApp.Position.PostedDate),
                                                     new XElement("ClosingDate", newApp.Position.ClosingDate)),
                                                new XElement("Experience",
                                                     newApp.Experiences.Select(e => new XElement("Company", e.Company)),
                                                     newApp.Experiences.Select(e => new XElement("Title", e.Title)),
                                                     newApp.Experiences.Select(e => new XElement("StartDate", e.StartDate)),
                                                     newApp.Experiences.Select(e => new XElement("EndDate", e.EndDate)),
                                                new XElement("Location",
                                                     newApp.Experiences.Select(e => new XElement("AddressLine1", e.Location.AddressLine1)),
                                                     newApp.Experiences.Select(e => new XElement("AddressLine2", e.Location.AddressLine2)),
                                                     newApp.Experiences.Select(e => new XElement("City", e.Location.City)),
                                                     newApp.Experiences.Select(e => new XElement("State", e.Location.State)),
                                                     newApp.Experiences.Select(e => new XElement("Zipcode", e.Location.Zipcode))),
                                                    newApp.Experiences.Select(e => new XElement("Description", e.Description)),
                                                    newApp.Experiences.Select(e => new XElement("SupervisorName", e.SupervisorName)),
                                                    newApp.Experiences.Select(e => new XElement("SupervisorPhone", e.SupervisorPhone)),
                                                    newApp.Experiences.Select(e => new XElement("SupervisorEmail", e.SupervisorEmail))),
                                               new XElement("Education",
                                                     newApp.Education.Select(e => new XElement("Degree", e.Degree.DegreeAbbr)),
                                                     newApp.Education.Select(e => new XElement("Institution", e.Institution)),
                                                new XElement("Location",
                                                     newApp.Education.Select(e => new XElement("AddressLine1", e.Location.AddressLine1)),
                                                     newApp.Education.Select(e => new XElement("AddressLine2", e.Location.AddressLine2)),
                                                     newApp.Education.Select(e => new XElement("City", e.Location.City)),
                                                     newApp.Education.Select(e => new XElement("State", e.Location.State)),
                                                     newApp.Education.Select(e => new XElement("Zipcode", e.Location.Zipcode))),
                                                     newApp.Education.Select(e => new XElement("StartDate", e.StartDate)),
                                                     newApp.Education.Select(e => new XElement("GraduationDate", e.GraduationDate)),
                                                     newApp.Education.Select(e => new XElement("GPA", e.GPA)),
                                                     newApp.Education.Select(e => new XElement("Concentration", e.Concentration))),
                                               new XElement("DesiredSalary", newApp.DesiredSalary),
                                               new XElement("AppDate", newApp.AppDate)
                                                ));

            doc.Save(RootPath + "Resumes.xml");

        }

        public List<Resume> GetAllResumes()
        {
            XDocument xDoc = XDocument.Load(RootPath + "Resumes.xml");
            var applications = xDoc.Descendants("resumes");

            foreach (var app in applications.Descendants("resume"))
            {
                Resume resume = new Resume();

                resume.AppId = int.Parse(app.Element("AppID").Value);

                foreach (var info in xDoc.Descendants("ContactInfo"))
                {
                    resume.ApplicantContactInfo.FirstName = info.Element("FirstName").Value;
                    resume.ApplicantContactInfo.LastName = info.Element("LastName").Value;
                    resume.ApplicantContactInfo.MiddleInitial = info.Element("MiddleInitial").Value;
                    resume.ApplicantContactInfo.Prefix = info.Element("Prefix").Value;
                    resume.ApplicantContactInfo.Suffix = info.Element("Suffix").Value;
                    resume.ApplicantContactInfo.Email = info.Element("Email").Value;
                    resume.ApplicantContactInfo.PhoneNumber = info.Element("PhoneNumber").Value;
                }

                foreach (var address in xDoc.Descendants("Address"))
                {
                    resume.ApplicantContactInfo.Address.AddressLine1 = address.Element("AddressLine1").Value;
                    resume.ApplicantContactInfo.Address.AddressLine2 = address.Element("AddressLine2").Value;
                    resume.ApplicantContactInfo.Address.City = address.Element("City").Value;
                    resume.ApplicantContactInfo.Address.State = address.Element("State").Value;
                    resume.ApplicantContactInfo.Address.Zipcode = address.Element("Zipcode").Value;
                }

                foreach (var pos in xDoc.Descendants("Position"))
                {
                    resume.Position.PositionId = int.Parse(pos.Element("PositionID").Value);
                    resume.Position.PositionName = pos.Element("PositionName").Value;
                    resume.Position.Description = pos.Element("Description").Value;
                    resume.Position.PostedDate = DateTime.Parse(pos.Element("PostedDate").Value);
                    resume.Position.ClosingDate = DateTime.Parse(pos.Element("ClosingDate").Value);
                }


                foreach (var exp in xDoc.Descendants("Experience"))
                {
                    Experience experience = new Experience();
                    List<Experience> experiences = new List<Experience>();

                    experience.Company = exp.Element("Company").Value;
                    experience.Title = exp.Element("Title").Value;
                    experience.StartDate = DateTime.Parse(exp.Element("StartDate").Value);
                    experience.EndDate = DateTime.Parse(exp.Element("EndDate").Value);

                    foreach (var address in xDoc.Descendants("Location"))
                    {
                        experience.Location.City = address.Element("City").Value;
                        experience.Location.State = address.Element("State").Value;
                    }
                    experience.Description = exp.Element("Description").Value;
                    experience.SupervisorName = exp.Element("SupervisorName").Value;
                    experience.SupervisorPhone = exp.Element("SupervisorPhone").Value;
                    experience.SupervisorEmail = exp.Element("SupervisorEmail").Value;

                    experiences.Add(experience);

                    resume.Experiences = experiences;
                }

                foreach (var edu in xDoc.Descendants("Education"))
                {

                    EducationInfo education = new EducationInfo();
                    List<EducationInfo> educations = new List<EducationInfo>();

                    education.Degree.DegreeAbbr = edu.Element("Degree").Value;
                    education.Institution = edu.Element("Institution").Value;

                    foreach (var address in xDoc.Elements("Location"))
                    {
                        education.Location.City = address.Element("City").Value;
                        education.Location.State = address.Element("State").Value;
                    }

                    education.StartDate = DateTime.Parse(edu.Element("StartDate").Value);
                    education.GraduationDate = DateTime.Parse(edu.Element("GraduationDate").Value);
                    education.GPA = int.Parse(edu.Element("GPA").Value);
                    education.Concentration = edu.Element("Concentration").Value;

                    educations.Add(education);

                    resume.Education = educations;

                }

                resume.DesiredSalary = int.Parse(app.Element("DesiredSalary").Value);
                resume.AppDate = DateTime.Parse(app.Element("AppDate").Value);

                Resumes.Add(resume);
            }

            return Resumes;
        }

        public Resume GetResumeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Position> GetAllPositions()
        {
            throw new NotImplementedException();
        }

        public List<State> GetAllStates()
        {
            throw new NotImplementedException();
        }

        public List<PolicyCategory> GetPolicyCategories()
        {
            throw new NotImplementedException();
        }

        public List<Policy> GetAllPolicies()
        {
            throw new NotImplementedException();
        }

        public List<Policy> GetPoliciesListInCategory(PolicyCategory category)
        {
            throw new NotImplementedException();
        }

        public Policy GetPolicyById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemovePolicyById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddNewPolicyInExistingCategory(Policy newPolicy)
        {
            throw new NotImplementedException();
        }

        public void AddNewPolicyInNewCategory(Policy newPolicy)
        {
            throw new NotImplementedException();
        }
    }
}
