﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewClientApp.ServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/wcfNewService")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRef.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetPersons", ReplyAction="http://tempuri.org/IMyService/GetPersonsResponse")]
        NewClientApp.ServiceRef.Person[] GetPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetPersons", ReplyAction="http://tempuri.org/IMyService/GetPersonsResponse")]
        System.Threading.Tasks.Task<NewClientApp.ServiceRef.Person[]> GetPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetPerson", ReplyAction="http://tempuri.org/IMyService/GetPersonResponse")]
        NewClientApp.ServiceRef.Person GetPerson(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetPerson", ReplyAction="http://tempuri.org/IMyService/GetPersonResponse")]
        System.Threading.Tasks.Task<NewClientApp.ServiceRef.Person> GetPersonAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddPerson", ReplyAction="http://tempuri.org/IMyService/AddPersonResponse")]
        void AddPerson(NewClientApp.ServiceRef.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddPerson", ReplyAction="http://tempuri.org/IMyService/AddPersonResponse")]
        System.Threading.Tasks.Task AddPersonAsync(NewClientApp.ServiceRef.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyPerson", ReplyAction="http://tempuri.org/IMyService/ModifyPersonResponse")]
        void ModifyPerson(NewClientApp.ServiceRef.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyPerson", ReplyAction="http://tempuri.org/IMyService/ModifyPersonResponse")]
        System.Threading.Tasks.Task ModifyPersonAsync(NewClientApp.ServiceRef.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetArraySize", ReplyAction="http://tempuri.org/IMyService/GetArraySizeResponse")]
        int GetArraySize();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetArraySize", ReplyAction="http://tempuri.org/IMyService/GetArraySizeResponse")]
        System.Threading.Tasks.Task<int> GetArraySizeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : NewClientApp.ServiceRef.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<NewClientApp.ServiceRef.IMyService>, NewClientApp.ServiceRef.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NewClientApp.ServiceRef.Person[] GetPersons() {
            return base.Channel.GetPersons();
        }
        
        public System.Threading.Tasks.Task<NewClientApp.ServiceRef.Person[]> GetPersonsAsync() {
            return base.Channel.GetPersonsAsync();
        }
        
        public NewClientApp.ServiceRef.Person GetPerson(int id) {
            return base.Channel.GetPerson(id);
        }
        
        public System.Threading.Tasks.Task<NewClientApp.ServiceRef.Person> GetPersonAsync(int id) {
            return base.Channel.GetPersonAsync(id);
        }
        
        public void AddPerson(NewClientApp.ServiceRef.Person person) {
            base.Channel.AddPerson(person);
        }
        
        public System.Threading.Tasks.Task AddPersonAsync(NewClientApp.ServiceRef.Person person) {
            return base.Channel.AddPersonAsync(person);
        }
        
        public void ModifyPerson(NewClientApp.ServiceRef.Person person) {
            base.Channel.ModifyPerson(person);
        }
        
        public System.Threading.Tasks.Task ModifyPersonAsync(NewClientApp.ServiceRef.Person person) {
            return base.Channel.ModifyPersonAsync(person);
        }
        
        public int GetArraySize() {
            return base.Channel.GetArraySize();
        }
        
        public System.Threading.Tasks.Task<int> GetArraySizeAsync() {
            return base.Channel.GetArraySizeAsync();
        }
    }
}