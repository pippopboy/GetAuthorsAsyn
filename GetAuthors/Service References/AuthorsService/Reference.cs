﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetAuthors.AuthorsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Author", Namespace="http://schemas.datacontract.org/2004/07/TracingLoggingAuthorsService")]
    [System.SerializableAttribute()]
    public partial class Author : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GroupNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProjectNameField;
        
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
        public string GroupName {
            get {
                return this.GroupNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupNameField, value) != true)) {
                    this.GroupNameField = value;
                    this.RaisePropertyChanged("GroupName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProjectName {
            get {
                return this.ProjectNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjectNameField, value) != true)) {
                    this.ProjectNameField = value;
                    this.RaisePropertyChanged("ProjectName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthorsService.IAuthors")]
    public interface IAuthors {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthors/Getauthors", ReplyAction="http://tempuri.org/IAuthors/GetauthorsResponse")]
        GetAuthors.AuthorsService.Author Getauthors();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IAuthors/Getauthors", ReplyAction="http://tempuri.org/IAuthors/GetauthorsResponse")]
        System.IAsyncResult BeginGetauthors(System.AsyncCallback callback, object asyncState);
        
        GetAuthors.AuthorsService.Author EndGetauthors(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthorsChannel : GetAuthors.AuthorsService.IAuthors, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetauthorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetauthorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public GetAuthors.AuthorsService.Author Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((GetAuthors.AuthorsService.Author)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthorsClient : System.ServiceModel.ClientBase<GetAuthors.AuthorsService.IAuthors>, GetAuthors.AuthorsService.IAuthors {
        
        private BeginOperationDelegate onBeginGetauthorsDelegate;
        
        private EndOperationDelegate onEndGetauthorsDelegate;
        
        private System.Threading.SendOrPostCallback onGetauthorsCompletedDelegate;
        
        public AuthorsClient() {
        }
        
        public AuthorsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthorsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthorsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthorsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetauthorsCompletedEventArgs> GetauthorsCompleted;
        
        public GetAuthors.AuthorsService.Author Getauthors() {
            return base.Channel.Getauthors();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetauthors(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetauthors(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public GetAuthors.AuthorsService.Author EndGetauthors(System.IAsyncResult result) {
            return base.Channel.EndGetauthors(result);
        }
        
        private System.IAsyncResult OnBeginGetauthors(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetauthors(callback, asyncState);
        }
        
        private object[] OnEndGetauthors(System.IAsyncResult result) {
            GetAuthors.AuthorsService.Author retVal = this.EndGetauthors(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetauthorsCompleted(object state) {
            if ((this.GetauthorsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetauthorsCompleted(this, new GetauthorsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetauthorsAsync() {
            this.GetauthorsAsync(null);
        }
        
        public void GetauthorsAsync(object userState) {
            if ((this.onBeginGetauthorsDelegate == null)) {
                this.onBeginGetauthorsDelegate = new BeginOperationDelegate(this.OnBeginGetauthors);
            }
            if ((this.onEndGetauthorsDelegate == null)) {
                this.onEndGetauthorsDelegate = new EndOperationDelegate(this.OnEndGetauthors);
            }
            if ((this.onGetauthorsCompletedDelegate == null)) {
                this.onGetauthorsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetauthorsCompleted);
            }
            base.InvokeAsync(this.onBeginGetauthorsDelegate, null, this.onEndGetauthorsDelegate, this.onGetauthorsCompletedDelegate, userState);
        }
    }
}
