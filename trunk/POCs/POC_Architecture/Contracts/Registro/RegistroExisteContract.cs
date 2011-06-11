using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts.Registro
{
    [DataContract(Namespace="http://www.transportesplus.com.br/DataContracts/2011/06/")]
    public class RegistroExisteContract
    {
        [DataMember]
        public bool RegistroExiste { get; set; }
    }
}
