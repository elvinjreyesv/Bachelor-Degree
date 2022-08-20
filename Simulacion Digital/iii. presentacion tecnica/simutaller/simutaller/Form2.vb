Public Class Form2

    Private Sub TandaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TandaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TandaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SimuTallerDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SimuTallerDataSet.tanda' Puede moverla o quitarla según sea necesario.
        Me.TandaTableAdapter.Fill(Me.SimuTallerDataSet.tanda)

    End Sub
End Class