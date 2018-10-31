Imports System.Data.SqlClient

Public Class Form1
    Public con As New SqlConnection("Initial Catalog=gpOgrenciKayit;Data Source=localhost;Integrated Security=SSPI;")
    Dim cmd As New SqlCommand
    Dim adtr As New SqlDataAdapter("select * From Students", con)
    Dim dtst As New DataSet
    Private Sub show()
        dtst.Clear()
        adtr.Fill(dtst, "st")
        DataGridView1.DataSource = dtst.Tables("st")
    End Sub
    Private Sub clear()
        stName.Clear()
        stSurname.Clear()
        stNumber.Clear()
        stClass.Clear()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call show()
    End Sub
    Dim Id As Integer
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim s As Integer
            s = DataGridView1.CurrentCell.RowIndex
            Id = DataGridView1(0, s).Value
            stName.Text = DataGridView1(1, s).Value
            stSurname.Text = DataGridView1(2, s).Value
            stNumber.Text = DataGridView1(3, s).Value
            stClass.Text = DataGridView1(4, s).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If Me.stNumber.Text = "" Then
            MsgBox("Lütfen Tüm Alanını Doldurunuz. Alan Boş Bırakılamaz.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
        Else
            cmd.Connection = con
            cmd.CommandText = "Insert into Students(stName,stSurname,stNumber,stClass) values (@stName,@stSurname,@stNumber,@stClass)"
            cmd.Parameters.AddWithValue("@stName", stName.Text)
            cmd.Parameters.AddWithValue("@stSurname", stSurname.Text)
            cmd.Parameters.AddWithValue("@stNumber", stNumber.Text)
            cmd.Parameters.AddWithValue("@stClass", stClass.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Girdiğiniz Ögrenci Kayıt Yapılmıştır.", MsgBoxStyle.Information, "Tebrikler")
            Call clear()
            Call show()
        End If
    End Sub
    Private Sub ButtonDeleted_Click(sender As Object, e As EventArgs) Handles ButtonDeleted.Click
        If Me.stName.Text = "" Then
            MsgBox("Lütfen Kayıt Seçiniz.", MsgBoxStyle.Exclamation, "DİKKAT")
        Else
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM Students WHERE Id='" & Id & "'"
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Listeden Seçmiş Olduğunuz Veriler Silinmiştir.", MsgBoxStyle.Exclamation, "Silme İşlemi")
            Call clear()
            Call show()
        End If
    End Sub

    Private Sub ButtonUpdated_Click(sender As Object, e As EventArgs) Handles ButtonUpdated.Click
        If Me.stName.Text = "" Then
            MsgBox("Lütfen Kayıt Seçiniz.", MsgBoxStyle.Exclamation, "DİKKAT")
        Else
            cmd.Connection = con
            cmd.CommandText = "Update Students SET stName='" & stName.Text & "',stSurname='" & stSurname.Text & "',stNumber='" & stNumber.Text & "',stClass='" & stClass.Text & "' WHERE Id='" & Id & "' "
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Değiştirmiş Olduğunuz Veriler Doğrultusunda Kayıtlar Güncellenmiştir.", MsgBoxStyle.Exclamation, "Değişiklik Uyarısı")
            Call clear()
            Call show()
        End If
    End Sub


End Class
