using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DLWMS
{
    /// <summary>
    /// Summary description for MojServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MojServis : System.Web.Services.WebService
    {
        public List<Student> studenti = new List<Student>();
        public List<GodinaStudija> godine = new List<GodinaStudija>();

        public MojServis()
        {
            godine.Add(new GodinaStudija() { Id = 1, Oznaka = "Prva" });
            godine.Add(new GodinaStudija() { Id = 2, Oznaka = "Druga" });
            godine.Add(new GodinaStudija() { Id = 3, Oznaka = "Treća" });

            studenti.Add(new Student() { Id = 1, Ime = "Eldar", Prezime = "Jahijagić", GodinaStudija = godine[2] });
            studenti.Add(new Student() { Id = 2, Ime = "Asmir", Prezime = "Hasić", GodinaStudija = godine[0] });
            studenti.Add(new Student() { Id = 3, Ime = "Bakir", Prezime = "Karić", GodinaStudija = godine[0] });
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<GodinaStudija> GetGodineStudija()
        {
            return godine;
        }
        [WebMethod]
        public List<Student> GetStudente()
        {
            return studenti;
        }
        [WebMethod]
        public List<Student> GetStudenteByGodinaStudija(int IdGodinaStudija)
        {
            return studenti.Where(s=>s.GodinaStudija.Id == IdGodinaStudija).ToList();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public GodinaStudija GodinaStudija { get; set; }
    }

    public class GodinaStudija
    {
        public int Id { get; set; }
        public string Oznaka { get; set; }
    }
}
