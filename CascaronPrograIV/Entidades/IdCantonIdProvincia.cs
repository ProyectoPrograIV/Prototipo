using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    
    [Serializable]

    public class IdCantonIdProvincia
    {
        
        //Objeto para poder almacenar los ids de Canton y provincia y poder actualizarlos.
        private int idCanton;
        private int idProvincia;

        public int PropIdCanton
        {
            get
            {
                return idCanton;
            }

            set
            {
                idCanton = value;
            }
        }

        public int PropIdProvincia
        {
            get
            {
                return idProvincia;
            }

            set
            {
                idProvincia = value;
            }
        }
    }
}
