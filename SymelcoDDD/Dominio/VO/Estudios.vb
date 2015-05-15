Public Class Estudios
    Implements ICertificacion

    Public Property FechaExpedicion As Date? Implements ICertificacion.FechaExpedicion

    Public Property FechaVencimiento As Date? Implements ICertificacion.FechaVencimiento

    Public Property CertificacionId As Int32 Implements ICertificacion.CertificacionId

    Public Property Institucion As InstitucionesEducativas

End Class
