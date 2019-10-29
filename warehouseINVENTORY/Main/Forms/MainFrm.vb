Public Class MainFrm
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = user_fullname
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        If InventoryToolStripMenuItem.Checked = True Then
            Dim inv As Form = WarehouseInvFrm
            inv.MdiParent = Me
            inv.WindowState = FormWindowState.Maximized
            inv.Show()
        Else
            WarehouseInvFrm.Close()
        End If

    End Sub

    Private Sub MainFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginFrm.Close()
    End Sub
End Class