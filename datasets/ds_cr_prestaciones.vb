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
Public Class ds_cr_prestaciones
    Inherits DataSet
    
    Private tablecr_prestaciones As cr_prestacionesDataTable
    
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
            If (Not (ds.Tables("cr_prestaciones")) Is Nothing) Then
                Me.Tables.Add(New cr_prestacionesDataTable(ds.Tables("cr_prestaciones")))
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
    Public ReadOnly Property cr_prestaciones As cr_prestacionesDataTable
        Get
            Return Me.tablecr_prestaciones
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_cr_prestaciones = CType(MyBase.Clone,ds_cr_prestaciones)
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
        If (Not (ds.Tables("cr_prestaciones")) Is Nothing) Then
            Me.Tables.Add(New cr_prestacionesDataTable(ds.Tables("cr_prestaciones")))
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
        Me.tablecr_prestaciones = CType(Me.Tables("cr_prestaciones"),cr_prestacionesDataTable)
        If (Not (Me.tablecr_prestaciones) Is Nothing) Then
            Me.tablecr_prestaciones.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_cr_prestaciones"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_cr_prestaciones.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablecr_prestaciones = New cr_prestacionesDataTable
        Me.Tables.Add(Me.tablecr_prestaciones)
    End Sub
    
    Private Function ShouldSerializecr_prestaciones() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub cr_prestacionesRowChangeEventHandler(ByVal sender As Object, ByVal e As cr_prestacionesRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cr_prestacionesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnprestacion As DataColumn
        
        Private columnnumero As DataColumn
        
        Friend Sub New()
            MyBase.New("cr_prestaciones")
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
        
        Friend ReadOnly Property prestacionColumn As DataColumn
            Get
                Return Me.columnprestacion
            End Get
        End Property
        
        Friend ReadOnly Property numeroColumn As DataColumn
            Get
                Return Me.columnnumero
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As cr_prestacionesRow
            Get
                Return CType(Me.Rows(index),cr_prestacionesRow)
            End Get
        End Property
        
        Public Event cr_prestacionesRowChanged As cr_prestacionesRowChangeEventHandler
        
        Public Event cr_prestacionesRowChanging As cr_prestacionesRowChangeEventHandler
        
        Public Event cr_prestacionesRowDeleted As cr_prestacionesRowChangeEventHandler
        
        Public Event cr_prestacionesRowDeleting As cr_prestacionesRowChangeEventHandler
        
        Public Overloads Sub Addcr_prestacionesRow(ByVal row As cr_prestacionesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addcr_prestacionesRow(ByVal prestacion As String, ByVal numero As Integer) As cr_prestacionesRow
            Dim rowcr_prestacionesRow As cr_prestacionesRow = CType(Me.NewRow,cr_prestacionesRow)
            rowcr_prestacionesRow.ItemArray = New Object() {prestacion, numero}
            Me.Rows.Add(rowcr_prestacionesRow)
            Return rowcr_prestacionesRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As cr_prestacionesDataTable = CType(MyBase.Clone,cr_prestacionesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New cr_prestacionesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnprestacion = Me.Columns("prestacion")
            Me.columnnumero = Me.Columns("numero")
        End Sub
        
        Private Sub InitClass()
            Me.columnprestacion = New DataColumn("prestacion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnprestacion)
            Me.columnnumero = New DataColumn("numero", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnnumero)
        End Sub
        
        Public Function Newcr_prestacionesRow() As cr_prestacionesRow
            Return CType(Me.NewRow,cr_prestacionesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New cr_prestacionesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(cr_prestacionesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.cr_prestacionesRowChangedEvent) Is Nothing) Then
                RaiseEvent cr_prestacionesRowChanged(Me, New cr_prestacionesRowChangeEvent(CType(e.Row,cr_prestacionesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.cr_prestacionesRowChangingEvent) Is Nothing) Then
                RaiseEvent cr_prestacionesRowChanging(Me, New cr_prestacionesRowChangeEvent(CType(e.Row,cr_prestacionesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.cr_prestacionesRowDeletedEvent) Is Nothing) Then
                RaiseEvent cr_prestacionesRowDeleted(Me, New cr_prestacionesRowChangeEvent(CType(e.Row,cr_prestacionesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.cr_prestacionesRowDeletingEvent) Is Nothing) Then
                RaiseEvent cr_prestacionesRowDeleting(Me, New cr_prestacionesRowChangeEvent(CType(e.Row,cr_prestacionesRow), e.Action))
            End If
        End Sub
        
        Public Sub Removecr_prestacionesRow(ByVal row As cr_prestacionesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cr_prestacionesRow
        Inherits DataRow
        
        Private tablecr_prestaciones As cr_prestacionesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablecr_prestaciones = CType(Me.Table,cr_prestacionesDataTable)
        End Sub
        
        Public Property prestacion As String
            Get
                Try 
                    Return CType(Me(Me.tablecr_prestaciones.prestacionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecr_prestaciones.prestacionColumn) = value
            End Set
        End Property
        
        Public Property numero As Integer
            Get
                Try 
                    Return CType(Me(Me.tablecr_prestaciones.numeroColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecr_prestaciones.numeroColumn) = value
            End Set
        End Property
        
        Public Function IsprestacionNull() As Boolean
            Return Me.IsNull(Me.tablecr_prestaciones.prestacionColumn)
        End Function
        
        Public Sub SetprestacionNull()
            Me(Me.tablecr_prestaciones.prestacionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsnumeroNull() As Boolean
            Return Me.IsNull(Me.tablecr_prestaciones.numeroColumn)
        End Function
        
        Public Sub SetnumeroNull()
            Me(Me.tablecr_prestaciones.numeroColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cr_prestacionesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As cr_prestacionesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As cr_prestacionesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As cr_prestacionesRow
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
