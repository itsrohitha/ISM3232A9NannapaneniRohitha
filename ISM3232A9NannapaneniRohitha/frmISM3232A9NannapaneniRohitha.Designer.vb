<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmISM3232A9NannapaneniRohitha
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnInheritance = New System.Windows.Forms.Button()
        Me.btnPolymorphism = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Script MT Bold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(153, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(286, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ISM 3232 Assignment 9"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Script MT Bold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(153, 85)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(292, 33)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "by Rohitha Nannapaneni"
        '
        'btnInheritance
        '
        Me.btnInheritance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInheritance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInheritance.Location = New System.Drawing.Point(56, 171)
        Me.btnInheritance.Name = "btnInheritance"
        Me.btnInheritance.Size = New System.Drawing.Size(181, 107)
        Me.btnInheritance.TabIndex = 2
        Me.btnInheritance.Text = "Account Balances Using Inheritance"
        Me.btnInheritance.UseVisualStyleBackColor = False
        '
        'btnPolymorphism
        '
        Me.btnPolymorphism.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPolymorphism.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPolymorphism.Location = New System.Drawing.Point(341, 171)
        Me.btnPolymorphism.Name = "btnPolymorphism"
        Me.btnPolymorphism.Size = New System.Drawing.Size(181, 107)
        Me.btnPolymorphism.TabIndex = 3
        Me.btnPolymorphism.Text = "Account Balances Using Polymorphism"
        Me.btnPolymorphism.UseVisualStyleBackColor = False
        '
        'frmISM3232A9NannapaneniRohitha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 334)
        Me.Controls.Add(Me.btnPolymorphism)
        Me.Controls.Add(Me.btnInheritance)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmISM3232A9NannapaneniRohitha"
        Me.Text = "ISM 3232 Assignment 9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnInheritance As Button
    Friend WithEvents btnPolymorphism As Button
End Class
