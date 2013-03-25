﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2032
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
Public Class ds_medicos
    Inherits DataSet
    
    Private tablemedicos As medicosDataTable
    
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
            If (Not (ds.Tables("medicos")) Is Nothing) Then
                Me.Tables.Add(New medicosDataTable(ds.Tables("medicos")))
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
    Public ReadOnly Property medicos As medicosDataTable
        Get
            Return Me.tablemedicos
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_medicos = CType(MyBase.Clone,ds_medicos)
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
        If (Not (ds.Tables("medicos")) Is Nothing) Then
            Me.Tables.Add(New medicosDataTable(ds.Tables("medicos")))
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
        Me.tablemedicos = CType(Me.Tables("medicos"),medicosDataTable)
        If (Not (Me.tablemedicos) Is Nothing) Then
            Me.tablemedicos.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_medicos"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_medicos.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablemedicos = New medicosDataTable
        Me.Tables.Add(Me.tablemedicos)
    End Sub
    
    Private Function ShouldSerializemedicos() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub medicosRowChangeEventHandler(ByVal sender As Object, ByVal e As medicosRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class medicosDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnnombre As DataColumn
        
        Private columnpers_key As DataColumn
        
        Friend Sub New()
            MyBase.New("medicos")
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
        
        Friend ReadOnly Property nombreColumn As DataColumn
            Get
                Return Me.columnnombre
            End Get
        End Property
        
        Friend ReadOnly Property pers_keyColumn As DataColumn
            Get
                Return Me.columnpers_key
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As medicosRow
            Get
                Return CType(Me.Rows(index),medicosRow)
            End Get
        End Property
        
        Public Event medicosRowChanged As medicosRowChangeEventHandler
        
        Public Event medicosRowChanging As medicosRowChangeEventHandler
        
        Public Event medicosRowDeleted As medicosRowChangeEventHandler
        
        Public Event medicosRowDeleting As medicosRowChangeEventHandler
        
        Public Overloads Sub AddmedicosRow(ByVal row As medicosRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddmedicosRow(ByVal nombre As String, ByVal pers_key As Integer) As medicosRow
            Dim rowmedicosRow As medicosRow = CType(Me.NewRow,medicosRow)
            rowmedicosRow.ItemArray = New Object() {nombre, pers_key}
            Me.Rows.Add(rowmedicosRow)
            Return rowmedicosRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As medicosDataTable = CType(MyBase.Clone,medicosDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New medicosDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnnombre = Me.Columns("nombre")
            Me.columnpers_key = Me.Columns("pers_key")
        End Sub
        
        Private Sub InitClass()
            Me.columnnombre = New DataColumn("nombre", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnnombre)
            Me.columnpers_key = New DataColumn("pers_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpers_key)
        End Sub
        
        Public Function NewmedicosRow() As medicosRow
            Return CType(Me.NewRow,medicosRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New medicosRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(medicosRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.medicosRowChangedEvent) Is Nothing) Then
                RaiseEvent medicosRowChanged(Me, New medicosRowChangeEvent(CType(e.Row,medicosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.medicosRowChangingEvent) Is Nothing) Then
                RaiseEvent medicosRowChanging(Me, New medicosRowChangeEvent(CType(e.Row,medicosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.medicosRowDeletedEvent) Is Nothing) Then
                RaiseEvent medicosRowDeleted(Me, New medicosRowChangeEvent(CType(e.Row,medicosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.medicosRowDeletingEvent) Is Nothing) Then
                RaiseEvent medicosRowDeleting(Me, New medicosRowChangeEvent(CType(e.Row,medicosRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovemedicosRow(ByVal row As medicosRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class medicosRow
        Inherits DataRow
        
        Private tablemedicos As medicosDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablemedicos = CType(Me.Table,medicosDataTable)
        End Sub
        
        Public Property nombre As String
            Get
                Try 
                    Return CType(Me(Me.tablemedicos.nombreColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablemedicos.nombreColumn) = value
            End Set
        End Property
        
        Public Property pers_key As Integer
            Get
                Try 
                    Return CType(Me(Me.tablemedicos.pers_keyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablemedicos.pers_keyColumn) = value
            End Set
        End Property
        
        Public Function IsnombreNull() As Boolean
            Return Me.IsNull(Me.tablemedicos.nombreColumn)
        End Function
        
        Public Sub SetnombreNull()
            Me(Me.tablemedicos.nombreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ispers_keyNull() As Boolean
            Return Me.IsNull(Me.tablemedicos.pers_keyColumn)
        End Function
        
        Public Sub Setpers_keyNull()
            Me(Me.tablemedicos.pers_keyColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class medicosRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As medicosRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As medicosRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As medicosRow
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