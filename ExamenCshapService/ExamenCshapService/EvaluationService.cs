using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ExamenCshapService.Model;

namespace ExamenCshapService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "EvaluationService" à la fois dans le code et le fichier de configuration.
    public class EvaluationService : IEvaluationService
    {
        BDContext bdc = new BDContext();
        public CritereEvaluation Add(CritereEvaluation c)
        {
            bdc.Evaluations.Add(c);
            bdc.SaveChanges();
            return c;
        }

        public int Delete(int i)
        {
            bdc.Evaluations.Remove(bdc.Evaluations.Find(i));
            bdc.SaveChanges();
            return i;
        }

        public CritereEvaluation Find(string l)
        {
            return bdc.Evaluations.Where(e => e.Libelle.Equals(l)).FirstOrDefault();
        }

        public List<CritereEvaluation> ListCritere()
        {
            return bdc.Evaluations.ToList<CritereEvaluation>();
        }

        public int Modify(string l,int l1)
        {
            //CritereEvaluation c = Find(l);
            //c.Libelle = l1;
            //bdc.SaveChanges();
            int i = bdc.Database.ExecuteSqlCommand("Update CritereEvaluations set Libelle ='"+l+"' where id ='"+l1+"'");
            return i;
        }
    }
}
