﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8000/GettingStarted/", ConfigurationName="MyWebService")]
public interface MyWebService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8000/GettingStarted/MyWebService/Add", ReplyAction="http://localhost:8000/GettingStarted/MyWebService/AddResponse")]
    double Add(double n1, double n2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8000/GettingStarted/MyWebService/Add", ReplyAction="http://localhost:8000/GettingStarted/MyWebService/AddResponse")]
    System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8000/GettingStarted/MyWebService/HelloWorld", ReplyAction="http://localhost:8000/GettingStarted/MyWebService/HelloWorldResponse")]
    string HelloWorld();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8000/GettingStarted/MyWebService/HelloWorld", ReplyAction="http://localhost:8000/GettingStarted/MyWebService/HelloWorldResponse")]
    System.Threading.Tasks.Task<string> HelloWorldAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface MyWebServiceChannel : MyWebService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MyWebServiceClient : System.ServiceModel.ClientBase<MyWebService>, MyWebService
{
    
    public MyWebServiceClient()
    {
    }
    
    public MyWebServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MyWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double Add(double n1, double n2)
    {
        return base.Channel.Add(n1, n2);
    }
    
    public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2)
    {
        return base.Channel.AddAsync(n1, n2);
    }
    
    public string HelloWorld()
    {
        return base.Channel.HelloWorld();
    }
    
    public System.Threading.Tasks.Task<string> HelloWorldAsync()
    {
        return base.Channel.HelloWorldAsync();
    }
}
