﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2470
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
Public Class ds_poliza
    Inherits DataSet
    
    Private tablepoliza As polizaDataTable
    
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
            If (Not (ds.Tables("poliza")) Is Nothing) Then
                Me.Tables.Add(New polizaDataTable(ds.Tables("poliza")))
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
    Public ReadOnly Property poliza As polizaDataTable
        Get
            Return Me.tablepoliza
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_poliza = CType(MyBase.Clone,ds_poliza)
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
        If (Not (ds.Tables("poliza")) Is Nothing) Then
            Me.Tables.Add(New polizaDataTable(ds.Tables("poliza")))
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
        Me.tablepoliza = CType(Me.Tables("poliza"),polizaDataTable)
        If (Not (Me.tablepoliza) Is Nothing) Then
            Me.tablepoliza.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_poliza"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_poliza.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablepoliza = New polizaDataTable
        Me.Tables.Add(Me.tablepoliza)
    End Sub
    
    Private Function ShouldSerializepoliza() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub polizaRowChangeEventHandler(ByVal sender As Object, ByVal e As polizaRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class polizaDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnfirm_key As DataColumn
        
        Private columnepisfirmassu As DataColumn
        
        Private columnpatifirmassu As DataColumn
        
        Friend Sub New()
            MyBase.New("poliza")
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
        
        Friend ReadOnly Property episfirmassuColumn As DataColumn
            Get
                Return Me.columnepisfirmassu
            End Get
        End Property
        
        Friend ReadOnly Property patifirmassuColumn As DataColumn
            Get
                Return Me.columnpatifirmassu
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As polizaRow
            Get
                Return CType(Me.Rows(index),polizaRow)
            End Get
        End Property
        
        Public Event polizaRowChanged As polizaRowChangeEventHandler
        
        Public Event polizaRowChanging As polizaRowChangeEventHandler
        
        Public Event polizaRowDeleted As polizaRowChangeEventHandler
        
        Public Event polizaRowDeleting As polizaRowChangeEventHandler
        
        Public Overloads Sub AddpolizaRow(ByVal row As polizaRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddpolizaRow(ByVal firm_key As Integer, ByVal episfirmassu As String, ByVal patifirmassu As String) As polizaRow
            Dim rowpolizaRow As polizaRow = CType(Me.NewRow,polizaRow)
            rowpolizaRow.ItemArray = New Object() {firm_key, episfirmassu, patifirmassu}
            Me.Rows.Add(rowpolizaRow)
            Return rowpolizaRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As polizaDataTable = CType(MyBase.Clone,polizaDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New polizaDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnfirm_key = Me.Columns("firm_key")
            Me.columnepisfirmassu = Me.Columns("episfirmassu")
            Me.columnpatifirmassu = Me.Columns("patifirmassu")
        End Sub
        
        Private Sub InitClass()
            Me.columnfirm_key = New DataColumn("firm_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfirm_key)
            Me.columnepisfirmassu = New DataColumn("episfirmassu", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnepisfirmassu)
            Me.columnpatifirmassu = New DataColumn("patifirmassu", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpatifirmassu)
        End Sub
        
        Public Function NewpolizaRow() As polizaRow
            Return CType(Me.NewRow,polizaRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New polizaRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(polizaRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.polizaRowChangedEvent) Is Nothing) Then
                RaiseEvent polizaRowChanged(Me, New polizaRowChangeEvent(CType(e.Row,polizaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.polizaRowChangingEvent) Is Nothing) Then
                RaiseEvent polizaRowChanging(Me, New polizaRowChangeEvent(CType(e.Row,polizaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.polizaRowDeletedEvent) Is Nothing) Then
                RaiseEvent polizaRowDeleted(Me, New polizaRowChangeEvent(CType(e.Row,polizaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.polizaRowDeletingEvent) Is Nothing) Then
                RaiseEvent polizaRowDeleting(Me, New polizaRowChangeEvent(CType(e.Row,polizaRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovepolizaRow(ByVal row As polizaRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class polizaRow
        Inherits DataRow
        
        Private tablepoliza As polizaDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablepoliza = CType(Me.Table,polizaDataTable)
        End Sub
        
        Public Property firm_key As Integer
            Get
                Try 
                    Return CType(Me(Me.tablepoliza.firm_keyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepoliza.firm_keyColumn) = value
            End Set
        End Property
        
        Public Property episfirmassu As String
            Get
                Try 
                    Return CType(Me(Me.tablepoliza.episfirmassuColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepoliza.episfirmassuColumn) = value
            End Set
        End Property
        
        Public Property patifirmassu As String
            Get
                Try 
                    Return CType(Me(Me.tablepoliza.patifirmassuColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepoliza.patifirmassuColumn) = value
            End Set
        End Property
        
        Public Function Isfirm_keyNull() As Boolean
            Return Me.IsNull(Me.tablepoliza.firm_keyColumn)
        End Function
        
        Public Sub Setfirm_keyNull()
            Me(Me.tablepoliza.firm_keyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsepisfirmassuNull() As Boolean
            Return Me.IsNull(Me.tablepoliza.episfirmassuColumn)
        End Function
        
        Public Sub SetepisfirmassuNull()
            Me(Me.tablepoliza.episfirmassuColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspatifirmassuNull() As Boolean
            Return Me.IsNull(Me.tablepoliza.patifirmassuColumn)
        End Function
        
        Public Sub SetpatifirmassuNull()
            Me(Me.tablepoliza.patifirmassuColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class polizaRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As polizaRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As polizaRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As polizaRow
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
