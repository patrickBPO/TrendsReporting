Public Class frmInmateEntry
    Private Sub InmateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        'Me.InmateBindingSource.EndEdit()

    End Sub

    Private Sub frmInmateEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbkolbeDataSet1.inmate' table. You can move, or remove it, as needed.
        Me.InmateTableAdapter.Fill(Me.DbkolbeDataSet1.inmate)
        'TODO: This line of code loads data into the 'DbkolbeDataSet.inmate' table. You can move, or remove it, as needed.
        'Me.InmateTableAdapter.Fill(Me.DbkolbeDataSet.inmate)
        'TODO: This line of code loads data into the 'DbkolbeTDataSet.inmate' table. You can move, or remove it, as needed.
        'Me.InmateTableAdapter.Fill(Me.DbkolbeTDataSet.inmate)
        ''TODO: This line of code loads data into the 'DbkolbeTDataSet.inmate' table. You can move, or remove it, as needed.
        'Me.InmateTableAdapter.Fill(Me.DbkolbeTDataSet.inmate)
    End Sub

    Private Sub InmateBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        'Me.InmateBindingSource.EndEdit()

    End Sub

    Private Sub InmateBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) 
        Me.Validate()
        'Me.InmateBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DbkolbeTDataSet)

    End Sub

    Private Sub frmInmateEntry_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.Opacity = 0.1 + 100 / 100

    End Sub

    Private Sub frmInmateEntry_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Opacity = 0.1 + 60 / 100

    End Sub

    Private Sub O_ageTextBox_TextChanged(sender As Object, e As EventArgs) Handles O_ageTextBox.TextChanged
        'Dim intYr As Integer
        'Dim intMth As Integer
        'O_ageTextBox.Text = DateDiff(Today, CDate(Admiss_dteDateTimePicker.Value), "m")
    End Sub


    Private Sub Admiss_dteDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Admiss_dteDateTimePicker.ValueChanged
        Dim lngDif As Long
        'O_ageTextBox.Text = DateDiff(Today, Admiss_dteDateTimePicker.Value, "m")
        lngDif = DateDiff("yyyy", CDate(Admiss_dteDateTimePicker.Value), Today)
        O_ageTextBox.Text = lngDif
    End Sub

End Class