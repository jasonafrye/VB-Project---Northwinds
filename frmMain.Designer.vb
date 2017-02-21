<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsByCatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstMain = New System.Windows.Forms.StatusStrip()
        Me.tsslFormName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuMain.SuspendLayout()
        Me.sstMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.WindowToolStripMenuItem, Me.TestToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1004, 24)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "C&lose"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsByNameToolStripMenuItem, Me.CustomersByNameToolStripMenuItem, Me.ProductsByCatToolStripMenuItem, Me.CategoriesProductsToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'ProductsByNameToolStripMenuItem
        '
        Me.ProductsByNameToolStripMenuItem.Name = "ProductsByNameToolStripMenuItem"
        Me.ProductsByNameToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ProductsByNameToolStripMenuItem.Text = "&Products by Name"
        '
        'CustomersByNameToolStripMenuItem
        '
        Me.CustomersByNameToolStripMenuItem.Name = "CustomersByNameToolStripMenuItem"
        Me.CustomersByNameToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.CustomersByNameToolStripMenuItem.Text = "&Suppliers by Company"
        '
        'ProductsByCatToolStripMenuItem
        '
        Me.ProductsByCatToolStripMenuItem.Name = "ProductsByCatToolStripMenuItem"
        Me.ProductsByCatToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ProductsByCatToolStripMenuItem.Text = "Products sorted by by &Cat"
        '
        'CategoriesProductsToolStripMenuItem
        '
        Me.CategoriesProductsToolStripMenuItem.Name = "CategoriesProductsToolStripMenuItem"
        Me.CategoriesProductsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.CategoriesProductsToolStripMenuItem.Text = "Categories / Products"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriesToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.SuppliersToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.MaintenanceToolStripMenuItem.Text = "&Maintenance"
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CategoriesToolStripMenuItem.Text = "Categories"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SuppliersToolStripMenuItem.Text = "Suppliers"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'sstMain
        '
        Me.sstMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslFormName, Me.tsslTime})
        Me.sstMain.Location = New System.Drawing.Point(0, 420)
        Me.sstMain.Name = "sstMain"
        Me.sstMain.Size = New System.Drawing.Size(1004, 22)
        Me.sstMain.TabIndex = 2
        Me.sstMain.Text = "StatusStrip1"
        '
        'tsslFormName
        '
        Me.tsslFormName.Name = "tsslFormName"
        Me.tsslFormName.Size = New System.Drawing.Size(494, 17)
        Me.tsslFormName.Spring = True
        '
        'tsslTime
        '
        Me.tsslTime.Name = "tsslTime"
        Me.tsslTime.Size = New System.Drawing.Size(494, 17)
        Me.tsslTime.Spring = True
        Me.tsslTime.Text = "Now()"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 442)
        Me.Controls.Add(Me.sstMain)
        Me.Controls.Add(Me.mnuMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.sstMain.ResumeLayout(False)
        Me.sstMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductsByNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersByNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sstMain As System.Windows.Forms.StatusStrip
    Friend WithEvents ProductsByCatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsslFormName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CategoriesProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
