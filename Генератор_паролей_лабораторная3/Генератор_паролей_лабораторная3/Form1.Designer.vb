<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "P(вероятность)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "V(скорость перебора)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "T(срок действия пароля)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "S*(нижняя граница паролей)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "A(мощность алфавита)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "L(длина пароля)"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(200, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "10"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(200, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 24)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "7"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(200, 15)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 24)
        Me.TextBox3.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(385, 15)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Латинские большие"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(385, 37)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(140, 17)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Латинские маленькие"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(385, 60)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "Русские большие"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(385, 83)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox4.TabIndex = 12
        Me.CheckBox4.Text = "Русские маленькие"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(385, 106)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox5.TabIndex = 13
        Me.CheckBox5.Text = "Символы"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(385, 129)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox6.TabIndex = 14
        Me.CheckBox6.Text = "Цифры"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Пароль:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 26)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Сформировать пароль"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(83, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(223, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(197, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(140, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Label11"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 295)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Генератор паролей"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
