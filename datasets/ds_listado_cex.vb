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
Public Class ds_listado_cex
    Inherits DataSet
    
    Private tableSP_CIMACEX_LISTADO_CEX As SP_CIMACEX_LISTADO_CEXDataTable
    
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
            If (Not (ds.Tables("SP_CIMACEX_LISTADO_CEX")) Is Nothing) Then
                Me.Tables.Add(New SP_CIMACEX_LISTADO_CEXDataTable(ds.Tables("SP_CIMACEX_LISTADO_CEX")))
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
    Public ReadOnly Property SP_CIMACEX_LISTADO_CEX As SP_CIMACEX_LISTADO_CEXDataTable
        Get
            Return Me.tableSP_CIMACEX_LISTADO_CEX
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_listado_cex = CType(MyBase.Clone,ds_listado_cex)
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
        If (Not (ds.Tables("SP_CIMACEX_LISTADO_CEX")) Is Nothing) Then
            Me.Tables.Add(New SP_CIMACEX_LISTADO_CEXDataTable(ds.Tables("SP_CIMACEX_LISTADO_CEX")))
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
        Me.tableSP_CIMACEX_LISTADO_CEX = CType(Me.Tables("SP_CIMACEX_LISTADO_CEX"),SP_CIMACEX_LISTADO_CEXDataTable)
        If (Not (Me.tableSP_CIMACEX_LISTADO_CEX) Is Nothing) Then
            Me.tableSP_CIMACEX_LISTADO_CEX.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_listado_cex"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_listado_cex.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableSP_CIMACEX_LISTADO_CEX = New SP_CIMACEX_LISTADO_CEXDataTable
        Me.Tables.Add(Me.tableSP_CIMACEX_LISTADO_CEX)
    End Sub
    
    Private Function ShouldSerializeSP_CIMACEX_LISTADO_CEX() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub SP_CIMACEX_LISTADO_CEXRowChangeEventHandler(ByVal sender As Object, ByVal e As SP_CIMACEX_LISTADO_CEXRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_LISTADO_CEXDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnepiscode As DataColumn
        
        Private columnpati_hfn As DataColumn
        
        Private columnhora_cita As DataColumn
        
        Private columnpersfullname As DataColumn
        
        Private columnfecha_nacimiento As DataColumn
        
        Private columnagenname As DataColumn
        
        Private columnagenprocdesc As DataColumn
        
        Private columnappostatdesc As DataColumn
        
        Private columnapporenddesc As DataColumn
        
        Private columnagenprocdesc1 As DataColumn
        
        Private columnbookhend As DataColumn
        
        Private columnappostatcode As DataColumn
        
        Private columnappoharr As DataColumn
        
        Private columndiardate As DataColumn
        
        Private columnbookhini As DataColumn
        
        Friend Sub New()
            MyBase.New("SP_CIMACEX_LISTADO_CEX")
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
        
        Friend ReadOnly Property pati_hfnColumn As DataColumn
            Get
                Return Me.columnpati_hfn
            End Get
        End Property
        
        Friend ReadOnly Property hora_citaColumn As DataColumn
            Get
                Return Me.columnhora_cita
            End Get
        End Property
        
        Friend ReadOnly Property persfullnameColumn As DataColumn
            Get
                Return Me.columnpersfullname
            End Get
        End Property
        
        Friend ReadOnly Property fecha_nacimientoColumn As DataColumn
            Get
                Return Me.columnfecha_nacimiento
            End Get
        End Property
        
        Friend ReadOnly Property agennameColumn As DataColumn
            Get
                Return Me.columnagenname
            End Get
        End Property
        
        Friend ReadOnly Property agenprocdescColumn As DataColumn
            Get
                Return Me.columnagenprocdesc
            End Get
        End Property
        
        Friend ReadOnly Property appostatdescColumn As DataColumn
            Get
                Return Me.columnappostatdesc
            End Get
        End Property
        
        Friend ReadOnly Property apporenddescColumn As DataColumn
            Get
                Return Me.columnapporenddesc
            End Get
        End Property
        
        Friend ReadOnly Property agenprocdesc1Column As DataColumn
            Get
                Return Me.columnagenprocdesc1
            End Get
        End Property
        
        Friend ReadOnly Property bookhendColumn As DataColumn
            Get
                Return Me.columnbookhend
            End Get
        End Property
        
        Friend ReadOnly Property appostatcodeColumn As DataColumn
            Get
                Return Me.columnappostatcode
            End Get
        End Property
        
        Friend ReadOnly Property appoharrColumn As DataColumn
            Get
                Return Me.columnappoharr
            End Get
        End Property
        
        Friend ReadOnly Property diardateColumn As DataColumn
            Get
                Return Me.columndiardate
            End Get
        End Property
        
        Friend ReadOnly Property bookhiniColumn As DataColumn
            Get
                Return Me.columnbookhini
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As SP_CIMACEX_LISTADO_CEXRow
            Get
                Return CType(Me.Rows(index),SP_CIMACEX_LISTADO_CEXRow)
            End Get
        End Property
        
        Public Event SP_CIMACEX_LISTADO_CEXRowChanged As SP_CIMACEX_LISTADO_CEXRowChangeEventHandler
        
        Public Event SP_CIMACEX_LISTADO_CEXRowChanging As SP_CIMACEX_LISTADO_CEXRowChangeEventHandler
        
        Public Event SP_CIMACEX_LISTADO_CEXRowDeleted As SP_CIMACEX_LISTADO_CEXRowChangeEventHandler
        
        Public Event SP_CIMACEX_LISTADO_CEXRowDeleting As SP_CIMACEX_LISTADO_CEXRowChangeEventHandler
        
        Public Overloads Sub AddSP_CIMACEX_LISTADO_CEXRow(ByVal row As SP_CIMACEX_LISTADO_CEXRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddSP_CIMACEX_LISTADO_CEXRow(ByVal episcode As String, ByVal pati_hfn As Integer, ByVal hora_cita As String, ByVal persfullname As String, ByVal fecha_nacimiento As String, ByVal agenname As String, ByVal agenprocdesc As String, ByVal appostatdesc As String, ByVal apporenddesc As String, ByVal agenprocdesc1 As String, ByVal bookhend As String, ByVal appostatcode As String, ByVal appoharr As String, ByVal diardate As String, ByVal bookhini As String) As SP_CIMACEX_LISTADO_CEXRow
            Dim rowSP_CIMACEX_LISTADO_CEXRow As SP_CIMACEX_LISTADO_CEXRow = CType(Me.NewRow,SP_CIMACEX_LISTADO_CEXRow)
            rowSP_CIMACEX_LISTADO_CEXRow.ItemArray = New Object() {episcode, pati_hfn, hora_cita, persfullname, fecha_nacimiento, agenname, agenprocdesc, appostatdesc, apporenddesc, agenprocdesc1, bookhend, appostatcode, appoharr, diardate, bookhini}
            Me.Rows.Add(rowSP_CIMACEX_LISTADO_CEXRow)
            Return rowSP_CIMACEX_LISTADO_CEXRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As SP_CIMACEX_LISTADO_CEXDataTable = CType(MyBase.Clone,SP_CIMACEX_LISTADO_CEXDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New SP_CIMACEX_LISTADO_CEXDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnepiscode = Me.Columns("episcode")
            Me.columnpati_hfn = Me.Columns("pati_hfn")
            Me.columnhora_cita = Me.Columns("hora_cita")
            Me.columnpersfullname = Me.Columns("persfullname")
            Me.columnfecha_nacimiento = Me.Columns("fecha_nacimiento")
            Me.columnagenname = Me.Columns("agenname")
            Me.columnagenprocdesc = Me.Columns("agenprocdesc")
            Me.columnappostatdesc = Me.Columns("appostatdesc")
            Me.columnapporenddesc = Me.Columns("apporenddesc")
            Me.columnagenprocdesc1 = Me.Columns("agenprocdesc1")
            Me.columnbookhend = Me.Columns("bookhend")
            Me.columnappostatcode = Me.Columns("appostatcode")
            Me.columnappoharr = Me.Columns("appoharr")
            Me.columndiardate = Me.Columns("diardate")
            Me.columnbookhini = Me.Columns("bookhini")
        End Sub
        
        Private Sub InitClass()
            Me.columnepiscode = New DataColumn("episcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnepiscode)
            Me.columnpati_hfn = New DataColumn("pati_hfn", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpati_hfn)
            Me.columnhora_cita = New DataColumn("hora_cita", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhora_cita)
            Me.columnpersfullname = New DataColumn("persfullname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpersfullname)
            Me.columnfecha_nacimiento = New DataColumn("fecha_nacimiento", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfecha_nacimiento)
            Me.columnagenname = New DataColumn("agenname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnagenname)
            Me.columnagenprocdesc = New DataColumn("agenprocdesc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnagenprocdesc)
            Me.columnappostatdesc = New DataColumn("appostatdesc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnappostatdesc)
            Me.columnapporenddesc = New DataColumn("apporenddesc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnapporenddesc)
            Me.columnagenprocdesc1 = New DataColumn("agenprocdesc1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnagenprocdesc1)
            Me.columnbookhend = New DataColumn("bookhend", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbookhend)
            Me.columnappostatcode = New DataColumn("appostatcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnappostatcode)
            Me.columnappoharr = New DataColumn("appoharr", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnappoharr)
            Me.columndiardate = New DataColumn("diardate", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndiardate)
            Me.columnbookhini = New DataColumn("bookhini", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbookhini)
            Me.columnepiscode.AllowDBNull = false
            Me.columnhora_cita.ReadOnly = true
            Me.columnfecha_nacimiento.ReadOnly = true
            Me.columnagenname.AllowDBNull = false
            Me.columnappostatdesc.AllowDBNull = false
            Me.columnbookhend.ReadOnly = true
            Me.columnappostatcode.AllowDBNull = false
            Me.columnappoharr.ReadOnly = true
        End Sub
        
        Public Function NewSP_CIMACEX_LISTADO_CEXRow() As SP_CIMACEX_LISTADO_CEXRow
            Return CType(Me.NewRow,SP_CIMACEX_LISTADO_CEXRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New SP_CIMACEX_LISTADO_CEXRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(SP_CIMACEX_LISTADO_CEXRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.SP_CIMACEX_LISTADO_CEXRowChangedEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_LISTADO_CEXRowChanged(Me, New SP_CIMACEX_LISTADO_CEXRowChangeEvent(CType(e.Row,SP_CIMACEX_LISTADO_CEXRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.SP_CIMACEX_LISTADO_CEXRowChangingEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_LISTADO_CEXRowChanging(Me, New SP_CIMACEX_LISTADO_CEXRowChangeEvent(CType(e.Row,SP_CIMACEX_LISTADO_CEXRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.SP_CIMACEX_LISTADO_CEXRowDeletedEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_LISTADO_CEXRowDeleted(Me, New SP_CIMACEX_LISTADO_CEXRowChangeEvent(CType(e.Row,SP_CIMACEX_LISTADO_CEXRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.SP_CIMACEX_LISTADO_CEXRowDeletingEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_LISTADO_CEXRowDeleting(Me, New SP_CIMACEX_LISTADO_CEXRowChangeEvent(CType(e.Row,SP_CIMACEX_LISTADO_CEXRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveSP_CIMACEX_LISTADO_CEXRow(ByVal row As SP_CIMACEX_LISTADO_CEXRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_LISTADO_CEXRow
        Inherits DataRow
        
        Private tableSP_CIMACEX_LISTADO_CEX As SP_CIMACEX_LISTADO_CEXDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableSP_CIMACEX_LISTADO_CEX = CType(Me.Table,SP_CIMACEX_LISTADO_CEXDataTable)
        End Sub
        
        Public Property episcode As String
            Get
                Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.episcodeColumn),String)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.episcodeColumn) = value
            End Set
        End Property
        
        Public Property pati_hfn As Integer
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.pati_hfnColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.pati_hfnColumn) = value
            End Set
        End Property
        
        Public Property hora_cita As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.hora_citaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.hora_citaColumn) = value
            End Set
        End Property
        
        Public Property persfullname As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.persfullnameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.persfullnameColumn) = value
            End Set
        End Property
        
        Public Property fecha_nacimiento As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.fecha_nacimientoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.fecha_nacimientoColumn) = value
            End Set
        End Property
        
        Public Property agenname As String
            Get
                Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.agennameColumn),String)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.agennameColumn) = value
            End Set
        End Property
        
        Public Property agenprocdesc As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.agenprocdescColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.agenprocdescColumn) = value
            End Set
        End Property
        
        Public Property appostatdesc As String
            Get
                Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.appostatdescColumn),String)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.appostatdescColumn) = value
            End Set
        End Property
        
        Public Property apporenddesc As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.apporenddescColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.apporenddescColumn) = value
            End Set
        End Property
        
        Public Property agenprocdesc1 As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.agenprocdesc1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.agenprocdesc1Column) = value
            End Set
        End Property
        
        Public Property bookhend As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.bookhendColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.bookhendColumn) = value
            End Set
        End Property
        
        Public Property appostatcode As String
            Get
                Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.appostatcodeColumn),String)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.appostatcodeColumn) = value
            End Set
        End Property
        
        Public Property appoharr As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.appoharrColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.appoharrColumn) = value
            End Set
        End Property
        
        Public Property diardate As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.diardateColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.diardateColumn) = value
            End Set
        End Property
        
        Public Property bookhini As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_LISTADO_CEX.bookhiniColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_LISTADO_CEX.bookhiniColumn) = value
            End Set
        End Property
        
        Public Function Ispati_hfnNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.pati_hfnColumn)
        End Function
        
        Public Sub Setpati_hfnNull()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.pati_hfnColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ishora_citaNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.hora_citaColumn)
        End Function
        
        Public Sub Sethora_citaNull()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.hora_citaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspersfullnameNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.persfullnameColumn)
        End Function
        
        Public Sub SetpersfullnameNull()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.persfullnameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isfecha_nacimientoNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.fecha_nacimientoColumn)
        End Function
        
        Public Sub Setfecha_nacimientoNull()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.fecha_nacimientoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsagenprocdescNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.agenprocdescColumn)
        End Function
        
        Public Sub SetagenprocdescNull()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.agenprocdescColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsapporenddescNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.apporenddescColumn)
        End Function
        
        Public Sub SetapporenddescNull()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.apporenddescColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isagenprocdesc1Null() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.agenprocdesc1Column)
        End Function
        
        Public Sub Setagenprocdesc1Null()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.agenprocdesc1Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsbookhendNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.bookhendColumn)
        End Function
        
        Public Sub SetbookhendNull()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.bookhendColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsappoharrNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.appoharrColumn)
        End Function
        
        Public Sub SetappoharrNull()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.appoharrColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsdiardateNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.diardateColumn)
        End Function
        
        Public Sub SetdiardateNull()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.diardateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsbookhiniNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_LISTADO_CEX.bookhiniColumn)
        End Function
        
        Public Sub SetbookhiniNull()
            Me(Me.tableSP_CIMACEX_LISTADO_CEX.bookhiniColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_LISTADO_CEXRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As SP_CIMACEX_LISTADO_CEXRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As SP_CIMACEX_LISTADO_CEXRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As SP_CIMACEX_LISTADO_CEXRow
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
