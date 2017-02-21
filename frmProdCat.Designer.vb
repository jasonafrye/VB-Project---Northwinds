<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdCat
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
        Me.cboCat = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgCatProd = New System.Windows.Forms.DataGridView
        CType(Me.dgCatProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCat
        '
        Me.cboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCat.FormattingEnabled = True
        Me.cboCat.Location = New System.Drawing.Point(267, 65)
        Me.cboCat.Name = "cboCat"
        Me.cboCat.Size = New System.Drawing.Size(121, 21)
        Me.cboCat.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select a Category from the drop down list "
        '
        'dgCatProd
        '
        Me.dgCatProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCatProd.Location = New System.Drawing.Point(48, 139)
        Me.dgCatProd.Name = "dgCatProd"
        Me.dgCatProd.Size = New System.Drawing.Size(933, 405)
        Me.dgCatProd.TabIndex = 2
        '
        'frmProdCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 576)
        Me.Controls.Add(Me.dgCatProd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCat)
        Me.Name = "frmProdCat"
        Me.Text = "Products by Category"
        CType(Me.dgCatProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgCatProd As System.Windows.Forms.DataGridView
End Class
