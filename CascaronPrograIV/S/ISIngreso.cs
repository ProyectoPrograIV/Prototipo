using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace S
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISIngreso" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISIngreso 
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        bool VerificarUsuario(TBL_USUARIO usuario);


    }
}
