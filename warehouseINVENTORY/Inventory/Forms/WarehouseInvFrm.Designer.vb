<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WarehouseInvFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WarehouseInvFrm))
        Me.Frm_Pnl = New System.Windows.Forms.Panel()
        Me.Inv_Cmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Loading_PB = New System.Windows.Forms.PictureBox()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Inv_Cmenu.SuspendLayout()
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frm_Pnl
        '
        Me.Frm_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frm_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.Frm_Pnl.Name = "Frm_Pnl"
        Me.Frm_Pnl.Size = New System.Drawing.Size(784, 461)
        Me.Frm_Pnl.TabIndex = 0
        '
        'Inv_Cmenu
        '
        Me.Inv_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.Inv_Cmenu.Name = "Inv_Cmenu"
        Me.Inv_Cmenu.Size = New System.Drawing.Size(113, 70)
        '
        'Loading_PB
        '
        Me.Loading_PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Loading_PB.Image = Global.warehouseINVENTORY.My.Resources.Resources.loading_image2
        Me.Loading_PB.Location = New System.Drawing.Point(356, 203)
        Me.Loading_PB.Name = "Loading_PB"
        Me.Loading_PB.Size = New System.Drawing.Size(73, 55)
        Me.Loading_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Loading_PB.TabIndex = 19
        Me.Loading_PB.TabStop = False
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.warehouseINVENTORY.My.Resources.Resources.add_48px
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Image = Global.warehouseINVENTORY.My.Resources.Resources.edit_48px
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.warehouseINVENTORY.My.Resources.Resources.delete_sign_48px
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'WarehouseInvFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Frm_Pnl)
        Me.Controls.Add(Me.Loading_PB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WarehouseInvFrm"
        Me.Text = "Warehouse Inventory"
        Me.Inv_Cmenu.ResumeLayout(False)
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Frm_Pnl As Panel
    Friend WithEvents Loading_PB As PictureBox
    Friend WithEvents Inv_Cmenu As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
