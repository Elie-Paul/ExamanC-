﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenClient.ServiceReferenceEval {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CritereEvaluation", Namespace="http://schemas.datacontract.org/2004/07/ExamenCshapService.Model")]
    [System.SerializableAttribute()]
    public partial class CritereEvaluation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExamenClient.ServiceReferenceEval.Indicateur[] IndicateursField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LibelleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExamenClient.ServiceReferenceEval.Indicateur[] Indicateurs {
            get {
                return this.IndicateursField;
            }
            set {
                if ((object.ReferenceEquals(this.IndicateursField, value) != true)) {
                    this.IndicateursField = value;
                    this.RaisePropertyChanged("Indicateurs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Libelle {
            get {
                return this.LibelleField;
            }
            set {
                if ((object.ReferenceEquals(this.LibelleField, value) != true)) {
                    this.LibelleField = value;
                    this.RaisePropertyChanged("Libelle");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Indicateur", Namespace="http://schemas.datacontract.org/2004/07/ExamenCshapService.Model")]
    [System.SerializableAttribute()]
    public partial class Indicateur : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExamenClient.ServiceReferenceEval.CritereEvaluation[] EvaluationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LibelleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExamenClient.ServiceReferenceEval.CritereEvaluation[] Evaluations {
            get {
                return this.EvaluationsField;
            }
            set {
                if ((object.ReferenceEquals(this.EvaluationsField, value) != true)) {
                    this.EvaluationsField = value;
                    this.RaisePropertyChanged("Evaluations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Libelle {
            get {
                return this.LibelleField;
            }
            set {
                if ((object.ReferenceEquals(this.LibelleField, value) != true)) {
                    this.LibelleField = value;
                    this.RaisePropertyChanged("Libelle");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceEval.IEvaluationService")]
    public interface IEvaluationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationService/Add", ReplyAction="http://tempuri.org/IEvaluationService/AddResponse")]
        ExamenClient.ServiceReferenceEval.CritereEvaluation Add(ExamenClient.ServiceReferenceEval.CritereEvaluation c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationService/Add", ReplyAction="http://tempuri.org/IEvaluationService/AddResponse")]
        System.Threading.Tasks.Task<ExamenClient.ServiceReferenceEval.CritereEvaluation> AddAsync(ExamenClient.ServiceReferenceEval.CritereEvaluation c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationService/Find", ReplyAction="http://tempuri.org/IEvaluationService/FindResponse")]
        ExamenClient.ServiceReferenceEval.CritereEvaluation Find(string l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationService/Find", ReplyAction="http://tempuri.org/IEvaluationService/FindResponse")]
        System.Threading.Tasks.Task<ExamenClient.ServiceReferenceEval.CritereEvaluation> FindAsync(string l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationService/Modify", ReplyAction="http://tempuri.org/IEvaluationService/ModifyResponse")]
        int Modify(string l, int l1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationService/Modify", ReplyAction="http://tempuri.org/IEvaluationService/ModifyResponse")]
        System.Threading.Tasks.Task<int> ModifyAsync(string l, int l1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationService/Delete", ReplyAction="http://tempuri.org/IEvaluationService/DeleteResponse")]
        int Delete(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationService/Delete", ReplyAction="http://tempuri.org/IEvaluationService/DeleteResponse")]
        System.Threading.Tasks.Task<int> DeleteAsync(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationService/ListCritere", ReplyAction="http://tempuri.org/IEvaluationService/ListCritereResponse")]
        ExamenClient.ServiceReferenceEval.CritereEvaluation[] ListCritere();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationService/ListCritere", ReplyAction="http://tempuri.org/IEvaluationService/ListCritereResponse")]
        System.Threading.Tasks.Task<ExamenClient.ServiceReferenceEval.CritereEvaluation[]> ListCritereAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEvaluationServiceChannel : ExamenClient.ServiceReferenceEval.IEvaluationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EvaluationServiceClient : System.ServiceModel.ClientBase<ExamenClient.ServiceReferenceEval.IEvaluationService>, ExamenClient.ServiceReferenceEval.IEvaluationService {
        
        public EvaluationServiceClient() {
        }
        
        public EvaluationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EvaluationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvaluationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvaluationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ExamenClient.ServiceReferenceEval.CritereEvaluation Add(ExamenClient.ServiceReferenceEval.CritereEvaluation c) {
            return base.Channel.Add(c);
        }
        
        public System.Threading.Tasks.Task<ExamenClient.ServiceReferenceEval.CritereEvaluation> AddAsync(ExamenClient.ServiceReferenceEval.CritereEvaluation c) {
            return base.Channel.AddAsync(c);
        }
        
        public ExamenClient.ServiceReferenceEval.CritereEvaluation Find(string l) {
            return base.Channel.Find(l);
        }
        
        public System.Threading.Tasks.Task<ExamenClient.ServiceReferenceEval.CritereEvaluation> FindAsync(string l) {
            return base.Channel.FindAsync(l);
        }
        
        public int Modify(string l, int l1) {
            return base.Channel.Modify(l, l1);
        }
        
        public System.Threading.Tasks.Task<int> ModifyAsync(string l, int l1) {
            return base.Channel.ModifyAsync(l, l1);
        }
        
        public int Delete(int i) {
            return base.Channel.Delete(i);
        }
        
        public System.Threading.Tasks.Task<int> DeleteAsync(int i) {
            return base.Channel.DeleteAsync(i);
        }
        
        public ExamenClient.ServiceReferenceEval.CritereEvaluation[] ListCritere() {
            return base.Channel.ListCritere();
        }
        
        public System.Threading.Tasks.Task<ExamenClient.ServiceReferenceEval.CritereEvaluation[]> ListCritereAsync() {
            return base.Channel.ListCritereAsync();
        }
    }
}