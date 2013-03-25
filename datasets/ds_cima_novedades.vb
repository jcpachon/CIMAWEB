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
Public Class ds_cima_novedades
    Inherits DataSet
    
    Private tablecima_novedades As cima_novedadesDataTable
    
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
            If (Not (ds.Tables("cima_novedades")) Is Nothing) Then
                Me.Tables.Add(New cima_novedadesDataTable(ds.Tables("cima_novedades")))
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
    Public ReadOnly Property cima_novedades As cima_novedadesDataTable
        Get
            Return Me.tablecima_novedades
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_cima_novedades = CType(MyBase.Clone,ds_cima_novedades)
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
        If (Not (ds.Tables("cima_novedades")) Is Nothing) Then
            Me.Tables.Add(New cima_novedadesDataTable(ds.Tables("cima_novedades")))
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
        Me.tablecima_novedades = CType(Me.Tables("cima_novedades"),cima_novedadesDataTable)
        If (Not (Me.tablecima_novedades) Is Nothing) Then
            Me.tablecima_novedades.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_cima_novedades"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_cima_novedades.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablecima_novedades = New cima_novedadesDataTable
        Me.Tables.Add(Me.tablecima_novedades)
    End Sub
    
    Private Function ShouldSerializecima_novedades() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub cima_novedadesRowChangeEventHandler(ByVal sender As Object, ByVal e As cima_novedadesRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_novedadesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columndescripcion As DataColumn
        
        Friend Sub New()
            MyBase.New("cima_novedades")
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
        
        Friend ReadOnly Property descripcionColumn As DataColumn
            Get
                Return Me.columndescripcion
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As cima_novedadesRow
            Get
                Return CType(Me.Rows(index),cima_novedadesRow)
            End Get
        End Property
        
        Public Event cima_novedadesRowChanged As cima_novedadesRowChangeEventHandler
        
        Public Event cima_novedadesRowChanging As cima_novedadesRowChangeEventHandler
        
        Public Event cima_novedadesRowDeleted As cima_novedadesRowChangeEventHandler
        
        Public Event cima_novedadesRowDeleting As cima_novedadesRowChangeEventHandler
        
        Public Overloads Sub Addcima_novedadesRow(ByVal row As cima_novedadesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addcima_novedadesRow(ByVal descripcion As String) As cima_novedadesRow
            Dim rowcima_novedadesRow As cima_novedadesRow = CType(Me.NewRow,cima_novedadesRow)
            rowcima_novedadesRow.ItemArray = New Object() {descripcion}
            Me.Rows.Add(rowcima_novedadesRow)
            Return rowcima_novedadesRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As cima_novedadesDataTable = CType(MyBase.Clone,cima_novedadesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New cima_novedadesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columndescripcion = Me.Columns("descripcion")
        End Sub
        
        Private Sub InitClass()
            Me.columndescripcion = New DataColumn("descripcion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndescripcion)
        End Sub
        
        Public Function Newcima_novedadesRow() As cima_novedadesRow
            Return CType(Me.NewRow,cima_novedadesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New cima_novedadesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(cima_novedadesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.cima_novedadesRowChangedEvent) Is Nothing) Then
                RaiseEvent cima_novedadesRowChanged(Me, New cima_novedadesRowChangeEvent(CType(e.Row,cima_novedadesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.cima_novedadesRowChangingEvent) Is Nothing) Then
                RaiseEvent cima_novedadesRowChanging(Me, New cima_novedadesRowChangeEvent(CType(e.Row,cima_novedadesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.cima_novedadesRowDeletedEvent) Is Nothing) Then
                RaiseEvent cima_novedadesRowDeleted(Me, New cima_novedadesRowChangeEvent(CType(e.Row,cima_novedadesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.cima_novedadesRowDeletingEvent) Is Nothing) Then
                RaiseEvent cima_novedadesRowDeleting(Me, New cima_novedadesRowChangeEvent(CType(e.Row,cima_novedadesRow), e.Action))
            End If
        End Sub
        
        Public Sub Removecima_novedadesRow(ByVal row As cima_novedadesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_novedadesRow
        Inherits DataRow
        
        Private tablecima_novedades As cima_novedadesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablecima_novedades = CType(Me.Table,cima_novedadesDataTable)
        End Sub
        
        Public Property descripcion As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_novedades.descripcionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_novedades.descripcionColumn) = value
            End Set
        End Property
        
        Public Function IsdescripcionNull() As Boolean
            Return Me.IsNull(Me.tablecima_novedades.descripcionColumn)
        End Function
        
        Public Sub SetdescripcionNull()
            Me(Me.tablecima_novedades.descripcionColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_novedadesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As cima_novedadesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As cima_novedadesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As cima_novedadesRow
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
