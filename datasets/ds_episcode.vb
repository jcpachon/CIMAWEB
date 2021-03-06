﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2407
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
Public Class ds_episcode
    Inherits DataSet
    
    Private tableepiscode As episcodeDataTable
    
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
            If (Not (ds.Tables("episcode")) Is Nothing) Then
                Me.Tables.Add(New episcodeDataTable(ds.Tables("episcode")))
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
    Public ReadOnly Property episcode As episcodeDataTable
        Get
            Return Me.tableepiscode
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_episcode = CType(MyBase.Clone,ds_episcode)
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
        If (Not (ds.Tables("episcode")) Is Nothing) Then
            Me.Tables.Add(New episcodeDataTable(ds.Tables("episcode")))
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
        Me.tableepiscode = CType(Me.Tables("episcode"),episcodeDataTable)
        If (Not (Me.tableepiscode) Is Nothing) Then
            Me.tableepiscode.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_episcode"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_episcode.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableepiscode = New episcodeDataTable
        Me.Tables.Add(Me.tableepiscode)
    End Sub
    
    Private Function ShouldSerializeepiscode() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub episcodeRowChangeEventHandler(ByVal sender As Object, ByVal e As episcodeRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class episcodeDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnepiscode As DataColumn
        
        Private columnepisdatecrea As DataColumn
        
        Private columnepis_key As DataColumn
        
        Private columndia_admision As DataColumn
        
        Private columnhora_admision As DataColumn
        
        Private columnmotivo_visita As DataColumn
        
        Friend Sub New()
            MyBase.New("episcode")
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
        
        Friend ReadOnly Property episcodeColumn As DataColumn
            Get
                Return Me.columnepiscode
            End Get
        End Property
        
        Friend ReadOnly Property episdatecreaColumn As DataColumn
            Get
                Return Me.columnepisdatecrea
            End Get
        End Property
        
        Friend ReadOnly Property epis_keyColumn As DataColumn
            Get
                Return Me.columnepis_key
            End Get
        End Property
        
        Friend ReadOnly Property dia_admisionColumn As DataColumn
            Get
                Return Me.columndia_admision
            End Get
        End Property
        
        Friend ReadOnly Property hora_admisionColumn As DataColumn
            Get
                Return Me.columnhora_admision
            End Get
        End Property
        
        Friend ReadOnly Property motivo_visitaColumn As DataColumn
            Get
                Return Me.columnmotivo_visita
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As episcodeRow
            Get
                Return CType(Me.Rows(index),episcodeRow)
            End Get
        End Property
        
        Public Event episcodeRowChanged As episcodeRowChangeEventHandler
        
        Public Event episcodeRowChanging As episcodeRowChangeEventHandler
        
        Public Event episcodeRowDeleted As episcodeRowChangeEventHandler
        
        Public Event episcodeRowDeleting As episcodeRowChangeEventHandler
        
        Public Overloads Sub AddepiscodeRow(ByVal row As episcodeRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddepiscodeRow(ByVal episcode As String, ByVal episdatecrea As String, ByVal epis_key As Integer, ByVal dia_admision As String, ByVal hora_admision As String, ByVal motivo_visita As String) As episcodeRow
            Dim rowepiscodeRow As episcodeRow = CType(Me.NewRow,episcodeRow)
            rowepiscodeRow.ItemArray = New Object() {episcode, episdatecrea, epis_key, dia_admision, hora_admision, motivo_visita}
            Me.Rows.Add(rowepiscodeRow)
            Return rowepiscodeRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As episcodeDataTable = CType(MyBase.Clone,episcodeDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New episcodeDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnepiscode = Me.Columns("episcode")
            Me.columnepisdatecrea = Me.Columns("episdatecrea")
            Me.columnepis_key = Me.Columns("epis_key")
            Me.columndia_admision = Me.Columns("dia_admision")
            Me.columnhora_admision = Me.Columns("hora_admision")
            Me.columnmotivo_visita = Me.Columns("motivo_visita")
        End Sub
        
        Private Sub InitClass()
            Me.columnepiscode = New DataColumn("episcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnepiscode)
            Me.columnepisdatecrea = New DataColumn("episdatecrea", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnepisdatecrea)
            Me.columnepis_key = New DataColumn("epis_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnepis_key)
            Me.columndia_admision = New DataColumn("dia_admision", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndia_admision)
            Me.columnhora_admision = New DataColumn("hora_admision", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhora_admision)
            Me.columnmotivo_visita = New DataColumn("motivo_visita", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnmotivo_visita)
            Me.columnepiscode.AllowDBNull = false
        End Sub
        
        Public Function NewepiscodeRow() As episcodeRow
            Return CType(Me.NewRow,episcodeRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New episcodeRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(episcodeRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.episcodeRowChangedEvent) Is Nothing) Then
                RaiseEvent episcodeRowChanged(Me, New episcodeRowChangeEvent(CType(e.Row,episcodeRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.episcodeRowChangingEvent) Is Nothing) Then
                RaiseEvent episcodeRowChanging(Me, New episcodeRowChangeEvent(CType(e.Row,episcodeRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.episcodeRowDeletedEvent) Is Nothing) Then
                RaiseEvent episcodeRowDeleted(Me, New episcodeRowChangeEvent(CType(e.Row,episcodeRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.episcodeRowDeletingEvent) Is Nothing) Then
                RaiseEvent episcodeRowDeleting(Me, New episcodeRowChangeEvent(CType(e.Row,episcodeRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveepiscodeRow(ByVal row As episcodeRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class episcodeRow
        Inherits DataRow
        
        Private tableepiscode As episcodeDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableepiscode = CType(Me.Table,episcodeDataTable)
        End Sub
        
        Public Property episcode As String
            Get
                Return CType(Me(Me.tableepiscode.episcodeColumn),String)
            End Get
            Set
                Me(Me.tableepiscode.episcodeColumn) = value
            End Set
        End Property
        
        Public Property episdatecrea As String
            Get
                Try 
                    Return CType(Me(Me.tableepiscode.episdatecreaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableepiscode.episdatecreaColumn) = value
            End Set
        End Property
        
        Public Property epis_key As Integer
            Get
                Try 
                    Return CType(Me(Me.tableepiscode.epis_keyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableepiscode.epis_keyColumn) = value
            End Set
        End Property
        
        Public Property dia_admision As String
            Get
                Try 
                    Return CType(Me(Me.tableepiscode.dia_admisionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableepiscode.dia_admisionColumn) = value
            End Set
        End Property
        
        Public Property hora_admision As String
            Get
                Try 
                    Return CType(Me(Me.tableepiscode.hora_admisionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableepiscode.hora_admisionColumn) = value
            End Set
        End Property
        
        Public Property motivo_visita As String
            Get
                Try 
                    Return CType(Me(Me.tableepiscode.motivo_visitaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableepiscode.motivo_visitaColumn) = value
            End Set
        End Property
        
        Public Function IsepisdatecreaNull() As Boolean
            Return Me.IsNull(Me.tableepiscode.episdatecreaColumn)
        End Function
        
        Public Sub SetepisdatecreaNull()
            Me(Me.tableepiscode.episdatecreaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isepis_keyNull() As Boolean
            Return Me.IsNull(Me.tableepiscode.epis_keyColumn)
        End Function
        
        Public Sub Setepis_keyNull()
            Me(Me.tableepiscode.epis_keyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isdia_admisionNull() As Boolean
            Return Me.IsNull(Me.tableepiscode.dia_admisionColumn)
        End Function
        
        Public Sub Setdia_admisionNull()
            Me(Me.tableepiscode.dia_admisionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ishora_admisionNull() As Boolean
            Return Me.IsNull(Me.tableepiscode.hora_admisionColumn)
        End Function
        
        Public Sub Sethora_admisionNull()
            Me(Me.tableepiscode.hora_admisionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ismotivo_visitaNull() As Boolean
            Return Me.IsNull(Me.tableepiscode.motivo_visitaColumn)
        End Function
        
        Public Sub Setmotivo_visitaNull()
            Me(Me.tableepiscode.motivo_visitaColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class episcodeRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As episcodeRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As episcodeRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As episcodeRow
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
