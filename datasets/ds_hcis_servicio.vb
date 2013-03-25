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
Public Class ds_hcis_servicio
    Inherits DataSet
    
    Private tablehcis_servicio As hcis_servicioDataTable
    
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
            If (Not (ds.Tables("hcis_servicio")) Is Nothing) Then
                Me.Tables.Add(New hcis_servicioDataTable(ds.Tables("hcis_servicio")))
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
    Public ReadOnly Property hcis_servicio As hcis_servicioDataTable
        Get
            Return Me.tablehcis_servicio
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_hcis_servicio = CType(MyBase.Clone,ds_hcis_servicio)
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
        If (Not (ds.Tables("hcis_servicio")) Is Nothing) Then
            Me.Tables.Add(New hcis_servicioDataTable(ds.Tables("hcis_servicio")))
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
        Me.tablehcis_servicio = CType(Me.Tables("hcis_servicio"),hcis_servicioDataTable)
        If (Not (Me.tablehcis_servicio) Is Nothing) Then
            Me.tablehcis_servicio.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_hcis_servicio"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_hcis_servicio.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablehcis_servicio = New hcis_servicioDataTable
        Me.Tables.Add(Me.tablehcis_servicio)
    End Sub
    
    Private Function ShouldSerializehcis_servicio() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub hcis_servicioRowChangeEventHandler(ByVal sender As Object, ByVal e As hcis_servicioRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class hcis_servicioDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnHCIScode_servicio As DataColumn
        
        Private columnHCIScodedesc_servicio As DataColumn
        
        Friend Sub New()
            MyBase.New("hcis_servicio")
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
        
        Friend ReadOnly Property HCIScode_servicioColumn As DataColumn
            Get
                Return Me.columnHCIScode_servicio
            End Get
        End Property
        
        Friend ReadOnly Property HCIScodedesc_servicioColumn As DataColumn
            Get
                Return Me.columnHCIScodedesc_servicio
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As hcis_servicioRow
            Get
                Return CType(Me.Rows(index),hcis_servicioRow)
            End Get
        End Property
        
        Public Event hcis_servicioRowChanged As hcis_servicioRowChangeEventHandler
        
        Public Event hcis_servicioRowChanging As hcis_servicioRowChangeEventHandler
        
        Public Event hcis_servicioRowDeleted As hcis_servicioRowChangeEventHandler
        
        Public Event hcis_servicioRowDeleting As hcis_servicioRowChangeEventHandler
        
        Public Overloads Sub Addhcis_servicioRow(ByVal row As hcis_servicioRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addhcis_servicioRow(ByVal HCIScode_servicio As String, ByVal HCIScodedesc_servicio As String) As hcis_servicioRow
            Dim rowhcis_servicioRow As hcis_servicioRow = CType(Me.NewRow,hcis_servicioRow)
            rowhcis_servicioRow.ItemArray = New Object() {HCIScode_servicio, HCIScodedesc_servicio}
            Me.Rows.Add(rowhcis_servicioRow)
            Return rowhcis_servicioRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As hcis_servicioDataTable = CType(MyBase.Clone,hcis_servicioDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New hcis_servicioDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnHCIScode_servicio = Me.Columns("HCIScode_servicio")
            Me.columnHCIScodedesc_servicio = Me.Columns("HCIScodedesc_servicio")
        End Sub
        
        Private Sub InitClass()
            Me.columnHCIScode_servicio = New DataColumn("HCIScode_servicio", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnHCIScode_servicio)
            Me.columnHCIScodedesc_servicio = New DataColumn("HCIScodedesc_servicio", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnHCIScodedesc_servicio)
        End Sub
        
        Public Function Newhcis_servicioRow() As hcis_servicioRow
            Return CType(Me.NewRow,hcis_servicioRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New hcis_servicioRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(hcis_servicioRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.hcis_servicioRowChangedEvent) Is Nothing) Then
                RaiseEvent hcis_servicioRowChanged(Me, New hcis_servicioRowChangeEvent(CType(e.Row,hcis_servicioRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.hcis_servicioRowChangingEvent) Is Nothing) Then
                RaiseEvent hcis_servicioRowChanging(Me, New hcis_servicioRowChangeEvent(CType(e.Row,hcis_servicioRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.hcis_servicioRowDeletedEvent) Is Nothing) Then
                RaiseEvent hcis_servicioRowDeleted(Me, New hcis_servicioRowChangeEvent(CType(e.Row,hcis_servicioRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.hcis_servicioRowDeletingEvent) Is Nothing) Then
                RaiseEvent hcis_servicioRowDeleting(Me, New hcis_servicioRowChangeEvent(CType(e.Row,hcis_servicioRow), e.Action))
            End If
        End Sub
        
        Public Sub Removehcis_servicioRow(ByVal row As hcis_servicioRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class hcis_servicioRow
        Inherits DataRow
        
        Private tablehcis_servicio As hcis_servicioDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablehcis_servicio = CType(Me.Table,hcis_servicioDataTable)
        End Sub
        
        Public Property HCIScode_servicio As String
            Get
                Try 
                    Return CType(Me(Me.tablehcis_servicio.HCIScode_servicioColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablehcis_servicio.HCIScode_servicioColumn) = value
            End Set
        End Property
        
        Public Property HCIScodedesc_servicio As String
            Get
                Try 
                    Return CType(Me(Me.tablehcis_servicio.HCIScodedesc_servicioColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablehcis_servicio.HCIScodedesc_servicioColumn) = value
            End Set
        End Property
        
        Public Function IsHCIScode_servicioNull() As Boolean
            Return Me.IsNull(Me.tablehcis_servicio.HCIScode_servicioColumn)
        End Function
        
        Public Sub SetHCIScode_servicioNull()
            Me(Me.tablehcis_servicio.HCIScode_servicioColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsHCIScodedesc_servicioNull() As Boolean
            Return Me.IsNull(Me.tablehcis_servicio.HCIScodedesc_servicioColumn)
        End Function
        
        Public Sub SetHCIScodedesc_servicioNull()
            Me(Me.tablehcis_servicio.HCIScodedesc_servicioColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class hcis_servicioRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As hcis_servicioRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As hcis_servicioRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As hcis_servicioRow
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
