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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.label_1 = New System.Windows.Forms.Label()
        Me.txt_Cat_Id = New System.Windows.Forms.TextBox()
        Me.txt_Cat_Name = New System.Windows.Forms.TextBox()
        Me.label_2 = New System.Windows.Forms.Label()
        Me.txt_Desc = New System.Windows.Forms.TextBox()
        Me.label_3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(964, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CONNECT"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'label_1
        '
        Me.label_1.AutoSize = True
        Me.label_1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_1.Location = New System.Drawing.Point(31, 66)
        Me.label_1.Name = "label_1"
        Me.label_1.Size = New System.Drawing.Size(84, 19)
        Me.label_1.TabIndex = 1
        Me.label_1.Text = "Catgory ID:"
        '
        'txt_Cat_Id
        '
        Me.txt_Cat_Id.Enabled = False
        Me.txt_Cat_Id.Location = New System.Drawing.Point(164, 66)
        Me.txt_Cat_Id.Multiline = True
        Me.txt_Cat_Id.Name = "txt_Cat_Id"
        Me.txt_Cat_Id.Size = New System.Drawing.Size(230, 26)
        Me.txt_Cat_Id.TabIndex = 2
        '
        'txt_Cat_Name
        '
        Me.txt_Cat_Name.Location = New System.Drawing.Point(164, 110)
        Me.txt_Cat_Name.Multiline = True
        Me.txt_Cat_Name.Name = "txt_Cat_Name"
        Me.txt_Cat_Name.Size = New System.Drawing.Size(230, 27)
        Me.txt_Cat_Name.TabIndex = 4
        '
        'label_2
        '
        Me.label_2.AutoSize = True
        Me.label_2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_2.Location = New System.Drawing.Point(30, 110)
        Me.label_2.Name = "label_2"
        Me.label_2.Size = New System.Drawing.Size(118, 19)
        Me.label_2.TabIndex = 3
        Me.label_2.Text = "Category Name:"
        '
        'txt_Desc
        '
        Me.txt_Desc.Location = New System.Drawing.Point(164, 156)
        Me.txt_Desc.Multiline = True
        Me.txt_Desc.Name = "txt_Desc"
        Me.txt_Desc.Size = New System.Drawing.Size(230, 28)
        Me.txt_Desc.TabIndex = 6
        '
        'label_3
        '
        Me.label_3.AutoSize = True
        Me.label_3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_3.Location = New System.Drawing.Point(30, 155)
        Me.label_3.Name = "label_3"
        Me.label_3.Size = New System.Drawing.Size(90, 19)
        Me.label_3.TabIndex = 5
        Me.label_3.Text = "Description:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(35, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(845, 35)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 449)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(845, 33)
        Me.Panel2.TabIndex = 10
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Location = New System.Drawing.Point(426, 66)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(398, 360)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Category ID"
        Me.ColumnHeader1.Width = 75
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Category Name"
        Me.ColumnHeader2.Width = 85
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 236
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(845, 482)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_Desc)
        Me.Controls.Add(Me.label_3)
        Me.Controls.Add(Me.txt_Cat_Name)
        Me.Controls.Add(Me.label_2)
        Me.Controls.Add(Me.txt_Cat_Id)
        Me.Controls.Add(Me.label_1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents label_1 As System.Windows.Forms.Label
    Friend WithEvents txt_Cat_Id As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cat_Name As System.Windows.Forms.TextBox
    Friend WithEvents label_2 As System.Windows.Forms.Label
    Friend WithEvents txt_Desc As System.Windows.Forms.TextBox
    Friend WithEvents label_3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader

End Class
