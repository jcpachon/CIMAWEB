﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2490
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
Public Class ds_cima_SANITAS
    Inherits DataSet
    
    Private tablecima_SANITAS As cima_SANITASDataTable
    
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
            If (Not (ds.Tables("cima_SANITAS")) Is Nothing) Then
                Me.Tables.Add(New cima_SANITASDataTable(ds.Tables("cima_SANITAS")))
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
    Public ReadOnly Property cima_SANITAS As cima_SANITASDataTable
        Get
            Return Me.tablecima_SANITAS
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_cima_SANITAS = CType(MyBase.Clone,ds_cima_SANITAS)
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
        If (Not (ds.Tables("cima_SANITAS")) Is Nothing) Then
            Me.Tables.Add(New cima_SANITASDataTable(ds.Tables("cima_SANITAS")))
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
        Me.tablecima_SANITAS = CType(Me.Tables("cima_SANITAS"),cima_SANITASDataTable)
        If (Not (Me.tablecima_SANITAS) Is Nothing) Then
            Me.tablecima_SANITAS.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_cima_SANITAS"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_cima_SANITAS.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablecima_SANITAS = New cima_SANITASDataTable
        Me.Tables.Add(Me.tablecima_SANITAS)
    End Sub
    
    Private Function ShouldSerializecima_SANITAS() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub cima_SANITASRowChangeEventHandler(ByVal sender As Object, ByVal e As cima_SANITASRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_SANITASDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnvalor As DataColumn
        
        Private columnid_valor As DataColumn
        
        Friend Sub New()
            MyBase.New("cima_SANITAS")
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
        
        Friend ReadOnly Property valorColumn As DataColumn
            Get
                Return Me.columnvalor
            End Get
        End Property
        
        Friend ReadOnly Property id_valorColumn As DataColumn
            Get
                Return Me.columnid_valor
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As cima_SANITASRow
            Get
                Return CType(Me.Rows(index),cima_SANITASRow)
            End Get
        End Property
        
        Public Event cima_SANITASRowChanged As cima_SANITASRowChangeEventHandler
        
        Public Event cima_SANITASRowChanging As cima_SANITASRowChangeEventHandler
        
        Public Event cima_SANITASRowDeleted As cima_SANITASRowChangeEventHandler
        
        Public Event cima_SANITASRowDeleting As cima_SANITASRowChangeEventHandler
        
        Public Overloads Sub Addcima_SANITASRow(ByVal row As cima_SANITASRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addcima_SANITASRow(ByVal valor As String) As cima_SANITASRow
            Dim rowcima_SANITASRow As cima_SANITASRow = CType(Me.NewRow,cima_SANITASRow)
            rowcima_SANITASRow.ItemArray = New Object() {valor, Nothing}
            Me.Rows.Add(rowcima_SANITASRow)
            Return rowcima_SANITASRow
        End Function
        
        Public Function FindByid_valor(ByVal id_valor As Integer) As cima_SANITASRow
            Return CType(Me.Rows.Find(New Object() {id_valor}),cima_SANITASRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As cima_SANITASDataTable = CType(MyBase.Clone,cima_SANITASDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New cima_SANITASDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnvalor = Me.Columns("valor")
            Me.columnid_valor = Me.Columns("id_valor")
        End Sub
        
        Private Sub InitClass()
            Me.columnvalor = New DataColumn("valor", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnvalor)
            Me.columnid_valor = New DataColumn("id_valor", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_valor)
            Me.Constraints.Add(New UniqueConstraint("ds_cima_SANITASKey1", New DataColumn() {Me.columnid_valor}, true))
            Me.columnid_valor.AutoIncrement = true
            Me.columnid_valor.AllowDBNull = false
            Me.columnid_valor.ReadOnly = true
            Me.columnid_valor.Unique = true
        End Sub
        
        Public Function Newcima_SANITASRow() As cima_SANITASRow
            Return CType(Me.NewRow,cima_SANITASRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New cima_SANITASRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(cima_SANITASRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.cima_SANITASRowChangedEvent) Is Nothing) Then
                RaiseEvent cima_SANITASRowChanged(Me, New cima_SANITASRowChangeEvent(CType(e.Row,cima_SANITASRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.cima_SANITASRowChangingEvent) Is Nothing) Then
                RaiseEvent cima_SANITASRowChanging(Me, New cima_SANITASRowChangeEvent(CType(e.Row,cima_SANITASRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.cima_SANITASRowDeletedEvent) Is Nothing) Then
                RaiseEvent cima_SANITASRowDeleted(Me, New cima_SANITASRowChangeEvent(CType(e.Row,cima_SANITASRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.cima_SANITASRowDeletingEvent) Is Nothing) Then
                RaiseEvent cima_SANITASRowDeleting(Me, New cima_SANITASRowChangeEvent(CType(e.Row,cima_SANITASRow), e.Action))
            End If
        End Sub
        
        Public Sub Removecima_SANITASRow(ByVal row As cima_SANITASRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_SANITASRow
        Inherits DataRow
        
        Private tablecima_SANITAS As cima_SANITASDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablecima_SANITAS = CType(Me.Table,cima_SANITASDataTable)
        End Sub
        
        Public Property valor As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_SANITAS.valorColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_SANITAS.valorColumn) = value
            End Set
        End Property
        
        Public Property id_valor As Integer
            Get
                Return CType(Me(Me.tablecima_SANITAS.id_valorColumn),Integer)
            End Get
            Set
                Me(Me.tablecima_SANITAS.id_valorColumn) = value
            End Set
        End Property
        
        Public Function IsvalorNull() As Boolean
            Return Me.IsNull(Me.tablecima_SANITAS.valorColumn)
        End Function
        
        Public Sub SetvalorNull()
            Me(Me.tablecima_SANITAS.valorColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_SANITASRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As cima_SANITASRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As cima_SANITASRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As cima_SANITASRow
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
