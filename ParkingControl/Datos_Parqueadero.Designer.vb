﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Datos_Parqueadero
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
        Me.DNameLabel = New System.Windows.Forms.Label()
        Me.DFare1Label = New System.Windows.Forms.Label()
        Me.DFare2Label = New System.Windows.Forms.Label()
        Me.DFare4Label = New System.Windows.Forms.Label()
        Me.DCapacityLabel = New System.Windows.Forms.Label()
        Me.DAddressLabel = New System.Windows.Forms.Label()
        Me.DNameTextBox = New System.Windows.Forms.TextBox()
        Me.DFare1TextBox = New System.Windows.Forms.TextBox()
        Me.DFare2TextBox = New System.Windows.Forms.TextBox()
        Me.DCapacityTextBox = New System.Windows.Forms.TextBox()
        Me.DFare4TextBox = New System.Windows.Forms.TextBox()
        Me.DAddressTextBox = New System.Windows.Forms.TextBox()
        Me.DSaveButton = New System.Windows.Forms.Button()
        Me.DOpeningTimeLabel = New System.Windows.Forms.Label()
        Me.DScheduleLabel = New System.Windows.Forms.Label()
        Me.DClosingHourLabel = New System.Windows.Forms.Label()
        Me.DDaysComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DDaysComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DOpenHourComboBox = New System.Windows.Forms.ComboBox()
        Me.DCloseHourComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'DNameLabel
        '
        Me.DNameLabel.AutoSize = True
        Me.DNameLabel.Location = New System.Drawing.Point(43, 39)
        Me.DNameLabel.Name = "DNameLabel"
        Me.DNameLabel.Size = New System.Drawing.Size(62, 17)
        Me.DNameLabel.TabIndex = 0
        Me.DNameLabel.Text = "Nombre:"
        '
        'DFare1Label
        '
        Me.DFare1Label.AutoSize = True
        Me.DFare1Label.Location = New System.Drawing.Point(432, 183)
        Me.DFare1Label.Name = "DFare1Label"
        Me.DFare1Label.Size = New System.Drawing.Size(94, 17)
        Me.DFare1Label.TabIndex = 4
        Me.DFare1Label.Text = "Tarifa 1 hora:"
        '
        'DFare2Label
        '
        Me.DFare2Label.AutoSize = True
        Me.DFare2Label.Location = New System.Drawing.Point(432, 112)
        Me.DFare2Label.Name = "DFare2Label"
        Me.DFare2Label.Size = New System.Drawing.Size(106, 17)
        Me.DFare2Label.TabIndex = 5
        Me.DFare2Label.Text = "Tarifa 1/2 hora:"
        '
        'DFare4Label
        '
        Me.DFare4Label.AutoSize = True
        Me.DFare4Label.Location = New System.Drawing.Point(432, 41)
        Me.DFare4Label.Name = "DFare4Label"
        Me.DFare4Label.Size = New System.Drawing.Size(106, 17)
        Me.DFare4Label.TabIndex = 6
        Me.DFare4Label.Text = "Tarifa 1/4 hora:"
        '
        'DCapacityLabel
        '
        Me.DCapacityLabel.AutoSize = True
        Me.DCapacityLabel.Location = New System.Drawing.Point(43, 183)
        Me.DCapacityLabel.Name = "DCapacityLabel"
        Me.DCapacityLabel.Size = New System.Drawing.Size(79, 17)
        Me.DCapacityLabel.TabIndex = 7
        Me.DCapacityLabel.Text = "Capacidad:"
        '
        'DAddressLabel
        '
        Me.DAddressLabel.AutoSize = True
        Me.DAddressLabel.Location = New System.Drawing.Point(43, 110)
        Me.DAddressLabel.Name = "DAddressLabel"
        Me.DAddressLabel.Size = New System.Drawing.Size(71, 17)
        Me.DAddressLabel.TabIndex = 8
        Me.DAddressLabel.Text = "Dirección:"
        '
        'DNameTextBox
        '
        Me.DNameTextBox.Location = New System.Drawing.Point(140, 36)
        Me.DNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DNameTextBox.Name = "DNameTextBox"
        Me.DNameTextBox.Size = New System.Drawing.Size(153, 22)
        Me.DNameTextBox.TabIndex = 1
        '
        'DFare1TextBox
        '
        Me.DFare1TextBox.Location = New System.Drawing.Point(555, 178)
        Me.DFare1TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DFare1TextBox.Name = "DFare1TextBox"
        Me.DFare1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.DFare1TextBox.TabIndex = 6
        '
        'DFare2TextBox
        '
        Me.DFare2TextBox.Location = New System.Drawing.Point(555, 105)
        Me.DFare2TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DFare2TextBox.Name = "DFare2TextBox"
        Me.DFare2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.DFare2TextBox.TabIndex = 5
        '
        'DCapacityTextBox
        '
        Me.DCapacityTextBox.Location = New System.Drawing.Point(140, 178)
        Me.DCapacityTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DCapacityTextBox.Name = "DCapacityTextBox"
        Me.DCapacityTextBox.Size = New System.Drawing.Size(112, 22)
        Me.DCapacityTextBox.TabIndex = 3
        '
        'DFare4TextBox
        '
        Me.DFare4TextBox.Location = New System.Drawing.Point(555, 34)
        Me.DFare4TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DFare4TextBox.Name = "DFare4TextBox"
        Me.DFare4TextBox.Size = New System.Drawing.Size(100, 22)
        Me.DFare4TextBox.TabIndex = 4
        '
        'DAddressTextBox
        '
        Me.DAddressTextBox.Location = New System.Drawing.Point(140, 105)
        Me.DAddressTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DAddressTextBox.Name = "DAddressTextBox"
        Me.DAddressTextBox.Size = New System.Drawing.Size(247, 22)
        Me.DAddressTextBox.TabIndex = 2
        '
        'DSaveButton
        '
        Me.DSaveButton.Location = New System.Drawing.Point(311, 393)
        Me.DSaveButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DSaveButton.Name = "DSaveButton"
        Me.DSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.DSaveButton.TabIndex = 11
        Me.DSaveButton.Text = "Guardar"
        Me.DSaveButton.UseVisualStyleBackColor = True
        '
        'DOpeningTimeLabel
        '
        Me.DOpeningTimeLabel.AutoSize = True
        Me.DOpeningTimeLabel.Location = New System.Drawing.Point(43, 329)
        Me.DOpeningTimeLabel.Name = "DOpeningTimeLabel"
        Me.DOpeningTimeLabel.Size = New System.Drawing.Size(122, 17)
        Me.DOpeningTimeLabel.TabIndex = 19
        Me.DOpeningTimeLabel.Text = "Hora de Apertura:"
        '
        'DScheduleLabel
        '
        Me.DScheduleLabel.AutoSize = True
        Me.DScheduleLabel.Location = New System.Drawing.Point(43, 249)
        Me.DScheduleLabel.Name = "DScheduleLabel"
        Me.DScheduleLabel.Size = New System.Drawing.Size(63, 17)
        Me.DScheduleLabel.TabIndex = 23
        Me.DScheduleLabel.Text = "Horario: "
        '
        'DClosingHourLabel
        '
        Me.DClosingHourLabel.AutoSize = True
        Me.DClosingHourLabel.Location = New System.Drawing.Point(432, 329)
        Me.DClosingHourLabel.Name = "DClosingHourLabel"
        Me.DClosingHourLabel.Size = New System.Drawing.Size(118, 17)
        Me.DClosingHourLabel.TabIndex = 24
        Me.DClosingHourLabel.Text = "Hora de Cerrado:"
        '
        'DDaysComboBox
        '
        Me.DDaysComboBox.FormattingEnabled = True
        Me.DDaysComboBox.Items.AddRange(New Object() {"Lun", "Mar", "Mie", "Jue", "Vie", "Sab", "Dom"})
        Me.DDaysComboBox.Location = New System.Drawing.Point(140, 249)
        Me.DDaysComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DDaysComboBox.Name = "DDaysComboBox"
        Me.DDaysComboBox.Size = New System.Drawing.Size(55, 24)
        Me.DDaysComboBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "-"
        '
        'DDaysComboBox2
        '
        Me.DDaysComboBox2.FormattingEnabled = True
        Me.DDaysComboBox2.Items.AddRange(New Object() {"Lun", "Mar", "Mie", "Jue", "Vie", "Sab", "Dom"})
        Me.DDaysComboBox2.Location = New System.Drawing.Point(239, 249)
        Me.DDaysComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DDaysComboBox2.Name = "DDaysComboBox2"
        Me.DDaysComboBox2.Size = New System.Drawing.Size(55, 24)
        Me.DDaysComboBox2.TabIndex = 8
        '
        'DOpenHourComboBox
        '
        Me.DOpenHourComboBox.FormattingEnabled = True
        Me.DOpenHourComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.DOpenHourComboBox.Location = New System.Drawing.Point(239, 326)
        Me.DOpenHourComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DOpenHourComboBox.Name = "DOpenHourComboBox"
        Me.DOpenHourComboBox.Size = New System.Drawing.Size(55, 24)
        Me.DOpenHourComboBox.TabIndex = 9
        '
        'DCloseHourComboBox
        '
        Me.DCloseHourComboBox.FormattingEnabled = True
        Me.DCloseHourComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.DCloseHourComboBox.Location = New System.Drawing.Point(555, 322)
        Me.DCloseHourComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DCloseHourComboBox.Name = "DCloseHourComboBox"
        Me.DCloseHourComboBox.Size = New System.Drawing.Size(55, 24)
        Me.DCloseHourComboBox.TabIndex = 10
        '
        'Datos_Parqueadero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 441)
        Me.Controls.Add(Me.DCloseHourComboBox)
        Me.Controls.Add(Me.DOpenHourComboBox)
        Me.Controls.Add(Me.DDaysComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DDaysComboBox)
        Me.Controls.Add(Me.DClosingHourLabel)
        Me.Controls.Add(Me.DScheduleLabel)
        Me.Controls.Add(Me.DOpeningTimeLabel)
        Me.Controls.Add(Me.DSaveButton)
        Me.Controls.Add(Me.DAddressTextBox)
        Me.Controls.Add(Me.DFare4TextBox)
        Me.Controls.Add(Me.DCapacityTextBox)
        Me.Controls.Add(Me.DFare2TextBox)
        Me.Controls.Add(Me.DFare1TextBox)
        Me.Controls.Add(Me.DNameTextBox)
        Me.Controls.Add(Me.DAddressLabel)
        Me.Controls.Add(Me.DCapacityLabel)
        Me.Controls.Add(Me.DFare4Label)
        Me.Controls.Add(Me.DFare2Label)
        Me.Controls.Add(Me.DFare1Label)
        Me.Controls.Add(Me.DNameLabel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Datos_Parqueadero"
        Me.Text = "Información del Parqueadero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DNameLabel As Label
    Friend WithEvents DFare1Label As Label
    Friend WithEvents DFare2Label As Label
    Friend WithEvents DFare4Label As Label
    Friend WithEvents DCapacityLabel As Label
    Friend WithEvents DAddressLabel As Label
    Friend WithEvents DNameTextBox As TextBox
    Friend WithEvents DFare1TextBox As TextBox
    Friend WithEvents DFare2TextBox As TextBox
    Friend WithEvents DCapacityTextBox As TextBox
    Friend WithEvents DFare4TextBox As TextBox
    Friend WithEvents DAddressTextBox As TextBox
    Friend WithEvents DSaveButton As Button
    Friend WithEvents DOpeningTimeLabel As Label
    Friend WithEvents DScheduleLabel As Label
    Friend WithEvents DClosingHourLabel As Label
    Friend WithEvents DDaysComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DDaysComboBox2 As ComboBox
    Friend WithEvents DOpenHourComboBox As ComboBox
    Friend WithEvents DCloseHourComboBox As ComboBox
End Class
