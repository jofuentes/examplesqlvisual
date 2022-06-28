<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TB_Server = New System.Windows.Forms.TextBox()
        Me.TB_Database = New System.Windows.Forms.TextBox()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.TB_User = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QueryDGV = New System.Windows.Forms.Button()
        Me.BS1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_Server
        '
        Me.TB_Server.Location = New System.Drawing.Point(67, 12)
        Me.TB_Server.Name = "TB_Server"
        Me.TB_Server.Size = New System.Drawing.Size(232, 20)
        Me.TB_Server.TabIndex = 0
        Me.TB_Server.Text = "91df094b8410.sn.mynetname.net"
        '
        'TB_Database
        '
        Me.TB_Database.Location = New System.Drawing.Point(67, 38)
        Me.TB_Database.Name = "TB_Database"
        Me.TB_Database.Size = New System.Drawing.Size(232, 20)
        Me.TB_Database.TabIndex = 1
        Me.TB_Database.Text = "Prospectos"
        '
        'TB_Password
        '
        Me.TB_Password.Location = New System.Drawing.Point(67, 90)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.Size = New System.Drawing.Size(232, 20)
        Me.TB_Password.TabIndex = 2
        Me.TB_Password.Text = "Coloco.71"
        Me.TB_Password.UseSystemPasswordChar = True
        '
        'TB_User
        '
        Me.TB_User.Location = New System.Drawing.Point(67, 64)
        Me.TB_User.Name = "TB_User"
        Me.TB_User.Size = New System.Drawing.Size(232, 20)
        Me.TB_User.TabIndex = 3
        Me.TB_User.Text = "Jofuentes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Database"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV1.Location = New System.Drawing.Point(3, 16)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(625, 158)
        Me.DGV1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 177)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Grid View Example"
        '
        'QueryDGV
        '
        Me.QueryDGV.Location = New System.Drawing.Point(15, 361)
        Me.QueryDGV.Name = "QueryDGV"
        Me.QueryDGV.Size = New System.Drawing.Size(75, 23)
        Me.QueryDGV.TabIndex = 11
        Me.QueryDGV.Text = "Consultar"
        Me.QueryDGV.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 465)
        Me.Controls.Add(Me.QueryDGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_User)
        Me.Controls.Add(Me.TB_Password)
        Me.Controls.Add(Me.TB_Database)
        Me.Controls.Add(Me.TB_Server)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Server As TextBox
    Friend WithEvents TB_Database As TextBox
    Friend WithEvents TB_Password As TextBox
    Friend WithEvents TB_User As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents QueryDGV As Button
    Friend WithEvents BS1 As BindingSource
End Class
