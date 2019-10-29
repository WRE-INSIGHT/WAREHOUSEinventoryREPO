<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarehouseItemFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WarehouseItemFrm))
        Me.Frm_Pnl = New System.Windows.Forms.Panel()
        Me.Loading_PB = New System.Windows.Forms.PictureBox()
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frm_Pnl
        '
        Me.Frm_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frm_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.Frm_Pnl.Name = "Frm_Pnl"
        Me.Frm_Pnl.Size = New System.Drawing.Size(484, 461)
        Me.Frm_Pnl.TabIndex = 0
        '
        'Loading_PB
        '
        Me.Loading_PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Loading_PB.Image = Global.warehouseINVENTORY.My.Resources.Resources.loading_image2
        Me.Loading_PB.Location = New System.Drawing.Point(206, 203)
        Me.Loading_PB.Name = "Loading_PB"
        Me.Loading_PB.Size = New System.Drawing.Size(73, 55)
        Me.Loading_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Loading_PB.TabIndex = 20
        Me.Loading_PB.TabStop = False
        '
        'WarehouseItemFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Frm_Pnl)
        Me.Controls.Add(Me.Loading_PB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WarehouseItemFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Info"
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Frm_Pnl As Panel
    Friend WithEvents Loading_PB As PictureBox
End Class
