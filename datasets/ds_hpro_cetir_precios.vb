﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2407
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
Public Class ds_hpro_cetir_precios
    Inherits DataSet
    
    Private tablecima_hpro_cetir_precios As cima_hpro_cetir_preciosDataTable
    
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
            If (Not (ds.Tables("cima_hpro_cetir_precios")) Is Nothing) Then
                Me.Tables.Add(New cima_hpro_cetir_preciosDataTable(ds.Tables("cima_hpro_cetir_precios")))
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
    Public ReadOnly Property cima_hpro_cetir_precios As cima_hpro_cetir_preciosDataTable
        Get
            Return Me.tablecima_hpro_cetir_precios
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_hpro_cetir_precios = CType(MyBase.Clone,ds_hpro_cetir_precios)
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
        If (Not (ds.Tables("cima_hpro_cetir_precios")) Is Nothing) Then
            Me.Tables.Add(New cima_hpro_cetir_preciosDataTable(ds.Tables("cima_hpro_cetir_precios")))
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
        Me.tablecima_hpro_cetir_precios = CType(Me.Tables("cima_hpro_cetir_precios"),cima_hpro_cetir_preciosDataTable)
        If (Not (Me.tablecima_hpro_cetir_precios) Is Nothing) Then
            Me.tablecima_hpro_cetir_precios.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_hpro_cetir_precios"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_hpro_cetir_precios.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablecima_hpro_cetir_precios = New cima_hpro_cetir_preciosDataTable
        Me.Tables.Add(Me.tablecima_hpro_cetir_precios)
    End Sub
    
    Private Function ShouldSerializecima_hpro_cetir_precios() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub cima_hpro_cetir_preciosRowChangeEventHandler(ByVal sender As Object, ByVal e As cima_hpro_cetir_preciosRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_hpro_cetir_preciosDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnhpro_key As DataColumn
        
        Private columnhprocode As DataColumn
        
        Private columnhprodesclong As DataColumn
        
        Private columnimporte As DataColumn
        
        Friend Sub New()
            MyBase.New("cima_hpro_cetir_precios")
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
        
        Friend ReadOnly Property hpro_keyColumn As DataColumn
            Get
                Return Me.columnhpro_key
            End Get
        End Property
        
        Friend ReadOnly Property hprocodeColumn As DataColumn
            Get
                Return Me.columnhprocode
            End Get
        End Property
        
        Friend ReadOnly Property hprodesclongColumn As DataColumn
            Get
                Return Me.columnhprodesclong
            End Get
        End Property
        
        Friend ReadOnly Property importeColumn As DataColumn
            Get
                Return Me.columnimporte
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As cima_hpro_cetir_preciosRow
            Get
                Return CType(Me.Rows(index),cima_hpro_cetir_preciosRow)
            End Get
        End Property
        
        Public Event cima_hpro_cetir_preciosRowChanged As cima_hpro_cetir_preciosRowChangeEventHandler
        
        Public Event cima_hpro_cetir_preciosRowChanging As cima_hpro_cetir_preciosRowChangeEventHandler
        
        Public Event cima_hpro_cetir_preciosRowDeleted As cima_hpro_cetir_preciosRowChangeEventHandler
        
        Public Event cima_hpro_cetir_preciosRowDeleting As cima_hpro_cetir_preciosRowChangeEventHandler
        
        Public Overloads Sub Addcima_hpro_cetir_preciosRow(ByVal row As cima_hpro_cetir_preciosRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addcima_hpro_cetir_preciosRow(ByVal hpro_key As Integer, ByVal hprocode As String, ByVal hprodesclong As String, ByVal importe As Double) As cima_hpro_cetir_preciosRow
            Dim rowcima_hpro_cetir_preciosRow As cima_hpro_cetir_preciosRow = CType(Me.NewRow,cima_hpro_cetir_preciosRow)
            rowcima_hpro_cetir_preciosRow.ItemArray = New Object() {hpro_key, hprocode, hprodesclong, importe}
            Me.Rows.Add(rowcima_hpro_cetir_preciosRow)
            Return rowcima_hpro_cetir_preciosRow
        End Function
        
        Public Function FindByhpro_key(ByVal hpro_key As Integer) As cima_hpro_cetir_preciosRow
            Return CType(Me.Rows.Find(New Object() {hpro_key}),cima_hpro_cetir_preciosRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As cima_hpro_cetir_preciosDataTable = CType(MyBase.Clone,cima_hpro_cetir_preciosDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New cima_hpro_cetir_preciosDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnhpro_key = Me.Columns("hpro_key")
            Me.columnhprocode = Me.Columns("hprocode")
            Me.columnhprodesclong = Me.Columns("hprodesclong")
            Me.columnimporte = Me.Columns("importe")
        End Sub
        
        Private Sub InitClass()
            Me.columnhpro_key = New DataColumn("hpro_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhpro_key)
            Me.columnhprocode = New DataColumn("hprocode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhprocode)
            Me.columnhprodesclong = New DataColumn("hprodesclong", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhprodesclong)
            Me.columnimporte = New DataColumn("importe", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnimporte)
            Me.Constraints.Add(New UniqueConstraint("ds_hpro_cetir_preciosKey1", New DataColumn() {Me.columnhpro_key}, true))
            Me.columnhpro_key.AllowDBNull = false
            Me.columnhpro_key.Unique = true
        End Sub
        
        Public Function Newcima_hpro_cetir_preciosRow() As cima_hpro_cetir_preciosRow
            Return CType(Me.NewRow,cima_hpro_cetir_preciosRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New cima_hpro_cetir_preciosRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(cima_hpro_cetir_preciosRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.cima_hpro_cetir_preciosRowChangedEvent) Is Nothing) Then
                RaiseEvent cima_hpro_cetir_preciosRowChanged(Me, New cima_hpro_cetir_preciosRowChangeEvent(CType(e.Row,cima_hpro_cetir_preciosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.cima_hpro_cetir_preciosRowChangingEvent) Is Nothing) Then
                RaiseEvent cima_hpro_cetir_preciosRowChanging(Me, New cima_hpro_cetir_preciosRowChangeEvent(CType(e.Row,cima_hpro_cetir_preciosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.cima_hpro_cetir_preciosRowDeletedEvent) Is Nothing) Then
                RaiseEvent cima_hpro_cetir_preciosRowDeleted(Me, New cima_hpro_cetir_preciosRowChangeEvent(CType(e.Row,cima_hpro_cetir_preciosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.cima_hpro_cetir_preciosRowDeletingEvent) Is Nothing) Then
                RaiseEvent cima_hpro_cetir_preciosRowDeleting(Me, New cima_hpro_cetir_preciosRowChangeEvent(CType(e.Row,cima_hpro_cetir_preciosRow), e.Action))
            End If
        End Sub
        
        Public Sub Removecima_hpro_cetir_preciosRow(ByVal row As cima_hpro_cetir_preciosRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_hpro_cetir_preciosRow
        Inherits DataRow
        
        Private tablecima_hpro_cetir_precios As cima_hpro_cetir_preciosDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablecima_hpro_cetir_precios = CType(Me.Table,cima_hpro_cetir_preciosDataTable)
        End Sub
        
        Public Property hpro_key As Integer
            Get
                Return CType(Me(Me.tablecima_hpro_cetir_precios.hpro_keyColumn),Integer)
            End Get
            Set
                Me(Me.tablecima_hpro_cetir_precios.hpro_keyColumn) = value
            End Set
        End Property
        
        Public Property hprocode As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_hpro_cetir_precios.hprocodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_hpro_cetir_precios.hprocodeColumn) = value
            End Set
        End Property
        
        Public Property hprodesclong As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_hpro_cetir_precios.hprodesclongColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_hpro_cetir_precios.hprodesclongColumn) = value
            End Set
        End Property
        
        Public Property importe As Double
            Get
                Try 
                    Return CType(Me(Me.tablecima_hpro_cetir_precios.importeColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_hpro_cetir_precios.importeColumn) = value
            End Set
        End Property
        
        Public Function IshprocodeNull() As Boolean
            Return Me.IsNull(Me.tablecima_hpro_cetir_precios.hprocodeColumn)
        End Function
        
        Public Sub SethprocodeNull()
            Me(Me.tablecima_hpro_cetir_precios.hprocodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IshprodesclongNull() As Boolean
            Return Me.IsNull(Me.tablecima_hpro_cetir_precios.hprodesclongColumn)
        End Function
        
        Public Sub SethprodesclongNull()
            Me(Me.tablecima_hpro_cetir_precios.hprodesclongColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsimporteNull() As Boolean
            Return Me.IsNull(Me.tablecima_hpro_cetir_precios.importeColumn)
        End Function
        
        Public Sub SetimporteNull()
            Me(Me.tablecima_hpro_cetir_precios.importeColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_hpro_cetir_preciosRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As cima_hpro_cetir_preciosRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As cima_hpro_cetir_preciosRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As cima_hpro_cetir_preciosRow
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
