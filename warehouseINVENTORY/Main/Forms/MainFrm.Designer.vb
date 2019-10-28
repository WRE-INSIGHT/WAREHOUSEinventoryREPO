<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.Main_MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Main_MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main_MenuStrip
        '
        Me.Main_MenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Main_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.Main_MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.Main_MenuStrip.Name = "Main_MenuStrip"
        Me.Main_MenuStrip.Size = New System.Drawing.Size(784, 24)
        Me.Main_MenuStrip.TabIndex = 0
        Me.Main_MenuStrip.Text = "MenuStrip1"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckToolStripMenuItem})
        Me.InventoryToolStripMenuItem.Image = Global.warehouseINVENTORY.My.Resources.Resources.warehouse_1_48px
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Image = Global.warehouseINVENTORY.My.Resources.Resources.user_male_circle_48px
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'CheckToolStripMenuItem
        '
        Me.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem"
        Me.CheckToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CheckToolStripMenuItem.Text = "Check"
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Main_MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Main_MenuStrip
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Main_MenuStrip.ResumeLayout(False)
        Me.Main_MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Main_MenuStrip As MenuStrip
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckToolStripMenuItem As ToolStripMenuItem
End Class
