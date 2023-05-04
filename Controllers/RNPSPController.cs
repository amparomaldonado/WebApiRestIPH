using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiRestIPH.Controllers
{
    public class RNPSPController : ApiController
    {

        public List<IPH> Get()


        {
            List<IPH> personas = new List<IPH>();
            IPH per = new IPH();
            per.idFuente = 3;
            per.nombre = "JUAN";
            per.paterno = "PEREZ";
            per.materno = "MATINEZ";
            per.curp = "MAVA750909MMSZLM01";
            per.fechanac = "09091975";

            personas.Add(per);

            IPH per1 = new IPH();
            per1.idFuente = 3;
            per1.nombre = "JOSE";
            per1.paterno = "MEDINA";
            per1.materno = "MATINEZ";
            per1.curp = "JAVA720109MMSZLM02";
            per1.fechanac = "09011972";
            personas.Add(per1);

            IPH per2 = new IPH();
            per2.idFuente = 3;
            per2.nombre = "ALBERTO";
            per2.paterno = "MEJIA";
            per2.materno = "MORALES";
            per2.curp = "MOMA7120109MMSZLM02";
            per2.fechanac = "10201971";
            personas.Add(per2);

            IPH per3 = new IPH();
            per3.idFuente = 3;
            per3.nombre = "LUIS";
            per3.paterno = "SANCHEZ";
            per3.materno = "MORALES";
            per3.curp = "SALU8501019MMSZLM02";
            per3.fechanac = "01011985";
            personas.Add(per3);
            //string json = JsonConvert.SerializeObject(personas);
            return personas;


        }


        public class IPH
        {
            public int idFuente;
            public string nombre;
            public string paterno;
            public string materno;
            public string curp;
            public string fechanac;
        }
    }
}
