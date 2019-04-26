using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ExamenCshapService.Model;

namespace ExamenCshapService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "IndicateurService" à la fois dans le code et le fichier de configuration.
    public class IndicateurService : IIndicateurService
    {
        BDContext bdc = new BDContext();
        public Indicateur Add(Indicateur i)
        {
            bdc.Indicateurs.Add(i);
            bdc.SaveChanges();
            return i;
        }
    }
}
