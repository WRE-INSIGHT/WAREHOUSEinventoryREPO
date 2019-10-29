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
        Me.Frm_Split = New System.Windows.Forms.SplitContainer()
        Me.Loading_PB = New System.Windows.Forms.PictureBox()
        Me.Search_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Header_Cbox = New System.Windows.Forms.ComboBox()
        Me.Location_Tbox = New System.Windows.Forms.TextBox()
        Me.UnitPrice_Tbox = New System.Windows.Forms.TextBox()
        Me.Monetary_Tbox = New System.Windows.Forms.TextBox()
        Me.UFactor_Tbox = New System.Windows.Forms.TextBox()
        Me.Unit_Tbox = New System.Windows.Forms.TextBox()
        Me.Min_Tbox = New System.Windows.Forms.TextBox()
        Me.Qty_Tbox = New System.Windows.Forms.TextBox()
        Me.Desc_Tbox = New System.Windows.Forms.TextBox()
        Me.ArticleNo_Cbox = New System.Windows.Forms.ComboBox()
        Me.TypeColor_Cbox = New System.Windows.Forms.ComboBox()
        Me.Costhead_Cbox = New System.Windows.Forms.ComboBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Mode_Lbl = New MetroFramework.Controls.MetroLabel()
        Me.Supplier_Cbox = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Inv_Cmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Frm_Pnl.SuspendLayout()
        CType(Me.Frm_Split, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frm_Split.Panel1.SuspendLayout()
        Me.Frm_Split.Panel2.SuspendLayout()
        Me.Frm_Split.SuspendLayout()
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Inv_Cmenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frm_Pnl
        '
        Me.Frm_Pnl.BackColor = System.Drawing.Color.White
        Me.Frm_Pnl.Controls.Add(Me.Frm_Split)
        Me.Frm_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frm_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.Frm_Pnl.Name = "Frm_Pnl"
        Me.Frm_Pnl.Size = New System.Drawing.Size(784, 730)
        Me.Frm_Pnl.TabIndex = 0
        '
        'Frm_Split
        '
        Me.Frm_Split.BackColor = System.Drawing.Color.White
        Me.Frm_Split.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frm_Split.Location = New System.Drawing.Point(0, 0)
        Me.Frm_Split.Name = "Frm_Split"
        Me.Frm_Split.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Frm_Split.Panel1
        '
        Me.Frm_Split.Panel1.BackColor = System.Drawing.Color.White
        Me.Frm_Split.Panel1.Controls.Add(Me.Loading_PB)
        '
        'Frm_Split.Panel2
        '
        Me.Frm_Split.Panel2.AutoScroll = True
        Me.Frm_Split.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Frm_Split.Panel2.Controls.Add(Me.Header_Cbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.Location_Tbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.UnitPrice_Tbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.Monetary_Tbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.UFactor_Tbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.Unit_Tbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.Min_Tbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.Qty_Tbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.Desc_Tbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.ArticleNo_Cbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.TypeColor_Cbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.Costhead_Cbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel13)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel12)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel11)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel10)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel9)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel8)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel7)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel6)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel5)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel4)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel3)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel2)
        Me.Frm_Split.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Frm_Split.Panel2.Controls.Add(Me.Supplier_Cbox)
        Me.Frm_Split.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Frm_Split.Panel2.Controls.Add(Me.Panel1)
        Me.Frm_Split.Size = New System.Drawing.Size(784, 730)
        Me.Frm_Split.SplitterDistance = 455
        Me.Frm_Split.TabIndex = 0
        '
        'Loading_PB
        '
        Me.Loading_PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Loading_PB.Image = Global.warehouseINVENTORY.My.Resources.Resources.loading_image2
        Me.Loading_PB.Location = New System.Drawing.Point(433, 200)
        Me.Loading_PB.Name = "Loading_PB"
        Me.Loading_PB.Size = New System.Drawing.Size(73, 55)
        Me.Loading_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Loading_PB.TabIndex = 19
        Me.Loading_PB.TabStop = False
        '
        'Search_Tbox
        '
        '
        '
        '
        Me.Search_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Search_Tbox.CustomButton.Location = New System.Drawing.Point(273, 1)
        Me.Search_Tbox.CustomButton.Name = ""
        Me.Search_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Search_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Search_Tbox.CustomButton.TabIndex = 1
        Me.Search_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Search_Tbox.CustomButton.UseSelectable = True
        Me.Search_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Search_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Search_Tbox.Lines = New String(-1) {}
        Me.Search_Tbox.Location = New System.Drawing.Point(514, 4)
        Me.Search_Tbox.MaxLength = 32767
        Me.Search_Tbox.Name = "Search_Tbox"
        Me.Search_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Search_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Search_Tbox.SelectedText = ""
        Me.Search_Tbox.SelectionLength = 0
        Me.Search_Tbox.SelectionStart = 0
        Me.Search_Tbox.ShowButton = True
        Me.Search_Tbox.ShowClearButton = True
        Me.Search_Tbox.Size = New System.Drawing.Size(299, 27)
        Me.Search_Tbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.Search_Tbox.TabIndex = 831
        Me.Search_Tbox.UseCustomForeColor = True
        Me.Search_Tbox.UseSelectable = True
        Me.Search_Tbox.WaterMark = "Search here"
        Me.Search_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Search_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Header_Cbox
        '
        Me.Header_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Header_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Header_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header_Cbox.FormattingEnabled = True
        Me.Header_Cbox.Location = New System.Drawing.Point(514, 182)
        Me.Header_Cbox.Name = "Header_Cbox"
        Me.Header_Cbox.Size = New System.Drawing.Size(299, 25)
        Me.Header_Cbox.TabIndex = 26
        Me.Header_Cbox.Tag = "HEADER"
        '
        'Location_Tbox
        '
        Me.Location_Tbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location_Tbox.Location = New System.Drawing.Point(514, 147)
        Me.Location_Tbox.Name = "Location_Tbox"
        Me.Location_Tbox.Size = New System.Drawing.Size(299, 25)
        Me.Location_Tbox.TabIndex = 25
        '
        'UnitPrice_Tbox
        '
        Me.UnitPrice_Tbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPrice_Tbox.Location = New System.Drawing.Point(514, 112)
        Me.UnitPrice_Tbox.Name = "UnitPrice_Tbox"
        Me.UnitPrice_Tbox.Size = New System.Drawing.Size(299, 25)
        Me.UnitPrice_Tbox.TabIndex = 24
        Me.UnitPrice_Tbox.Tag = "Unit Price"
        Me.UnitPrice_Tbox.Text = "0.0"
        '
        'Monetary_Tbox
        '
        Me.Monetary_Tbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monetary_Tbox.Location = New System.Drawing.Point(514, 77)
        Me.Monetary_Tbox.Name = "Monetary_Tbox"
        Me.Monetary_Tbox.Size = New System.Drawing.Size(299, 25)
        Me.Monetary_Tbox.TabIndex = 23
        '
        'UFactor_Tbox
        '
        Me.UFactor_Tbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UFactor_Tbox.Location = New System.Drawing.Point(514, 42)
        Me.UFactor_Tbox.Name = "UFactor_Tbox"
        Me.UFactor_Tbox.Size = New System.Drawing.Size(299, 25)
        Me.UFactor_Tbox.TabIndex = 22
        Me.UFactor_Tbox.Tag = "Unit Factor"
        Me.UFactor_Tbox.Text = "0"
        '
        'Unit_Tbox
        '
        Me.Unit_Tbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_Tbox.Location = New System.Drawing.Point(345, 217)
        Me.Unit_Tbox.Name = "Unit_Tbox"
        Me.Unit_Tbox.Size = New System.Drawing.Size(65, 25)
        Me.Unit_Tbox.TabIndex = 21
        '
        'Min_Tbox
        '
        Me.Min_Tbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min_Tbox.Location = New System.Drawing.Point(229, 217)
        Me.Min_Tbox.Name = "Min_Tbox"
        Me.Min_Tbox.Size = New System.Drawing.Size(65, 25)
        Me.Min_Tbox.TabIndex = 20
        Me.Min_Tbox.Tag = "Minimum Quantity"
        Me.Min_Tbox.Text = "0"
        '
        'Qty_Tbox
        '
        Me.Qty_Tbox.BackColor = System.Drawing.SystemColors.Window
        Me.Qty_Tbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_Tbox.Location = New System.Drawing.Point(111, 217)
        Me.Qty_Tbox.Name = "Qty_Tbox"
        Me.Qty_Tbox.Size = New System.Drawing.Size(65, 25)
        Me.Qty_Tbox.TabIndex = 19
        Me.Qty_Tbox.Tag = "Quantity"
        Me.Qty_Tbox.Text = "0"
        '
        'Desc_Tbox
        '
        Me.Desc_Tbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc_Tbox.Location = New System.Drawing.Point(111, 182)
        Me.Desc_Tbox.Name = "Desc_Tbox"
        Me.Desc_Tbox.Size = New System.Drawing.Size(299, 25)
        Me.Desc_Tbox.TabIndex = 18
        '
        'ArticleNo_Cbox
        '
        Me.ArticleNo_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ArticleNo_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ArticleNo_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArticleNo_Cbox.FormattingEnabled = True
        Me.ArticleNo_Cbox.Location = New System.Drawing.Point(111, 147)
        Me.ArticleNo_Cbox.Name = "ArticleNo_Cbox"
        Me.ArticleNo_Cbox.Size = New System.Drawing.Size(299, 25)
        Me.ArticleNo_Cbox.TabIndex = 17
        Me.ArticleNo_Cbox.Tag = "ARTICLENO"
        '
        'TypeColor_Cbox
        '
        Me.TypeColor_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TypeColor_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TypeColor_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeColor_Cbox.FormattingEnabled = True
        Me.TypeColor_Cbox.Location = New System.Drawing.Point(111, 112)
        Me.TypeColor_Cbox.Name = "TypeColor_Cbox"
        Me.TypeColor_Cbox.Size = New System.Drawing.Size(299, 25)
        Me.TypeColor_Cbox.TabIndex = 16
        Me.TypeColor_Cbox.Tag = "TYPECOLOR"
        '
        'Costhead_Cbox
        '
        Me.Costhead_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Costhead_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Costhead_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costhead_Cbox.FormattingEnabled = True
        Me.Costhead_Cbox.Location = New System.Drawing.Point(111, 77)
        Me.Costhead_Cbox.Name = "Costhead_Cbox"
        Me.Costhead_Cbox.Size = New System.Drawing.Size(299, 25)
        Me.Costhead_Cbox.TabIndex = 15
        Me.Costhead_Cbox.Tag = "COSTHEAD"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel13.Location = New System.Drawing.Point(423, 112)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(85, 25)
        Me.MetroLabel13.TabIndex = 14
        Me.MetroLabel13.Text = "Unit Price"
        Me.MetroLabel13.UseCustomBackColor = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.Location = New System.Drawing.Point(182, 217)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(41, 25)
        Me.MetroLabel12.TabIndex = 13
        Me.MetroLabel12.Text = "Min"
        Me.MetroLabel12.UseCustomBackColor = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.Location = New System.Drawing.Point(11, 112)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(94, 25)
        Me.MetroLabel11.TabIndex = 12
        Me.MetroLabel11.Text = "Type/Color"
        Me.MetroLabel11.UseCustomBackColor = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel10.Location = New System.Drawing.Point(298, 217)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(43, 25)
        Me.MetroLabel10.TabIndex = 11
        Me.MetroLabel10.Text = "Unit"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.Location = New System.Drawing.Point(423, 77)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(85, 25)
        Me.MetroLabel9.TabIndex = 10
        Me.MetroLabel9.Text = "Monetary"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.Location = New System.Drawing.Point(432, 42)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel8.TabIndex = 9
        Me.MetroLabel8.Text = "U-Factor"
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(441, 182)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(67, 25)
        Me.MetroLabel7.TabIndex = 8
        Me.MetroLabel7.Text = "Header"
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(432, 147)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel6.TabIndex = 7
        Me.MetroLabel6.Text = "Location"
        Me.MetroLabel6.UseCustomBackColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(28, 217)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(77, 25)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Quantity"
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(8, 182)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(97, 25)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Description"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(13, 147)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(92, 25)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Article No."
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(22, 77)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(83, 25)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Costhead"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(31, 42)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(74, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Supplier"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'Mode_Lbl
        '
        Me.Mode_Lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Mode_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Mode_Lbl.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Mode_Lbl.Location = New System.Drawing.Point(8, 4)
        Me.Mode_Lbl.Name = "Mode_Lbl"
        Me.Mode_Lbl.Size = New System.Drawing.Size(499, 25)
        Me.Mode_Lbl.TabIndex = 1
        Me.Mode_Lbl.Text = "New"
        Me.Mode_Lbl.UseCustomBackColor = True
        Me.Mode_Lbl.UseCustomForeColor = True
        '
        'Supplier_Cbox
        '
        Me.Supplier_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Supplier_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Supplier_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_Cbox.FormattingEnabled = True
        Me.Supplier_Cbox.Location = New System.Drawing.Point(111, 42)
        Me.Supplier_Cbox.Name = "Supplier_Cbox"
        Me.Supplier_Cbox.Size = New System.Drawing.Size(299, 25)
        Me.Supplier_Cbox.TabIndex = 0
        Me.Supplier_Cbox.Tag = "SUPPLIER"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.LightGray
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(828, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(529, 249)
        Me.RichTextBox1.TabIndex = 27
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Inv_Cmenu
        '
        Me.Inv_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.Inv_Cmenu.Name = "Inv_Cmenu"
        Me.Inv_Cmenu.Size = New System.Drawing.Size(113, 70)
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Mode_Lbl)
        Me.Panel1.Controls.Add(Me.Search_Tbox)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 36)
        Me.Panel1.TabIndex = 832
        '
        'WarehouseInvFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(784, 730)
        Me.Controls.Add(Me.Frm_Pnl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "WarehouseInvFrm"
        Me.Text = "Warehouse Inventory"
        Me.Frm_Pnl.ResumeLayout(False)
        Me.Frm_Split.Panel1.ResumeLayout(False)
        Me.Frm_Split.Panel2.ResumeLayout(False)
        Me.Frm_Split.Panel2.PerformLayout()
        CType(Me.Frm_Split, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frm_Split.ResumeLayout(False)
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Inv_Cmenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Frm_Pnl As Panel
    Friend WithEvents Loading_PB As PictureBox
    Friend WithEvents Inv_Cmenu As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Frm_Split As SplitContainer
    Friend WithEvents Mode_Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Supplier_Cbox As ComboBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Desc_Tbox As TextBox
    Friend WithEvents ArticleNo_Cbox As ComboBox
    Friend WithEvents TypeColor_Cbox As ComboBox
    Friend WithEvents Costhead_Cbox As ComboBox
    Friend WithEvents Qty_Tbox As TextBox
    Friend WithEvents Unit_Tbox As TextBox
    Friend WithEvents Min_Tbox As TextBox
    Friend WithEvents Header_Cbox As ComboBox
    Friend WithEvents Location_Tbox As TextBox
    Friend WithEvents UnitPrice_Tbox As TextBox
    Friend WithEvents Monetary_Tbox As TextBox
    Friend WithEvents UFactor_Tbox As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Search_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel1 As Panel
End Class
