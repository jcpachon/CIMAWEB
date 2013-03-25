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
Public Class ds_incidencia_episodio
    Inherits DataSet
    
    Private tableincidencia_episodio As incidencia_episodioDataTable
    
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
            If (Not (ds.Tables("incidencia_episodio")) Is Nothing) Then
                Me.Tables.Add(New incidencia_episodioDataTable(ds.Tables("incidencia_episodio")))
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
    Public ReadOnly Property incidencia_episodio As incidencia_episodioDataTable
        Get
            Return Me.tableincidencia_episodio
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_incidencia_episodio = CType(MyBase.Clone,ds_incidencia_episodio)
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
        If (Not (ds.Tables("incidencia_episodio")) Is Nothing) Then
            Me.Tables.Add(New incidencia_episodioDataTable(ds.Tables("incidencia_episodio")))
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
        Me.tableincidencia_episodio = CType(Me.Tables("incidencia_episodio"),incidencia_episodioDataTable)
        If (Not (Me.tableincidencia_episodio) Is Nothing) Then
            Me.tableincidencia_episodio.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_incidencia_episodio"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_incidencia_episodio.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableincidencia_episodio = New incidencia_episodioDataTable
        Me.Tables.Add(Me.tableincidencia_episodio)
    End Sub
    
    Private Function ShouldSerializeincidencia_episodio() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub incidencia_episodioRowChangeEventHandler(ByVal sender As Object, ByVal e As incidencia_episodioRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class incidencia_episodioDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid_incidencia_episodio As DataColumn
        
        Private columncodigo_inc As DataColumn
        
        Private columndescripcion_inc As DataColumn
        
        Friend Sub New()
            MyBase.New("incidencia_episodio")
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
        
        Friend ReadOnly Property id_incidencia_episodioColumn As DataColumn
            Get
                Return Me.columnid_incidencia_episodio
            End Get
        End Property
        
        Friend ReadOnly Property codigo_incColumn As DataColumn
            Get
                Return Me.columncodigo_inc
            End Get
        End Property
        
        Friend ReadOnly Property descripcion_incColumn As DataColumn
            Get
                Return Me.columndescripcion_inc
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As incidencia_episodioRow
            Get
                Return CType(Me.Rows(index),incidencia_episodioRow)
            End Get
        End Property
        
        Public Event incidencia_episodioRowChanged As incidencia_episodioRowChangeEventHandler
        
        Public Event incidencia_episodioRowChanging As incidencia_episodioRowChangeEventHandler
        
        Public Event incidencia_episodioRowDeleted As incidencia_episodioRowChangeEventHandler
        
        Public Event incidencia_episodioRowDeleting As incidencia_episodioRowChangeEventHandler
        
        Public Overloads Sub Addincidencia_episodioRow(ByVal row As incidencia_episodioRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addincidencia_episodioRow(ByVal id_incidencia_episodio As Integer, ByVal codigo_inc As String, ByVal descripcion_inc As String) As incidencia_episodioRow
            Dim rowincidencia_episodioRow As incidencia_episodioRow = CType(Me.NewRow,incidencia_episodioRow)
            rowincidencia_episodioRow.ItemArray = New Object() {id_incidencia_episodio, codigo_inc, descripcion_inc}
            Me.Rows.Add(rowincidencia_episodioRow)
            Return rowincidencia_episodioRow
        End Function
        
        Public Function FindByid_incidencia_episodio(ByVal id_incidencia_episodio As Integer) As incidencia_episodioRow
            Return CType(Me.Rows.Find(New Object() {id_incidencia_episodio}),incidencia_episodioRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As incidencia_episodioDataTable = CType(MyBase.Clone,incidencia_episodioDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New incidencia_episodioDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid_incidencia_episodio = Me.Columns("id_incidencia_episodio")
            Me.columncodigo_inc = Me.Columns("codigo_inc")
            Me.columndescripcion_inc = Me.Columns("descripcion_inc")
        End Sub
        
        Private Sub InitClass()
            Me.columnid_incidencia_episodio = New DataColumn("id_incidencia_episodio", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_incidencia_episodio)
            Me.columncodigo_inc = New DataColumn("codigo_inc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncodigo_inc)
            Me.columndescripcion_inc = New DataColumn("descripcion_inc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndescripcion_inc)
            Me.Constraints.Add(New UniqueConstraint("ds_incidencia_episodioKey1", New DataColumn() {Me.columnid_incidencia_episodio}, true))
            Me.columnid_incidencia_episodio.AllowDBNull = false
            Me.columnid_incidencia_episodio.Unique = true
        End Sub
        
        Public Function Newincidencia_episodioRow() As incidencia_episodioRow
            Return CType(Me.NewRow,incidencia_episodioRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New incidencia_episodioRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(incidencia_episodioRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.incidencia_episodioRowChangedEvent) Is Nothing) Then
                RaiseEvent incidencia_episodioRowChanged(Me, New incidencia_episodioRowChangeEvent(CType(e.Row,incidencia_episodioRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.incidencia_episodioRowChangingEvent) Is Nothing) Then
                RaiseEvent incidencia_episodioRowChanging(Me, New incidencia_episodioRowChangeEvent(CType(e.Row,incidencia_episodioRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.incidencia_episodioRowDeletedEvent) Is Nothing) Then
                RaiseEvent incidencia_episodioRowDeleted(Me, New incidencia_episodioRowChangeEvent(CType(e.Row,incidencia_episodioRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.incidencia_episodioRowDeletingEvent) Is Nothing) Then
                RaiseEvent incidencia_episodioRowDeleting(Me, New incidencia_episodioRowChangeEvent(CType(e.Row,incidencia_episodioRow), e.Action))
            End If
        End Sub
        
        Public Sub Removeincidencia_episodioRow(ByVal row As incidencia_episodioRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class incidencia_episodioRow
        Inherits DataRow
        
        Private tableincidencia_episodio As incidencia_episodioDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableincidencia_episodio = CType(Me.Table,incidencia_episodioDataTable)
        End Sub
        
        Public Property id_incidencia_episodio As Integer
            Get
                Return CType(Me(Me.tableincidencia_episodio.id_incidencia_episodioColumn),Integer)
            End Get
            Set
                Me(Me.tableincidencia_episodio.id_incidencia_episodioColumn) = value
            End Set
        End Property
        
        Public Property codigo_inc As String
            Get
                Try 
                    Return CType(Me(Me.tableincidencia_episodio.codigo_incColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableincidencia_episodio.codigo_incColumn) = value
            End Set
        End Property
        
        Public Property descripcion_inc As String
            Get
                Try 
                    Return CType(Me(Me.tableincidencia_episodio.descripcion_incColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableincidencia_episodio.descripcion_incColumn) = value
            End Set
        End Property
        
        Public Function Iscodigo_incNull() As Boolean
            Return Me.IsNull(Me.tableincidencia_episodio.codigo_incColumn)
        End Function
        
        Public Sub Setcodigo_incNull()
            Me(Me.tableincidencia_episodio.codigo_incColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isdescripcion_incNull() As Boolean
            Return Me.IsNull(Me.tableincidencia_episodio.descripcion_incColumn)
        End Function
        
        Public Sub Setdescripcion_incNull()
            Me(Me.tableincidencia_episodio.descripcion_incColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class incidencia_episodioRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As incidencia_episodioRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As incidencia_episodioRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As incidencia_episodioRow
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