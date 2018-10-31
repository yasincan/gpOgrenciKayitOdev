<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.stName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.stSurname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.stNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonDeleted = New System.Windows.Forms.Button()
        Me.ButtonUpdated = New System.Windows.Forms.Button()
        Me.stClass = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(552, 206)
        Me.DataGridView1.TabIndex = 0
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(19, 135)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "Kaydet"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'stName
        '
        Me.stName.Location = New System.Drawing.Point(104, 16)
        Me.stName.Name = "stName"
        Me.stName.Size = New System.Drawing.Size(100, 20)
        Me.stName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ögrenci Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ögrenci Soyadı:"
        '
        'stSurname
        '
        Me.stSurname.Location = New System.Drawing.Point(104, 42)
        Me.stSurname.Name = "stSurname"
        Me.stSurname.Size = New System.Drawing.Size(100, 20)
        Me.stSurname.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.stClass)
        Me.Panel1.Controls.Add(Me.ButtonUpdated)
        Me.Panel1.Controls.Add(Me.ButtonDeleted)
        Me.Panel1.Controls.Add(Me.ButtonAdd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.stNumber)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.stSurname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.stName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 192)
        Me.Panel1.TabIndex = 6
        '
        'stNumber
        '
        Me.stNumber.Location = New System.Drawing.Point(104, 68)
        Me.stNumber.Name = "stNumber"
        Me.stNumber.Size = New System.Drawing.Size(100, 20)
        Me.stNumber.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ögrenci No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ögrenci Sınıfı:"
        '
        'ButtonDeleted
        '
        Me.ButtonDeleted.Location = New System.Drawing.Point(104, 135)
        Me.ButtonDeleted.Name = "ButtonDeleted"
        Me.ButtonDeleted.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDeleted.TabIndex = 10
        Me.ButtonDeleted.Text = "Sil"
        Me.ButtonDeleted.UseVisualStyleBackColor = True
        '
        'ButtonUpdated
        '
        Me.ButtonUpdated.Location = New System.Drawing.Point(185, 135)
        Me.ButtonUpdated.Name = "ButtonUpdated"
        Me.ButtonUpdated.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdated.TabIndex = 11
        Me.ButtonUpdated.Text = "Güncelle"
        Me.ButtonUpdated.UseVisualStyleBackColor = True
        '
        'stClass
        '
        Me.stClass.Location = New System.Drawing.Point(104, 97)
        Me.stClass.Name = "stClass"
        Me.stClass.Size = New System.Drawing.Size(100, 20)
        Me.stClass.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 458)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Ögerenci Kayit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents stName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents stSurname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents stNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonDeleted As Button
    Friend WithEvents ButtonUpdated As Button
    Friend WithEvents stClass As TextBox
End Class
