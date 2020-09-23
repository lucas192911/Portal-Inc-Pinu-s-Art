Public Class Encargo

    Private Sub Encargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String = <a>select nombre as Nombre,
                                    fecha as Fecha, 
                                    presupuesto as Presupuesto,
                                    descripcion as Descripcion 
                                    from encargo</a>

        Me.dtgMostrar.DataSource = Consulta(s)


    End Sub
End Class