using ExamenCshapService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExamenCshapService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IEvaluationService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IEvaluationService
    {
        [OperationContract]
        CritereEvaluation Add(CritereEvaluation c);

        [OperationContract]
        CritereEvaluation Find(string l);

        [OperationContract]
        int Modify(string l,int l1);

        [OperationContract]
        int Delete(int i);

        [OperationContract]
        List<CritereEvaluation> ListCritere();
    }
}
