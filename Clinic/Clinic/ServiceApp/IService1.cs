using System.Collections.Generic;
using System.ServiceModel;
using BibliotecaClasses.model.basic;

namespace ServiceApp {
    [ServiceContract]
//  [XmlSerializerFormat]
    public interface IService1 {
        [OperationContract] bool insertConsulta (BConsulta bCos);
        [OperationContract] bool alterConsulta  (BConsulta bCos);
        [OperationContract] void deleteConsulta (BConsulta bCos);

        [OperationContract] List<BAdministrador> listAdministrador(BAdministrador bAdm);
        [OperationContract] List<BConsulta>      listConsulta(BConsulta bCos);
        [OperationContract] List<BPaciente>      listPaciente(BPaciente bPac);
        [OperationContract] List<BMedico>        listMedico(BMedico bMed);
        [OperationContract] List<BTipoConsulta>  listTipoConsulta(BTipoConsulta bTip);
    }
}
