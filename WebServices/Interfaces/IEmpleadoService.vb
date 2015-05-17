Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IEmpleadoService" in both code and config file together.
<ServiceContract()>
Public Interface IEmpleadoService

    <OperationContract()> _
    <WebInvoke(BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", ResponseFormat:=WebMessageFormat.Xml, UriTemplate:="Empleados/{EmpleadoID}")> _
    Function GetEmpleado(ByVal EmpleadoId As String) As String

End Interface
