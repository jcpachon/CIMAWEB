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
Public Class ds_terr
    Inherits DataSet
    
    Private tableterr As terrDataTable
    
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
            If (Not (ds.Tables("terr")) Is Nothing) Then
                Me.Tables.Add(New terrDataTable(ds.Tables("terr")))
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
    Public ReadOnly Property terr As terrDataTable
        Get
            Return Me.tableterr
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_terr = CType(MyBase.Clone,ds_terr)
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
        If (Not (ds.Tables("terr")) Is Nothing) Then
            Me.Tables.Add(New terrDataTable(ds.Tables("terr")))
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
        Me.tableterr = CType(Me.Tables("terr"),terrDataTable)
        If (Not (Me.tableterr) Is Nothing) Then
            Me.tableterr.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_terr"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_terr.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableterr = New terrDataTable
        Me.Tables.Add(Me.tableterr)
    End Sub
    
    Private Function ShouldSerializeterr() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub terrRowChangeEventHandler(ByVal sender As Object, ByVal e As terrRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class terrDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnterr_key As DataColumn
        
        Private columnterr_keyfath As DataColumn
        
        Private columnterrleve As DataColumn
        
        Private columnterrdesc As DataColumn
        
        Friend Sub New()
            MyBase.New("terr")
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
        
        Friend ReadOnly Property terr_keyColumn As DataColumn
            Get
                Return Me.columnterr_key
            End Get
        End Property
        
        Friend ReadOnly Property terr_keyfathColumn As DataColumn
            Get
                Return Me.columnterr_keyfath
            End Get
        End Property
        
        Friend ReadOnly Property terrleveColumn As DataColumn
            Get
                Return Me.columnterrleve
            End Get
        End Property
        
        Friend ReadOnly Property terrdescColumn As DataColumn
            Get
                Return Me.columnterrdesc
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As terrRow
            Get
                Return CType(Me.Rows(index),terrRow)
            End Get
        End Property
        
        Public Event terrRowChanged As terrRowChangeEventHandler
        
        Public Event terrRowChanging As terrRowChangeEventHandler
        
        Public Event terrRowDeleted As terrRowChangeEventHandler
        
        Public Event terrRowDeleting As terrRowChangeEventHandler
        
        Public Overloads Sub AddterrRow(ByVal row As terrRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddterrRow(ByVal terr_key As Integer, ByVal terr_keyfath As Integer, ByVal terrleve As Integer, ByVal terrdesc As String) As terrRow
            Dim rowterrRow As terrRow = CType(Me.NewRow,terrRow)
            rowterrRow.ItemArray = New Object() {terr_key, terr_keyfath, terrleve, terrdesc}
            Me.Rows.Add(rowterrRow)
            Return rowterrRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As terrDataTable = CType(MyBase.Clone,terrDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New terrDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnterr_key = Me.Columns("terr_key")
            Me.columnterr_keyfath = Me.Columns("terr_keyfath")
            Me.columnterrleve = Me.Columns("terrleve")
            Me.columnterrdesc = Me.Columns("terrdesc")
        End Sub
        
        Private Sub InitClass()
            Me.columnterr_key = New DataColumn("terr_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnterr_key)
            Me.columnterr_keyfath = New DataColumn("terr_keyfath", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnterr_keyfath)
            Me.columnterrleve = New DataColumn("terrleve", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnterrleve)
            Me.columnterrdesc = New DataColumn("terrdesc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnterrdesc)
            Me.Constraints.Add(New UniqueConstraint("ds_terrKey1", New DataColumn() {Me.columnterr_key}, false))
            Me.columnterr_key.AllowDBNull = false
            Me.columnterr_key.Unique = true
        End Sub
        
        Public Function NewterrRow() As terrRow
            Return CType(Me.NewRow,terrRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New terrRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(terrRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.terrRowChangedEvent) Is Nothing) Then
                RaiseEvent terrRowChanged(Me, New terrRowChangeEvent(CType(e.Row,terrRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.terrRowChangingEvent) Is Nothing) Then
                RaiseEvent terrRowChanging(Me, New terrRowChangeEvent(CType(e.Row,terrRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.terrRowDeletedEvent) Is Nothing) Then
                RaiseEvent terrRowDeleted(Me, New terrRowChangeEvent(CType(e.Row,terrRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.terrRowDeletingEvent) Is Nothing) Then
                RaiseEvent terrRowDeleting(Me, New terrRowChangeEvent(CType(e.Row,terrRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveterrRow(ByVal row As terrRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class terrRow
        Inherits DataRow
        
        Private tableterr As terrDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableterr = CType(Me.Table,terrDataTable)
        End Sub
        
        Public Property terr_key As Integer
            Get
                Return CType(Me(Me.tableterr.terr_keyColumn),Integer)
            End Get
            Set
                Me(Me.tableterr.terr_keyColumn) = value
            End Set
        End Property
        
        Public Property terr_keyfath As Integer
            Get
                Try 
                    Return CType(Me(Me.tableterr.terr_keyfathColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableterr.terr_keyfathColumn) = value
            End Set
        End Property
        
        Public Property terrleve As Integer
            Get
                Try 
                    Return CType(Me(Me.tableterr.terrleveColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableterr.terrleveColumn) = value
            End Set
        End Property
        
        Public Property terrdesc As String
            Get
                Try 
                    Return CType(Me(Me.tableterr.terrdescColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableterr.terrdescColumn) = value
            End Set
        End Property
        
        Public Function Isterr_keyfathNull() As Boolean
            Return Me.IsNull(Me.tableterr.terr_keyfathColumn)
        End Function
        
        Public Sub Setterr_keyfathNull()
            Me(Me.tableterr.terr_keyfathColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsterrleveNull() As Boolean
            Return Me.IsNull(Me.tableterr.terrleveColumn)
        End Function
        
        Public Sub SetterrleveNull()
            Me(Me.tableterr.terrleveColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsterrdescNull() As Boolean
            Return Me.IsNull(Me.tableterr.terrdescColumn)
        End Function
        
        Public Sub SetterrdescNull()
            Me(Me.tableterr.terrdescColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class terrRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As terrRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As terrRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As terrRow
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