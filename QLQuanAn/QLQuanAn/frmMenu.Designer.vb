﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.nmGia = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dtgvMenuMonAnChiNhanh = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txbTenChiNhanh = New System.Windows.Forms.TextBox()
        Me.btnTimKiemChiNhanh = New System.Windows.Forms.Button()
        Me.txbTenMonAn = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.dtgvMenuChiNhanh = New System.Windows.Forms.DataGridView()
        Me.dtgvMenuMonAn = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.nmGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvMenuMonAnChiNhanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgvMenuChiNhanh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvMenuMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.nmGia)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnXoa)
        Me.Panel2.Controls.Add(Me.btnSua)
        Me.Panel2.Controls.Add(Me.btnThem)
        Me.Panel2.Controls.Add(Me.dtgvMenuMonAnChiNhanh)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(541, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 450)
        Me.Panel2.TabIndex = 41
        '
        'nmGia
        '
        Me.nmGia.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nmGia.Location = New System.Drawing.Point(82, 19)
        Me.nmGia.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nmGia.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nmGia.Name = "nmGia"
        Me.nmGia.Size = New System.Drawing.Size(148, 20)
        Me.nmGia.TabIndex = 5
        Me.nmGia.ThousandsSeparator = True
        Me.nmGia.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Giá"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(172, 55)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(72, 23)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(94, 55)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(72, 23)
        Me.btnSua.TabIndex = 7
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(16, 55)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(72, 23)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dtgvMenuMonAnChiNhanh
        '
        Me.dtgvMenuMonAnChiNhanh.AllowUserToAddRows = False
        Me.dtgvMenuMonAnChiNhanh.AllowUserToDeleteRows = False
        Me.dtgvMenuMonAnChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgvMenuMonAnChiNhanh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgvMenuMonAnChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvMenuMonAnChiNhanh.Location = New System.Drawing.Point(5, 84)
        Me.dtgvMenuMonAnChiNhanh.Name = "dtgvMenuMonAnChiNhanh"
        Me.dtgvMenuMonAnChiNhanh.Size = New System.Drawing.Size(248, 354)
        Me.dtgvMenuMonAnChiNhanh.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txbTenChiNhanh)
        Me.Panel1.Controls.Add(Me.btnTimKiemChiNhanh)
        Me.Panel1.Controls.Add(Me.txbTenMonAn)
        Me.Panel1.Controls.Add(Me.btnTimKiem)
        Me.Panel1.Controls.Add(Me.dtgvMenuChiNhanh)
        Me.Panel1.Controls.Add(Me.dtgvMenuMonAn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 450)
        Me.Panel1.TabIndex = 40
        '
        'txbTenChiNhanh
        '
        Me.txbTenChiNhanh.Location = New System.Drawing.Point(109, 226)
        Me.txbTenChiNhanh.Name = "txbTenChiNhanh"
        Me.txbTenChiNhanh.Size = New System.Drawing.Size(172, 20)
        Me.txbTenChiNhanh.TabIndex = 3
        Me.txbTenChiNhanh.Text = "Tên chi nhánh"
        '
        'btnTimKiemChiNhanh
        '
        Me.btnTimKiemChiNhanh.Location = New System.Drawing.Point(287, 224)
        Me.btnTimKiemChiNhanh.Name = "btnTimKiemChiNhanh"
        Me.btnTimKiemChiNhanh.Size = New System.Drawing.Size(72, 23)
        Me.btnTimKiemChiNhanh.TabIndex = 4
        Me.btnTimKiemChiNhanh.Text = "Tìm kiếm"
        Me.btnTimKiemChiNhanh.UseVisualStyleBackColor = True
        '
        'txbTenMonAn
        '
        Me.txbTenMonAn.Location = New System.Drawing.Point(109, 15)
        Me.txbTenMonAn.Name = "txbTenMonAn"
        Me.txbTenMonAn.Size = New System.Drawing.Size(172, 20)
        Me.txbTenMonAn.TabIndex = 1
        Me.txbTenMonAn.Text = "Tên món ăn"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(287, 12)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(72, 23)
        Me.btnTimKiem.TabIndex = 2
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'dtgvMenuChiNhanh
        '
        Me.dtgvMenuChiNhanh.AllowUserToAddRows = False
        Me.dtgvMenuChiNhanh.AllowUserToDeleteRows = False
        Me.dtgvMenuChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgvMenuChiNhanh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgvMenuChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvMenuChiNhanh.Location = New System.Drawing.Point(11, 258)
        Me.dtgvMenuChiNhanh.Name = "dtgvMenuChiNhanh"
        Me.dtgvMenuChiNhanh.Size = New System.Drawing.Size(518, 181)
        Me.dtgvMenuChiNhanh.TabIndex = 51
        '
        'dtgvMenuMonAn
        '
        Me.dtgvMenuMonAn.AllowUserToAddRows = False
        Me.dtgvMenuMonAn.AllowUserToDeleteRows = False
        Me.dtgvMenuMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgvMenuMonAn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgvMenuMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvMenuMonAn.Location = New System.Drawing.Point(11, 42)
        Me.dtgvMenuMonAn.Name = "dtgvMenuMonAn"
        Me.dtgvMenuMonAn.Size = New System.Drawing.Size(518, 167)
        Me.dtgvMenuMonAn.TabIndex = 50
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.nmGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvMenuMonAnChiNhanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgvMenuChiNhanh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvMenuMonAn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dtgvMenuMonAnChiNhanh As DataGridView
    Friend WithEvents nmGia As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txbTenChiNhanh As TextBox
    Friend WithEvents btnTimKiemChiNhanh As Button
    Friend WithEvents txbTenMonAn As TextBox
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents dtgvMenuChiNhanh As DataGridView
    Friend WithEvents dtgvMenuMonAn As DataGridView
End Class
