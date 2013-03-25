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
Public Class ds_carga_mod_cita
    Inherits DataSet
    
    Private tableSP_CIMACEX_CARGA_MOD_CITA As SP_CIMACEX_CARGA_MOD_CITADataTable
    
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
            If (Not (ds.Tables("SP_CIMACEX_CARGA_MOD_CITA")) Is Nothing) Then
                Me.Tables.Add(New SP_CIMACEX_CARGA_MOD_CITADataTable(ds.Tables("SP_CIMACEX_CARGA_MOD_CITA")))
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
    Public ReadOnly Property SP_CIMACEX_CARGA_MOD_CITA As SP_CIMACEX_CARGA_MOD_CITADataTable
        Get
            Return Me.tableSP_CIMACEX_CARGA_MOD_CITA
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_carga_mod_cita = CType(MyBase.Clone,ds_carga_mod_cita)
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
        If (Not (ds.Tables("SP_CIMACEX_CARGA_MOD_CITA")) Is Nothing) Then
            Me.Tables.Add(New SP_CIMACEX_CARGA_MOD_CITADataTable(ds.Tables("SP_CIMACEX_CARGA_MOD_CITA")))
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
        Me.tableSP_CIMACEX_CARGA_MOD_CITA = CType(Me.Tables("SP_CIMACEX_CARGA_MOD_CITA"),SP_CIMACEX_CARGA_MOD_CITADataTable)
        If (Not (Me.tableSP_CIMACEX_CARGA_MOD_CITA) Is Nothing) Then
            Me.tableSP_CIMACEX_CARGA_MOD_CITA.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_carga_mod_cita"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_carga_mod_cita.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableSP_CIMACEX_CARGA_MOD_CITA = New SP_CIMACEX_CARGA_MOD_CITADataTable
        Me.Tables.Add(Me.tableSP_CIMACEX_CARGA_MOD_CITA)
    End Sub
    
    Private Function ShouldSerializeSP_CIMACEX_CARGA_MOD_CITA() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub SP_CIMACEX_CARGA_MOD_CITARowChangeEventHandler(ByVal sender As Object, ByVal e As SP_CIMACEX_CARGA_MOD_CITARowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_CARGA_MOD_CITADataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnpers_key As DataColumn
        
        Private columnbtimetabcode As DataColumn
        
        Private columnbookhini As DataColumn
        
        Private columnbookhend As DataColumn
        
        Private columnbooktime As DataColumn
        
        Private columnagenproc_key As DataColumn
        
        Friend Sub New()
            MyBase.New("SP_CIMACEX_CARGA_MOD_CITA")
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
        
        Friend ReadOnly Property pers_keyColumn As DataColumn
            Get
                Return Me.columnpers_key
            End Get
        End Property
        
        Friend ReadOnly Property btimetabcodeColumn As DataColumn
            Get
                Return Me.columnbtimetabcode
            End Get
        End Property
        
        Friend ReadOnly Property bookhiniColumn As DataColumn
            Get
                Return Me.columnbookhini
            End Get
        End Property
        
        Friend ReadOnly Property bookhendColumn As DataColumn
            Get
                Return Me.columnbookhend
            End Get
        End Property
        
        Friend ReadOnly Property booktimeColumn As DataColumn
            Get
                Return Me.columnbooktime
            End Get
        End Property
        
        Friend ReadOnly Property agenproc_keyColumn As DataColumn
            Get
                Return Me.columnagenproc_key
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As SP_CIMACEX_CARGA_MOD_CITARow
            Get
                Return CType(Me.Rows(index),SP_CIMACEX_CARGA_MOD_CITARow)
            End Get
        End Property
        
        Public Event SP_CIMACEX_CARGA_MOD_CITARowChanged As SP_CIMACEX_CARGA_MOD_CITARowChangeEventHandler
        
        Public Event SP_CIMACEX_CARGA_MOD_CITARowChanging As SP_CIMACEX_CARGA_MOD_CITARowChangeEventHandler
        
        Public Event SP_CIMACEX_CARGA_MOD_CITARowDeleted As SP_CIMACEX_CARGA_MOD_CITARowChangeEventHandler
        
        Public Event SP_CIMACEX_CARGA_MOD_CITARowDeleting As SP_CIMACEX_CARGA_MOD_CITARowChangeEventHandler
        
        Public Overloads Sub AddSP_CIMACEX_CARGA_MOD_CITARow(ByVal row As SP_CIMACEX_CARGA_MOD_CITARow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddSP_CIMACEX_CARGA_MOD_CITARow(ByVal pers_key As Integer, ByVal btimetabcode As Short, ByVal bookhini As String, ByVal bookhend As String, ByVal booktime As Short, ByVal agenproc_key As String) As SP_CIMACEX_CARGA_MOD_CITARow
            Dim rowSP_CIMACEX_CARGA_MOD_CITARow As SP_CIMACEX_CARGA_MOD_CITARow = CType(Me.NewRow,SP_CIMACEX_CARGA_MOD_CITARow)
            rowSP_CIMACEX_CARGA_MOD_CITARow.ItemArray = New Object() {pers_key, btimetabcode, bookhini, bookhend, booktime, agenproc_key}
            Me.Rows.Add(rowSP_CIMACEX_CARGA_MOD_CITARow)
            Return rowSP_CIMACEX_CARGA_MOD_CITARow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As SP_CIMACEX_CARGA_MOD_CITADataTable = CType(MyBase.Clone,SP_CIMACEX_CARGA_MOD_CITADataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New SP_CIMACEX_CARGA_MOD_CITADataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnpers_key = Me.Columns("pers_key")
            Me.columnbtimetabcode = Me.Columns("btimetabcode")
            Me.columnbookhini = Me.Columns("bookhini")
            Me.columnbookhend = Me.Columns("bookhend")
            Me.columnbooktime = Me.Columns("booktime")
            Me.columnagenproc_key = Me.Columns("agenproc_key")
        End Sub
        
        Private Sub InitClass()
            Me.columnpers_key = New DataColumn("pers_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpers_key)
            Me.columnbtimetabcode = New DataColumn("btimetabcode", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabcode)
            Me.columnbookhini = New DataColumn("bookhini", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbookhini)
            Me.columnbookhend = New DataColumn("bookhend", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbookhend)
            Me.columnbooktime = New DataColumn("booktime", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbooktime)
            Me.columnagenproc_key = New DataColumn("agenproc_key", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnagenproc_key)
            Me.columnbtimetabcode.AllowDBNull = false
            Me.columnbookhini.AllowDBNull = false
            Me.columnbookhend.AllowDBNull = false
            Me.columnbooktime.AllowDBNull = false
            Me.columnagenproc_key.AllowDBNull = false
        End Sub
        
        Public Function NewSP_CIMACEX_CARGA_MOD_CITARow() As SP_CIMACEX_CARGA_MOD_CITARow
            Return CType(Me.NewRow,SP_CIMACEX_CARGA_MOD_CITARow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New SP_CIMACEX_CARGA_MOD_CITARow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(SP_CIMACEX_CARGA_MOD_CITARow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.SP_CIMACEX_CARGA_MOD_CITARowChangedEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_CARGA_MOD_CITARowChanged(Me, New SP_CIMACEX_CARGA_MOD_CITARowChangeEvent(CType(e.Row,SP_CIMACEX_CARGA_MOD_CITARow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.SP_CIMACEX_CARGA_MOD_CITARowChangingEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_CARGA_MOD_CITARowChanging(Me, New SP_CIMACEX_CARGA_MOD_CITARowChangeEvent(CType(e.Row,SP_CIMACEX_CARGA_MOD_CITARow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.SP_CIMACEX_CARGA_MOD_CITARowDeletedEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_CARGA_MOD_CITARowDeleted(Me, New SP_CIMACEX_CARGA_MOD_CITARowChangeEvent(CType(e.Row,SP_CIMACEX_CARGA_MOD_CITARow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.SP_CIMACEX_CARGA_MOD_CITARowDeletingEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_CARGA_MOD_CITARowDeleting(Me, New SP_CIMACEX_CARGA_MOD_CITARowChangeEvent(CType(e.Row,SP_CIMACEX_CARGA_MOD_CITARow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveSP_CIMACEX_CARGA_MOD_CITARow(ByVal row As SP_CIMACEX_CARGA_MOD_CITARow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_CARGA_MOD_CITARow
        Inherits DataRow
        
        Private tableSP_CIMACEX_CARGA_MOD_CITA As SP_CIMACEX_CARGA_MOD_CITADataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableSP_CIMACEX_CARGA_MOD_CITA = CType(Me.Table,SP_CIMACEX_CARGA_MOD_CITADataTable)
        End Sub
        
        Public Property pers_key As Integer
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.pers_keyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.pers_keyColumn) = value
            End Set
        End Property
        
        Public Property btimetabcode As Short
            Get
                Return CType(Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.btimetabcodeColumn),Short)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.btimetabcodeColumn) = value
            End Set
        End Property
        
        Public Property bookhini As String
            Get
                Return CType(Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.bookhiniColumn),String)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.bookhiniColumn) = value
            End Set
        End Property
        
        Public Property bookhend As String
            Get
                Return CType(Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.bookhendColumn),String)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.bookhendColumn) = value
            End Set
        End Property
        
        Public Property booktime As Short
            Get
                Return CType(Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.booktimeColumn),Short)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.booktimeColumn) = value
            End Set
        End Property
        
        Public Property agenproc_key As String
            Get
                Return CType(Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.agenproc_keyColumn),String)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.agenproc_keyColumn) = value
            End Set
        End Property
        
        Public Function Ispers_keyNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_CARGA_MOD_CITA.pers_keyColumn)
        End Function
        
        Public Sub Setpers_keyNull()
            Me(Me.tableSP_CIMACEX_CARGA_MOD_CITA.pers_keyColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_CARGA_MOD_CITARowChangeEvent
        Inherits EventArgs
        
        Private eventRow As SP_CIMACEX_CARGA_MOD_CITARow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As SP_CIMACEX_CARGA_MOD_CITARow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As SP_CIMACEX_CARGA_MOD_CITARow
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
