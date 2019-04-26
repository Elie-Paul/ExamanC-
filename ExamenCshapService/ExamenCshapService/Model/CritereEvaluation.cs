using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCshapService.Model
{
    [DataContract]
    public class CritereEvaluation
    {
        [DataMember]
        [Key]
        public int Id { get; set; }

        [DataMember]
        public string Libelle { get; set; }

        [DataMember]
        public ICollection<Indicateur> Indicateurs { get; set; }
    }
}
