﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2443
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class ds_citas
    Inherits DataSet
    
    Private tablecitas As citasDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("citas")) Is Nothing) Then
                Me.Tables.Add(New citasDataTable(ds.Tables("citas")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property citas As citasDataTable
        Get
            Return Me.tablecitas
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_citas = CType(MyBase.Clone,ds_citas)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("citas")) Is Nothing) Then
            Me.Tables.Add(New citasDataTable(ds.Tables("citas")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tablecitas = CType(Me.Tables("citas"),citasDataTable)
        If (Not (Me.tablecitas) Is Nothing) Then
            Me.tablecitas.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_citas"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_citas.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablecitas = New citasDataTable
        Me.Tables.Add(Me.tablecitas)
    End Sub
    
    Private Function ShouldSerializecitas() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub citasRowChangeEventHandler(ByVal sender As Object, ByVal e As citasRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class citasDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnestadoCita As DataColumn
        
        Private columnfechaNacimiento As DataColumn
        
        Private columnfechaUltCita As DataColumn
        
        Private columngarante As DataColumn
        
        Private columnhistElectronica As DataColumn
        
        Private columnhora As DataColumn
        
        Private columnnombre As DataColumn
        
        Private columnnumPoliza As DataColumn
        
        Private columnnumeroHc As DataColumn
        
        Private columnobservaciones As DataColumn
        
        Private columnprestacion As DataColumn
        
        Private columnrealizada As DataColumn
        
        Private columntelefono As DataColumn
        
        Friend Sub New()
            MyBase.New("citas")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property estadoCitaColumn As DataColumn
            Get
                Return Me.columnestadoCita
            End Get
        End Property
        
        Friend ReadOnly Property fechaNacimientoColumn As DataColumn
            Get
                Return Me.columnfechaNacimiento
            End Get
        End Property
        
        Friend ReadOnly Property fechaUltCitaColumn As DataColumn
            Get
                Return Me.columnfechaUltCita
            End Get
        End Property
        
        Friend ReadOnly Property garanteColumn As DataColumn
            Get
                Return Me.columngarante
            End Get
        End Property
        
        Friend ReadOnly Property histElectronicaColumn As DataColumn
            Get
                Return Me.columnhistElectronica
            End Get
        End Property
        
        Friend ReadOnly Property horaColumn As DataColumn
            Get
                Return Me.columnhora
            End Get
        End Property
        
        Friend ReadOnly Property nombreColumn As DataColumn
            Get
                Return Me.columnnombre
            End Get
        End Property
        
        Friend ReadOnly Property numPolizaColumn As DataColumn
            Get
                Return Me.columnnumPoliza
            End Get
        End Property
        
        Friend ReadOnly Property numeroHcColumn As DataColumn
            Get
                Return Me.columnnumeroHc
            End Get
        End Property
        
        Friend ReadOnly Property observacionesColumn As DataColumn
            Get
                Return Me.columnobservaciones
            End Get
        End Property
        
        Friend ReadOnly Property prestacionColumn As DataColumn
            Get
                Return Me.columnprestacion
            End Get
        End Property
        
        Friend ReadOnly Property realizadaColumn As DataColumn
            Get
                Return Me.columnrealizada
            End Get
        End Property
        
        Friend ReadOnly Property telefonoColumn As DataColumn
            Get
                Return Me.columntelefono
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As citasRow
            Get
                Return CType(Me.Rows(index),citasRow)
            End Get
        End Property
        
        Public Event citasRowChanged As citasRowChangeEventHandler
        
        Public Event citasRowChanging As citasRowChangeEventHandler
        
        Public Event citasRowDeleted As citasRowChangeEventHandler
        
        Public Event citasRowDeleting As citasRowChangeEventHandler
        
        Public Overloads Sub AddcitasRow(ByVal row As citasRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddcitasRow(ByVal estadoCita As String, ByVal fechaNacimiento As String, ByVal fechaUltCita As String, ByVal garante As String, ByVal histElectronica As String, ByVal hora As String, ByVal nombre As String, ByVal numPoliza As String, ByVal numeroHc As String, ByVal observaciones As String, ByVal prestacion As String, ByVal realizada As String, ByVal telefono As String) As citasRow
            Dim rowcitasRow As citasRow = CType(Me.NewRow,citasRow)
            rowcitasRow.ItemArray = New Object() {estadoCita, fechaNacimiento, fechaUltCita, garante, histElectronica, hora, nombre, numPoliza, numeroHc, observaciones, prestacion, realizada, telefono}
            Me.Rows.Add(rowcitasRow)
            Return rowcitasRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As citasDataTable = CType(MyBase.Clone,citasDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New citasDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnestadoCita = Me.Columns("estadoCita")
            Me.columnfechaNacimiento = Me.Columns("fechaNacimiento")
            Me.columnfechaUltCita = Me.Columns("fechaUltCita")
            Me.columngarante = Me.Columns("garante")
            Me.columnhistElectronica = Me.Columns("histElectronica")
            Me.columnhora = Me.Columns("hora")
            Me.columnnombre = Me.Columns("nombre")
            Me.columnnumPoliza = Me.Columns("numPoliza")
            Me.columnnumeroHc = Me.Columns("numeroHc")
            Me.columnobservaciones = Me.Columns("observaciones")
            Me.columnprestacion = Me.Columns("prestacion")
            Me.columnrealizada = Me.Columns("realizada")
            Me.columntelefono = Me.Columns("telefono")
        End Sub
        
        Private Sub InitClass()
            Me.columnestadoCita = New DataColumn("estadoCita", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnestadoCita)
            Me.columnfechaNacimiento = New DataColumn("fechaNacimiento", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfechaNacimiento)
            Me.columnfechaUltCita = New DataColumn("fechaUltCita", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfechaUltCita)
            Me.columngarante = New DataColumn("garante", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columngarante)
            Me.columnhistElectronica = New DataColumn("histElectronica", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhistElectronica)
            Me.columnhora = New DataColumn("hora", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhora)
            Me.columnnombre = New DataColumn("nombre", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnnombre)
            Me.columnnumPoliza = New DataColumn("numPoliza", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnnumPoliza)
            Me.columnnumeroHc = New DataColumn("numeroHc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnnumeroHc)
            Me.columnobservaciones = New DataColumn("observaciones", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnobservaciones)
            Me.columnprestacion = New DataColumn("prestacion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnprestacion)
            Me.columnrealizada = New DataColumn("realizada", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnrealizada)
            Me.columntelefono = New DataColumn("telefono", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columntelefono)
        End Sub
        
        Public Function NewcitasRow() As citasRow
            Return CType(Me.NewRow,citasRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New citasRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(citasRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.citasRowChangedEvent) Is Nothing) Then
                RaiseEvent citasRowChanged(Me, New citasRowChangeEvent(CType(e.Row,citasRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.citasRowChangingEvent) Is Nothing) Then
                RaiseEvent citasRowChanging(Me, New citasRowChangeEvent(CType(e.Row,citasRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.citasRowDeletedEvent) Is Nothing) Then
                RaiseEvent citasRowDeleted(Me, New citasRowChangeEvent(CType(e.Row,citasRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.citasRowDeletingEvent) Is Nothing) Then
                RaiseEvent citasRowDeleting(Me, New citasRowChangeEvent(CType(e.Row,citasRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovecitasRow(ByVal row As citasRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class citasRow
        Inherits DataRow
        
        Private tablecitas As citasDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablecitas = CType(Me.Table,citasDataTable)
        End Sub
        
        Public Property estadoCita As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.estadoCitaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.estadoCitaColumn) = value
            End Set
        End Property
        
        Public Property fechaNacimiento As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.fechaNacimientoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.fechaNacimientoColumn) = value
            End Set
        End Property
        
        Public Property fechaUltCita As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.fechaUltCitaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.fechaUltCitaColumn) = value
            End Set
        End Property
        
        Public Property garante As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.garanteColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.garanteColumn) = value
            End Set
        End Property
        
        Public Property histElectronica As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.histElectronicaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.histElectronicaColumn) = value
            End Set
        End Property
        
        Public Property hora As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.horaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.horaColumn) = value
            End Set
        End Property
        
        Public Property nombre As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.nombreColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.nombreColumn) = value
            End Set
        End Property
        
        Public Property numPoliza As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.numPolizaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.numPolizaColumn) = value
            End Set
        End Property
        
        Public Property numeroHc As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.numeroHcColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.numeroHcColumn) = value
            End Set
        End Property
        
        Public Property observaciones As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.observacionesColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.observacionesColumn) = value
            End Set
        End Property
        
        Public Property prestacion As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.prestacionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.prestacionColumn) = value
            End Set
        End Property
        
        Public Property realizada As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.realizadaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.realizadaColumn) = value
            End Set
        End Property
        
        Public Property telefono As String
            Get
                Try 
                    Return CType(Me(Me.tablecitas.telefonoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecitas.telefonoColumn) = value
            End Set
        End Property
        
        Public Function IsestadoCitaNull() As Boolean
            Return Me.IsNull(Me.tablecitas.estadoCitaColumn)
        End Function
        
        Public Sub SetestadoCitaNull()
            Me(Me.tablecitas.estadoCitaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsfechaNacimientoNull() As Boolean
            Return Me.IsNull(Me.tablecitas.fechaNacimientoColumn)
        End Function
        
        Public Sub SetfechaNacimientoNull()
            Me(Me.tablecitas.fechaNacimientoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsfechaUltCitaNull() As Boolean
            Return Me.IsNull(Me.tablecitas.fechaUltCitaColumn)
        End Function
        
        Public Sub SetfechaUltCitaNull()
            Me(Me.tablecitas.fechaUltCitaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsgaranteNull() As Boolean
            Return Me.IsNull(Me.tablecitas.garanteColumn)
        End Function
        
        Public Sub SetgaranteNull()
            Me(Me.tablecitas.garanteColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IshistElectronicaNull() As Boolean
            Return Me.IsNull(Me.tablecitas.histElectronicaColumn)
        End Function
        
        Public Sub SethistElectronicaNull()
            Me(Me.tablecitas.histElectronicaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IshoraNull() As Boolean
            Return Me.IsNull(Me.tablecitas.horaColumn)
        End Function
        
        Public Sub SethoraNull()
            Me(Me.tablecitas.horaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsnombreNull() As Boolean
            Return Me.IsNull(Me.tablecitas.nombreColumn)
        End Function
        
        Public Sub SetnombreNull()
            Me(Me.tablecitas.nombreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsnumPolizaNull() As Boolean
            Return Me.IsNull(Me.tablecitas.numPolizaColumn)
        End Function
        
        Public Sub SetnumPolizaNull()
            Me(Me.tablecitas.numPolizaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsnumeroHcNull() As Boolean
            Return Me.IsNull(Me.tablecitas.numeroHcColumn)
        End Function
        
        Public Sub SetnumeroHcNull()
            Me(Me.tablecitas.numeroHcColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsobservacionesNull() As Boolean
            Return Me.IsNull(Me.tablecitas.observacionesColumn)
        End Function
        
        Public Sub SetobservacionesNull()
            Me(Me.tablecitas.observacionesColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsprestacionNull() As Boolean
            Return Me.IsNull(Me.tablecitas.prestacionColumn)
        End Function
        
        Public Sub SetprestacionNull()
            Me(Me.tablecitas.prestacionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsrealizadaNull() As Boolean
            Return Me.IsNull(Me.tablecitas.realizadaColumn)
        End Function
        
        Public Sub SetrealizadaNull()
            Me(Me.tablecitas.realizadaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IstelefonoNull() As Boolean
            Return Me.IsNull(Me.tablecitas.telefonoColumn)
        End Function
        
        Public Sub SettelefonoNull()
            Me(Me.tablecitas.telefonoColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class citasRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As citasRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As citasRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As citasRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
