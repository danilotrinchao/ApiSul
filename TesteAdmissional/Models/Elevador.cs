using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAdmissional.Models
{
    public class Elevador
    {
        //[JsonProperty("code")]
        public string RequestId { get; set; }

      
        public int andar { get; set; }
        public char elevador { get; set; }
      
        public char turno { get; set; }
        
        
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        //public static implicit operator List<object>(Elevador v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
