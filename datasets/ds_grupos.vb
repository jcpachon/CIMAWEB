﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
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
Public Class ds_grupos
    Inherits DataSet
    
    Private tablecima_grupos As cima_gruposDataTable
    
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
            If (Not (ds.Tables("cima_grupos")) Is Nothing) Then
                Me.Tables.Add(New cima_gruposDataTable(ds.Tables("cima_grupos")))
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
    Public ReadOnly Property cima_grupos As cima_gruposDataTable
        Get
            Return Me.tablecima_grupos
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_grupos = CType(MyBase.Clone,ds_grupos)
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
        If (Not (ds.Tables("cima_grupos")) Is Nothing) Then
            Me.Tables.Add(New cima_gruposDataTable(ds.Tables("cima_grupos")))
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
        Me.tablecima_grupos = CType(Me.Tables("cima_grupos"),cima_gruposDataTable)
        If (Not (Me.tablecima_grupos) Is Nothing) Then
            Me.tablecima_grupos.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_grupos"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_grupos.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablecima_grupos = New cima_gruposDataTable
        Me.Tables.Add(Me.tablecima_grupos)
    End Sub
    
    Private Function ShouldSerializecima_grupos() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub cima_gruposRowChangeEventHandler(ByVal sender As Object, ByVal e As cima_gruposRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_gruposDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid_grupo As DataColumn
        
        Private columndesc_grupo As DataColumn
        
        Friend Sub New()
            MyBase.New("cima_grupos")
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
        
        Friend ReadOnly Property id_grupoColumn As DataColumn
            Get
                Return Me.columnid_grupo
            End Get
        End Property
        
        Friend ReadOnly Property desc_grupoColumn As DataColumn
            Get
                Return Me.columndesc_grupo
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As cima_gruposRow
            Get
                Return CType(Me.Rows(index),cima_gruposRow)
            End Get
        End Property
        
        Public Event cima_gruposRowChanged As cima_gruposRowChangeEventHandler
        
        Public Event cima_gruposRowChanging As cima_gruposRowChangeEventHandler
        
        Public Event cima_gruposRowDeleted As cima_gruposRowChangeEventHandler
        
        Public Event cima_gruposRowDeleting As cima_gruposRowChangeEventHandler
        
        Public Overloads Sub Addcima_gruposRow(ByVal row As cima_gruposRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addcima_gruposRow(ByVal desc_grupo As String) As cima_gruposRow
            Dim rowcima_gruposRow As cima_gruposRow = CType(Me.NewRow,cima_gruposRow)
            rowcima_gruposRow.ItemArray = New Object() {Nothing, desc_grupo}
            Me.Rows.Add(rowcima_gruposRow)
            Return rowcima_gruposRow
        End Function
        
        Public Function FindByid_grupo(ByVal id_grupo As Integer) As cima_gruposRow
            Return CType(Me.Rows.Find(New Object() {id_grupo}),cima_gruposRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As cima_gruposDataTable = CType(MyBase.Clone,cima_gruposDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New cima_gruposDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid_grupo = Me.Columns("id_grupo")
            Me.columndesc_grupo = Me.Columns("desc_grupo")
        End Sub
        
        Private Sub InitClass()
            Me.columnid_grupo = New DataColumn("id_grupo", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_grupo)
            Me.columndesc_grupo = New DataColumn("desc_grupo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndesc_grupo)
            Me.Constraints.Add(New UniqueConstraint("ds_gruposKey1", New DataColumn() {Me.columnid_grupo}, true))
            Me.columnid_grupo.AutoIncrement = true
            Me.columnid_grupo.AllowDBNull = false
            Me.columnid_grupo.ReadOnly = true
            Me.columnid_grupo.Unique = true
        End Sub
        
        Public Function Newcima_gruposRow() As cima_gruposRow
            Return CType(Me.NewRow,cima_gruposRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New cima_gruposRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(cima_gruposRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.cima_gruposRowChangedEvent) Is Nothing) Then
                RaiseEvent cima_gruposRowChanged(Me, New cima_gruposRowChangeEvent(CType(e.Row,cima_gruposRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.cima_gruposRowChangingEvent) Is Nothing) Then
                RaiseEvent cima_gruposRowChanging(Me, New cima_gruposRowChangeEvent(CType(e.Row,cima_gruposRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.cima_gruposRowDeletedEvent) Is Nothing) Then
                RaiseEvent cima_gruposRowDeleted(Me, New cima_gruposRowChangeEvent(CType(e.Row,cima_gruposRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.cima_gruposRowDeletingEvent) Is Nothing) Then
                RaiseEvent cima_gruposRowDeleting(Me, New cima_gruposRowChangeEvent(CType(e.Row,cima_gruposRow), e.Action))
            End If
        End Sub
        
        Public Sub Removecima_gruposRow(ByVal row As cima_gruposRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_gruposRow
        Inherits DataRow
        
        Private tablecima_grupos As cima_gruposDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablecima_grupos = CType(Me.Table,cima_gruposDataTable)
        End Sub
        
        Public Property id_grupo As Integer
            Get
                Return CType(Me(Me.tablecima_grupos.id_grupoColumn),Integer)
            End Get
            Set
                Me(Me.tablecima_grupos.id_grupoColumn) = value
            End Set
        End Property
        
        Public Property desc_grupo As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_grupos.desc_grupoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_grupos.desc_grupoColumn) = value
            End Set
        End Property
        
        Public Function Isdesc_grupoNull() As Boolean
            Return Me.IsNull(Me.tablecima_grupos.desc_grupoColumn)
        End Function
        
        Public Sub Setdesc_grupoNull()
            Me(Me.tablecima_grupos.desc_grupoColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_gruposRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As cima_gruposRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As cima_gruposRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As cima_gruposRow
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