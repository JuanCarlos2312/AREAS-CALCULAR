//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculoAreas.ServiceReferenceAreas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceAreas.WebServiceAreaSoap")]
    public interface WebServiceAreaSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento EstudianteResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Estudiante", ReplyAction="*")]
        CalculoAreas.ServiceReferenceAreas.EstudianteResponse Estudiante(CalculoAreas.ServiceReferenceAreas.EstudianteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Estudiante", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculoAreas.ServiceReferenceAreas.EstudianteResponse> EstudianteAsync(CalculoAreas.ServiceReferenceAreas.EstudianteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CUADRADO", ReplyAction="*")]
        int CUADRADO(int LADO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CUADRADO", ReplyAction="*")]
        System.Threading.Tasks.Task<int> CUADRADOAsync(int LADO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TRIANGULO", ReplyAction="*")]
        int TRIANGULO(int BASE, int ALTURA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TRIANGULO", ReplyAction="*")]
        System.Threading.Tasks.Task<int> TRIANGULOAsync(int BASE, int ALTURA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CIRCULO", ReplyAction="*")]
        double CIRCULO(double RADIO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CIRCULO", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CIRCULOAsync(double RADIO);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EstudianteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Estudiante", Namespace="http://tempuri.org/", Order=0)]
        public CalculoAreas.ServiceReferenceAreas.EstudianteRequestBody Body;
        
        public EstudianteRequest() {
        }
        
        public EstudianteRequest(CalculoAreas.ServiceReferenceAreas.EstudianteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class EstudianteRequestBody {
        
        public EstudianteRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EstudianteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EstudianteResponse", Namespace="http://tempuri.org/", Order=0)]
        public CalculoAreas.ServiceReferenceAreas.EstudianteResponseBody Body;
        
        public EstudianteResponse() {
        }
        
        public EstudianteResponse(CalculoAreas.ServiceReferenceAreas.EstudianteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EstudianteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EstudianteResult;
        
        public EstudianteResponseBody() {
        }
        
        public EstudianteResponseBody(string EstudianteResult) {
            this.EstudianteResult = EstudianteResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceAreaSoapChannel : CalculoAreas.ServiceReferenceAreas.WebServiceAreaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceAreaSoapClient : System.ServiceModel.ClientBase<CalculoAreas.ServiceReferenceAreas.WebServiceAreaSoap>, CalculoAreas.ServiceReferenceAreas.WebServiceAreaSoap {
        
        public WebServiceAreaSoapClient() {
        }
        
        public WebServiceAreaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceAreaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAreaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAreaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalculoAreas.ServiceReferenceAreas.EstudianteResponse CalculoAreas.ServiceReferenceAreas.WebServiceAreaSoap.Estudiante(CalculoAreas.ServiceReferenceAreas.EstudianteRequest request) {
            return base.Channel.Estudiante(request);
        }
        
        public string Estudiante() {
            CalculoAreas.ServiceReferenceAreas.EstudianteRequest inValue = new CalculoAreas.ServiceReferenceAreas.EstudianteRequest();
            inValue.Body = new CalculoAreas.ServiceReferenceAreas.EstudianteRequestBody();
            CalculoAreas.ServiceReferenceAreas.EstudianteResponse retVal = ((CalculoAreas.ServiceReferenceAreas.WebServiceAreaSoap)(this)).Estudiante(inValue);
            return retVal.Body.EstudianteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalculoAreas.ServiceReferenceAreas.EstudianteResponse> CalculoAreas.ServiceReferenceAreas.WebServiceAreaSoap.EstudianteAsync(CalculoAreas.ServiceReferenceAreas.EstudianteRequest request) {
            return base.Channel.EstudianteAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculoAreas.ServiceReferenceAreas.EstudianteResponse> EstudianteAsync() {
            CalculoAreas.ServiceReferenceAreas.EstudianteRequest inValue = new CalculoAreas.ServiceReferenceAreas.EstudianteRequest();
            inValue.Body = new CalculoAreas.ServiceReferenceAreas.EstudianteRequestBody();
            return ((CalculoAreas.ServiceReferenceAreas.WebServiceAreaSoap)(this)).EstudianteAsync(inValue);
        }
        
        public int CUADRADO(int LADO) {
            return base.Channel.CUADRADO(LADO);
        }
        
        public System.Threading.Tasks.Task<int> CUADRADOAsync(int LADO) {
            return base.Channel.CUADRADOAsync(LADO);
        }
        
        public int TRIANGULO(int BASE, int ALTURA) {
            return base.Channel.TRIANGULO(BASE, ALTURA);
        }
        
        public System.Threading.Tasks.Task<int> TRIANGULOAsync(int BASE, int ALTURA) {
            return base.Channel.TRIANGULOAsync(BASE, ALTURA);
        }
        
        public double CIRCULO(double RADIO) {
            return base.Channel.CIRCULO(RADIO);
        }
        
        public System.Threading.Tasks.Task<double> CIRCULOAsync(double RADIO) {
            return base.Channel.CIRCULOAsync(RADIO);
        }
    }
}
