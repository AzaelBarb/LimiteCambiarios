<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoreo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbRangoFechas = New System.Windows.Forms.RadioButton()
        Me.rbDia = New System.Windows.Forms.RadioButton()
        Me.gpbCriterios = New System.Windows.Forms.GroupBox()
        Me.dtFFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdBusqueda = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.colNombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumeroOpera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoOper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMontoOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraOpera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImporteLiq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDivisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraLiq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImportePend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCanalOper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.gpbCriterios.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRangoFechas)
        Me.GroupBox1.Controls.Add(Me.rbDia)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(241, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'rbRangoFechas
        '
        Me.rbRangoFechas.AutoSize = True
        Me.rbRangoFechas.Location = New System.Drawing.Point(31, 104)
        Me.rbRangoFechas.Name = "rbRangoFechas"
        Me.rbRangoFechas.Size = New System.Drawing.Size(133, 20)
        Me.rbRangoFechas.TabIndex = 1
        Me.rbRangoFechas.TabStop = True
        Me.rbRangoFechas.Text = "Rango de Fechas"
        Me.rbRangoFechas.UseVisualStyleBackColor = True
        '
        'rbDia
        '
        Me.rbDia.AutoSize = True
        Me.rbDia.Location = New System.Drawing.Point(31, 37)
        Me.rbDia.Name = "rbDia"
        Me.rbDia.Size = New System.Drawing.Size(70, 20)
        Me.rbDia.TabIndex = 0
        Me.rbDia.TabStop = True
        Me.rbDia.Text = "Por Dia"
        Me.rbDia.UseVisualStyleBackColor = True
        '
        'gpbCriterios
        '
        Me.gpbCriterios.Controls.Add(Me.dtFFinal)
        Me.gpbCriterios.Controls.Add(Me.dtFInicial)
        Me.gpbCriterios.Controls.Add(Me.Label2)
        Me.gpbCriterios.Controls.Add(Me.Label1)
        Me.gpbCriterios.Location = New System.Drawing.Point(266, 13)
        Me.gpbCriterios.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbCriterios.Name = "gpbCriterios"
        Me.gpbCriterios.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbCriterios.Size = New System.Drawing.Size(236, 170)
        Me.gpbCriterios.TabIndex = 1
        Me.gpbCriterios.TabStop = False
        Me.gpbCriterios.Text = "Criterio"
        '
        'dtFFinal
        '
        Me.dtFFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFFinal.Location = New System.Drawing.Point(29, 123)
        Me.dtFFinal.Name = "dtFFinal"
        Me.dtFFinal.Size = New System.Drawing.Size(170, 22)
        Me.dtFFinal.TabIndex = 3
        '
        'dtFInicial
        '
        Me.dtFInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFInicial.Location = New System.Drawing.Point(29, 48)
        Me.dtFInicial.Name = "dtFInicial"
        Me.dtFInicial.Size = New System.Drawing.Size(170, 22)
        Me.dtFInicial.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Inicial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicial:"
        '
        'cmdBusqueda
        '
        Me.cmdBusqueda.Location = New System.Drawing.Point(509, 154)
        Me.cmdBusqueda.Name = "cmdBusqueda"
        Me.cmdBusqueda.Size = New System.Drawing.Size(134, 29)
        Me.cmdBusqueda.TabIndex = 3
        Me.cmdBusqueda.Text = "Realizar Busqueda"
        Me.cmdBusqueda.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdExportar)
        Me.GroupBox3.Controls.Add(Me.dgvResultado)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 189)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(928, 424)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultados"
        '
        'cmdExportar
        '
        Me.cmdExportar.Location = New System.Drawing.Point(817, 21)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(105, 24)
        Me.cmdExportar.TabIndex = 4
        Me.cmdExportar.Text = "Exportar Excel"
        Me.cmdExportar.UseVisualStyleBackColor = True
        '
        'dgvResultado
        '
        Me.dgvResultado.AllowUserToAddRows = False
        Me.dgvResultado.AllowUserToDeleteRows = False
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNombreCliente, Me.colNumeroOpera, Me.colTipoOper, Me.colMontoOperacion, Me.colHoraOpera, Me.colImporteLiq, Me.colDivisa, Me.colHoraLiq, Me.colImportePend, Me.colEstatus, Me.colCanalOper})
        Me.dgvResultado.Location = New System.Drawing.Point(6, 51)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.ReadOnly = True
        Me.dgvResultado.Size = New System.Drawing.Size(916, 367)
        Me.dgvResultado.TabIndex = 3
        '
        'colNombreCliente
        '
        Me.colNombreCliente.HeaderText = "Nombre Cliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.ReadOnly = True
        '
        'colNumeroOpera
        '
        Me.colNumeroOpera.HeaderText = "Numero Operacion"
        Me.colNumeroOpera.Name = "colNumeroOpera"
        Me.colNumeroOpera.ReadOnly = True
        '
        'colTipoOper
        '
        Me.colTipoOper.HeaderText = "Tipo Operacion"
        Me.colTipoOper.Name = "colTipoOper"
        Me.colTipoOper.ReadOnly = True
        '
        'colMontoOperacion
        '
        Me.colMontoOperacion.HeaderText = "Monto Operacion"
        Me.colMontoOperacion.Name = "colMontoOperacion"
        Me.colMontoOperacion.ReadOnly = True
        '
        'colHoraOpera
        '
        Me.colHoraOpera.HeaderText = "Hora Operacion"
        Me.colHoraOpera.Name = "colHoraOpera"
        Me.colHoraOpera.ReadOnly = True
        '
        'colImporteLiq
        '
        Me.colImporteLiq.HeaderText = "Importe a Liquidar"
        Me.colImporteLiq.Name = "colImporteLiq"
        Me.colImporteLiq.ReadOnly = True
        '
        'colDivisa
        '
        Me.colDivisa.HeaderText = "Divisa"
        Me.colDivisa.Name = "colDivisa"
        Me.colDivisa.ReadOnly = True
        '
        'colHoraLiq
        '
        Me.colHoraLiq.HeaderText = "Hora de Liquidacion"
        Me.colHoraLiq.Name = "colHoraLiq"
        Me.colHoraLiq.ReadOnly = True
        '
        'colImportePend
        '
        Me.colImportePend.HeaderText = "Importe Pendiente"
        Me.colImportePend.Name = "colImportePend"
        Me.colImportePend.ReadOnly = True
        '
        'colEstatus
        '
        Me.colEstatus.HeaderText = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        Me.colEstatus.ReadOnly = True
        '
        'colCanalOper
        '
        Me.colCanalOper.HeaderText = "Canal de Opeacion"
        Me.colCanalOper.Name = "colCanalOper"
        Me.colCanalOper.ReadOnly = True
        '
        'frmMonitoreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(958, 625)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdBusqueda)
        Me.Controls.Add(Me.gpbCriterios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMonitoreo"
        Me.Text = "Monitoreo de Operaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbCriterios.ResumeLayout(False)
        Me.gpbCriterios.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbRangoFechas As RadioButton
    Friend WithEvents rbDia As RadioButton
    Friend WithEvents gpbCriterios As GroupBox
    Friend WithEvents dtFFinal As DateTimePicker
    Friend WithEvents dtFInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdBusqueda As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdExportar As Button
    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents colNombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents colNumeroOpera As DataGridViewTextBoxColumn
    Friend WithEvents colTipoOper As DataGridViewTextBoxColumn
    Friend WithEvents colMontoOperacion As DataGridViewTextBoxColumn
    Friend WithEvents colHoraOpera As DataGridViewTextBoxColumn
    Friend WithEvents colImporteLiq As DataGridViewTextBoxColumn
    Friend WithEvents colDivisa As DataGridViewTextBoxColumn
    Friend WithEvents colHoraLiq As DataGridViewTextBoxColumn
    Friend WithEvents colImportePend As DataGridViewTextBoxColumn
    Friend WithEvents colEstatus As DataGridViewTextBoxColumn
    Friend WithEvents colCanalOper As DataGridViewTextBoxColumn
End Class
