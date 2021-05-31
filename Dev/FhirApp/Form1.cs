using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace FhirApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreatePatient_Click(object sender, EventArgs e)
        {
            var pat = CreatePatient();
            var client = CreateFhirClient();

            var created_pat = client.Create(pat);
        }

        private Patient CreatePatient()
        {
            var pat = new Patient();

            var id = new Identifier();
            id.System = "http://hl7.org/fhir/sid/us-ssn";
            id.Value = "juan.tapia";
            pat.Identifier.Add(id);

            var name = new HumanName().WithGiven("Juan").WithGiven("Adrián").AndFamily("Tapia");
            name.Prefix = new string[] { "Sr." };
            name.Use = HumanName.NameUse.Official;

            var nickname = new HumanName();
            nickname.Use = HumanName.NameUse.Nickname;
            nickname.GivenElement.Add(new FhirString("Juan"));

            pat.Name.Add(name);
            pat.Name.Add(nickname);

            pat.Gender = AdministrativeGender.Male;

            pat.BirthDate = "1972-10-01";

            var birthplace = new Extension();
            birthplace.Url = "http://hl7.org/fhir/StructureDefinition/birthPlace";
            birthplace.Value = new Address() { City = "Jujuy" };
            pat.Extension.Add(birthplace);

            var birthtime = new Extension("http://hl7.org/fhir/StructureDefinition/patient-birthTime",
                                           new FhirDateTime(1972, 10, 1, 4, 0));
            pat.BirthDateElement.Extension.Add(birthtime);

            var address = new Address()
            {
                Line = new string[] { "Hipolito Yrigoyen 2569" },
                City = "Balvanera",
                State = "CABA",
                PostalCode = "1090",
                Country = "ARG"
            };
            pat.Address.Add(address);

            var contact = new Patient.ContactComponent();
            contact.Name = new HumanName();
            contact.Name.Given = new string[] { "Alicia" };
            contact.Name.Family = "Duro";
            contact.Gender = AdministrativeGender.Female;
            contact.Relationship.Add(new CodeableConcept("http://hl7.org/fhir/v2/0131", "N"));
            contact.Telecom.Add(new ContactPoint(ContactPoint.ContactPointSystem.Phone, null, ""));
            pat.Contact.Add(contact);

            pat.Deceased = new FhirBoolean(false);
            return pat;
        }

        private Hl7.Fhir.Rest.FhirClient CreateFhirClient()
        {

            var settings = new FhirClientSettings
            {
                Timeout = 0,
                PreferredFormat = ResourceFormat.Json,
                VerifyFhirVersion = true,
                PreferredReturn = Prefer.ReturnMinimal
            };

            var client = new FhirClient("http://vonk.furore.com", settings);
            
            //var client = new Hl7.Fhir.Rest.FhirClient("http://server.fire.ly", settings);
            //http://test.fhir.org/r4/
            return client;
        }

    }
}
