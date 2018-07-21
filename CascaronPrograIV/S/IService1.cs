using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;

namespace S
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void InsertarRol(TBL_ROLUSUARIO obj);
        [OperationContract]
        void InsertarPersona(TBL_PERSONA obj);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   // [DataContract]

}
