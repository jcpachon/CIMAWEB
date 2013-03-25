﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2300
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
Public Class ds_firm
    Inherits DataSet
    
    Private tablefirm As firmDataTable
    
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
            If (Not (ds.Tables("firm")) Is Nothing) Then
                Me.Tables.Add(New firmDataTable(ds.Tables("firm")))
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
    Public ReadOnly Property firm As firmDataTable
        Get
            Return Me.tablefirm
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_firm = CType(MyBase.Clone,ds_firm)
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
        If (Not (ds.Tables("firm")) Is Nothing) Then
            Me.Tables.Add(New firmDataTable(ds.Tables("firm")))
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
        Me.tablefirm = CType(Me.Tables("firm"),firmDataTable)
        If (Not (Me.tablefirm) Is Nothing) Then
            Me.tablefirm.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_firm"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_firm.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablefirm = New firmDataTable
        Me.Tables.Add(Me.tablefirm)
    End Sub
    
    Private Function ShouldSerializefirm() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub firmRowChangeEventHandler(ByVal sender As Object, ByVal e As firmRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class firmDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnfirm_key As DataColumn
        
        Private columnfirmcode As DataColumn
        
        Friend Sub New()
            MyBase.New("firm")
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
        
        Friend ReadOnly Property firm_keyColumn As DataColumn
            Get
                Return Me.columnfirm_key
            End Get
        End Property
        
        Friend ReadOnly Property firmcodeColumn As DataColumn
            Get
                Return Me.columnfirmcode
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As firmRow
            Get
                Return CType(Me.Rows(index),firmRow)
            End Get
        End Property
        
        Public Event firmRowChanged As firmRowChangeEventHandler
        
        Public Event firmRowChanging As firmRowChangeEventHandler
        
        Public Event firmRowDeleted As firmRowChangeEventHandler
        
        Public Event firmRowDeleting As firmRowChangeEventHandler
        
        Public Overloads Sub AddfirmRow(ByVal row As firmRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddfirmRow(ByVal firm_key As Integer, ByVal firmcode As String) As firmRow
            Dim rowfirmRow As firmRow = CType(Me.NewRow,firmRow)
            rowfirmRow.ItemArray = New Object() {firm_key, firmcode}
            Me.Rows.Add(rowfirmRow)
            Return rowfirmRow
        End Function
        
        Public Function FindByfirm_key(ByVal firm_key As Integer) As firmRow
            Return CType(Me.Rows.Find(New Object() {firm_key}),firmRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As firmDataTable = CType(MyBase.Clone,firmDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New firmDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnfirm_key = Me.Columns("firm_key")
            Me.columnfirmcode = Me.Columns("firmcode")
        End Sub
        
        Private Sub InitClass()
            Me.columnfirm_key = New DataColumn("firm_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfirm_key)
            Me.columnfirmcode = New DataColumn("firmcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfirmcode)
            Me.Constraints.Add(New UniqueConstraint("ds_firmKey1", New DataColumn() {Me.columnfirm_key}, true))
            Me.columnfirm_key.AllowDBNull = false
            Me.columnfirm_key.Unique = true
        End Sub
        
        Public Function NewfirmRow() As firmRow
            Return CType(Me.NewRow,firmRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New firmRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(firmRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.firmRowChangedEvent) Is Nothing) Then
                RaiseEvent firmRowChanged(Me, New firmRowChangeEvent(CType(e.Row,firmRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.firmRowChangingEvent) Is Nothing) Then
                RaiseEvent firmRowChanging(Me, New firmRowChangeEvent(CType(e.Row,firmRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.firmRowDeletedEvent) Is Nothing) Then
                RaiseEvent firmRowDeleted(Me, New firmRowChangeEvent(CType(e.Row,firmRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.firmRowDeletingEvent) Is Nothing) Then
                RaiseEvent firmRowDeleting(Me, New firmRowChangeEvent(CType(e.Row,firmRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovefirmRow(ByVal row As firmRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class firmRow
        Inherits DataRow
        
        Private tablefirm As firmDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablefirm = CType(Me.Table,firmDataTable)
        End Sub
        
        Public Property firm_key As Integer
            Get
                Return CType(Me(Me.tablefirm.firm_keyColumn),Integer)
            End Get
            Set
                Me(Me.tablefirm.firm_keyColumn) = value
            End Set
        End Property
        
        Public Property firmcode As String
            Get
                Try 
                    Return CType(Me(Me.tablefirm.firmcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablefirm.firmcodeColumn) = value
            End Set
        End Property
        
        Public Function IsfirmcodeNull() As Boolean
            Return Me.IsNull(Me.tablefirm.firmcodeColumn)
        End Function
        
        Public Sub SetfirmcodeNull()
            Me(Me.tablefirm.firmcodeColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class firmRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As firmRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As firmRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As firmRow
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