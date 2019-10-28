Public Class MainFrm
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = user_fullname
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

    End Sub

    Private Sub CheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckToolStripMenuItem.Click
        Dim inv As Form = WarehouseInvFrm
        inv.MdiParent = Me
        inv.Show()
    End Sub
End Class