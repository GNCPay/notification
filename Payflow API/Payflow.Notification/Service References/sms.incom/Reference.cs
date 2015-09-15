﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Payflow.Notification.sms.incom {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://203.162.168.170/SendMTAuth/", ConfigurationName="sms.incom.Service_SendSMSSoap")]
    public interface Service_SendSMSSoap {
        
        // CODEGEN: Generating message contract since element name account_name from namespace http://203.162.168.170/SendMTAuth/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://203.162.168.170/SendMTAuth/SendSMS", ReplyAction="*")]
        Payflow.Notification.sms.incom.SendSMSResponse SendSMS(Payflow.Notification.sms.incom.SendSMSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://203.162.168.170/SendMTAuth/SendSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<Payflow.Notification.sms.incom.SendSMSResponse> SendSMSAsync(Payflow.Notification.sms.incom.SendSMSRequest request);
        
        // CODEGEN: Generating message contract since element name account_name from namespace http://203.162.168.170/SendMTAuth/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://203.162.168.170/SendMTAuth/SendSMSAdvert", ReplyAction="*")]
        Payflow.Notification.sms.incom.SendSMSAdvertResponse SendSMSAdvert(Payflow.Notification.sms.incom.SendSMSAdvertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://203.162.168.170/SendMTAuth/SendSMSAdvert", ReplyAction="*")]
        System.Threading.Tasks.Task<Payflow.Notification.sms.incom.SendSMSAdvertResponse> SendSMSAdvertAsync(Payflow.Notification.sms.incom.SendSMSAdvertRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMS", Namespace="http://203.162.168.170/SendMTAuth/", Order=0)]
        public Payflow.Notification.sms.incom.SendSMSRequestBody Body;
        
        public SendSMSRequest() {
        }
        
        public SendSMSRequest(Payflow.Notification.sms.incom.SendSMSRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://203.162.168.170/SendMTAuth/")]
    public partial class SendSMSRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string account_name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string account_password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string User_ID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Content;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Service_ID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Command_Code;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Request_ID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Message_Type;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Total_Message;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string Message_Index;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string IsMore;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string Content_Type;
        
        public SendSMSRequestBody() {
        }
        
        public SendSMSRequestBody(string account_name, string account_password, string User_ID, string Content, string Service_ID, string Command_Code, string Request_ID, string Message_Type, string Total_Message, string Message_Index, string IsMore, string Content_Type) {
            this.account_name = account_name;
            this.account_password = account_password;
            this.User_ID = User_ID;
            this.Content = Content;
            this.Service_ID = Service_ID;
            this.Command_Code = Command_Code;
            this.Request_ID = Request_ID;
            this.Message_Type = Message_Type;
            this.Total_Message = Total_Message;
            this.Message_Index = Message_Index;
            this.IsMore = IsMore;
            this.Content_Type = Content_Type;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSResponse", Namespace="http://203.162.168.170/SendMTAuth/", Order=0)]
        public Payflow.Notification.sms.incom.SendSMSResponseBody Body;
        
        public SendSMSResponse() {
        }
        
        public SendSMSResponse(Payflow.Notification.sms.incom.SendSMSResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://203.162.168.170/SendMTAuth/")]
    public partial class SendSMSResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int SendSMSResult;
        
        public SendSMSResponseBody() {
        }
        
        public SendSMSResponseBody(int SendSMSResult) {
            this.SendSMSResult = SendSMSResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSAdvertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSAdvert", Namespace="http://203.162.168.170/SendMTAuth/", Order=0)]
        public Payflow.Notification.sms.incom.SendSMSAdvertRequestBody Body;
        
        public SendSMSAdvertRequest() {
        }
        
        public SendSMSAdvertRequest(Payflow.Notification.sms.incom.SendSMSAdvertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://203.162.168.170/SendMTAuth/")]
    public partial class SendSMSAdvertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string account_name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string account_password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Phonenumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Message;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string SendFrom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string CommandCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string RequestID;
        
        public SendSMSAdvertRequestBody() {
        }
        
        public SendSMSAdvertRequestBody(string account_name, string account_password, string Phonenumber, string Message, string SendFrom, string CommandCode, string RequestID) {
            this.account_name = account_name;
            this.account_password = account_password;
            this.Phonenumber = Phonenumber;
            this.Message = Message;
            this.SendFrom = SendFrom;
            this.CommandCode = CommandCode;
            this.RequestID = RequestID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSAdvertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSAdvertResponse", Namespace="http://203.162.168.170/SendMTAuth/", Order=0)]
        public Payflow.Notification.sms.incom.SendSMSAdvertResponseBody Body;
        
        public SendSMSAdvertResponse() {
        }
        
        public SendSMSAdvertResponse(Payflow.Notification.sms.incom.SendSMSAdvertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://203.162.168.170/SendMTAuth/")]
    public partial class SendSMSAdvertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int SendSMSAdvertResult;
        
        public SendSMSAdvertResponseBody() {
        }
        
        public SendSMSAdvertResponseBody(int SendSMSAdvertResult) {
            this.SendSMSAdvertResult = SendSMSAdvertResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service_SendSMSSoapChannel : Payflow.Notification.sms.incom.Service_SendSMSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_SendSMSSoapClient : System.ServiceModel.ClientBase<Payflow.Notification.sms.incom.Service_SendSMSSoap>, Payflow.Notification.sms.incom.Service_SendSMSSoap {
        
        public Service_SendSMSSoapClient() {
        }
        
        public Service_SendSMSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_SendSMSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_SendSMSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_SendSMSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Payflow.Notification.sms.incom.SendSMSResponse Payflow.Notification.sms.incom.Service_SendSMSSoap.SendSMS(Payflow.Notification.sms.incom.SendSMSRequest request) {
            return base.Channel.SendSMS(request);
        }
        
        public int SendSMS(string account_name, string account_password, string User_ID, string Content, string Service_ID, string Command_Code, string Request_ID, string Message_Type, string Total_Message, string Message_Index, string IsMore, string Content_Type) {
            Payflow.Notification.sms.incom.SendSMSRequest inValue = new Payflow.Notification.sms.incom.SendSMSRequest();
            inValue.Body = new Payflow.Notification.sms.incom.SendSMSRequestBody();
            inValue.Body.account_name = account_name;
            inValue.Body.account_password = account_password;
            inValue.Body.User_ID = User_ID;
            inValue.Body.Content = Content;
            inValue.Body.Service_ID = Service_ID;
            inValue.Body.Command_Code = Command_Code;
            inValue.Body.Request_ID = Request_ID;
            inValue.Body.Message_Type = Message_Type;
            inValue.Body.Total_Message = Total_Message;
            inValue.Body.Message_Index = Message_Index;
            inValue.Body.IsMore = IsMore;
            inValue.Body.Content_Type = Content_Type;
            Payflow.Notification.sms.incom.SendSMSResponse retVal = ((Payflow.Notification.sms.incom.Service_SendSMSSoap)(this)).SendSMS(inValue);
            return retVal.Body.SendSMSResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Payflow.Notification.sms.incom.SendSMSResponse> Payflow.Notification.sms.incom.Service_SendSMSSoap.SendSMSAsync(Payflow.Notification.sms.incom.SendSMSRequest request) {
            return base.Channel.SendSMSAsync(request);
        }
        
        public System.Threading.Tasks.Task<Payflow.Notification.sms.incom.SendSMSResponse> SendSMSAsync(string account_name, string account_password, string User_ID, string Content, string Service_ID, string Command_Code, string Request_ID, string Message_Type, string Total_Message, string Message_Index, string IsMore, string Content_Type) {
            Payflow.Notification.sms.incom.SendSMSRequest inValue = new Payflow.Notification.sms.incom.SendSMSRequest();
            inValue.Body = new Payflow.Notification.sms.incom.SendSMSRequestBody();
            inValue.Body.account_name = account_name;
            inValue.Body.account_password = account_password;
            inValue.Body.User_ID = User_ID;
            inValue.Body.Content = Content;
            inValue.Body.Service_ID = Service_ID;
            inValue.Body.Command_Code = Command_Code;
            inValue.Body.Request_ID = Request_ID;
            inValue.Body.Message_Type = Message_Type;
            inValue.Body.Total_Message = Total_Message;
            inValue.Body.Message_Index = Message_Index;
            inValue.Body.IsMore = IsMore;
            inValue.Body.Content_Type = Content_Type;
            return ((Payflow.Notification.sms.incom.Service_SendSMSSoap)(this)).SendSMSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Payflow.Notification.sms.incom.SendSMSAdvertResponse Payflow.Notification.sms.incom.Service_SendSMSSoap.SendSMSAdvert(Payflow.Notification.sms.incom.SendSMSAdvertRequest request) {
            return base.Channel.SendSMSAdvert(request);
        }
        
        public int SendSMSAdvert(string account_name, string account_password, string Phonenumber, string Message, string SendFrom, string CommandCode, string RequestID) {
            Payflow.Notification.sms.incom.SendSMSAdvertRequest inValue = new Payflow.Notification.sms.incom.SendSMSAdvertRequest();
            inValue.Body = new Payflow.Notification.sms.incom.SendSMSAdvertRequestBody();
            inValue.Body.account_name = account_name;
            inValue.Body.account_password = account_password;
            inValue.Body.Phonenumber = Phonenumber;
            inValue.Body.Message = Message;
            inValue.Body.SendFrom = SendFrom;
            inValue.Body.CommandCode = CommandCode;
            inValue.Body.RequestID = RequestID;
            Payflow.Notification.sms.incom.SendSMSAdvertResponse retVal = ((Payflow.Notification.sms.incom.Service_SendSMSSoap)(this)).SendSMSAdvert(inValue);
            return retVal.Body.SendSMSAdvertResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Payflow.Notification.sms.incom.SendSMSAdvertResponse> Payflow.Notification.sms.incom.Service_SendSMSSoap.SendSMSAdvertAsync(Payflow.Notification.sms.incom.SendSMSAdvertRequest request) {
            return base.Channel.SendSMSAdvertAsync(request);
        }
        
        public System.Threading.Tasks.Task<Payflow.Notification.sms.incom.SendSMSAdvertResponse> SendSMSAdvertAsync(string account_name, string account_password, string Phonenumber, string Message, string SendFrom, string CommandCode, string RequestID) {
            Payflow.Notification.sms.incom.SendSMSAdvertRequest inValue = new Payflow.Notification.sms.incom.SendSMSAdvertRequest();
            inValue.Body = new Payflow.Notification.sms.incom.SendSMSAdvertRequestBody();
            inValue.Body.account_name = account_name;
            inValue.Body.account_password = account_password;
            inValue.Body.Phonenumber = Phonenumber;
            inValue.Body.Message = Message;
            inValue.Body.SendFrom = SendFrom;
            inValue.Body.CommandCode = CommandCode;
            inValue.Body.RequestID = RequestID;
            return ((Payflow.Notification.sms.incom.Service_SendSMSSoap)(this)).SendSMSAdvertAsync(inValue);
        }
    }
}