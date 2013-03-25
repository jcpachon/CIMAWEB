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
Public Class ds_btimetab
    Inherits DataSet
    
    Private tablebtimetab As btimetabDataTable
    
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
            If (Not (ds.Tables("btimetab")) Is Nothing) Then
                Me.Tables.Add(New btimetabDataTable(ds.Tables("btimetab")))
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
    Public ReadOnly Property btimetab As btimetabDataTable
        Get
            Return Me.tablebtimetab
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_btimetab = CType(MyBase.Clone,ds_btimetab)
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
        If (Not (ds.Tables("btimetab")) Is Nothing) Then
            Me.Tables.Add(New btimetabDataTable(ds.Tables("btimetab")))
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
        Me.tablebtimetab = CType(Me.Tables("btimetab"),btimetabDataTable)
        If (Not (Me.tablebtimetab) Is Nothing) Then
            Me.tablebtimetab.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_btimetab"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_btimetab.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablebtimetab = New btimetabDataTable
        Me.Tables.Add(Me.tablebtimetab)
    End Sub
    
    Private Function ShouldSerializebtimetab() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub btimetabRowChangeEventHandler(ByVal sender As Object, ByVal e As btimetabRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class btimetabDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnagencode As DataColumn
        
        Private columnbtimetabcode As DataColumn
        
        Private columnbtimetabdesc As DataColumn
        
        Private columnbtimetabdateinit As DataColumn
        
        Private columnbtimetabdate_end As DataColumn
        
        Private columnbtimetabdaysweek As DataColumn
        
        Private columnbtimetabhour_end As DataColumn
        
        Private columnbtimetabhourinit As DataColumn
        
        Private columnbtimetab_maxpers As DataColumn
        
        Private columnbtimetabamou As DataColumn
        
        Private columnbtimetabappointe As DataColumn
        
        Private columnbtimetabappoholi As DataColumn
        
        Private columnbtimetabgran As DataColumn
        
        Private columnspdi_key As DataColumn
        
        Private columnbtimetabacti As DataColumn
        
        Private columnbtimetabupda As DataColumn
        
        Private columnbtimetabdefa As DataColumn
        
        Private columnbtimetabwarn As DataColumn
        
        Friend Sub New()
            MyBase.New("btimetab")
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
        
        Friend ReadOnly Property agencodeColumn As DataColumn
            Get
                Return Me.columnagencode
            End Get
        End Property
        
        Friend ReadOnly Property btimetabcodeColumn As DataColumn
            Get
                Return Me.columnbtimetabcode
            End Get
        End Property
        
        Friend ReadOnly Property btimetabdescColumn As DataColumn
            Get
                Return Me.columnbtimetabdesc
            End Get
        End Property
        
        Friend ReadOnly Property btimetabdateinitColumn As DataColumn
            Get
                Return Me.columnbtimetabdateinit
            End Get
        End Property
        
        Friend ReadOnly Property btimetabdate_endColumn As DataColumn
            Get
                Return Me.columnbtimetabdate_end
            End Get
        End Property
        
        Friend ReadOnly Property btimetabdaysweekColumn As DataColumn
            Get
                Return Me.columnbtimetabdaysweek
            End Get
        End Property
        
        Friend ReadOnly Property btimetabhour_endColumn As DataColumn
            Get
                Return Me.columnbtimetabhour_end
            End Get
        End Property
        
        Friend ReadOnly Property btimetabhourinitColumn As DataColumn
            Get
                Return Me.columnbtimetabhourinit
            End Get
        End Property
        
        Friend ReadOnly Property btimetab_maxpersColumn As DataColumn
            Get
                Return Me.columnbtimetab_maxpers
            End Get
        End Property
        
        Friend ReadOnly Property btimetabamouColumn As DataColumn
            Get
                Return Me.columnbtimetabamou
            End Get
        End Property
        
        Friend ReadOnly Property btimetabappointeColumn As DataColumn
            Get
                Return Me.columnbtimetabappointe
            End Get
        End Property
        
        Friend ReadOnly Property btimetabappoholiColumn As DataColumn
            Get
                Return Me.columnbtimetabappoholi
            End Get
        End Property
        
        Friend ReadOnly Property btimetabgranColumn As DataColumn
            Get
                Return Me.columnbtimetabgran
            End Get
        End Property
        
        Friend ReadOnly Property spdi_keyColumn As DataColumn
            Get
                Return Me.columnspdi_key
            End Get
        End Property
        
        Friend ReadOnly Property btimetabactiColumn As DataColumn
            Get
                Return Me.columnbtimetabacti
            End Get
        End Property
        
        Friend ReadOnly Property btimetabupdaColumn As DataColumn
            Get
                Return Me.columnbtimetabupda
            End Get
        End Property
        
        Friend ReadOnly Property btimetabdefaColumn As DataColumn
            Get
                Return Me.columnbtimetabdefa
            End Get
        End Property
        
        Friend ReadOnly Property btimetabwarnColumn As DataColumn
            Get
                Return Me.columnbtimetabwarn
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As btimetabRow
            Get
                Return CType(Me.Rows(index),btimetabRow)
            End Get
        End Property
        
        Public Event btimetabRowChanged As btimetabRowChangeEventHandler
        
        Public Event btimetabRowChanging As btimetabRowChangeEventHandler
        
        Public Event btimetabRowDeleted As btimetabRowChangeEventHandler
        
        Public Event btimetabRowDeleting As btimetabRowChangeEventHandler
        
        Public Overloads Sub AddbtimetabRow(ByVal row As btimetabRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddbtimetabRow( _
                    ByVal agencode As String,  _
                    ByVal btimetabcode As Short,  _
                    ByVal btimetabdesc As String,  _
                    ByVal btimetabdateinit As Date,  _
                    ByVal btimetabdate_end As Date,  _
                    ByVal btimetabdaysweek As String,  _
                    ByVal btimetabhour_end As Date,  _
                    ByVal btimetabhourinit As Date,  _
                    ByVal btimetab_maxpers As Short,  _
                    ByVal btimetabamou As String,  _
                    ByVal btimetabappointe As Short,  _
                    ByVal btimetabappoholi As String,  _
                    ByVal btimetabgran As Integer,  _
                    ByVal spdi_key As Integer,  _
                    ByVal btimetabacti As String,  _
                    ByVal btimetabupda As String,  _
                    ByVal btimetabdefa As String,  _
                    ByVal btimetabwarn As String) As btimetabRow
            Dim rowbtimetabRow As btimetabRow = CType(Me.NewRow,btimetabRow)
            rowbtimetabRow.ItemArray = New Object() {agencode, btimetabcode, btimetabdesc, btimetabdateinit, btimetabdate_end, btimetabdaysweek, btimetabhour_end, btimetabhourinit, btimetab_maxpers, btimetabamou, btimetabappointe, btimetabappoholi, btimetabgran, spdi_key, btimetabacti, btimetabupda, btimetabdefa, btimetabwarn}
            Me.Rows.Add(rowbtimetabRow)
            Return rowbtimetabRow
        End Function
        
        Public Function FindByagencodebtimetabcode(ByVal agencode As String, ByVal btimetabcode As Short) As btimetabRow
            Return CType(Me.Rows.Find(New Object() {agencode, btimetabcode}),btimetabRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As btimetabDataTable = CType(MyBase.Clone,btimetabDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New btimetabDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnagencode = Me.Columns("agencode")
            Me.columnbtimetabcode = Me.Columns("btimetabcode")
            Me.columnbtimetabdesc = Me.Columns("btimetabdesc")
            Me.columnbtimetabdateinit = Me.Columns("btimetabdateinit")
            Me.columnbtimetabdate_end = Me.Columns("btimetabdate_end")
            Me.columnbtimetabdaysweek = Me.Columns("btimetabdaysweek")
            Me.columnbtimetabhour_end = Me.Columns("btimetabhour_end")
            Me.columnbtimetabhourinit = Me.Columns("btimetabhourinit")
            Me.columnbtimetab_maxpers = Me.Columns("btimetab_maxpers")
            Me.columnbtimetabamou = Me.Columns("btimetabamou")
            Me.columnbtimetabappointe = Me.Columns("btimetabappointe")
            Me.columnbtimetabappoholi = Me.Columns("btimetabappoholi")
            Me.columnbtimetabgran = Me.Columns("btimetabgran")
            Me.columnspdi_key = Me.Columns("spdi_key")
            Me.columnbtimetabacti = Me.Columns("btimetabacti")
            Me.columnbtimetabupda = Me.Columns("btimetabupda")
            Me.columnbtimetabdefa = Me.Columns("btimetabdefa")
            Me.columnbtimetabwarn = Me.Columns("btimetabwarn")
        End Sub
        
        Private Sub InitClass()
            Me.columnagencode = New DataColumn("agencode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnagencode)
            Me.columnbtimetabcode = New DataColumn("btimetabcode", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabcode)
            Me.columnbtimetabdesc = New DataColumn("btimetabdesc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabdesc)
            Me.columnbtimetabdateinit = New DataColumn("btimetabdateinit", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabdateinit)
            Me.columnbtimetabdate_end = New DataColumn("btimetabdate_end", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabdate_end)
            Me.columnbtimetabdaysweek = New DataColumn("btimetabdaysweek", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabdaysweek)
            Me.columnbtimetabhour_end = New DataColumn("btimetabhour_end", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabhour_end)
            Me.columnbtimetabhourinit = New DataColumn("btimetabhourinit", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabhourinit)
            Me.columnbtimetab_maxpers = New DataColumn("btimetab_maxpers", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetab_maxpers)
            Me.columnbtimetabamou = New DataColumn("btimetabamou", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabamou)
            Me.columnbtimetabappointe = New DataColumn("btimetabappointe", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabappointe)
            Me.columnbtimetabappoholi = New DataColumn("btimetabappoholi", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabappoholi)
            Me.columnbtimetabgran = New DataColumn("btimetabgran", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabgran)
            Me.columnspdi_key = New DataColumn("spdi_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnspdi_key)
            Me.columnbtimetabacti = New DataColumn("btimetabacti", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabacti)
            Me.columnbtimetabupda = New DataColumn("btimetabupda", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabupda)
            Me.columnbtimetabdefa = New DataColumn("btimetabdefa", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabdefa)
            Me.columnbtimetabwarn = New DataColumn("btimetabwarn", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbtimetabwarn)
            Me.Constraints.Add(New UniqueConstraint("ds_btimetabKey1", New DataColumn() {Me.columnagencode, Me.columnbtimetabcode}, true))
            Me.columnagencode.AllowDBNull = false
            Me.columnbtimetabcode.AllowDBNull = false
            Me.columnbtimetabdesc.AllowDBNull = false
            Me.columnbtimetabdateinit.AllowDBNull = false
            Me.columnbtimetabdate_end.AllowDBNull = false
            Me.columnbtimetabdaysweek.AllowDBNull = false
            Me.columnbtimetabhour_end.AllowDBNull = false
            Me.columnbtimetabhourinit.AllowDBNull = false
            Me.columnbtimetabamou.AllowDBNull = false
            Me.columnbtimetabappointe.AllowDBNull = false
            Me.columnbtimetabacti.AllowDBNull = false
            Me.columnbtimetabupda.AllowDBNull = false
        End Sub
        
        Public Function NewbtimetabRow() As btimetabRow
            Return CType(Me.NewRow,btimetabRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New btimetabRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(btimetabRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.btimetabRowChangedEvent) Is Nothing) Then
                RaiseEvent btimetabRowChanged(Me, New btimetabRowChangeEvent(CType(e.Row,btimetabRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.btimetabRowChangingEvent) Is Nothing) Then
                RaiseEvent btimetabRowChanging(Me, New btimetabRowChangeEvent(CType(e.Row,btimetabRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.btimetabRowDeletedEvent) Is Nothing) Then
                RaiseEvent btimetabRowDeleted(Me, New btimetabRowChangeEvent(CType(e.Row,btimetabRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.btimetabRowDeletingEvent) Is Nothing) Then
                RaiseEvent btimetabRowDeleting(Me, New btimetabRowChangeEvent(CType(e.Row,btimetabRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovebtimetabRow(ByVal row As btimetabRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class btimetabRow
        Inherits DataRow
        
        Private tablebtimetab As btimetabDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablebtimetab = CType(Me.Table,btimetabDataTable)
        End Sub
        
        Public Property agencode As String
            Get
                Return CType(Me(Me.tablebtimetab.agencodeColumn),String)
            End Get
            Set
                Me(Me.tablebtimetab.agencodeColumn) = value
            End Set
        End Property
        
        Public Property btimetabcode As Short
            Get
                Return CType(Me(Me.tablebtimetab.btimetabcodeColumn),Short)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabcodeColumn) = value
            End Set
        End Property
        
        Public Property btimetabdesc As String
            Get
                Return CType(Me(Me.tablebtimetab.btimetabdescColumn),String)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabdescColumn) = value
            End Set
        End Property
        
        Public Property btimetabdateinit As Date
            Get
                Return CType(Me(Me.tablebtimetab.btimetabdateinitColumn),Date)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabdateinitColumn) = value
            End Set
        End Property
        
        Public Property btimetabdate_end As Date
            Get
                Return CType(Me(Me.tablebtimetab.btimetabdate_endColumn),Date)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabdate_endColumn) = value
            End Set
        End Property
        
        Public Property btimetabdaysweek As String
            Get
                Return CType(Me(Me.tablebtimetab.btimetabdaysweekColumn),String)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabdaysweekColumn) = value
            End Set
        End Property
        
        Public Property btimetabhour_end As Date
            Get
                Return CType(Me(Me.tablebtimetab.btimetabhour_endColumn),Date)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabhour_endColumn) = value
            End Set
        End Property
        
        Public Property btimetabhourinit As Date
            Get
                Return CType(Me(Me.tablebtimetab.btimetabhourinitColumn),Date)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabhourinitColumn) = value
            End Set
        End Property
        
        Public Property btimetab_maxpers As Short
            Get
                Try 
                    Return CType(Me(Me.tablebtimetab.btimetab_maxpersColumn),Short)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebtimetab.btimetab_maxpersColumn) = value
            End Set
        End Property
        
        Public Property btimetabamou As String
            Get
                Return CType(Me(Me.tablebtimetab.btimetabamouColumn),String)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabamouColumn) = value
            End Set
        End Property
        
        Public Property btimetabappointe As Short
            Get
                Return CType(Me(Me.tablebtimetab.btimetabappointeColumn),Short)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabappointeColumn) = value
            End Set
        End Property
        
        Public Property btimetabappoholi As String
            Get
                Try 
                    Return CType(Me(Me.tablebtimetab.btimetabappoholiColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebtimetab.btimetabappoholiColumn) = value
            End Set
        End Property
        
        Public Property btimetabgran As Integer
            Get
                Try 
                    Return CType(Me(Me.tablebtimetab.btimetabgranColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebtimetab.btimetabgranColumn) = value
            End Set
        End Property
        
        Public Property spdi_key As Integer
            Get
                Try 
                    Return CType(Me(Me.tablebtimetab.spdi_keyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebtimetab.spdi_keyColumn) = value
            End Set
        End Property
        
        Public Property btimetabacti As String
            Get
                Return CType(Me(Me.tablebtimetab.btimetabactiColumn),String)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabactiColumn) = value
            End Set
        End Property
        
        Public Property btimetabupda As String
            Get
                Return CType(Me(Me.tablebtimetab.btimetabupdaColumn),String)
            End Get
            Set
                Me(Me.tablebtimetab.btimetabupdaColumn) = value
            End Set
        End Property
        
        Public Property btimetabdefa As String
            Get
                Try 
                    Return CType(Me(Me.tablebtimetab.btimetabdefaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebtimetab.btimetabdefaColumn) = value
            End Set
        End Property
        
        Public Property btimetabwarn As String
            Get
                Try 
                    Return CType(Me(Me.tablebtimetab.btimetabwarnColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebtimetab.btimetabwarnColumn) = value
            End Set
        End Property
        
        Public Function Isbtimetab_maxpersNull() As Boolean
            Return Me.IsNull(Me.tablebtimetab.btimetab_maxpersColumn)
        End Function
        
        Public Sub Setbtimetab_maxpersNull()
            Me(Me.tablebtimetab.btimetab_maxpersColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsbtimetabappoholiNull() As Boolean
            Return Me.IsNull(Me.tablebtimetab.btimetabappoholiColumn)
        End Function
        
        Public Sub SetbtimetabappoholiNull()
            Me(Me.tablebtimetab.btimetabappoholiColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsbtimetabgranNull() As Boolean
            Return Me.IsNull(Me.tablebtimetab.btimetabgranColumn)
        End Function
        
        Public Sub SetbtimetabgranNull()
            Me(Me.tablebtimetab.btimetabgranColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isspdi_keyNull() As Boolean
            Return Me.IsNull(Me.tablebtimetab.spdi_keyColumn)
        End Function
        
        Public Sub Setspdi_keyNull()
            Me(Me.tablebtimetab.spdi_keyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsbtimetabdefaNull() As Boolean
            Return Me.IsNull(Me.tablebtimetab.btimetabdefaColumn)
        End Function
        
        Public Sub SetbtimetabdefaNull()
            Me(Me.tablebtimetab.btimetabdefaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsbtimetabwarnNull() As Boolean
            Return Me.IsNull(Me.tablebtimetab.btimetabwarnColumn)
        End Function
        
        Public Sub SetbtimetabwarnNull()
            Me(Me.tablebtimetab.btimetabwarnColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class btimetabRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As btimetabRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As btimetabRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As btimetabRow
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