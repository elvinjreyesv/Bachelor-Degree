Imports System.Data.SqlClient
Module Comun
    Public mayor As Integer
    Public codigo As Integer
    Public codsupl As Integer = 4
    Public codart As Integer
    Public docu As String
    Public result As Boolean
    Public tip As Integer
    Public cr As String
    Public lote As String
    Public codcli As Integer = 0
    Public numcon As Integer = 0
    Public codtanda As Integer = 0
    'Public CargarReporte As New CrFactura
    'Public rptcoti As New CrCotizacion
    Public Function discreta(ByVal a, ByVal b)
        Dim r As Double = Rnd()
        Dim val As Double
        val = a + r * (b - a)
        Return val
    End Function
    Public Function tdisponible(codcorrida As Integer, tipo As Integer) As DataSet
        ' tdisponible(CInt(txtCorrida.Text), CajDisp, CoTipo)
        'Dim s As String = "select t.codtecnico,t.tocio,t.tocupado from tecnicos t inner join tecnico_tipoequipo tt on t.codtecnico=tt.codtecnico where tt.tipequipo= " & tipo & ""
        Dim s As String = "select * from tecnicos  where tipequipo=" & tipo & ""
        oDataAdapter = New SqlDataAdapter(s, oConexion)
        oDataSet = New DataSet
        oDataAdapter.Fill(oDataSet)
        Return oDataSet

    End Function

    'genera_fallo
    Public Function generaservicio(num As Integer, ByRef cant As Integer) As Integer
        Dim tip As Integer = 0
        oDataAdapter = New SqlDataAdapter("exec genera_fallo " & num & "", oConexion)
        oDataSet = New DataSet
        oDataAdapter.Fill(oDataSet)
        Dim row As DataRow
        For Each row In oDataSet.Tables(0).Rows
            If row.IsNull("tipo") Then
                Return 0
                'Return cant
            Else
                cant = row("cantidad")
                tip = row("tipo")
            End If
        Next
        Return tip



    End Function
    'selectTecnico()
    'Public Function selectTecnico(num As Integer, tip As Integer, llega As Double) As Double
    '    Dim tini As Double = 0.0
    '    Dim s As String = "exec selec_tecnico " & llega & " ," & tip & "," & num & ""
    '    oDataAdapter = New SqlDataAdapter(s, oConexion)
    '    oDataSet = New DataSet
    '    oDataAdapter.Fill(oDataSet)
    '    Dim row As DataRow
    '    For Each row In oDataSet.Tables(0).Rows
    '        If row.IsNull("tini") Then
    '            Return 0
    '            'Return cant
    '        Else
    '            tini = row("tini")
    '        End If
    '    Next
    '    Return tini
    'End Function
    Public Sub SelTecnico(ByVal CodCorrida As Integer, ByVal tipo As Integer, ByVal Cantidad As Integer, ByVal TiempoD As DataSet, ByRef tecnico As Integer, ByRef Tllegada As Double, ByRef Tinicio As Double, ByRef Tespera As Double, ByVal TServicio As Double)
        Dim Libre As Boolean
        Dim Menor As Double
        Dim Tocio As Double
        Dim ocupada As Double
        Dim row As DataRow = Nothing
        Dim Disponible As New ArrayList
        For Each row In TiempoD.Tables(0).Rows
            ocupada = row("tocupado")
            If Tllegada > CDbl(row("tocupado")) Then

                tecnico = CInt(row("Codtecnico"))
                Libre = True
                Tinicio = Tllegada
                Tocio = Tllegada - ocupada
                Exit For
            Else
                Disponible.Add(CDbl(row("tocupado")) - Tllegada)
            End If

        Next

        If Not Libre Then
            'For I = 1 To Cantidad
            Dim I As Integer = 0
            For Each row In TiempoD.Tables(0).Rows
                I = I + 1
                If I = 1 Then
                    Menor = CDbl(row("tocupado"))
                Else
                    If CDbl(Disponible.Item(I - 1)) < Menor Then
                        Menor = CDbl(Disponible.Item(I - 1))
                        tecnico = I
                    End If
                End If
            Next
            Tinicio = CDbl(row("tocupado").ToString)
        End If

        Tespera = Tinicio - Tllegada
        ocupada = ocupada + TServicio
        EjectComand("update tecnicos set Tocio= " & Tocio & ",tocupado = tocupado + " & ocupada & _
                    " where Codtecnico = " & tecnico & " and tipequipo =" & tipo)

    End Sub
    Public Sub EjectComand(s As String)
        oConexion.Open()
        oComando = New SqlCommand(s, oConexion)
        oComando.ExecuteNonQuery()
        oConexion.Close()
    End Sub
    Public Function generaTenLlegadas(tanda As Integer) As Double
        Dim tel As Double = 0.0
        oDataAdapter = New SqlDataAdapter("exec generallegada " & tanda & "", oConexion)
        oDataSet = New DataSet
        oDataAdapter.Fill(oDataSet)
        Dim row As DataRow
        For Each row In oDataSet.Tables(0).Rows
            If row.IsNull("llega") Then
                Return 0
                'Return cant
            Else
                tel = row("llega")
            End If
        Next
        Return tel
    End Function
    Public Sub tipEquipo(ByRef txt As TextBox, ByVal tan As Integer)
        oDataSet = New DataSet
        oDataAdapter = New SqlDataAdapter("exec generallegada " & tan & "", oConexion)
        oDataAdapter.Fill(oDataSet)
        Dim row As DataRow
        row = Nothing
        For Each row In oDataSet.Tables(0).Rows
            txt.Text = row("llega").ToString.Trim


        Next
    End Sub
    Public Class equipoServicio
        Private numero As Integer
        Private Tenllegadas As Double
        Private TLlegada As Double
        Private TEspera As Double
        Private TInicio As Double
        Private TTermino As Double
        Private TServicio As Double
        Private codfallo As Integer
        Private Ttolerancia As Double
        Private Tsistema As Double
        Private CodTecnico As Integer
        Public Property ETsistema() As Double
            Get
                Return Tsistema
            End Get
            Set(ByVal value As Double)
                Tsistema = value
            End Set
        End Property
        Public Property ETenllegadas() As Double
            Get
                Return Tenllegadas
            End Get
            Set(ByVal value As Double)
                Tenllegadas = value
            End Set
        End Property
        Public Property ECodTecnico() As Integer
            Get
                Return CodTecnico
            End Get
            Set(ByVal value As Integer)
                CodTecnico = value
            End Set
        End Property
        Public Property ECodEquipo() As Integer
            Get
                Return numero
            End Get
            Set(ByVal value As Integer)
                numero = value
            End Set
        End Property
        Public Property ETiempoLlegada() As Double
            Get
                Return TLlegada
            End Get
            Set(ByVal value As Double)
                TLlegada = value
            End Set
        End Property
        Public Property ETiempoEspera() As Double
            Get
                Return TEspera
            End Get
            Set(ByVal value As Double)
                TEspera = value
            End Set
        End Property
        Public Property ETiempoInicio() As Double
            Get
                Return TInicio
            End Get
            Set(ByVal value As Double)
                TInicio = value
            End Set
        End Property
        Public Property ETiempoTermin() As Double
            Get
                Return TTermino
            End Get
            Set(ByVal value As Double)
                TTermino = value
            End Set
        End Property
        Public Property ETiempoServicio() As Double
            Get
                Return TServicio
            End Get
            Set(ByVal value As Double)
                TServicio = value
            End Set
        End Property
        Public Property EcodFallo() As Integer
            Get
                Return codfallo
            End Get
            Set(ByVal value As Integer)
                codfallo = value
            End Set
        End Property
        Public Property ETolerancia() As Double
            Get
                Return Ttolerancia
            End Get
            Set(ByVal value As Double)
                Ttolerancia = value
            End Set
        End Property
        Public Function actualizar(ByVal CODIGO As Integer, Optional ByVal codequipo As Integer = 0, Optional ByVal FILTRO As String = "", Optional ByVal ORDEN As String = "DescripcionTipoServicio") As Boolean
            Dim oConfig As New DataSet
            Dim row As DataRow, FiltCli$
            FiltCli = ""
            actualizar = False
            Try
                If codequipo > 0 Then
                    FiltCli = " AND CodCliente = " & codequipo
                End If
                ReturnTabla(oConfig, "Select * from equipo_servi where numero =" & CODIGO & FiltCli)
                For Each row In oConfig.Tables(0).Rows
                    numero = CInt(row("codequipo"))
                    TLlegada = CDbl(row("tllegada"))
                    TInicio = CDbl(row("tinicio"))
                    TEspera = CDbl(row("tespera"))
                    TServicio = CDbl(row("tservicio"))
                    Ttolerancia = CDbl(row("ttolerancia"))
                    TTermino = CDbl(row("ttermino"))
                    codfallo = CInt(row("codfallo"))
                Next
                If oConfig.Tables(0).Rows.Count > 0 Then
                    actualizar = True
                End If
            Catch oExep As SqlException
                MessageBox.Show("Error al conectar con datos" & ControlChars.CrLf & oExep.Message)
                'If GuardaErrores Then ControlErrores("Consultar Configuracion", oExep.Message)
                actualizar = False
            End Try
        End Function




    End Class
    Public Class corridas
        Private CodCorrida As Integer
        Private CodServicio As Integer
        Private CodEquipo As Integer
        Private IAT As Double
        Private TiempoLlegada As Double
        Private TiempoInicio As Double
        Private TiempoOcio As Double
        Private TiempoEspera As Double
        Private TiempoServicio As Double
        Private TiempoRetraso As Double
        Private TiempoTermin As Double
        Private TiempoSistema As Double
        Private codtecnico As Integer
        Private codcliente As Integer
        Private CantProbl As Integer
        Private Codfallo As Integer
        Private TiempoEnLlegadas As Double
        Public Property PCodfallo() As Integer
            Get
                Return Codfallo
            End Get
            Set(ByVal value As Integer)
                Codfallo = value
            End Set
        End Property
        Public Property Pcodcliente() As Integer
            Get
                Return codcliente
            End Get
            Set(ByVal value As Integer)
                codcliente = value
            End Set
        End Property
        Public Property PCodCorrida() As Integer
            Get
                Return CodCorrida
            End Get
            Set(ByVal value As Integer)
                CodCorrida = value
            End Set
        End Property
        ' pTiempoEnLlegadas
        Public Property pTiempoEnLlegadas() As Double
            Get
                Return TiempoEnLlegadas
            End Get
            Set(ByVal value As Double)
                TiempoEnLlegadas = value
            End Set
        End Property
        Public Property PCodEquipo() As Integer
            Get
                Return CodEquipo
            End Get
            Set(ByVal value As Integer)
                CodEquipo = value
            End Set
        End Property
        Public Property PIAT() As Double
            Get
                Return IAT
            End Get
            Set(ByVal value As Double)
                IAT = value
            End Set
        End Property
        Public Property PTiempoLlegada() As Double
            Get
                Return TiempoLlegada
            End Get
            Set(ByVal value As Double)
                TiempoLlegada = value
            End Set
        End Property
        Public Property PTiempoOcio() As Double
            Get
                Return TiempoOcio
            End Get
            Set(ByVal value As Double)
                TiempoOcio = value
            End Set
        End Property
        Public Property PTiempoEspera() As Double
            Get
                Return TiempoEspera
            End Get
            Set(ByVal value As Double)
                TiempoEspera = value
            End Set
        End Property
        Public Property PTiempoServicio() As Double
            Get
                Return TiempoServicio
            End Get
            Set(ByVal value As Double)
                TiempoServicio = value
            End Set
        End Property
        'Public Property PTiempoRetraso() As Double
        '    Get
        '        Return TiempoRetraso
        '    End Get
        '    Set(ByVal value As Double)
        '        TiempoRetraso = value
        '    End Set
        'End Property
        Public Property PTiempoTermin() As Double
            Get
                Return TiempoTermin
            End Get
            Set(ByVal value As Double)
                TiempoTermin = value
            End Set
        End Property
        Public Property PTiempoSistema() As Double
            Get
                Return TiempoSistema
            End Get
            Set(ByVal value As Double)
                TiempoSistema = value
            End Set
        End Property
        Public Property Pcodtecnico() As Integer
            Get
                Return codtecnico
            End Get
            Set(ByVal value As Integer)
                codtecnico = value
            End Set
        End Property
        Public Property PCantProbl() As Integer
            Get
                Return CantProbl
            End Get
            Set(ByVal value As Integer)
                CantProbl = value
            End Set
        End Property
        Public Property PTiempoInicio() As Double
            Get
                Return TiempoInicio
            End Get
            Set(ByVal value As Double)
                TiempoInicio = value
            End Set
        End Property
        Public Function Guardar() As Boolean
            Guardar = False
            Dim SqlString As String = ""
            Dim ListSqlStrings As New ArrayList
            Try
                SqlString = "EXEC insertar_datos " & _
                     "@tabla='resultados'," & _
                     "@cambios1='codcorrida=''" & PCodCorrida & "'',codfallo=''" & PCodfallo & "'',codcliente=''" & Pcodcliente & "'', codequipo=''" & PCodEquipo & "'', tenllegadas=''" & pTiempoEnLlegadas & "'', Tllegada=''" & PTiempoLlegada & "'', TInicio=''" & PTiempoInicio & "'', TOcio=''" & PTiempoOcio & "'', TEspera=''" & PTiempoEspera & "'', TServicio=''" & PTiempoServicio & "'',  tfinalizacion=''" & PTiempoTermin & "'', TSistema=''" & PTiempoSistema & "'', Codtecnico=''" & Pcodtecnico & "'', CantProbl=''" & PCantProbl & "'''," & _
                     "@cambios2=''," & _
                     "@condicion='CodCorrida=''" & PCodCorrida & "'' and codcliente=''" & Pcodcliente & "'''," & _
                     "@campos='Codcorrida, codcliente,codequipo,codfallo,tinicio, tenllegadas, Tllegada, TOcio, TEspera, TServicio, tfinalizacion, TSistema, codtecnico, CantProbl'," & _
                     "@valores1='''" & PCodCorrida & "'',''" & Pcodcliente & "'',''" & PCodEquipo & "'',''" & PCodfallo & "'',''" & PTiempoInicio & "'' , ''" & pTiempoEnLlegadas & "'', ''" & PTiempoLlegada & "'', ''" & PTiempoOcio & "'', ''" & PTiempoEspera & "'', ''" & PTiempoServicio & "'',''" & PTiempoTermin & "'', ''" & PTiempoSistema & "'', ''" & Pcodtecnico & "'', ''" & CantProbl & "'''," & _
                     "@valores2=''"
                ListSqlStrings.Add(SqlString)
                If EjecutarTransaccion(ListSqlStrings) Then
                    Guardar = True
                Else
                    Guardar = False
                End If
            Catch oExep As SqlException
                MessageBox.Show("Error al conectar con datos" & ControlChars.CrLf & oExep.Message)
                Guardar = False
            End Try
        End Function
        'Public Function Guardar() As Boolean
        '    Guardar = False
        '    Dim SqlString As String = ""
        '    Dim ListSqlStrings As New ArrayList
        '    Try
        '        SqlString = "EXEC insertar_datos " & _
        '             "@tabla='Tipo_Servicios'," & _
        '             "@cambios1='DescripcionTipoServicio=''" & PDescripcionTipoServicio & "'', IdTipoServicio=''" & PIdTipoServicio & "'''," & _
        '             "@cambios2=''," & _
        '             "@condicion='CodigoTipoServicio=" & PCodigoTipoServicio & "'," & _
        '             "@campos='DescripcionTipoServicio,IdTipoServicio'," & _
        '             "@valores1='''" & PDescripcionTipoServicio & "'', ''" & PIdTipoServicio & "'''," & _
        '             "@valores2=''"
        '        ListSqlStrings.Add(SqlString)
        '        If EjecutarTransaccion(ListSqlStrings) Then
        '            Guardar = True
        '        Else
        '            Guardar = False
        '        End If
        '    Catch oExep As SqlException
        '        MessageBox.Show("Error al conectar con datos" & ControlChars.CrLf & oExep.Message)
        '        Guardar = False
        '    End Try
        'End Function

        Public Function Consultar(ByVal CODIGO As Integer, Optional ByVal codequipo As Integer = 0, Optional ByVal FILTRO As String = "", Optional ByVal ORDEN As String = "DescripcionTipoServicio") As Boolean
            Dim oConfig As New DataSet
            Dim row As DataRow, FiltCli$
            FiltCli = ""
            Consultar = False
            Try
                If codequipo > 0 Then
                    FiltCli = " AND CodCliente = " & codequipo
                End If
                ReturnTabla(oConfig, "Select * from resultados where CodCorrida =" & CODIGO & FiltCli)
                For Each row In oConfig.Tables(0).Rows
                    CodCorrida = CInt(row("Codcorrida"))
                    CodServicio = CInt(row("Codfallo"))
                    codequipo = CInt(row("codequipo"))
                    TiempoLlegada = CDbl(row("tllegada"))
                    TiempoInicio = CDbl(row("tinicio"))
                    TiempoOcio = CDbl(row("tocio"))
                    TiempoEspera = CDbl(row("tespera"))
                    TiempoServicio = CDbl(row("tservicio"))
                    'TiempoRetraso = CDbl(row("TiempoRetraso"))
                    TiempoTermin = CDbl(row("tfinalizacion"))
                    TiempoSistema = CDbl(row("tsistema"))
                    codtecnico = CInt(row("codtecnico"))
                    CantProbl = CInt(row("CantProbl"))
                    codcliente = CInt(row("codcliente"))
                    pTiempoEnLlegadas = CDbl(row("tenllegadas"))
                Next
                If oConfig.Tables(0).Rows.Count > 0 Then
                    Consultar = True
                End If
            Catch oExep As SqlException
                MessageBox.Show("Error al conectar con datos" & ControlChars.CrLf & oExep.Message)
                'If GuardaErrores Then ControlErrores("Consultar Configuracion", oExep.Message)
                Consultar = False
            End Try
        End Function
    End Class

    Public Function ReturnTable(ByVal DBQuery As String, ByVal QueryTable As String) As DataSet
        Dim Ds As New DataSet()
        oDataAdapter = New SqlDataAdapter(DBQuery, oConexion)
        oDataAdapter.Fill(Ds, QueryTable)
        oDataAdapter = Nothing
        oConexion.Close()
        Return Ds
    End Function
    REM retornar una tabla 
    Public Sub ReturnTabla(ByRef oConfig As DataSet, ByVal sSql As String)
        Try
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            ' oDataSet = New DataSet
            oDataAdapter.Fill(oConfig)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub Seleccionar3(ByVal Grd As DataGridView, ByVal oForm As Form)
        Dim i As Integer
        For i = 0 To Grd.Rows.Count - 1
            If Grd.Rows.Item(i).Selected Then
                codigo = CInt(Grd.Item(0, i).Value)
                Exit For
            End If
        Next
        oForm.Dispose()
    End Sub
    Public Sub ValidarDatos(ByVal ofrm As Form, ByVal oError As ErrorProvider)
        For Each c As Control In ofrm.Controls

            If TypeOf c Is TextBox Then
                If c.Text = "" Then
                    oError.SetError(c, "ERROR, Campo en Vacio")
                Else
                    oError.SetError(c, Nothing)
                End If
            End If
            If TypeOf c Is NumericUpDown Then
                If c.Text = CStr(0) Then
                    oError.SetError(c, "ERROR, Campo en Vacio")
                Else
                    oError.SetError(c, Nothing)
                End If
            End If
            If TypeOf c Is ComboBox Then
                If c.Text = "" Then
                    oError.SetError(c, "ERROR, Campo en Vacio")
                Else
                    oError.SetError(c, Nothing)
                End If
            End If
        Next
    End Sub
    Public Sub insertadir(ByVal txt As TextBox, ByVal cod As Integer)
        Dim str As String

        str = "select d.dirter,se.dessec,ci.nomciu,pr.despro,pa.nompai from direccion d  " & _
            "inner join sector se on d.codsec=se.codsec " & _
            "inner join ciudades ci on se.codciu=ci.codciu inner join provincias pr on ci.codprov=pr.codprov " & _
            "inner join paises pa on pr.codpais=pa.codpai where d.codter= " & cod & ""
        oDataAdapter = New SqlDataAdapter(str, oConexion)
        oDataSet = New DataSet
        oDataAdapter.Fill(oDataSet)

        Dim row As DataRow
        row = Nothing
        For Each row In oDataSet.Tables(0).Rows
            txt.Text = row("dirter").ToString + " , " + row("dessec").ToString + " , " + row("nomciu").ToString + " , " + row("despro").ToString + " , " + row("nompai").ToString
        Next

    End Sub
    Public Sub llenarDocumentos(ByVal grdDocumen As DataGridView, ByVal cod As String)
        If cod <> Nothing Then
            Dim sSql As String = "select  dt.docter as numero,do.doc as tipo,do.tipdoc as cTipo,t.codter  " & _
                    "from documentos_tercero dt inner join documentos do on dt.tipdoc=do.tipdoc inner join tercero t on dt.codter=t.codter " & _
                    "WHERE t.codter= " & cod.Trim & " "
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            oConexion.Open()
            tDataset = New DataSet
            oDataAdapter.Fill(tDataset, "Documentos")
            oConexion.Close()
            grdDocumen.DataSource = tDataset
            grdDocumen.DataMember = "Documentos"
            grdDocumen.Columns(2).Visible = False
            grdDocumen.Columns(3).Visible = False
        End If
    End Sub
    Public Sub llenarTelefonos(ByVal grdTel As DataGridView, ByVal cod As String)
        If cod <> Nothing Then
            Dim sSql As String = "select  tvt.numtel as numero,tt.destip as tipo,tt.tiptel as cTipo " & _
                    "from telefonos_terceros tvt inner join tipo_telefono tt on tt.tiptel=tvt.tiptel " & _
                    "inner join tercero te on te.codter=tvt.codter  " & _
                    "WHERE tvt.codter= " & cod.Trim & " "
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            oConexion.Open()
            tDataset = New DataSet
            oDataAdapter.Fill(tDataset, "Telefono")
            oConexion.Close()
            grdTel.DataSource = tDataset
            grdTel.DataMember = "Telefono"
            grdTel.Columns(2).Visible = False
            'grdTel.Columns(3).Visible = False
        End If

    End Sub
    Public Sub llenaGrid(ByVal grid As DataGridView)

        Dim sSql As String = "select * from resultados"
        oDataAdapter = New SqlDataAdapter(sSql, oConexion)
        oConexion.Open()
        eDataset = New DataSet
        oDataAdapter.Fill(eDataset, "resultados")
        oConexion.Close()
        grid.DataSource = eDataset
        grid.DataMember = "resultados"
        'grdmail.Columns(0).Visible = False

    End Sub
    Public Sub ValidarForm(ByVal oForm As Form)
        For Each c As Control In oForm.Controls
            If TypeOf c Is TabControl Then
                For Each t As Control In CType(c, TabControl).Controls
                    If TypeOf t Is TabPage Then
                        For Each tp As Control In CType(t, TabPage).Controls
                            If TypeOf tp Is GroupBox Then
                                For Each g As Control In CType(tp, GroupBox).Controls
                                    If TypeOf g Is TextBox Or TypeOf g Is ComboBox Or TypeOf g Is MaskedTextBox Then
                                        g.Text = ""
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    Public Sub LimpiarCampos(ByVal ofrm As Form)
        For Each c As Control In ofrm.Controls
            If TypeOf c Is GroupBox Then
                For Each g As Control In CType(c, GroupBox).Controls
                    If TypeOf g Is TextBox Or TypeOf g Is MaskedTextBox Then
                        g.Text = ""
                    End If
                Next
            End If
        Next
    End Sub
    Public Sub LimpiaTxt(ByVal grp As Form)
        For Each c As Control In grp.Controls
            If TypeOf c Is GroupBox Then
                For Each d As Control In CType(c, GroupBox).Controls
                    If TypeOf d Is TextBox Or TypeOf d Is ComboBox Or TypeOf d Is MaskedTextBox Then
                        d.Text = ""
                    End If
                Next
            End If
        Next
    End Sub
    Public Sub Llenarcombos(ByVal combo As ComboBox, ByVal ssql As String, ByVal Display As String, ByVal value As String)
        Try
            oDataAdapter = New SqlDataAdapter(ssql, oConexion)

            oDataSet = New DataSet
            oDataAdapter.Fill(oDataSet)
            combo.DataSource = oDataSet.Tables(0)
            combo.DisplayMember = Display
            combo.ValueMember = value
        Catch oExep As SqlException
            MessageBox.Show("Error al conectar con datos" & ControlChars.CrLf & oExep.Message)
        End Try
        combo.SelectedValue = 0

    End Sub
    'sub valida los groupbox
    Public Sub ValidarGroupBox(ByVal oError As ErrorProvider, ByVal oGroup As GroupBox)
        For Each c As Control In oGroup.Controls

            If TypeOf c Is TextBox Then
                If c.Text = "" Then
                    oError.SetError(c, "ERROR, Campo en Vacio")
                Else
                    oError.SetError(c, Nothing)
                End If
            End If
            If TypeOf c Is NumericUpDown Then
                If c.Text = CStr(0) Then
                    oError.SetError(c, "ERROR, Campo en Vacio")
                Else
                    oError.SetError(c, Nothing)
                End If
            End If
            If TypeOf c Is ComboBox Then
                If c.Text = "" Then
                    oError.SetError(c, "ERROR, Campo en Vacio")
                Else
                    oError.SetError(c, Nothing)
                End If
            End If
            If TypeOf c Is MaskedTextBox Then
                If c.Text = "" Then
                    oError.SetError(c, "ERROR, Campo en Vacio")
                Else
                    oError.SetError(c, Nothing)
                End If
            End If
        Next

    End Sub
    Public Sub Validar2(ByVal oGroup As GroupBox)
        For Each c As Control In oGroup.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Or TypeOf c Is MaskedTextBox Then
                If c.Text = "" Then
                    result = True
                End If
            End If
        Next
    End Sub

    REM bloque groupbox
    Sub bloqinac(ByVal group As GroupBox, ByVal es As String)

        If es = "False" Then
            group.Enabled = False
        Else
            group.Enabled = True
        End If
    End Sub
    REM valida mail

    Public Function Validar_Mail(ByVal Mail As String) As Boolean
        ' Retorna True o False
        Return System.Text.RegularExpressions.Regex.IsMatch(Mail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
    Function soloNumero(ByVal keyascii As Short) As Short
        If InStr("1234567890", Chr(keyascii)) = 0 Then
            soloNumero = 0
        Else
            soloNumero = keyascii
        End If
        Select Case keyascii
            Case 8
                soloNumero = keyascii
            Case 13
                soloNumero = keyascii
        End Select
    End Function
    REM NUEVAS FUNCIONES 
    Public Function Secuencia(ByVal num As String) As String
        Dim k As String
        Dim a As Integer
        Dim s As String
        Dim sec As String
        sec = "0000000" & num

        If CDbl(num) > 9 And CDbl(num) < 99 Then
            sec = "000000" & num
        End If

        If CDbl(num) > 99 And CDbl(num) < 999 Then
            sec = "00000" & num
        End If

        If CDbl(num) > 999 And CDbl(num) < 9999 Then
            sec = "0000" & num
        End If

        If CDbl(num) > 99999 And CDbl(num) < 999999 Then
            sec = "00" & num
        End If

        If CDbl(num) > 9999999 And CDbl(num) < 99999999 Then
            sec = num
        End If


        k = "1" & sec
        a = CInt(k) + 1
        s = a.ToString.Substring(1, 8)
        Return s
    End Function
    'SUB QUE RETORNA EL MAYOR DE UNA TABLA
    Public Function retornaint(ByVal combo As ComboBox) As Integer
        Dim ssql As String = "exec genera_cantequipos " & combo.SelectedValue & ""
        Dim cant As Integer = 0
        oDataAdapter = New SqlDataAdapter(ssql, oConexion)
        oDataSet = New DataSet
        oDataAdapter.Fill(oDataSet)
        Dim row As DataRow
        For Each row In oDataSet.Tables(0).Rows
            If row.IsNull("cantidad") Then
                Return 0
                'Return cant
            Else
                cant = row("cantidad")
            End If
        Next
        Return cant
    End Function
    Public Function BuscaMayor(ByVal sSql As String) As Integer
        'Dim ssql As String = sSqll
        Dim mayor As Integer = 0
        oDataAdapter = New SqlDataAdapter(sSql, oConexion)
        oDataSet = New DataSet
        oDataAdapter.Fill(oDataSet)
        Dim row As DataRow

        'If mayor < 1 Then
        '    mayor = CStr(CInt(mayor) + 1)
        '    Return mayor
        'End If

        For Each row In oDataSet.Tables(0).Rows
            If row.IsNull("mayor") Then
                mayor = CStr(CInt(mayor) + 1)
                Return mayor
            Else
                mayor = row("mayor") + 1
            End If
        Next
        If mayor = Nothing Then
            mayor = CStr(1)
        Else
            'mayor = CStr(CInt(mayor) + 1)
        End If
        Return mayor
    End Function

    ' SUB QUE RETORNA EL CODIGO SELECCIONADO DE UNA CONSULTA
    Public Sub Seleccionar2(ByVal Grd As DataGridView, ByVal oForm As Form)
        Dim i As Integer
        For i = 0 To Grd.Rows.Count - 1
            If Grd.Rows.Item(i).Selected Then
                If Grd.Item(0, i).Value <> Nothing Then
                    docu = (Grd.Item(0, i).Value)

                End If

                If Grd.Item(1, i).Value.ToString = Nothing Then

                Else
                    cr = CStr(Grd.Item(1, i).Value)
                    codigo = (Grd.Item(1, i).Value)

                End If

                Exit For

            End If
        Next
        oForm.Dispose()
    End Sub
    Public Sub Seleccionar(ByVal Grd As DataGridView, ByVal oForm As Form)
        Dim i As Integer
        For i = 0 To Grd.Rows.Count - 1
            If Grd.Rows.Item(i).Selected Then
                If Grd.Item(0, i).Value <> Nothing Then
                    codigo = CInt(Grd.Item(0, i).Value)
                End If

                If Grd.Item(1, i).Value.ToString = Nothing Then

                Else
                    cr = CStr(Grd.Item(1, i).Value)
                End If

                Exit For

            End If
        Next
        oForm.Dispose()
    End Sub
    Public Function ReturnCampo(ByVal sSql As String, ByVal Campo As String) As String
        Dim DS As New DataSet
        Dim Devol As String = ""
        Dim row As DataRow
        Try
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            oDataAdapter.Fill(DS)
            oConexion.Close()
            For Each row In DS.Tables(0).Rows
                Devol = row("" & Campo & "").ToString
            Next
        Catch oExep As SqlException
            MessageBox.Show("Error al Conectar con datos" & ControlChars.CrLf & _
            oExep.Message)
        End Try
        Return Devol
    End Function
    'Public Sub EnableTf(ByVal grp As Form, ByVal num As Integer)
    '    For Each c As Control In grp.Controls
    '        If TypeOf c Is GroupBox Then
    '            For Each d As Control In CType(c, GroupBox).Controls
    '                If TypeOf d Is TextBox Or TypeOf d Is ComboBox Or TypeOf d Is MaskedTextBox Or TypeOf d Is DataGridView Then
    '                    If num = 1 Then
    '                        d.Enabled = True
    '                    Else
    '                        d.Enabled = False
    '                    End If
    '                End If
    '            Next
    '        End If
    '    Next
    'End Sub
    Public Function ExtraerImagen(ByVal Foto As Integer) As Byte()
        Dim SqlSelect As String = "Select imausu From image_usuario Where codter = " & Foto
        Dim Command As New SqlCommand(SqlSelect, oConexion)
        oConexion.Open()
        Dim MyPhoto() As Byte = CType(Command.ExecuteScalar(), Byte())
        oConexion.Close()
        Return MyPhoto
    End Function

    Public Sub EnableTF(ByVal ofrm As Form, ByVal i As Integer)
        For Each c As Control In ofrm.Controls

            If TypeOf c Is TabControl Then
                For Each t As Control In CType(c, TabControl).Controls
                    If TypeOf t Is TabPage Then
                        For Each tp As Control In CType(t, TabPage).Controls
                            If TypeOf tp Is Button Or TypeOf tp Is DataGridView Then
                                If i = 1 Then
                                    tp.Enabled = True
                                Else
                                    tp.Enabled = False
                                End If
                            End If
                            If TypeOf tp Is GroupBox Then
                                For Each g As Control In CType(tp, GroupBox).Controls
                                    If TypeOf g Is TextBox Or TypeOf g Is ComboBox Or TypeOf g Is MaskedTextBox Or TypeOf g Is Button Then
                                        If i = 1 Then
                                            g.Enabled = True
                                        Else
                                            g.Enabled = False
                                        End If
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            End If
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Or TypeOf c Is MaskedTextBox Or TypeOf c Is Button Then
                If i = 1 Then
                    c.Enabled = True
                Else
                    c.Enabled = False
                End If
            End If

            If TypeOf c Is GroupBox Then
                For Each g As Control In CType(c, GroupBox).Controls
                    If TypeOf g Is TextBox Or TypeOf g Is ComboBox Or TypeOf g Is MaskedTextBox Or TypeOf g Is Button Then
                        If i = 1 Then
                            g.Enabled = True
                        Else
                            g.Enabled = False
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub Filtro(ByVal Rbt As RadioButton, ByVal Grp As GroupBox)
        If Rbt.Checked = True Then
            Grp.Visible = True
        Else
            Grp.Visible = False
        End If
    End Sub

    Public Function Chequed(ByVal rbt As RadioButton) As Boolean
        Dim Dev As Boolean
        If rbt.Checked = True Then
            Dev = True
        Else
            Dev = False
        End If

        Return Dev

    End Function

    Public Sub Campo(ByVal Reporte As String, ByVal campos As ComboBox)
        If Reporte = "Clientes" Then
            With campos.Items
                .Add("Codigo")
                .Add("Nombre")
                .Add("Apellido")
                .Add("Cedula")
                .Add("Sexo")
                .Add("Sector")
                .Add("Direccion")
            End With
        End If

    End Sub

    Public Sub Permisos(ByVal Grupo As String)

        '    oDataSet = New DataSet
        '    Dim sSql As String = "select * from permisos_usuarios where tip_usu=" & Grupo
        '    oDataAdapter = New SqlDataAdapter(sSql, oConexion)
        '    oConexion.Close()
        '    oDataAdapter.Fill(oDataSet)

        '    Dim Row As DataRow
        '    Dim oMenu As String
        '    Row = Nothing
        '    For Each Row In oDataSet.Tables(0).Rows
        '        If Row("padre").ToString.Trim = "Procesos" Then
        '            oMenu = Row("hijos").ToString.Trim
        '            Select Case oMenu
        '                Case Is = "Procesos"
        '                    Permisos1(FrmPrincipal.MnuProcesos, 1)
        '                Case Is = "Solicitud"
        '                    Permisos1(FrmPrincipal.MnuSolicitud, 1)
        '                Case Is = "Actualizacion de Orden"
        '                    Permisos1(FrmPrincipal.MnuActu_Orden, 1)
        '                Case Is = "Cobro"
        '                    Permisos1(FrmPrincipal.MnuCobro, 1)
        '                Case Is = "Facturación"
        '                    Permisos1(FrmPrincipal.MnuFacturacion, 1)
        '            End Select
        '        End If

        '        If Row("padre").ToString.Trim = "Mantenimientos" Then
        '            oMenu = Row("hijos").ToString.Trim
        '            Select Case oMenu
        '                Case Is = "Mantenimientos"
        '                    Permisos1(FrmPrincipal.MnuMantenimientos, 1)
        '                Case Is = "Clientes"
        '                    Permisos1(FrmPrincipal.ManClientes, 1)
        '                Case Is = "Ciudad"
        '                    Permisos1(FrmPrincipal.ManCiudad, 1)
        '                Case Is = "Pais"
        '                    Permisos1(FrmPrincipal.ManPais, 1)
        '                Case Is = "Bancos"
        '                    Permisos1(FrmPrincipal.ManBancos, 1)
        '                Case Is = "Empresa Telefónica"
        '                    Permisos1(FrmPrincipal.ManEmp_Tel, 1)
        '                Case Is = "Sectores"
        '                    Permisos1(FrmPrincipal.ManSectores, 1)
        '                Case Is = "Empleados"
        '                    Permisos1(FrmPrincipal.ManEmpleados, 1)
        '                Case Is = "Usuarios"
        '                    Permisos1(FrmPrincipal.ManUsuarios, 1)
        '                Case Is = "Paquete"
        '                    Permisos1(FrmPrincipal.ManPaquete, 1)
        '                Case Is = "Permisos de Usuarios"
        '                    Permisos1(FrmPrincipal.MantPermisos, 1)
        '                Case Is = "Planes"
        '                    Permisos1(FrmPrincipal.MantPlanes, 1)
        '            End Select
        '        End If

        '        If Row("padre").ToString.Trim = "Consultas" Then
        '            oMenu = Row("hijos").ToString.Trim
        '            Select Case oMenu
        '                Case Is = "Consultas"
        '                    Permisos1(FrmPrincipal.MnuConsultas, 1)
        '                Case Is = "Clientes"
        '                    Permisos1(FrmPrincipal.ConsCliente, 1)
        '                Case Is = "Ciudad"
        '                    Permisos1(FrmPrincipal.ConsCiudad, 1)
        '                Case Is = "Pais"
        '                    Permisos1(FrmPrincipal.ConsPais, 1)
        '                Case Is = "Bancos"
        '                    Permisos1(FrmPrincipal.ConsBancos, 1)
        '                Case Is = "Empresa Telefónica"
        '                    Permisos1(FrmPrincipal.ConsEmp_Tel, 1)
        '                Case Is = "Sectores"
        '                    Permisos1(FrmPrincipal.ConsSector, 1)
        '                Case Is = "Empleados"
        '                    Permisos1(FrmPrincipal.ConsEmpleados, 1)
        '                Case Is = "Paquetes"
        '                    Permisos1(FrmPrincipal.Cons_Paquetes, 1)
        '                Case Is = "Planes"
        '                    Permisos1(FrmPrincipal.Cons_Plan, 1)
        '            End Select
        '        End If

        '        If Row("padre").ToString.Trim = "Reportes" Then
        '            oMenu = Row("hijos").ToString.Trim
        '            Select Case oMenu
        '                Case Is = "Reportes"
        '                    Permisos1(FrmPrincipal.MnuReportes, 1)
        '                Case Is = "Reportes Varios"
        '                    Permisos1(FrmPrincipal.RptVario, 1)
        '            End Select
        '        End If

        '        If Row("padre").ToString.Trim = "Herramientas" Then
        '            oMenu = Row("hijos").ToString.Trim
        '            Select Case oMenu
        '                Case Is = "Herramientas"
        '                    Permisos1(FrmPrincipal.MnuHerramientas, 1)
        '                Case Is = "Copia de Seguridad"
        '                    Permisos1(FrmPrincipal.HerCopia_Seguridad, 1)
        '            End Select
        '        End If
        '    Next
        'End Sub
        'Public Sub Permisos1(ByVal item As ToolStripItem, ByVal Val As Integer)
        '    If Val = 1 Then
        '        item.Visible = True
        '    Else
        '        item.Visible = False
        '    End If
    End Sub


    Public Sub TodosPermisos(ByVal Mnu As MenuStrip)
        '    Permisos1(FrmPrincipal.MnuProcesos, 1)
        '    Permisos1(FrmPrincipal.MnuSolicitud, 1)
        '    Permisos1(FrmPrincipal.MnuActu_Orden, 1)
        '    Permisos1(FrmPrincipal.MnuCobro, 1)
        '    Permisos1(FrmPrincipal.MnuFacturacion, 1)
        '    Permisos1(FrmPrincipal.MnuMantenimientos, 1)
        '    Permisos1(FrmPrincipal.ManClientes, 1)
        '    Permisos1(FrmPrincipal.ManCiudad, 1)
        '    Permisos1(FrmPrincipal.ManPais, 1)
        '    Permisos1(FrmPrincipal.ManBancos, 1)
        '    Permisos1(FrmPrincipal.ManEmp_Tel, 1)
        '    Permisos1(FrmPrincipal.ManSectores, 1)
        '    Permisos1(FrmPrincipal.ManEmpleados, 1)
        '    Permisos1(FrmPrincipal.ManUsuarios, 1)
        '    Permisos1(FrmPrincipal.ManPaquete, 1)
        '    Permisos1(FrmPrincipal.MantPermisos, 1)
        '    Permisos1(FrmPrincipal.MnuConsultas, 1)
        '    Permisos1(FrmPrincipal.ConsCliente, 1)
        '    Permisos1(FrmPrincipal.ConsCiudad, 1)
        '    Permisos1(FrmPrincipal.ConsPais, 1)
        '    Permisos1(FrmPrincipal.ConsBancos, 1)
        '    Permisos1(FrmPrincipal.ConsEmp_Tel, 1)
        '    Permisos1(FrmPrincipal.ConsSector, 1)
        '    Permisos1(FrmPrincipal.ConsEmpleados, 1)
        '    Permisos1(FrmPrincipal.Cons_Paquetes, 1)
        '    Permisos1(FrmPrincipal.MnuReportes, 1)
        '    Permisos1(FrmPrincipal.RptVario, 1)
        '    Permisos1(FrmPrincipal.MnuHerramientas, 1)
        '    Permisos1(FrmPrincipal.HerCopia_Seguridad, 1)
        '    Permisos1(FrmPrincipal.Cons_Plan, 1)
        '    Permisos1(FrmPrincipal.MantPlanes, 1)
    End Sub


End Module
