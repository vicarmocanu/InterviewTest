﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFInterviewUI.DistrictSrv {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="District", Namespace="http://schemas.datacontract.org/2004/07/InterviewServices")]
    [System.SerializableAttribute()]
    public partial class District : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DistrictIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PrimSalePersonIdField;
        
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
        public int DistrictId {
            get {
                return this.DistrictIdField;
            }
            set {
                if ((this.DistrictIdField.Equals(value) != true)) {
                    this.DistrictIdField = value;
                    this.RaisePropertyChanged("DistrictId");
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
        public int PrimSalePersonId {
            get {
                return this.PrimSalePersonIdField;
            }
            set {
                if ((this.PrimSalePersonIdField.Equals(value) != true)) {
                    this.PrimSalePersonIdField = value;
                    this.RaisePropertyChanged("PrimSalePersonId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SalePerson", Namespace="http://schemas.datacontract.org/2004/07/InterviewServices")]
    [System.SerializableAttribute()]
    public partial class SalePerson : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pass {
            get {
                return this.PassField;
            }
            set {
                if ((object.ReferenceEquals(this.PassField, value) != true)) {
                    this.PassField = value;
                    this.RaisePropertyChanged("Pass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhoneNo {
            get {
                return this.PhoneNoField;
            }
            set {
                if ((this.PhoneNoField.Equals(value) != true)) {
                    this.PhoneNoField = value;
                    this.RaisePropertyChanged("PhoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Store", Namespace="http://schemas.datacontract.org/2004/07/InterviewServices")]
    [System.SerializableAttribute()]
    public partial class Store : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DistrictIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StoreIdField;
        
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
        public int DistrictId {
            get {
                return this.DistrictIdField;
            }
            set {
                if ((this.DistrictIdField.Equals(value) != true)) {
                    this.DistrictIdField = value;
                    this.RaisePropertyChanged("DistrictId");
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
        public int StoreId {
            get {
                return this.StoreIdField;
            }
            set {
                if ((this.StoreIdField.Equals(value) != true)) {
                    this.StoreIdField = value;
                    this.RaisePropertyChanged("StoreId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DistrictSrv.IDistrictService")]
    public interface IDistrictService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistrictService/addDistrict", ReplyAction="http://tempuri.org/IDistrictService/addDistrictResponse")]
        void addDistrict(int districtId, int primarySalePersonId, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistrictService/addDistrict", ReplyAction="http://tempuri.org/IDistrictService/addDistrictResponse")]
        System.Threading.Tasks.Task addDistrictAsync(int districtId, int primarySalePersonId, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistrictService/getAllDistricts", ReplyAction="http://tempuri.org/IDistrictService/getAllDistrictsResponse")]
        WPFInterviewUI.DistrictSrv.District[] getAllDistricts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistrictService/getAllDistricts", ReplyAction="http://tempuri.org/IDistrictService/getAllDistrictsResponse")]
        System.Threading.Tasks.Task<WPFInterviewUI.DistrictSrv.District[]> getAllDistrictsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistrictService/changePrimarySalesPerson", ReplyAction="http://tempuri.org/IDistrictService/changePrimarySalesPersonResponse")]
        void changePrimarySalesPerson(int districtid, int primeSalePersId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistrictService/changePrimarySalesPerson", ReplyAction="http://tempuri.org/IDistrictService/changePrimarySalesPersonResponse")]
        System.Threading.Tasks.Task changePrimarySalesPersonAsync(int districtid, int primeSalePersId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistrictService/getDistrictSalePersons", ReplyAction="http://tempuri.org/IDistrictService/getDistrictSalePersonsResponse")]
        WPFInterviewUI.DistrictSrv.SalePerson[] getDistrictSalePersons(int districtId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistrictService/getDistrictSalePersons", ReplyAction="http://tempuri.org/IDistrictService/getDistrictSalePersonsResponse")]
        System.Threading.Tasks.Task<WPFInterviewUI.DistrictSrv.SalePerson[]> getDistrictSalePersonsAsync(int districtId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistrictService/getStoresOnDistrict", ReplyAction="http://tempuri.org/IDistrictService/getStoresOnDistrictResponse")]
        WPFInterviewUI.DistrictSrv.Store[] getStoresOnDistrict(int districtId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistrictService/getStoresOnDistrict", ReplyAction="http://tempuri.org/IDistrictService/getStoresOnDistrictResponse")]
        System.Threading.Tasks.Task<WPFInterviewUI.DistrictSrv.Store[]> getStoresOnDistrictAsync(int districtId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDistrictServiceChannel : WPFInterviewUI.DistrictSrv.IDistrictService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DistrictServiceClient : System.ServiceModel.ClientBase<WPFInterviewUI.DistrictSrv.IDistrictService>, WPFInterviewUI.DistrictSrv.IDistrictService {
        
        public DistrictServiceClient() {
        }
        
        public DistrictServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DistrictServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DistrictServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DistrictServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void addDistrict(int districtId, int primarySalePersonId, string name) {
            base.Channel.addDistrict(districtId, primarySalePersonId, name);
        }
        
        public System.Threading.Tasks.Task addDistrictAsync(int districtId, int primarySalePersonId, string name) {
            return base.Channel.addDistrictAsync(districtId, primarySalePersonId, name);
        }
        
        public WPFInterviewUI.DistrictSrv.District[] getAllDistricts() {
            return base.Channel.getAllDistricts();
        }
        
        public System.Threading.Tasks.Task<WPFInterviewUI.DistrictSrv.District[]> getAllDistrictsAsync() {
            return base.Channel.getAllDistrictsAsync();
        }
        
        public void changePrimarySalesPerson(int districtid, int primeSalePersId) {
            base.Channel.changePrimarySalesPerson(districtid, primeSalePersId);
        }
        
        public System.Threading.Tasks.Task changePrimarySalesPersonAsync(int districtid, int primeSalePersId) {
            return base.Channel.changePrimarySalesPersonAsync(districtid, primeSalePersId);
        }
        
        public WPFInterviewUI.DistrictSrv.SalePerson[] getDistrictSalePersons(int districtId) {
            return base.Channel.getDistrictSalePersons(districtId);
        }
        
        public System.Threading.Tasks.Task<WPFInterviewUI.DistrictSrv.SalePerson[]> getDistrictSalePersonsAsync(int districtId) {
            return base.Channel.getDistrictSalePersonsAsync(districtId);
        }
        
        public WPFInterviewUI.DistrictSrv.Store[] getStoresOnDistrict(int districtId) {
            return base.Channel.getStoresOnDistrict(districtId);
        }
        
        public System.Threading.Tasks.Task<WPFInterviewUI.DistrictSrv.Store[]> getStoresOnDistrictAsync(int districtId) {
            return base.Channel.getStoresOnDistrictAsync(districtId);
        }
    }
}
