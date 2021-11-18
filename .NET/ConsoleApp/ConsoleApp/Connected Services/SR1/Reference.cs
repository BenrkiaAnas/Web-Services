﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp.SR1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws/", ConfigurationName="SR1.BanqueService")]
    public interface BanqueService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/listeComptesRequest", ReplyAction="http://ws/BanqueService/listeComptesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ConsoleApp.SR1.listeComptesResponse listeComptes(ConsoleApp.SR1.listeComptesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/listeComptesRequest", ReplyAction="http://ws/BanqueService/listeComptesResponse")]
        System.Threading.Tasks.Task<ConsoleApp.SR1.listeComptesResponse> listeComptesAsync(ConsoleApp.SR1.listeComptesRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/ConversionEuroToDHRequest", ReplyAction="http://ws/BanqueService/ConversionEuroToDHResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ConsoleApp.SR1.ConversionEuroToDHResponse ConversionEuroToDH(ConsoleApp.SR1.ConversionEuroToDHRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/ConversionEuroToDHRequest", ReplyAction="http://ws/BanqueService/ConversionEuroToDHResponse")]
        System.Threading.Tasks.Task<ConsoleApp.SR1.ConversionEuroToDHResponse> ConversionEuroToDHAsync(ConsoleApp.SR1.ConversionEuroToDHRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/getCompteRequest", ReplyAction="http://ws/BanqueService/getCompteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ConsoleApp.SR1.getCompteResponse getCompte(ConsoleApp.SR1.getCompteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/getCompteRequest", ReplyAction="http://ws/BanqueService/getCompteResponse")]
        System.Threading.Tasks.Task<ConsoleApp.SR1.getCompteResponse> getCompteAsync(ConsoleApp.SR1.getCompteRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws/")]
    public partial class compte : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long codeField;
        
        private bool codeFieldSpecified;
        
        private double soldeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codeSpecified {
            get {
                return this.codeFieldSpecified;
            }
            set {
                this.codeFieldSpecified = value;
                this.RaisePropertyChanged("codeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double solde {
            get {
                return this.soldeField;
            }
            set {
                this.soldeField = value;
                this.RaisePropertyChanged("solde");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listeComptes", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listeComptesRequest {
        
        public listeComptesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listeComptesResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listeComptesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ConsoleApp.SR1.compte[] @return;
        
        public listeComptesResponse() {
        }
        
        public listeComptesResponse(ConsoleApp.SR1.compte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEuroToDH", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ConversionEuroToDHRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double montant;
        
        public ConversionEuroToDHRequest() {
        }
        
        public ConversionEuroToDHRequest(double montant) {
            this.montant = montant;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEuroToDHResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ConversionEuroToDHResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double @return;
        
        public ConversionEuroToDHResponse() {
        }
        
        public ConversionEuroToDHResponse(double @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompte", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class getCompteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long code;
        
        public getCompteRequest() {
        }
        
        public getCompteRequest(long code) {
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompteResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class getCompteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ConsoleApp.SR1.compte @return;
        
        public getCompteResponse() {
        }
        
        public getCompteResponse(ConsoleApp.SR1.compte @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BanqueServiceChannel : ConsoleApp.SR1.BanqueService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BanqueServiceClient : System.ServiceModel.ClientBase<ConsoleApp.SR1.BanqueService>, ConsoleApp.SR1.BanqueService {
        
        public BanqueServiceClient() {
        }
        
        public BanqueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BanqueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanqueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp.SR1.listeComptesResponse ConsoleApp.SR1.BanqueService.listeComptes(ConsoleApp.SR1.listeComptesRequest request) {
            return base.Channel.listeComptes(request);
        }
        
        public ConsoleApp.SR1.compte[] listeComptes() {
            ConsoleApp.SR1.listeComptesRequest inValue = new ConsoleApp.SR1.listeComptesRequest();
            ConsoleApp.SR1.listeComptesResponse retVal = ((ConsoleApp.SR1.BanqueService)(this)).listeComptes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp.SR1.listeComptesResponse> ConsoleApp.SR1.BanqueService.listeComptesAsync(ConsoleApp.SR1.listeComptesRequest request) {
            return base.Channel.listeComptesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp.SR1.listeComptesResponse> listeComptesAsync() {
            ConsoleApp.SR1.listeComptesRequest inValue = new ConsoleApp.SR1.listeComptesRequest();
            return ((ConsoleApp.SR1.BanqueService)(this)).listeComptesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp.SR1.ConversionEuroToDHResponse ConsoleApp.SR1.BanqueService.ConversionEuroToDH(ConsoleApp.SR1.ConversionEuroToDHRequest request) {
            return base.Channel.ConversionEuroToDH(request);
        }
        
        public double ConversionEuroToDH(double montant) {
            ConsoleApp.SR1.ConversionEuroToDHRequest inValue = new ConsoleApp.SR1.ConversionEuroToDHRequest();
            inValue.montant = montant;
            ConsoleApp.SR1.ConversionEuroToDHResponse retVal = ((ConsoleApp.SR1.BanqueService)(this)).ConversionEuroToDH(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp.SR1.ConversionEuroToDHResponse> ConsoleApp.SR1.BanqueService.ConversionEuroToDHAsync(ConsoleApp.SR1.ConversionEuroToDHRequest request) {
            return base.Channel.ConversionEuroToDHAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp.SR1.ConversionEuroToDHResponse> ConversionEuroToDHAsync(double montant) {
            ConsoleApp.SR1.ConversionEuroToDHRequest inValue = new ConsoleApp.SR1.ConversionEuroToDHRequest();
            inValue.montant = montant;
            return ((ConsoleApp.SR1.BanqueService)(this)).ConversionEuroToDHAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp.SR1.getCompteResponse ConsoleApp.SR1.BanqueService.getCompte(ConsoleApp.SR1.getCompteRequest request) {
            return base.Channel.getCompte(request);
        }
        
        public ConsoleApp.SR1.compte getCompte(long code) {
            ConsoleApp.SR1.getCompteRequest inValue = new ConsoleApp.SR1.getCompteRequest();
            inValue.code = code;
            ConsoleApp.SR1.getCompteResponse retVal = ((ConsoleApp.SR1.BanqueService)(this)).getCompte(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp.SR1.getCompteResponse> ConsoleApp.SR1.BanqueService.getCompteAsync(ConsoleApp.SR1.getCompteRequest request) {
            return base.Channel.getCompteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp.SR1.getCompteResponse> getCompteAsync(long code) {
            ConsoleApp.SR1.getCompteRequest inValue = new ConsoleApp.SR1.getCompteRequest();
            inValue.code = code;
            return ((ConsoleApp.SR1.BanqueService)(this)).getCompteAsync(inValue);
        }
    }
}
