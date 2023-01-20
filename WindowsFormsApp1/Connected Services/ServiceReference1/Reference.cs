﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ZIprojekat")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WindowsFormsApp1.ServiceReference1.CompositeType GetDataUsingDataContract(WindowsFormsApp1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WindowsFormsApp1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EncryptBitmap", ReplyAction="http://tempuri.org/IService1/EncryptBitmapResponse")]
        bool EncryptBitmap(string inputPath, string outputPath, string alghorithm, bool hash, string key, string nonce);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EncryptBitmap", ReplyAction="http://tempuri.org/IService1/EncryptBitmapResponse")]
        System.Threading.Tasks.Task<bool> EncryptBitmapAsync(string inputPath, string outputPath, string alghorithm, bool hash, string key, string nonce);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DecryptBitmap", ReplyAction="http://tempuri.org/IService1/DecryptBitmapResponse")]
        bool DecryptBitmap(string inputPath, string outputPath, string alghorithm, bool hash, string key, string nonce);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DecryptBitmap", ReplyAction="http://tempuri.org/IService1/DecryptBitmapResponse")]
        System.Threading.Tasks.Task<bool> DecryptBitmapAsync(string inputPath, string outputPath, string alghorithm, bool hash, string key, string nonce);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EncryptRC6", ReplyAction="http://tempuri.org/IService1/EncryptRC6Response")]
        string EncryptRC6(string source, string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EncryptRC6", ReplyAction="http://tempuri.org/IService1/EncryptRC6Response")]
        System.Threading.Tasks.Task<string> EncryptRC6Async(string source, string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EncryptRC6_CTRmode", ReplyAction="http://tempuri.org/IService1/EncryptRC6_CTRmodeResponse")]
        string EncryptRC6_CTRmode(string source, string key, string nonce);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EncryptRC6_CTRmode", ReplyAction="http://tempuri.org/IService1/EncryptRC6_CTRmodeResponse")]
        System.Threading.Tasks.Task<string> EncryptRC6_CTRmodeAsync(string source, string key, string nonce);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DecryptRC6", ReplyAction="http://tempuri.org/IService1/DecryptRC6Response")]
        string DecryptRC6(string source, string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DecryptRC6", ReplyAction="http://tempuri.org/IService1/DecryptRC6Response")]
        System.Threading.Tasks.Task<string> DecryptRC6Async(string source, string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DecryptRC6_CTRmode", ReplyAction="http://tempuri.org/IService1/DecryptRC6_CTRmodeResponse")]
        string DecryptRC6_CTRmode(string source, string key, string nonce);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DecryptRC6_CTRmode", ReplyAction="http://tempuri.org/IService1/DecryptRC6_CTRmodeResponse")]
        System.Threading.Tasks.Task<string> DecryptRC6_CTRmodeAsync(string source, string key, string nonce);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerateRandomKeyBifid", ReplyAction="http://tempuri.org/IService1/GenerateRandomKeyBifidResponse")]
        string[] GenerateRandomKeyBifid();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerateRandomKeyBifid", ReplyAction="http://tempuri.org/IService1/GenerateRandomKeyBifidResponse")]
        System.Threading.Tasks.Task<string[]> GenerateRandomKeyBifidAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadKeyBifid", ReplyAction="http://tempuri.org/IService1/LoadKeyBifidResponse")]
        void LoadKeyBifid(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadKeyBifid", ReplyAction="http://tempuri.org/IService1/LoadKeyBifidResponse")]
        System.Threading.Tasks.Task LoadKeyBifidAsync(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EncryptBifid", ReplyAction="http://tempuri.org/IService1/EncryptBifidResponse")]
        string[] EncryptBifid(string[] source);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EncryptBifid", ReplyAction="http://tempuri.org/IService1/EncryptBifidResponse")]
        System.Threading.Tasks.Task<string[]> EncryptBifidAsync(string[] source);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DecryptBifid", ReplyAction="http://tempuri.org/IService1/DecryptBifidResponse")]
        string[] DecryptBifid(string[] source);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DecryptBifid", ReplyAction="http://tempuri.org/IService1/DecryptBifidResponse")]
        System.Threading.Tasks.Task<string[]> DecryptBifidAsync(string[] source);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerateTigerHash", ReplyAction="http://tempuri.org/IService1/GenerateTigerHashResponse")]
        byte[] GenerateTigerHash(string source);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerateTigerHash", ReplyAction="http://tempuri.org/IService1/GenerateTigerHashResponse")]
        System.Threading.Tasks.Task<byte[]> GenerateTigerHashAsync(string source);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsApp1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.IService1>, WindowsFormsApp1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(string value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(string value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WindowsFormsApp1.ServiceReference1.CompositeType GetDataUsingDataContract(WindowsFormsApp1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WindowsFormsApp1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool EncryptBitmap(string inputPath, string outputPath, string alghorithm, bool hash, string key, string nonce) {
            return base.Channel.EncryptBitmap(inputPath, outputPath, alghorithm, hash, key, nonce);
        }
        
        public System.Threading.Tasks.Task<bool> EncryptBitmapAsync(string inputPath, string outputPath, string alghorithm, bool hash, string key, string nonce) {
            return base.Channel.EncryptBitmapAsync(inputPath, outputPath, alghorithm, hash, key, nonce);
        }
        
        public bool DecryptBitmap(string inputPath, string outputPath, string alghorithm, bool hash, string key, string nonce) {
            return base.Channel.DecryptBitmap(inputPath, outputPath, alghorithm, hash, key, nonce);
        }
        
        public System.Threading.Tasks.Task<bool> DecryptBitmapAsync(string inputPath, string outputPath, string alghorithm, bool hash, string key, string nonce) {
            return base.Channel.DecryptBitmapAsync(inputPath, outputPath, alghorithm, hash, key, nonce);
        }
        
        public string EncryptRC6(string source, string key) {
            return base.Channel.EncryptRC6(source, key);
        }
        
        public System.Threading.Tasks.Task<string> EncryptRC6Async(string source, string key) {
            return base.Channel.EncryptRC6Async(source, key);
        }
        
        public string EncryptRC6_CTRmode(string source, string key, string nonce) {
            return base.Channel.EncryptRC6_CTRmode(source, key, nonce);
        }
        
        public System.Threading.Tasks.Task<string> EncryptRC6_CTRmodeAsync(string source, string key, string nonce) {
            return base.Channel.EncryptRC6_CTRmodeAsync(source, key, nonce);
        }
        
        public string DecryptRC6(string source, string key) {
            return base.Channel.DecryptRC6(source, key);
        }
        
        public System.Threading.Tasks.Task<string> DecryptRC6Async(string source, string key) {
            return base.Channel.DecryptRC6Async(source, key);
        }
        
        public string DecryptRC6_CTRmode(string source, string key, string nonce) {
            return base.Channel.DecryptRC6_CTRmode(source, key, nonce);
        }
        
        public System.Threading.Tasks.Task<string> DecryptRC6_CTRmodeAsync(string source, string key, string nonce) {
            return base.Channel.DecryptRC6_CTRmodeAsync(source, key, nonce);
        }
        
        public string[] GenerateRandomKeyBifid() {
            return base.Channel.GenerateRandomKeyBifid();
        }
        
        public System.Threading.Tasks.Task<string[]> GenerateRandomKeyBifidAsync() {
            return base.Channel.GenerateRandomKeyBifidAsync();
        }
        
        public void LoadKeyBifid(string key) {
            base.Channel.LoadKeyBifid(key);
        }
        
        public System.Threading.Tasks.Task LoadKeyBifidAsync(string key) {
            return base.Channel.LoadKeyBifidAsync(key);
        }
        
        public string[] EncryptBifid(string[] source) {
            return base.Channel.EncryptBifid(source);
        }
        
        public System.Threading.Tasks.Task<string[]> EncryptBifidAsync(string[] source) {
            return base.Channel.EncryptBifidAsync(source);
        }
        
        public string[] DecryptBifid(string[] source) {
            return base.Channel.DecryptBifid(source);
        }
        
        public System.Threading.Tasks.Task<string[]> DecryptBifidAsync(string[] source) {
            return base.Channel.DecryptBifidAsync(source);
        }
        
        public byte[] GenerateTigerHash(string source) {
            return base.Channel.GenerateTigerHash(source);
        }
        
        public System.Threading.Tasks.Task<byte[]> GenerateTigerHashAsync(string source) {
            return base.Channel.GenerateTigerHashAsync(source);
        }
    }
}
