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


        public string RootPath { get; set; }

        public ProdRepository()
        {
            RootPath = System.Web.HttpContext.Current.Server.MapPath("~/Files/");
        }


        public void AddResume(Resume newApp)
        {

            XDocument doc = new XDocument(new XElement("resume",
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
                                                     new XElement("PostedDate", newApp.Position.PostedDate)),
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
                                                     newApp.Education.Select(e => new XElement("Degree", e.Degree)),
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
            throw new NotImplementedException();
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

        public static XmlElement CreateXMLElement(XmlDocument xmlDoc, string name, string value)
        {
            XmlElement xmlElement = xmlDoc.CreateElement(name);
            XmlText xmlText = xmlDoc.CreateTextNode(value);
            xmlElement.AppendChild(xmlText);
            return xmlElement;
        }
    }
}
