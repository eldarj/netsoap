﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLWMSClient.DLWSMServis {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GodinaStudija", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class GodinaStudija : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OznakaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Oznaka {
            get {
                return this.OznakaField;
            }
            set {
                if ((object.ReferenceEquals(this.OznakaField, value) != true)) {
                    this.OznakaField = value;
                    this.RaisePropertyChanged("Oznaka");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrezimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DLWMSClient.DLWSMServis.GodinaStudija GodinaStudijaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Ime {
            get {
                return this.ImeField;
            }
            set {
                if ((object.ReferenceEquals(this.ImeField, value) != true)) {
                    this.ImeField = value;
                    this.RaisePropertyChanged("Ime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Prezime {
            get {
                return this.PrezimeField;
            }
            set {
                if ((object.ReferenceEquals(this.PrezimeField, value) != true)) {
                    this.PrezimeField = value;
                    this.RaisePropertyChanged("Prezime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public DLWMSClient.DLWSMServis.GodinaStudija GodinaStudija {
            get {
                return this.GodinaStudijaField;
            }
            set {
                if ((object.ReferenceEquals(this.GodinaStudijaField, value) != true)) {
                    this.GodinaStudijaField = value;
                    this.RaisePropertyChanged("GodinaStudija");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DLWSMServis.MojServisSoap")]
    public interface MojServisSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        DLWMSClient.DLWSMServis.HelloWorldResponse HelloWorld(DLWMSClient.DLWSMServis.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.HelloWorldResponse> HelloWorldAsync(DLWMSClient.DLWSMServis.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name GetGodineStudijaResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGodineStudija", ReplyAction="*")]
        DLWMSClient.DLWSMServis.GetGodineStudijaResponse GetGodineStudija(DLWMSClient.DLWSMServis.GetGodineStudijaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGodineStudija", ReplyAction="*")]
        System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.GetGodineStudijaResponse> GetGodineStudijaAsync(DLWMSClient.DLWSMServis.GetGodineStudijaRequest request);
        
        // CODEGEN: Generating message contract since element name GetStudenteResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStudente", ReplyAction="*")]
        DLWMSClient.DLWSMServis.GetStudenteResponse GetStudente(DLWMSClient.DLWSMServis.GetStudenteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStudente", ReplyAction="*")]
        System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.GetStudenteResponse> GetStudenteAsync(DLWMSClient.DLWSMServis.GetStudenteRequest request);
        
        // CODEGEN: Generating message contract since element name GetStudenteByGodinaStudijaResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStudenteByGodinaStudija", ReplyAction="*")]
        DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaResponse GetStudenteByGodinaStudija(DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStudenteByGodinaStudija", ReplyAction="*")]
        System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaResponse> GetStudenteByGodinaStudijaAsync(DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public DLWMSClient.DLWSMServis.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(DLWMSClient.DLWSMServis.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public DLWMSClient.DLWSMServis.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(DLWMSClient.DLWSMServis.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGodineStudijaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGodineStudija", Namespace="http://tempuri.org/", Order=0)]
        public DLWMSClient.DLWSMServis.GetGodineStudijaRequestBody Body;
        
        public GetGodineStudijaRequest() {
        }
        
        public GetGodineStudijaRequest(DLWMSClient.DLWSMServis.GetGodineStudijaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetGodineStudijaRequestBody {
        
        public GetGodineStudijaRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGodineStudijaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGodineStudijaResponse", Namespace="http://tempuri.org/", Order=0)]
        public DLWMSClient.DLWSMServis.GetGodineStudijaResponseBody Body;
        
        public GetGodineStudijaResponse() {
        }
        
        public GetGodineStudijaResponse(DLWMSClient.DLWSMServis.GetGodineStudijaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGodineStudijaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DLWMSClient.DLWSMServis.GodinaStudija[] GetGodineStudijaResult;
        
        public GetGodineStudijaResponseBody() {
        }
        
        public GetGodineStudijaResponseBody(DLWMSClient.DLWSMServis.GodinaStudija[] GetGodineStudijaResult) {
            this.GetGodineStudijaResult = GetGodineStudijaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudenteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudente", Namespace="http://tempuri.org/", Order=0)]
        public DLWMSClient.DLWSMServis.GetStudenteRequestBody Body;
        
        public GetStudenteRequest() {
        }
        
        public GetStudenteRequest(DLWMSClient.DLWSMServis.GetStudenteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetStudenteRequestBody {
        
        public GetStudenteRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudenteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudenteResponse", Namespace="http://tempuri.org/", Order=0)]
        public DLWMSClient.DLWSMServis.GetStudenteResponseBody Body;
        
        public GetStudenteResponse() {
        }
        
        public GetStudenteResponse(DLWMSClient.DLWSMServis.GetStudenteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStudenteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DLWMSClient.DLWSMServis.Student[] GetStudenteResult;
        
        public GetStudenteResponseBody() {
        }
        
        public GetStudenteResponseBody(DLWMSClient.DLWSMServis.Student[] GetStudenteResult) {
            this.GetStudenteResult = GetStudenteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudenteByGodinaStudijaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudenteByGodinaStudija", Namespace="http://tempuri.org/", Order=0)]
        public DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequestBody Body;
        
        public GetStudenteByGodinaStudijaRequest() {
        }
        
        public GetStudenteByGodinaStudijaRequest(DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStudenteByGodinaStudijaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int IdGodinaStudija;
        
        public GetStudenteByGodinaStudijaRequestBody() {
        }
        
        public GetStudenteByGodinaStudijaRequestBody(int IdGodinaStudija) {
            this.IdGodinaStudija = IdGodinaStudija;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudenteByGodinaStudijaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudenteByGodinaStudijaResponse", Namespace="http://tempuri.org/", Order=0)]
        public DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaResponseBody Body;
        
        public GetStudenteByGodinaStudijaResponse() {
        }
        
        public GetStudenteByGodinaStudijaResponse(DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStudenteByGodinaStudijaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DLWMSClient.DLWSMServis.Student[] GetStudenteByGodinaStudijaResult;
        
        public GetStudenteByGodinaStudijaResponseBody() {
        }
        
        public GetStudenteByGodinaStudijaResponseBody(DLWMSClient.DLWSMServis.Student[] GetStudenteByGodinaStudijaResult) {
            this.GetStudenteByGodinaStudijaResult = GetStudenteByGodinaStudijaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MojServisSoapChannel : DLWMSClient.DLWSMServis.MojServisSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MojServisSoapClient : System.ServiceModel.ClientBase<DLWMSClient.DLWSMServis.MojServisSoap>, DLWMSClient.DLWSMServis.MojServisSoap {
        
        public MojServisSoapClient() {
        }
        
        public MojServisSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MojServisSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MojServisSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MojServisSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DLWMSClient.DLWSMServis.HelloWorldResponse DLWMSClient.DLWSMServis.MojServisSoap.HelloWorld(DLWMSClient.DLWSMServis.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            DLWMSClient.DLWSMServis.HelloWorldRequest inValue = new DLWMSClient.DLWSMServis.HelloWorldRequest();
            inValue.Body = new DLWMSClient.DLWSMServis.HelloWorldRequestBody();
            DLWMSClient.DLWSMServis.HelloWorldResponse retVal = ((DLWMSClient.DLWSMServis.MojServisSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.HelloWorldResponse> DLWMSClient.DLWSMServis.MojServisSoap.HelloWorldAsync(DLWMSClient.DLWSMServis.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.HelloWorldResponse> HelloWorldAsync() {
            DLWMSClient.DLWSMServis.HelloWorldRequest inValue = new DLWMSClient.DLWSMServis.HelloWorldRequest();
            inValue.Body = new DLWMSClient.DLWSMServis.HelloWorldRequestBody();
            return ((DLWMSClient.DLWSMServis.MojServisSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DLWMSClient.DLWSMServis.GetGodineStudijaResponse DLWMSClient.DLWSMServis.MojServisSoap.GetGodineStudija(DLWMSClient.DLWSMServis.GetGodineStudijaRequest request) {
            return base.Channel.GetGodineStudija(request);
        }
        
        public DLWMSClient.DLWSMServis.GodinaStudija[] GetGodineStudija() {
            DLWMSClient.DLWSMServis.GetGodineStudijaRequest inValue = new DLWMSClient.DLWSMServis.GetGodineStudijaRequest();
            inValue.Body = new DLWMSClient.DLWSMServis.GetGodineStudijaRequestBody();
            DLWMSClient.DLWSMServis.GetGodineStudijaResponse retVal = ((DLWMSClient.DLWSMServis.MojServisSoap)(this)).GetGodineStudija(inValue);
            return retVal.Body.GetGodineStudijaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.GetGodineStudijaResponse> DLWMSClient.DLWSMServis.MojServisSoap.GetGodineStudijaAsync(DLWMSClient.DLWSMServis.GetGodineStudijaRequest request) {
            return base.Channel.GetGodineStudijaAsync(request);
        }
        
        public System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.GetGodineStudijaResponse> GetGodineStudijaAsync() {
            DLWMSClient.DLWSMServis.GetGodineStudijaRequest inValue = new DLWMSClient.DLWSMServis.GetGodineStudijaRequest();
            inValue.Body = new DLWMSClient.DLWSMServis.GetGodineStudijaRequestBody();
            return ((DLWMSClient.DLWSMServis.MojServisSoap)(this)).GetGodineStudijaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DLWMSClient.DLWSMServis.GetStudenteResponse DLWMSClient.DLWSMServis.MojServisSoap.GetStudente(DLWMSClient.DLWSMServis.GetStudenteRequest request) {
            return base.Channel.GetStudente(request);
        }
        
        public DLWMSClient.DLWSMServis.Student[] GetStudente() {
            DLWMSClient.DLWSMServis.GetStudenteRequest inValue = new DLWMSClient.DLWSMServis.GetStudenteRequest();
            inValue.Body = new DLWMSClient.DLWSMServis.GetStudenteRequestBody();
            DLWMSClient.DLWSMServis.GetStudenteResponse retVal = ((DLWMSClient.DLWSMServis.MojServisSoap)(this)).GetStudente(inValue);
            return retVal.Body.GetStudenteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.GetStudenteResponse> DLWMSClient.DLWSMServis.MojServisSoap.GetStudenteAsync(DLWMSClient.DLWSMServis.GetStudenteRequest request) {
            return base.Channel.GetStudenteAsync(request);
        }
        
        public System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.GetStudenteResponse> GetStudenteAsync() {
            DLWMSClient.DLWSMServis.GetStudenteRequest inValue = new DLWMSClient.DLWSMServis.GetStudenteRequest();
            inValue.Body = new DLWMSClient.DLWSMServis.GetStudenteRequestBody();
            return ((DLWMSClient.DLWSMServis.MojServisSoap)(this)).GetStudenteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaResponse DLWMSClient.DLWSMServis.MojServisSoap.GetStudenteByGodinaStudija(DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequest request) {
            return base.Channel.GetStudenteByGodinaStudija(request);
        }
        
        public DLWMSClient.DLWSMServis.Student[] GetStudenteByGodinaStudija(int IdGodinaStudija) {
            DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequest inValue = new DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequest();
            inValue.Body = new DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequestBody();
            inValue.Body.IdGodinaStudija = IdGodinaStudija;
            DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaResponse retVal = ((DLWMSClient.DLWSMServis.MojServisSoap)(this)).GetStudenteByGodinaStudija(inValue);
            return retVal.Body.GetStudenteByGodinaStudijaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaResponse> DLWMSClient.DLWSMServis.MojServisSoap.GetStudenteByGodinaStudijaAsync(DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequest request) {
            return base.Channel.GetStudenteByGodinaStudijaAsync(request);
        }
        
        public System.Threading.Tasks.Task<DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaResponse> GetStudenteByGodinaStudijaAsync(int IdGodinaStudija) {
            DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequest inValue = new DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequest();
            inValue.Body = new DLWMSClient.DLWSMServis.GetStudenteByGodinaStudijaRequestBody();
            inValue.Body.IdGodinaStudija = IdGodinaStudija;
            return ((DLWMSClient.DLWSMServis.MojServisSoap)(this)).GetStudenteByGodinaStudijaAsync(inValue);
        }
    }
}
