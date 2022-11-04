<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCobranza
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmdBusqueda = New System.Windows.Forms.Button()
        Me.txtCriterio = New System.Windows.Forms.TextBox()
        Me.lblCriterio = New System.Windows.Forms.Label()
        Me.rbNoCliente = New System.Windows.Forms.RadioButton()
        Me.rbNoLC = New System.Windows.Forms.RadioButton()
        Me.rbNoOpera = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblImporteVenci = New System.Windows.Forms.Label()
        Me.lblNoOperaciones = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblNoCliente = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblEstatusLC = New System.Windows.Forms.Label()
        Me.lblFechaApert = New System.Windows.Forms.Label()
        Me.lblNoLC = New System.Windows.Forms.Label()
        Me.lblFechaOrig = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblDivisa = New System.Windows.Forms.Label()
        Me.lblMontoOtor = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.cboNumeroCuenta = New System.Windows.Forms.ComboBox()
        Me.cmdAplicarPago = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNoOpera)
        Me.GroupBox1.Controls.Add(Me.rbNoLC)
        Me.GroupBox1.Controls.Add(Me.rbNoCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Busqueda"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCriterio)
        Me.GroupBox2.Controls.Add(Me.txtCriterio)
        Me.GroupBox2.Controls.Add(Me.cmdBusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 156)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Criterios de Busqueda"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(684, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(555, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'cmdBusqueda
        '
        Me.cmdBusqueda.Location = New System.Drawing.Point(290, 124)
        Me.cmdBusqueda.Name = "cmdBusqueda"
        Me.cmdBusqueda.Size = New System.Drawing.Size(119, 26)
        Me.cmdBusqueda.TabIndex = 0
        Me.cmdBusqueda.Text = "Realiza Busqueda"
        Me.cmdBusqueda.UseVisualStyleBackColor = True
        '
        'txtCriterio
        '
        Me.txtCriterio.Location = New System.Drawing.Point(12, 43)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(208, 20)
        Me.txtCriterio.TabIndex = 1
        '
        'lblCriterio
        '
        Me.lblCriterio.Location = New System.Drawing.Point(12, 18)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(207, 25)
        Me.lblCriterio.TabIndex = 2
        Me.lblCriterio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbNoCliente
        '
        Me.rbNoCliente.AutoSize = True
        Me.rbNoCliente.Location = New System.Drawing.Point(17, 26)
        Me.rbNoCliente.Name = "rbNoCliente"
        Me.rbNoCliente.Size = New System.Drawing.Size(112, 17)
        Me.rbNoCliente.TabIndex = 0
        Me.rbNoCliente.TabStop = True
        Me.rbNoCliente.Text = "Numero de Cliente"
        Me.rbNoCliente.UseVisualStyleBackColor = True
        '
        'rbNoLC
        '
        Me.rbNoLC.AutoSize = True
        Me.rbNoLC.Location = New System.Drawing.Point(17, 72)
        Me.rbNoLC.Name = "rbNoLC"
        Me.rbNoLC.Size = New System.Drawing.Size(96, 17)
        Me.rbNoLC.TabIndex = 1
        Me.rbNoLC.TabStop = True
        Me.rbNoLC.Text = "Numero de LC:"
        Me.rbNoLC.UseVisualStyleBackColor = True
        '
        'rbNoOpera
        '
        Me.rbNoOpera.AutoSize = True
        Me.rbNoOpera.Location = New System.Drawing.Point(17, 124)
        Me.rbNoOpera.Name = "rbNoOpera"
        Me.rbNoOpera.Size = New System.Drawing.Size(126, 17)
        Me.rbNoOpera.TabIndex = 2
        Me.rbNoOpera.TabStop = True
        Me.rbNoOpera.Text = "Numeo de Operacion"
        Me.rbNoOpera.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblMontoOtor)
        Me.GroupBox3.Controls.Add(Me.lblDivisa)
        Me.GroupBox3.Controls.Add(Me.lblProducto)
        Me.GroupBox3.Controls.Add(Me.lblFechaOrig)
        Me.GroupBox3.Controls.Add(Me.lblNoLC)
        Me.GroupBox3.Controls.Add(Me.lblFechaApert)
        Me.GroupBox3.Controls.Add(Me.lblEstatusLC)
        Me.GroupBox3.Controls.Add(Me.lblSucursal)
        Me.GroupBox3.Controls.Add(Me.lblNombreCliente)
        Me.GroupBox3.Controls.Add(Me.lblNoCliente)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblNoOperaciones)
        Me.GroupBox3.Controls.Add(Me.lblImporteVenci)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 169)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1220, 326)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1201, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "D A T O S    G E N E R A L E S"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1201, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Detalle Limite Cambiario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Importe del Vencimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Numero de Operaciones al Vencimiento:"
        '
        'lblImporteVenci
        '
        Me.lblImporteVenci.AutoSize = True
        Me.lblImporteVenci.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteVenci.Location = New System.Drawing.Point(266, 230)
        Me.lblImporteVenci.Name = "lblImporteVenci"
        Me.lblImporteVenci.Size = New System.Drawing.Size(0, 13)
        Me.lblImporteVenci.TabIndex = 4
        '
        'lblNoOperaciones
        '
        Me.lblNoOperaciones.AutoSize = True
        Me.lblNoOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOperaciones.Location = New System.Drawing.Point(266, 278)
        Me.lblNoOperaciones.Name = "lblNoOperaciones"
        Me.lblNoOperaciones.Size = New System.Drawing.Size(0, 13)
        Me.lblNoOperaciones.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Numero de Cliente:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nombre del Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Fecha de Apertura:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(83, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Sucursal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(71, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Estatus LC:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(677, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Divisa:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(661, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Producto:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(621, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Monto Otorgado:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(591, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Fecha de Originacion:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(632, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Numero de LC:"
        '
        'lblNoCliente
        '
        Me.lblNoCliente.AutoSize = True
        Me.lblNoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoCliente.Location = New System.Drawing.Point(149, 56)
        Me.lblNoCliente.Name = "lblNoCliente"
        Me.lblNoCliente.Size = New System.Drawing.Size(14, 13)
        Me.lblNoCliente.TabIndex = 16
        Me.lblNoCliente.Text = "L"
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(149, 81)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(14, 13)
        Me.lblNombreCliente.TabIndex = 17
        Me.lblNombreCliente.Text = "L"
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(149, 107)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(14, 13)
        Me.lblSucursal.TabIndex = 18
        Me.lblSucursal.Text = "L"
        '
        'lblEstatusLC
        '
        Me.lblEstatusLC.AutoSize = True
        Me.lblEstatusLC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatusLC.Location = New System.Drawing.Point(149, 132)
        Me.lblEstatusLC.Name = "lblEstatusLC"
        Me.lblEstatusLC.Size = New System.Drawing.Size(14, 13)
        Me.lblEstatusLC.TabIndex = 19
        Me.lblEstatusLC.Text = "L"
        '
        'lblFechaApert
        '
        Me.lblFechaApert.AutoSize = True
        Me.lblFechaApert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaApert.Location = New System.Drawing.Point(149, 156)
        Me.lblFechaApert.Name = "lblFechaApert"
        Me.lblFechaApert.Size = New System.Drawing.Size(14, 13)
        Me.lblFechaApert.TabIndex = 20
        Me.lblFechaApert.Text = "L"
        '
        'lblNoLC
        '
        Me.lblNoLC.AutoSize = True
        Me.lblNoLC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoLC.Location = New System.Drawing.Point(729, 56)
        Me.lblNoLC.Name = "lblNoLC"
        Me.lblNoLC.Size = New System.Drawing.Size(14, 13)
        Me.lblNoLC.TabIndex = 21
        Me.lblNoLC.Text = "L"
        '
        'lblFechaOrig
        '
        Me.lblFechaOrig.AutoSize = True
        Me.lblFechaOrig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaOrig.Location = New System.Drawing.Point(729, 81)
        Me.lblFechaOrig.Name = "lblFechaOrig"
        Me.lblFechaOrig.Size = New System.Drawing.Size(14, 13)
        Me.lblFechaOrig.TabIndex = 22
        Me.lblFechaOrig.Text = "L"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(729, 107)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(14, 13)
        Me.lblProducto.TabIndex = 23
        Me.lblProducto.Text = "L"
        '
        'lblDivisa
        '
        Me.lblDivisa.AutoSize = True
        Me.lblDivisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisa.Location = New System.Drawing.Point(729, 132)
        Me.lblDivisa.Name = "lblDivisa"
        Me.lblDivisa.Size = New System.Drawing.Size(14, 13)
        Me.lblDivisa.TabIndex = 24
        Me.lblDivisa.Text = "L"
        '
        'lblMontoOtor
        '
        Me.lblMontoOtor.AutoSize = True
        Me.lblMontoOtor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoOtor.Location = New System.Drawing.Point(729, 156)
        Me.lblMontoOtor.Name = "lblMontoOtor"
        Me.lblMontoOtor.Size = New System.Drawing.Size(14, 13)
        Me.lblMontoOtor.TabIndex = 25
        Me.lblMontoOtor.Text = "L"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(31, 522)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(572, 27)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Detalle Limite Cambiario"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(653, 522)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(579, 27)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Detalle Limite Cambiario"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(34, 565)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(569, 94)
        Me.TextBox1.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(668, 624)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Numero de Cuenta:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(731, 568)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Importe:"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(790, 565)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(189, 20)
        Me.txtImporte.TabIndex = 9
        Me.txtImporte.Text = "$0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboNumeroCuenta
        '
        Me.cboNumeroCuenta.FormattingEnabled = True
        Me.cboNumeroCuenta.Location = New System.Drawing.Point(790, 621)
        Me.cboNumeroCuenta.Name = "cboNumeroCuenta"
        Me.cboNumeroCuenta.Size = New System.Drawing.Size(189, 21)
        Me.cboNumeroCuenta.TabIndex = 10
        '
        'cmdAplicarPago
        '
        Me.cmdAplicarPago.Location = New System.Drawing.Point(1087, 633)
        Me.cmdAplicarPago.Name = "cmdAplicarPago"
        Me.cmdAplicarPago.Size = New System.Drawing.Size(119, 26)
        Me.cmdAplicarPago.TabIndex = 11
        Me.cmdAplicarPago.Text = "Aplicar Pago"
        Me.cmdAplicarPago.UseVisualStyleBackColor = True
        '
        'frmCobranza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1251, 671)
        Me.Controls.Add(Me.cmdAplicarPago)
        Me.Controls.Add(Me.cboNumeroCuenta)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCobranza"
        Me.Text = "Cobranza de las Operaciones de Limite Cambiario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNoOpera As RadioButton
    Friend WithEvents rbNoLC As RadioButton
    Friend WithEvents rbNoCliente As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCriterio As Label
    Friend WithEvents txtCriterio As TextBox
    Friend WithEvents cmdBusqueda As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblMontoOtor As Label
    Friend WithEvents lblDivisa As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblFechaOrig As Label
    Friend WithEvents lblNoLC As Label
    Friend WithEvents lblFechaApert As Label
    Friend WithEvents lblEstatusLC As Label
    Friend WithEvents lblSucursal As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblNoCliente As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNoOperaciones As Label
    Friend WithEvents lblImporteVenci As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents cboNumeroCuenta As ComboBox
    Friend WithEvents cmdAplicarPago As Button
End Class
