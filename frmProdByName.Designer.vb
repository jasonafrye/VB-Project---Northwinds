<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdByName
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
        Me.lisProduct = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.txtProdQty = New System.Windows.Forms.TextBox()
        Me.txtProdPrice = New System.Windows.Forms.TextBox()
        Me.txtProdStock = New System.Windows.Forms.TextBox()
        Me.txtProdOnOrder = New System.Windows.Forms.TextBox()
        Me.txtProdReorder = New System.Windows.Forms.TextBox()
        Me.chkDis = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lisProduct
        '
        Me.lisProduct.FormattingEnabled = True
        Me.lisProduct.Location = New System.Drawing.Point(26, 37)
        Me.lisProduct.Name = "lisProduct"
        Me.lisProduct.Size = New System.Drawing.Size(164, 316)
        Me.lisProduct.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quantity per Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Price per Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Units in Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Units on Order"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Reorder Level"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(226, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Discontinued"
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(316, 44)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(100, 20)
        Me.txtProdName.TabIndex = 16
        '
        'txtProdID
        '
        Me.txtProdID.Location = New System.Drawing.Point(316, 77)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(100, 20)
        Me.txtProdID.TabIndex = 17
        '
        'txtProdQty
        '
        Me.txtProdQty.Location = New System.Drawing.Point(316, 110)
        Me.txtProdQty.Name = "txtProdQty"
        Me.txtProdQty.Size = New System.Drawing.Size(100, 20)
        Me.txtProdQty.TabIndex = 18
        '
        'txtProdPrice
        '
        Me.txtProdPrice.Location = New System.Drawing.Point(316, 156)
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtProdPrice.TabIndex = 19
        '
        'txtProdStock
        '
        Me.txtProdStock.Location = New System.Drawing.Point(316, 189)
        Me.txtProdStock.Name = "txtProdStock"
        Me.txtProdStock.Size = New System.Drawing.Size(100, 20)
        Me.txtProdStock.TabIndex = 20
        '
        'txtProdOnOrder
        '
        Me.txtProdOnOrder.Location = New System.Drawing.Point(316, 222)
        Me.txtProdOnOrder.Name = "txtProdOnOrder"
        Me.txtProdOnOrder.Size = New System.Drawing.Size(100, 20)
        Me.txtProdOnOrder.TabIndex = 21
        '
        'txtProdReorder
        '
        Me.txtProdReorder.Location = New System.Drawing.Point(316, 255)
        Me.txtProdReorder.Name = "txtProdReorder"
        Me.txtProdReorder.Size = New System.Drawing.Size(100, 20)
        Me.txtProdReorder.TabIndex = 22
        '
        'chkDis
        '
        Me.chkDis.AutoSize = True
        Me.chkDis.Location = New System.Drawing.Point(316, 288)
        Me.chkDis.Name = "chkDis"
        Me.chkDis.Size = New System.Drawing.Size(15, 14)
        Me.chkDis.TabIndex = 23
        Me.chkDis.UseVisualStyleBackColor = True
        '
        'frmProdByName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 400)
        Me.Controls.Add(Me.chkDis)
        Me.Controls.Add(Me.txtProdReorder)
        Me.Controls.Add(Me.txtProdOnOrder)
        Me.Controls.Add(Me.txtProdStock)
        Me.Controls.Add(Me.txtProdPrice)
        Me.Controls.Add(Me.txtProdQty)
        Me.Controls.Add(Me.txtProdID)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lisProduct)
        Me.Name = "frmProdByName"
        Me.Text = "frmProdByName"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lisProduct As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProdName As System.Windows.Forms.TextBox
    Friend WithEvents txtProdID As System.Windows.Forms.TextBox
    Friend WithEvents txtProdQty As System.Windows.Forms.TextBox
    Friend WithEvents txtProdPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtProdStock As System.Windows.Forms.TextBox
    Friend WithEvents txtProdOnOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtProdReorder As System.Windows.Forms.TextBox
    Friend WithEvents chkDis As System.Windows.Forms.CheckBox
End Class
