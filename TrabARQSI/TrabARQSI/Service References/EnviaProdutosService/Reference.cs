﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabARQSI.EnviaProdutosService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EnviaProdutosService.IEnviaProdutos")]
    public interface IEnviaProdutos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnviaProdutos/DoWork", ReplyAction="http://tempuri.org/IEnviaProdutos/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnviaProdutos/DoWork", ReplyAction="http://tempuri.org/IEnviaProdutos/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnviaProdutos/enviaProdutos", ReplyAction="http://tempuri.org/IEnviaProdutos/enviaProdutosResponse")]
        void enviaProdutos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnviaProdutos/enviaProdutos", ReplyAction="http://tempuri.org/IEnviaProdutos/enviaProdutosResponse")]
        System.Threading.Tasks.Task enviaProdutosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEnviaProdutosChannel : TrabARQSI.EnviaProdutosService.IEnviaProdutos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EnviaProdutosClient : System.ServiceModel.ClientBase<TrabARQSI.EnviaProdutosService.IEnviaProdutos>, TrabARQSI.EnviaProdutosService.IEnviaProdutos {
        
        public EnviaProdutosClient() {
        }
        
        public EnviaProdutosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EnviaProdutosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EnviaProdutosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EnviaProdutosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public void enviaProdutos() {
            base.Channel.enviaProdutos();
        }
        
        public System.Threading.Tasks.Task enviaProdutosAsync() {
            return base.Channel.enviaProdutosAsync();
        }
    }
}
