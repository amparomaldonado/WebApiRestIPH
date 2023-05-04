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

        public string Get()


        {
            List<IPH> personas = new List<IPH>();
            IPH per = new IPH();
            per.idFuente = 3;
            per.nombre = "JUAN";
            per.paterno = "PEREZ";
            per.materno = "MATINEZ";
            per.curp = "MAVA750909MMSZLM01";
            per.fechanac = "09/09/1975";

            personas.Add(per);

            per.idFuente = 3;
            per.nombre = "JOSE";
            per.paterno = "MEDINA";
            per.materno = "MATINEZ";
            per.curp = "JAVA720109MMSZLM02";
            per.fechanac = "09/09/1975";
            personas.Add(per);

            per.idFuente = 3;
            per.nombre = "ALBERTO";
            per.paterno = "MEJIA";
            per.materno = "MORALES";
            per.curp = "MOMA7220109MMSZLM02";
            per.fechanac = "09/09/1975";
            personas.Add(per);


            per.idFuente = 3;
            per.nombre = "LUIS";
            per.paterno = "SANCHEZ";
            per.materno = "MORALES";
            per.curp = "SALU7220109MMSZLM02";
            per.fechanac = "09/09/1975";
            personas.Add(per);
            string json = JsonConvert.SerializeObject(personas);
            return json;


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
