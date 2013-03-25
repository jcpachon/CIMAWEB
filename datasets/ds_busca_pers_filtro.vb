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
Public Class ds_busca_pers_filtro
    Inherits DataSet
    
    Private tablepers_filtro As pers_filtroDataTable
    
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
            If (Not (ds.Tables("pers_filtro")) Is Nothing) Then
                Me.Tables.Add(New pers_filtroDataTable(ds.Tables("pers_filtro")))
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
    Public ReadOnly Property pers_filtro As pers_filtroDataTable
        Get
            Return Me.tablepers_filtro
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_busca_pers_filtro = CType(MyBase.Clone,ds_busca_pers_filtro)
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
        If (Not (ds.Tables("pers_filtro")) Is Nothing) Then
            Me.Tables.Add(New pers_filtroDataTable(ds.Tables("pers_filtro")))
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
        Me.tablepers_filtro = CType(Me.Tables("pers_filtro"),pers_filtroDataTable)
        If (Not (Me.tablepers_filtro) Is Nothing) Then
            Me.tablepers_filtro.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_busca_pers_filtro"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_busca_pers_filtro.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablepers_filtro = New pers_filtroDataTable
        Me.Tables.Add(Me.tablepers_filtro)
    End Sub
    
    Private Function ShouldSerializepers_filtro() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub pers_filtroRowChangeEventHandler(ByVal sender As Object, ByVal e As pers_filtroRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class pers_filtroDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnpers_key As DataColumn
        
        Private columnpersfullname As DataColumn
        
        Private columnpersidencod1 As DataColumn
        
        Private columnpersidencod2 As DataColumn
        
        Private columnnhc As DataColumn
        
        Private columnepiscode As DataColumn
        
        Private columndia As DataColumn
        
        Private columnhora As DataColumn
        
        Private columnagenname As DataColumn
        
        Private columnagencode As DataColumn
        
        Private columntactcode As DataColumn
        
        Friend Sub New()
            MyBase.New("pers_filtro")
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
        
        Friend ReadOnly Property persfullnameColumn As DataColumn
            Get
                Return Me.columnpersfullname
            End Get
        End Property
        
        Friend ReadOnly Property persidencod1Column As DataColumn
            Get
                Return Me.columnpersidencod1
            End Get
        End Property
        
        Friend ReadOnly Property persidencod2Column As DataColumn
            Get
                Return Me.columnpersidencod2
            End Get
        End Property
        
        Friend ReadOnly Property nhcColumn As DataColumn
            Get
                Return Me.columnnhc
            End Get
        End Property
        
        Friend ReadOnly Property episcodeColumn As DataColumn
            Get
                Return Me.columnepiscode
            End Get
        End Property
        
        Friend ReadOnly Property diaColumn As DataColumn
            Get
                Return Me.columndia
            End Get
        End Property
        
        Friend ReadOnly Property horaColumn As DataColumn
            Get
                Return Me.columnhora
            End Get
        End Property
        
        Friend ReadOnly Property agennameColumn As DataColumn
            Get
                Return Me.columnagenname
            End Get
        End Property
        
        Friend ReadOnly Property agencodeColumn As DataColumn
            Get
                Return Me.columnagencode
            End Get
        End Property
        
        Friend ReadOnly Property tactcodeColumn As DataColumn
            Get
                Return Me.columntactcode
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As pers_filtroRow
            Get
                Return CType(Me.Rows(index),pers_filtroRow)
            End Get
        End Property
        
        Public Event pers_filtroRowChanged As pers_filtroRowChangeEventHandler
        
        Public Event pers_filtroRowChanging As pers_filtroRowChangeEventHandler
        
        Public Event pers_filtroRowDeleted As pers_filtroRowChangeEventHandler
        
        Public Event pers_filtroRowDeleting As pers_filtroRowChangeEventHandler
        
        Public Overloads Sub Addpers_filtroRow(ByVal row As pers_filtroRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addpers_filtroRow(ByVal pers_key As Integer, ByVal persfullname As String, ByVal persidencod1 As String, ByVal persidencod2 As String, ByVal nhc As String, ByVal episcode As String, ByVal dia As String, ByVal hora As String, ByVal agenname As String, ByVal agencode As String, ByVal tactcode As String) As pers_filtroRow
            Dim rowpers_filtroRow As pers_filtroRow = CType(Me.NewRow,pers_filtroRow)
            rowpers_filtroRow.ItemArray = New Object() {pers_key, persfullname, persidencod1, persidencod2, nhc, episcode, dia, hora, agenname, agencode, tactcode}
            Me.Rows.Add(rowpers_filtroRow)
            Return rowpers_filtroRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As pers_filtroDataTable = CType(MyBase.Clone,pers_filtroDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New pers_filtroDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnpers_key = Me.Columns("pers_key")
            Me.columnpersfullname = Me.Columns("persfullname")
            Me.columnpersidencod1 = Me.Columns("persidencod1")
            Me.columnpersidencod2 = Me.Columns("persidencod2")
            Me.columnnhc = Me.Columns("nhc")
            Me.columnepiscode = Me.Columns("episcode")
            Me.columndia = Me.Columns("dia")
            Me.columnhora = Me.Columns("hora")
            Me.columnagenname = Me.Columns("agenname")
            Me.columnagencode = Me.Columns("agencode")
            Me.columntactcode = Me.Columns("tactcode")
        End Sub
        
        Private Sub InitClass()
            Me.columnpers_key = New DataColumn("pers_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpers_key)
            Me.columnpersfullname = New DataColumn("persfullname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpersfullname)
            Me.columnpersidencod1 = New DataColumn("persidencod1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpersidencod1)
            Me.columnpersidencod2 = New DataColumn("persidencod2", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpersidencod2)
            Me.columnnhc = New DataColumn("nhc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnnhc)
            Me.columnepiscode = New DataColumn("episcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnepiscode)
            Me.columndia = New DataColumn("dia", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndia)
            Me.columnhora = New DataColumn("hora", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhora)
            Me.columnagenname = New DataColumn("agenname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnagenname)
            Me.columnagencode = New DataColumn("agencode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnagencode)
            Me.columntactcode = New DataColumn("tactcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columntactcode)
        End Sub
        
        Public Function Newpers_filtroRow() As pers_filtroRow
            Return CType(Me.NewRow,pers_filtroRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New pers_filtroRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(pers_filtroRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.pers_filtroRowChangedEvent) Is Nothing) Then
                RaiseEvent pers_filtroRowChanged(Me, New pers_filtroRowChangeEvent(CType(e.Row,pers_filtroRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.pers_filtroRowChangingEvent) Is Nothing) Then
                RaiseEvent pers_filtroRowChanging(Me, New pers_filtroRowChangeEvent(CType(e.Row,pers_filtroRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.pers_filtroRowDeletedEvent) Is Nothing) Then
                RaiseEvent pers_filtroRowDeleted(Me, New pers_filtroRowChangeEvent(CType(e.Row,pers_filtroRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.pers_filtroRowDeletingEvent) Is Nothing) Then
                RaiseEvent pers_filtroRowDeleting(Me, New pers_filtroRowChangeEvent(CType(e.Row,pers_filtroRow), e.Action))
            End If
        End Sub
        
        Public Sub Removepers_filtroRow(ByVal row As pers_filtroRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class pers_filtroRow
        Inherits DataRow
        
        Private tablepers_filtro As pers_filtroDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablepers_filtro = CType(Me.Table,pers_filtroDataTable)
        End Sub
        
        Public Property pers_key As Integer
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.pers_keyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.pers_keyColumn) = value
            End Set
        End Property
        
        Public Property persfullname As String
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.persfullnameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.persfullnameColumn) = value
            End Set
        End Property
        
        Public Property persidencod1 As String
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.persidencod1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.persidencod1Column) = value
            End Set
        End Property
        
        Public Property persidencod2 As String
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.persidencod2Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.persidencod2Column) = value
            End Set
        End Property
        
        Public Property nhc As String
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.nhcColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.nhcColumn) = value
            End Set
        End Property
        
        Public Property episcode As String
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.episcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.episcodeColumn) = value
            End Set
        End Property
        
        Public Property dia As String
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.diaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.diaColumn) = value
            End Set
        End Property
        
        Public Property hora As String
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.horaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.horaColumn) = value
            End Set
        End Property
        
        Public Property agenname As String
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.agennameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.agennameColumn) = value
            End Set
        End Property
        
        Public Property agencode As String
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.agencodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.agencodeColumn) = value
            End Set
        End Property
        
        Public Property tactcode As String
            Get
                Try 
                    Return CType(Me(Me.tablepers_filtro.tactcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablepers_filtro.tactcodeColumn) = value
            End Set
        End Property
        
        Public Function Ispers_keyNull() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.pers_keyColumn)
        End Function
        
        Public Sub Setpers_keyNull()
            Me(Me.tablepers_filtro.pers_keyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspersfullnameNull() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.persfullnameColumn)
        End Function
        
        Public Sub SetpersfullnameNull()
            Me(Me.tablepers_filtro.persfullnameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ispersidencod1Null() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.persidencod1Column)
        End Function
        
        Public Sub Setpersidencod1Null()
            Me(Me.tablepers_filtro.persidencod1Column) = System.Convert.DBNull
        End Sub
        
        Public Function Ispersidencod2Null() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.persidencod2Column)
        End Function
        
        Public Sub Setpersidencod2Null()
            Me(Me.tablepers_filtro.persidencod2Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsnhcNull() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.nhcColumn)
        End Function
        
        Public Sub SetnhcNull()
            Me(Me.tablepers_filtro.nhcColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsepiscodeNull() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.episcodeColumn)
        End Function
        
        Public Sub SetepiscodeNull()
            Me(Me.tablepers_filtro.episcodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsdiaNull() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.diaColumn)
        End Function
        
        Public Sub SetdiaNull()
            Me(Me.tablepers_filtro.diaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IshoraNull() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.horaColumn)
        End Function
        
        Public Sub SethoraNull()
            Me(Me.tablepers_filtro.horaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsagennameNull() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.agennameColumn)
        End Function
        
        Public Sub SetagennameNull()
            Me(Me.tablepers_filtro.agennameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsagencodeNull() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.agencodeColumn)
        End Function
        
        Public Sub SetagencodeNull()
            Me(Me.tablepers_filtro.agencodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IstactcodeNull() As Boolean
            Return Me.IsNull(Me.tablepers_filtro.tactcodeColumn)
        End Function
        
        Public Sub SettactcodeNull()
            Me(Me.tablepers_filtro.tactcodeColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class pers_filtroRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As pers_filtroRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As pers_filtroRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As pers_filtroRow
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
