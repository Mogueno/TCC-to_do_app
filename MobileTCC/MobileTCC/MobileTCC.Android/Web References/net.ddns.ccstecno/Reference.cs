﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Este código-fonte foi gerado automaticamente por Microsoft.VSDesigner, Versão 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace MobileTCC.Droid.net.ddns.ccstecno {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="FAAT")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetDataSetOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExecuteNonQueryOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = "http://ccstecno.ddns.net:1418/WebService1.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetDataSetCompletedEventHandler GetDataSetCompleted;
        
        /// <remarks/>
        public event ExecuteNonQueryCompletedEventHandler ExecuteNonQueryCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("FAAT/GetDataSet", RequestNamespace="FAAT", ResponseNamespace="FAAT", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetDataSet(string pSQL, string pBase) {
            object[] results = this.Invoke("GetDataSet", new object[] {
                        pSQL,
                        pBase});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataSetAsync(string pSQL, string pBase) {
            this.GetDataSetAsync(pSQL, pBase, null);
        }
        
        /// <remarks/>
        public void GetDataSetAsync(string pSQL, string pBase, object userState) {
            if ((this.GetDataSetOperationCompleted == null)) {
                this.GetDataSetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataSetOperationCompleted);
            }
            this.InvokeAsync("GetDataSet", new object[] {
                        pSQL,
                        pBase}, this.GetDataSetOperationCompleted, userState);
        }
        
        private void OnGetDataSetOperationCompleted(object arg) {
            if ((this.GetDataSetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataSetCompleted(this, new GetDataSetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("FAAT/ExecuteNonQuery", RequestNamespace="FAAT", ResponseNamespace="FAAT", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ExecuteNonQuery(string pSQL, string pBase) {
            object[] results = this.Invoke("ExecuteNonQuery", new object[] {
                        pSQL,
                        pBase});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ExecuteNonQueryAsync(string pSQL, string pBase) {
            this.ExecuteNonQueryAsync(pSQL, pBase, null);
        }
        
        /// <remarks/>
        public void ExecuteNonQueryAsync(string pSQL, string pBase, object userState) {
            if ((this.ExecuteNonQueryOperationCompleted == null)) {
                this.ExecuteNonQueryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExecuteNonQueryOperationCompleted);
            }
            this.InvokeAsync("ExecuteNonQuery", new object[] {
                        pSQL,
                        pBase}, this.ExecuteNonQueryOperationCompleted, userState);
        }
        
        private void OnExecuteNonQueryOperationCompleted(object arg) {
            if ((this.ExecuteNonQueryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExecuteNonQueryCompleted(this, new ExecuteNonQueryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetDataSetCompletedEventHandler(object sender, GetDataSetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataSetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataSetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void ExecuteNonQueryCompletedEventHandler(object sender, ExecuteNonQueryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExecuteNonQueryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExecuteNonQueryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591