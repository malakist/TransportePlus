using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Entities
{    
    [DataContract(Namespace="http://transporteplus.com.br/DataContracts/2011/06/")]
    public class Registro
    {
        [DataMember]
        public string Chave { get; set; }

        [DataMember]
        public string Valor { get; set; }
    }
}
