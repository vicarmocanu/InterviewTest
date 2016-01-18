﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFInterviewUI.AssignedSalePrsSrv {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AssignedSalePrsSrv.IAssignedSalePersService")]
    public interface IAssignedSalePersService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignedSalePersService/assignSalePerson", ReplyAction="http://tempuri.org/IAssignedSalePersService/assignSalePersonResponse")]
        void assignSalePerson(int salePersonId, int districtId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignedSalePersService/assignSalePerson", ReplyAction="http://tempuri.org/IAssignedSalePersService/assignSalePersonResponse")]
        System.Threading.Tasks.Task assignSalePersonAsync(int salePersonId, int districtId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignedSalePersService/deleteAssignedPerson", ReplyAction="http://tempuri.org/IAssignedSalePersService/deleteAssignedPersonResponse")]
        void deleteAssignedPerson(int salePersonId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignedSalePersService/deleteAssignedPerson", ReplyAction="http://tempuri.org/IAssignedSalePersService/deleteAssignedPersonResponse")]
        System.Threading.Tasks.Task deleteAssignedPersonAsync(int salePersonId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAssignedSalePersServiceChannel : WPFInterviewUI.AssignedSalePrsSrv.IAssignedSalePersService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AssignedSalePersServiceClient : System.ServiceModel.ClientBase<WPFInterviewUI.AssignedSalePrsSrv.IAssignedSalePersService>, WPFInterviewUI.AssignedSalePrsSrv.IAssignedSalePersService {
        
        public AssignedSalePersServiceClient() {
        }
        
        public AssignedSalePersServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AssignedSalePersServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AssignedSalePersServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AssignedSalePersServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void assignSalePerson(int salePersonId, int districtId) {
            base.Channel.assignSalePerson(salePersonId, districtId);
        }
        
        public System.Threading.Tasks.Task assignSalePersonAsync(int salePersonId, int districtId) {
            return base.Channel.assignSalePersonAsync(salePersonId, districtId);
        }
        
        public void deleteAssignedPerson(int salePersonId) {
            base.Channel.deleteAssignedPerson(salePersonId);
        }
        
        public System.Threading.Tasks.Task deleteAssignedPersonAsync(int salePersonId) {
            return base.Channel.deleteAssignedPersonAsync(salePersonId);
        }
    }
}