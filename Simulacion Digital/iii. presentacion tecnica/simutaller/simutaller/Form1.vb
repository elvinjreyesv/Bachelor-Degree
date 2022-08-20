Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Public i As Integer
    Public n As String
    Public cantequipos As Integer
    Public codcorrida As Integer
    Dim equipoAnt As New Comun.corridas
    Dim equipo As New Comun.corridas
    Dim enServicio As New Comun.equipoServicio
    Dim etapa As Integer
    Dim tel As Double
    Dim tipoServicio As Integer
    Dim CantiTecnico As Integer
    Dim tecDisp As New ArrayList


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenarcombos(cboTanda, "select * from tanda", "destanda", "codtanda")
        'selecciona mayor(codcorrida)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Me.TextBox1.Text = discreta(6, 8).ToString
        'For i = 1 To 3

        '    Dim n As New equipo
        '    n.Name = i

        '    If i < 2 Then
        '        n.apellido = "santana"
        '    ElseIf i < 3 Then
        '        n.apellido = "lopez"
        '    Else
        '        n.apellido = "maria"
        '    End If


        '    MessageBox.Show("nombre " & n.Name)
        '    If n.Name <> "0" Then
        '        TextBox1.Text = n.Name - 1
        '    End If
        'Next
        tipEquipo(txtCorrida, cboTanda.SelectedValue)

    End Sub

    Private Sub cboTanda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTanda.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cboTanda.SelectedValue < 1 Then
            MessageBox.Show("Debe seleccionar una tanda antes de continuar")
            Return
        End If

        txtCorrida.Text = codcorrida
        codcorrida = BuscaMayor("select max(codcorrida) as mayor from resultados ")
        txtCorrida.Text = codcorrida.ToString
        codtanda = cboTanda.SelectedValue
        inicializarCorrida(codcorrida)
        cantequipos = retornaint(cboTanda)
        generaEquipo(cantequipos)
        equipo.PCodCorrida = codcorrida
        For i = 1 To cantequipos
            enServicio.actualizar(i)
            tel = generaTenLlegadas(cboTanda.SelectedValue)
            If i > 1 Then
                equipo.PTiempoLlegada = (tel) + (equipoAnt.PTiempoLlegada)
            Else
                equipo.PTiempoLlegada = (tel)
            End If
            equipoAnt.Consultar(codcorrida - 1)
            'seleccionar cliente anterior = select codequipo codcorrida and 
            equipo.pTiempoEnLlegadas = tel
            'generar tiempo/llegada

            etapa = 1
            tipoServicio = generaservicio(i, CantiTecnico)
            enServicio.actualizar(i)
            equipo.PTiempoServicio = enServicio.ETiempoServicio
            'equipo.PTiempoInicio = selectTecnico(i, tipoServicio, equipo.PTiempoLlegada)
            SelTecnico(codcorrida, tipoServicio, CantiTecnico, tdisponible(codcorrida, tipoServicio), equipo.Pcodtecnico, equipo.PTiempoLlegada,
                       equipo.PTiempoInicio, equipo.PTiempoEspera, equipo.PTiempoServicio)

            enServicio.actualizar(i)
            equipo.Pcodcliente = i
            'equipo.Pcodtecnico = enServicio.ECodTecnico
            equipo.PCodfallo = enServicio.EcodFallo
            equipo.PCodEquipo = enServicio.ECodEquipo
            equipo.PTiempoTermin = equipo.PTiempoInicio + equipo.PTiempoServicio
            equipo.PTiempoSistema = equipo.PTiempoTermin + equipo.PTiempoLlegada

            'generoo tipo servicio(etapa)
            'genero servicio
            'selecciono cajero
            'genero problema
            'tocio
            ' guardar en tabla resultados




            'Instancia.Consultar(codigoCorrida)
            'tservicio = instancia.PtiempoServicio
            'instancia.Ptiemposervicio = 10


            equipo.Guardar()


        Next




        MessageBox.Show("final")
        llenaGrid(DataGridView1)
    End Sub
    ' initCorrida
    Sub inicializarCorrida(codcorrid As Integer)
        oConexion.Open()
        oComando = New SqlCommand("exec initCorrida " & codcorrid & "", oConexion)
        oComando.ExecuteNonQuery()
        oConexion.Close()


    End Sub
 
    Sub generaEquipo(cant As Integer)
        oConexion.Open()
        oComando = New SqlCommand("exec genera_equipos " & cant & "", oConexion)
        oComando.ExecuteNonQuery()
        oConexion.Close()


    End Sub
End Class
