﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangingGradeRequest
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Close_Btn = New System.Windows.Forms.Button()
        Me.Profile_Label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Approve_Btn = New System.Windows.Forms.Button()
        Me.PendingRequestTable = New System.Windows.Forms.DataGridView()
        Me.Decline_Btn = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PendingRequestTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Close_Btn)
        Me.Panel1.Controls.Add(Me.Profile_Label)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 607)
        Me.Panel1.TabIndex = 0
        '
        'Close_Btn
        '
        Me.Close_Btn.BackColor = System.Drawing.Color.Red
        Me.Close_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Close_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Close_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Btn.ForeColor = System.Drawing.Color.White
        Me.Close_Btn.Location = New System.Drawing.Point(797, 20)
        Me.Close_Btn.Name = "Close_Btn"
        Me.Close_Btn.Size = New System.Drawing.Size(42, 40)
        Me.Close_Btn.TabIndex = 57
        Me.Close_Btn.Text = "X"
        Me.Close_Btn.UseVisualStyleBackColor = False
        '
        'Profile_Label
        '
        Me.Profile_Label.AutoSize = True
        Me.Profile_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profile_Label.ForeColor = System.Drawing.Color.White
        Me.Profile_Label.Location = New System.Drawing.Point(17, 20)
        Me.Profile_Label.Name = "Profile_Label"
        Me.Profile_Label.Size = New System.Drawing.Size(235, 40)
        Me.Profile_Label.TabIndex = 1
        Me.Profile_Label.Text = "Pending Request"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PendingRequestTable)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(16, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(823, 516)
        Me.Panel2.TabIndex = 2
        '
        'Approve_Btn
        '
        Me.Approve_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Approve_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Approve_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Approve_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Approve_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Approve_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Approve_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Approve_Btn.ForeColor = System.Drawing.Color.Black
        Me.Approve_Btn.Location = New System.Drawing.Point(619, 16)
        Me.Approve_Btn.Name = "Approve_Btn"
        Me.Approve_Btn.Size = New System.Drawing.Size(149, 40)
        Me.Approve_Btn.TabIndex = 69
        Me.Approve_Btn.Text = "Approve"
        Me.Approve_Btn.UseVisualStyleBackColor = False
        '
        'PendingRequestTable
        '
        Me.PendingRequestTable.AllowUserToAddRows = False
        Me.PendingRequestTable.AllowUserToResizeColumns = False
        Me.PendingRequestTable.AllowUserToResizeRows = False
        Me.PendingRequestTable.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Bernard MT Condensed", 14.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PendingRequestTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.PendingRequestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PendingRequestTable.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PendingRequestTable.DefaultCellStyle = DataGridViewCellStyle6
        Me.PendingRequestTable.GridColor = System.Drawing.Color.Black
        Me.PendingRequestTable.Location = New System.Drawing.Point(21, 16)
        Me.PendingRequestTable.Name = "PendingRequestTable"
        Me.PendingRequestTable.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PendingRequestTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.PendingRequestTable.RowHeadersVisible = False
        Me.PendingRequestTable.RowHeadersWidth = 51
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PendingRequestTable.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.PendingRequestTable.RowTemplate.Height = 24
        Me.PendingRequestTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PendingRequestTable.Size = New System.Drawing.Size(781, 352)
        Me.PendingRequestTable.TabIndex = 68
        '
        'Decline_Btn
        '
        Me.Decline_Btn.BackColor = System.Drawing.Color.Red
        Me.Decline_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Decline_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Decline_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Decline_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Decline_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Decline_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Decline_Btn.ForeColor = System.Drawing.Color.White
        Me.Decline_Btn.Location = New System.Drawing.Point(619, 62)
        Me.Decline_Btn.Name = "Decline_Btn"
        Me.Decline_Btn.Size = New System.Drawing.Size(149, 40)
        Me.Decline_Btn.TabIndex = 58
        Me.Decline_Btn.Text = "Decline"
        Me.Decline_Btn.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(20, 16)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(574, 86)
        Me.Panel12.TabIndex = 81
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel12)
        Me.Panel3.Controls.Add(Me.Approve_Btn)
        Me.Panel3.Controls.Add(Me.Decline_Btn)
        Me.Panel3.Location = New System.Drawing.Point(21, 380)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(781, 117)
        Me.Panel3.TabIndex = 82
        '
        'ChangingGradeRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ChangingGradeRequest"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PendingRequestTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Profile_Label As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Close_Btn As Button
    Friend WithEvents Decline_Btn As Button
    Friend WithEvents PendingRequestTable As DataGridView
    Friend WithEvents Approve_Btn As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel3 As Panel
End Class
