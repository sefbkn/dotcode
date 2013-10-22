﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dotcode.CompilerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UnsupportedLanguageFaultContract", Namespace="http://schemas.datacontract.org/2004/07/CompilerService.Fault")]
    [System.SerializableAttribute()]
    public partial class UnsupportedLanguageFaultContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private dotcode.lib.common.Language LanguageField;
        
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
        public dotcode.lib.common.Language Language {
            get {
                return this.LanguageField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageField, value) != true)) {
                    this.LanguageField = value;
                    this.RaisePropertyChanged("Language");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompilerService.ICompilerService")]
    public interface ICompilerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompilerService/Compile", ReplyAction="http://tempuri.org/ICompilerService/CompileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException), Action="http://tempuri.org/ICompilerService/CompileArgumentNullExceptionFault", Name="ArgumentNullException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.FaultContractAttribute(typeof(dotcode.CompilerService.UnsupportedLanguageFaultContract), Action="http://tempuri.org/ICompilerService/CompileUnsupportedLanguageFaultContractFault", Name="UnsupportedLanguageFaultContract", Namespace="http://schemas.datacontract.org/2004/07/CompilerService.Fault")]
        dotcode.lib.common.Compiler.CompilerOutput Compile(dotcode.lib.common.CompilerInput compilerInput, string tempCompilerDir);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompilerService/Compile", ReplyAction="http://tempuri.org/ICompilerService/CompileResponse")]
        System.Threading.Tasks.Task<dotcode.lib.common.Compiler.CompilerOutput> CompileAsync(dotcode.lib.common.CompilerInput compilerInput, string tempCompilerDir);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompilerServiceChannel : dotcode.CompilerService.ICompilerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompilerServiceClient : System.ServiceModel.ClientBase<dotcode.CompilerService.ICompilerService>, dotcode.CompilerService.ICompilerService {
        
        public CompilerServiceClient() {
        }
        
        public CompilerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompilerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompilerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompilerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public dotcode.lib.common.Compiler.CompilerOutput Compile(dotcode.lib.common.CompilerInput compilerInput, string tempCompilerDir) {
            return base.Channel.Compile(compilerInput, tempCompilerDir);
        }
        
        public System.Threading.Tasks.Task<dotcode.lib.common.Compiler.CompilerOutput> CompileAsync(dotcode.lib.common.CompilerInput compilerInput, string tempCompilerDir) {
            return base.Channel.CompileAsync(compilerInput, tempCompilerDir);
        }
    }
}