using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using BibliotecaClasses.model.basic;
using BibliotecaClasses.model.interfaces;
using BibliotecaClasses.controller.business;

namespace WebApplication {
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService : System.Web.Services.WebService, IConsulta {
        NConsulta nCos = new NConsulta();

        [WebMethod] public bool insertConsulta(BConsulta bCos) {
            return nCos.insertConsulta(bCos);
        }
        [WebMethod] public bool alterConsulta(BConsulta bCos) {
            throw new NotImplementedException();
        }
        [WebMethod] public void deleteConsulta(BConsulta bCos) {
            throw new NotImplementedException();
        }
        [WebMethod] public List<BConsulta> listConsulta(BConsulta bCos) {
            throw new NotImplementedException();
        }
    }
}
