﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenClient.ServiceReferenceIndic {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Indicateur", Namespace="http://schemas.datacontract.org/2004/07/ExamenCshapService.Model")]
    [System.SerializableAttribute()]
    public partial class Indicateur : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExamenClient.ServiceReferenceIndic.CritereEvaluation[] EvaluationsField;
        
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
        public ExamenClient.ServiceReferenceIndic.CritereEvaluation[] Evaluations {
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
        private ExamenClient.ServiceReferenceIndic.Indicateur[] IndicateursField;
        
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
        public ExamenClient.ServiceReferenceIndic.Indicateur[] Indicateurs {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceIndic.IIndicateurService")]
    public interface IIndicateurService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndicateurService/Add", ReplyAction="http://tempuri.org/IIndicateurService/AddResponse")]
        ExamenClient.ServiceReferenceIndic.Indicateur Add(ExamenClient.ServiceReferenceIndic.Indicateur i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndicateurService/Add", ReplyAction="http://tempuri.org/IIndicateurService/AddResponse")]
        System.Threading.Tasks.Task<ExamenClient.ServiceReferenceIndic.Indicateur> AddAsync(ExamenClient.ServiceReferenceIndic.Indicateur i);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIndicateurServiceChannel : ExamenClient.ServiceReferenceIndic.IIndicateurService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IndicateurServiceClient : System.ServiceModel.ClientBase<ExamenClient.ServiceReferenceIndic.IIndicateurService>, ExamenClient.ServiceReferenceIndic.IIndicateurService {
        
        public IndicateurServiceClient() {
        }
        
        public IndicateurServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IndicateurServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IndicateurServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IndicateurServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ExamenClient.ServiceReferenceIndic.Indicateur Add(ExamenClient.ServiceReferenceIndic.Indicateur i) {
            return base.Channel.Add(i);
        }
        
        public System.Threading.Tasks.Task<ExamenClient.ServiceReferenceIndic.Indicateur> AddAsync(ExamenClient.ServiceReferenceIndic.Indicateur i) {
            return base.Channel.AddAsync(i);
        }
    }
}
