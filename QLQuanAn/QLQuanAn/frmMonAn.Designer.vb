﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMonAn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonAn))
        Me.dtgvMonAn = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chbXoa = New System.Windows.Forms.CheckBox()
        Me.lbresult = New System.Windows.Forms.Label()
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.cbDanhMucMonAn = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbMotaMonAn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txbNgayCapNhatMonAn = New System.Windows.Forms.TextBox()
        Me.txbNgayTaoMonAn = New System.Windows.Forms.TextBox()
        Me.txbGiaMonAn = New System.Windows.Forms.TextBox()
        Me.txbTenMonAn = New System.Windows.Forms.TextBox()
        Me.txbIdMonAn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtgvMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgvMonAn
        '
        Me.dtgvMonAn.AllowDrop = True
        Me.dtgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgvMonAn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgvMonAn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvMonAn.Location = New System.Drawing.Point(0, 0)
        Me.dtgvMonAn.Name = "dtgvMonAn"
        Me.dtgvMonAn.Size = New System.Drawing.Size(493, 450)
        Me.dtgvMonAn.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chbXoa)
        Me.Panel1.Controls.Add(Me.lbresult)
        Me.Panel1.Controls.Add(Me.txbSearch)
        Me.Panel1.Controls.Add(Me.cbDanhMucMonAn)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txbMotaMonAn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnTimKiem)
        Me.Panel1.Controls.Add(Me.btnXoa)
        Me.Panel1.Controls.Add(Me.btnSua)
        Me.Panel1.Controls.Add(Me.btnThem)
        Me.Panel1.Controls.Add(Me.txbNgayCapNhatMonAn)
        Me.Panel1.Controls.Add(Me.txbNgayTaoMonAn)
        Me.Panel1.Controls.Add(Me.txbGiaMonAn)
        Me.Panel1.Controls.Add(Me.txbTenMonAn)
        Me.Panel1.Controls.Add(Me.txbIdMonAn)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(493, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 450)
        Me.Panel1.TabIndex = 1
        '
        'chbXoa
        '
        Me.chbXoa.AutoSize = True
        Me.chbXoa.Location = New System.Drawing.Point(234, 341)
        Me.chbXoa.Name = "chbXoa"
        Me.chbXoa.Size = New System.Drawing.Size(62, 17)
        Me.chbXoa.TabIndex = 45
        Me.chbXoa.Text = "Đã Xóa"
        Me.chbXoa.UseVisualStyleBackColor = True
        '
        'lbresult
        '
        Me.lbresult.AutoSize = True
        Me.lbresult.Location = New System.Drawing.Point(73, 397)
        Me.lbresult.Name = "lbresult"
        Me.lbresult.Size = New System.Drawing.Size(0, 13)
        Me.lbresult.TabIndex = 44
        '
        'txbSearch
        '
        Me.txbSearch.Location = New System.Drawing.Point(56, 338)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(172, 20)
        Me.txbSearch.TabIndex = 7
        '
        'cbDanhMucMonAn
        '
        Me.cbDanhMucMonAn.FormattingEnabled = True
        Me.cbDanhMucMonAn.Location = New System.Drawing.Point(124, 139)
        Me.cbDanhMucMonAn.Name = "cbDanhMucMonAn"
        Me.cbDanhMucMonAn.Size = New System.Drawing.Size(172, 21)
        Me.cbDanhMucMonAn.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Danh mục"
        '
        'txbMotaMonAn
        '
        Me.txbMotaMonAn.Location = New System.Drawing.Point(124, 175)
        Me.txbMotaMonAn.Name = "txbMotaMonAn"
        Me.txbMotaMonAn.Size = New System.Drawing.Size(172, 20)
        Me.txbMotaMonAn.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Mô tả"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(136, 364)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(72, 23)
        Me.btnTimKiem.TabIndex = 8
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(222, 291)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(72, 23)
        Me.btnXoa.TabIndex = 34
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(114, 291)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(72, 23)
        Me.btnSua.TabIndex = 6
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(6, 291)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(72, 23)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txbNgayCapNhatMonAn
        '
        Me.txbNgayCapNhatMonAn.Location = New System.Drawing.Point(124, 245)
        Me.txbNgayCapNhatMonAn.Name = "txbNgayCapNhatMonAn"
        Me.txbNgayCapNhatMonAn.ReadOnly = True
        Me.txbNgayCapNhatMonAn.Size = New System.Drawing.Size(172, 20)
        Me.txbNgayCapNhatMonAn.TabIndex = 39
        '
        'txbNgayTaoMonAn
        '
        Me.txbNgayTaoMonAn.Location = New System.Drawing.Point(124, 210)
        Me.txbNgayTaoMonAn.Name = "txbNgayTaoMonAn"
        Me.txbNgayTaoMonAn.ReadOnly = True
        Me.txbNgayTaoMonAn.Size = New System.Drawing.Size(172, 20)
        Me.txbNgayTaoMonAn.TabIndex = 38
        '
        'txbGiaMonAn
        '
        Me.txbGiaMonAn.Location = New System.Drawing.Point(124, 104)
        Me.txbGiaMonAn.Name = "txbGiaMonAn"
        Me.txbGiaMonAn.Size = New System.Drawing.Size(172, 20)
        Me.txbGiaMonAn.TabIndex = 2
        '
        'txbTenMonAn
        '
        Me.txbTenMonAn.Location = New System.Drawing.Point(124, 69)
        Me.txbTenMonAn.Name = "txbTenMonAn"
        Me.txbTenMonAn.Size = New System.Drawing.Size(172, 20)
        Me.txbTenMonAn.TabIndex = 1
        '
        'txbIdMonAn
        '
        Me.txbIdMonAn.Location = New System.Drawing.Point(124, 34)
        Me.txbIdMonAn.Name = "txbIdMonAn"
        Me.txbIdMonAn.ReadOnly = True
        Me.txbIdMonAn.Size = New System.Drawing.Size(172, 20)
        Me.txbIdMonAn.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Ngày tạo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Ngày cập nhật"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Giá"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Tên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Thông tin món ăn"
        '
        'frmMonAn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtgvMonAn)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMonAn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Món Ăn"
        CType(Me.dtgvMonAn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgvMonAn As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbDanhMucMonAn As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txbMotaMonAn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents txbNgayCapNhatMonAn As TextBox
    Friend WithEvents txbNgayTaoMonAn As TextBox
    Friend WithEvents txbGiaMonAn As TextBox
    Friend WithEvents txbTenMonAn As TextBox
    Friend WithEvents txbIdMonAn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbresult As Label
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents chbXoa As CheckBox
End Class
