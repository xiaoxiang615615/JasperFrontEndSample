﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace JasperMvcTest1.JasperListTest {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AuthorisationTransactionsWebServiceSoap11Binding", Namespace="http://webservice.authorisationtransactions.newhope.com")]
    public partial class AuthorisationTransactionsWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getZAUTHEADOperationCompleted;
        
        private System.Threading.SendOrPostCallback getZAUTLINEOperationCompleted;
        
        private System.Threading.SendOrPostCallback getZautheadDetailOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAuthorisationCommentsOperationCompleted;
        
        private System.Threading.SendOrPostCallback webServiceTestOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUserGroupOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AuthorisationTransactionsWebService() {
            this.Url = global::JasperMvcTest1.Properties.Settings.Default.JasperMvcTest1_JasperListTest_AuthorisationTransactionsWebService;
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
        public event getZAUTHEADCompletedEventHandler getZAUTHEADCompleted;
        
        /// <remarks/>
        public event getZAUTLINECompletedEventHandler getZAUTLINECompleted;
        
        /// <remarks/>
        public event getZautheadDetailCompletedEventHandler getZautheadDetailCompleted;
        
        /// <remarks/>
        public event getAuthorisationCommentsCompletedEventHandler getAuthorisationCommentsCompleted;
        
        /// <remarks/>
        public event webServiceTestCompletedEventHandler webServiceTestCompleted;
        
        /// <remarks/>
        public event getUserGroupCompletedEventHandler getUserGroupCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getZAUTHEAD", RequestNamespace="http://webservice.authorisationtransactions.newhope.com", ResponseNamespace="http://webservice.authorisationtransactions.newhope.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string getZAUTHEAD(
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zautyp, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zrolln, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zwrkun, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zwrkti, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string rgtm, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string rgdt, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zcurln, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zpurcn, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zausts, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string itds, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string sunm, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string sino, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string puno, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string plpn, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zprvrn, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string conm, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string fromDate, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string toDate, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string fromAmount, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string toAmount, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string supplier, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string invoiceNumber, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string poNumber, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string plannedOrderNumber, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string currentUser, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string isOpenTransactionsOnly, 
                    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string authentication) {
            object[] results = this.Invoke("getZAUTHEAD", new object[] {
                        zautyp,
                        zrolln,
                        zwrkun,
                        zwrkti,
                        rgtm,
                        rgdt,
                        zcurln,
                        zpurcn,
                        zausts,
                        itds,
                        sunm,
                        sino,
                        puno,
                        plpn,
                        zprvrn,
                        conm,
                        fromDate,
                        toDate,
                        fromAmount,
                        toAmount,
                        supplier,
                        invoiceNumber,
                        poNumber,
                        plannedOrderNumber,
                        currentUser,
                        isOpenTransactionsOnly,
                        authentication});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getZAUTHEADAsync(
                    string zautyp, 
                    string zrolln, 
                    string zwrkun, 
                    string zwrkti, 
                    string rgtm, 
                    string rgdt, 
                    string zcurln, 
                    string zpurcn, 
                    string zausts, 
                    string itds, 
                    string sunm, 
                    string sino, 
                    string puno, 
                    string plpn, 
                    string zprvrn, 
                    string conm, 
                    string fromDate, 
                    string toDate, 
                    string fromAmount, 
                    string toAmount, 
                    string supplier, 
                    string invoiceNumber, 
                    string poNumber, 
                    string plannedOrderNumber, 
                    string currentUser, 
                    string isOpenTransactionsOnly, 
                    string authentication) {
            this.getZAUTHEADAsync(zautyp, zrolln, zwrkun, zwrkti, rgtm, rgdt, zcurln, zpurcn, zausts, itds, sunm, sino, puno, plpn, zprvrn, conm, fromDate, toDate, fromAmount, toAmount, supplier, invoiceNumber, poNumber, plannedOrderNumber, currentUser, isOpenTransactionsOnly, authentication, null);
        }
        
        /// <remarks/>
        public void getZAUTHEADAsync(
                    string zautyp, 
                    string zrolln, 
                    string zwrkun, 
                    string zwrkti, 
                    string rgtm, 
                    string rgdt, 
                    string zcurln, 
                    string zpurcn, 
                    string zausts, 
                    string itds, 
                    string sunm, 
                    string sino, 
                    string puno, 
                    string plpn, 
                    string zprvrn, 
                    string conm, 
                    string fromDate, 
                    string toDate, 
                    string fromAmount, 
                    string toAmount, 
                    string supplier, 
                    string invoiceNumber, 
                    string poNumber, 
                    string plannedOrderNumber, 
                    string currentUser, 
                    string isOpenTransactionsOnly, 
                    string authentication, 
                    object userState) {
            if ((this.getZAUTHEADOperationCompleted == null)) {
                this.getZAUTHEADOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetZAUTHEADOperationCompleted);
            }
            this.InvokeAsync("getZAUTHEAD", new object[] {
                        zautyp,
                        zrolln,
                        zwrkun,
                        zwrkti,
                        rgtm,
                        rgdt,
                        zcurln,
                        zpurcn,
                        zausts,
                        itds,
                        sunm,
                        sino,
                        puno,
                        plpn,
                        zprvrn,
                        conm,
                        fromDate,
                        toDate,
                        fromAmount,
                        toAmount,
                        supplier,
                        invoiceNumber,
                        poNumber,
                        plannedOrderNumber,
                        currentUser,
                        isOpenTransactionsOnly,
                        authentication}, this.getZAUTHEADOperationCompleted, userState);
        }
        
        private void OngetZAUTHEADOperationCompleted(object arg) {
            if ((this.getZAUTHEADCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getZAUTHEADCompleted(this, new getZAUTHEADCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getZAUTLINE", RequestNamespace="http://webservice.authorisationtransactions.newhope.com", ResponseNamespace="http://webservice.authorisationtransactions.newhope.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string getZAUTLINE([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zwrkun, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string rgdt, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string rgtm, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zauact, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zusrnm, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zrolln, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zdelfn) {
            object[] results = this.Invoke("getZAUTLINE", new object[] {
                        zwrkun,
                        rgdt,
                        rgtm,
                        zauact,
                        zusrnm,
                        zrolln,
                        zdelfn});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getZAUTLINEAsync(string zwrkun, string rgdt, string rgtm, string zauact, string zusrnm, string zrolln, string zdelfn) {
            this.getZAUTLINEAsync(zwrkun, rgdt, rgtm, zauact, zusrnm, zrolln, zdelfn, null);
        }
        
        /// <remarks/>
        public void getZAUTLINEAsync(string zwrkun, string rgdt, string rgtm, string zauact, string zusrnm, string zrolln, string zdelfn, object userState) {
            if ((this.getZAUTLINEOperationCompleted == null)) {
                this.getZAUTLINEOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetZAUTLINEOperationCompleted);
            }
            this.InvokeAsync("getZAUTLINE", new object[] {
                        zwrkun,
                        rgdt,
                        rgtm,
                        zauact,
                        zusrnm,
                        zrolln,
                        zdelfn}, this.getZAUTLINEOperationCompleted, userState);
        }
        
        private void OngetZAUTLINEOperationCompleted(object arg) {
            if ((this.getZAUTLINECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getZAUTLINECompleted(this, new getZAUTLINECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getZautheadDetail", RequestNamespace="http://webservice.authorisationtransactions.newhope.com", ResponseNamespace="http://webservice.authorisationtransactions.newhope.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string getZautheadDetail([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string divi, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zwrkun) {
            object[] results = this.Invoke("getZautheadDetail", new object[] {
                        divi,
                        zwrkun});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getZautheadDetailAsync(string divi, string zwrkun) {
            this.getZautheadDetailAsync(divi, zwrkun, null);
        }
        
        /// <remarks/>
        public void getZautheadDetailAsync(string divi, string zwrkun, object userState) {
            if ((this.getZautheadDetailOperationCompleted == null)) {
                this.getZautheadDetailOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetZautheadDetailOperationCompleted);
            }
            this.InvokeAsync("getZautheadDetail", new object[] {
                        divi,
                        zwrkun}, this.getZautheadDetailOperationCompleted, userState);
        }
        
        private void OngetZautheadDetailOperationCompleted(object arg) {
            if ((this.getZautheadDetailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getZautheadDetailCompleted(this, new getZautheadDetailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getAuthorisationComments", RequestNamespace="http://webservice.authorisationtransactions.newhope.com", ResponseNamespace="http://webservice.authorisationtransactions.newhope.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string getAuthorisationComments([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string zwrkun) {
            object[] results = this.Invoke("getAuthorisationComments", new object[] {
                        zwrkun});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAuthorisationCommentsAsync(string zwrkun) {
            this.getAuthorisationCommentsAsync(zwrkun, null);
        }
        
        /// <remarks/>
        public void getAuthorisationCommentsAsync(string zwrkun, object userState) {
            if ((this.getAuthorisationCommentsOperationCompleted == null)) {
                this.getAuthorisationCommentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAuthorisationCommentsOperationCompleted);
            }
            this.InvokeAsync("getAuthorisationComments", new object[] {
                        zwrkun}, this.getAuthorisationCommentsOperationCompleted, userState);
        }
        
        private void OngetAuthorisationCommentsOperationCompleted(object arg) {
            if ((this.getAuthorisationCommentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAuthorisationCommentsCompleted(this, new getAuthorisationCommentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:webServiceTest", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("webServiceTestResponse", Namespace="http://webservice.authorisationtransactions.newhope.com")]
        public webServiceTestResponse webServiceTest() {
            object[] results = this.Invoke("webServiceTest", new object[0]);
            return ((webServiceTestResponse)(results[0]));
        }
        
        /// <remarks/>
        public void webServiceTestAsync() {
            this.webServiceTestAsync(null);
        }
        
        /// <remarks/>
        public void webServiceTestAsync(object userState) {
            if ((this.webServiceTestOperationCompleted == null)) {
                this.webServiceTestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwebServiceTestOperationCompleted);
            }
            this.InvokeAsync("webServiceTest", new object[0], this.webServiceTestOperationCompleted, userState);
        }
        
        private void OnwebServiceTestOperationCompleted(object arg) {
            if ((this.webServiceTestCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.webServiceTestCompleted(this, new webServiceTestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getUserGroup", RequestNamespace="http://webservice.authorisationtransactions.newhope.com", ResponseNamespace="http://webservice.authorisationtransactions.newhope.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string getUserGroup([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string schema, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string userName) {
            object[] results = this.Invoke("getUserGroup", new object[] {
                        schema,
                        userName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getUserGroupAsync(string schema, string userName) {
            this.getUserGroupAsync(schema, userName, null);
        }
        
        /// <remarks/>
        public void getUserGroupAsync(string schema, string userName, object userState) {
            if ((this.getUserGroupOperationCompleted == null)) {
                this.getUserGroupOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUserGroupOperationCompleted);
            }
            this.InvokeAsync("getUserGroup", new object[] {
                        schema,
                        userName}, this.getUserGroupOperationCompleted, userState);
        }
        
        private void OngetUserGroupOperationCompleted(object arg) {
            if ((this.getUserGroupCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUserGroupCompleted(this, new getUserGroupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://webservice.authorisationtransactions.newhope.com")]
    public partial class webServiceTestResponse {
        
        private string returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string @return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getZAUTHEADCompletedEventHandler(object sender, getZAUTHEADCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getZAUTHEADCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getZAUTHEADCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getZAUTLINECompletedEventHandler(object sender, getZAUTLINECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getZAUTLINECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getZAUTLINECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getZautheadDetailCompletedEventHandler(object sender, getZautheadDetailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getZautheadDetailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getZautheadDetailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getAuthorisationCommentsCompletedEventHandler(object sender, getAuthorisationCommentsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAuthorisationCommentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAuthorisationCommentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void webServiceTestCompletedEventHandler(object sender, webServiceTestCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class webServiceTestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal webServiceTestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public webServiceTestResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((webServiceTestResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getUserGroupCompletedEventHandler(object sender, getUserGroupCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUserGroupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUserGroupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591