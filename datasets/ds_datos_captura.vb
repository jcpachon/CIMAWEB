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
Public Class ds_datos_captura
    Inherits DataSet
    
    Private tableSP_CIMACEX_DATOS_CAPTURA As SP_CIMACEX_DATOS_CAPTURADataTable
    
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
            If (Not (ds.Tables("SP_CIMACEX_DATOS_CAPTURA")) Is Nothing) Then
                Me.Tables.Add(New SP_CIMACEX_DATOS_CAPTURADataTable(ds.Tables("SP_CIMACEX_DATOS_CAPTURA")))
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
    Public ReadOnly Property SP_CIMACEX_DATOS_CAPTURA As SP_CIMACEX_DATOS_CAPTURADataTable
        Get
            Return Me.tableSP_CIMACEX_DATOS_CAPTURA
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_datos_captura = CType(MyBase.Clone,ds_datos_captura)
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
        If (Not (ds.Tables("SP_CIMACEX_DATOS_CAPTURA")) Is Nothing) Then
            Me.Tables.Add(New SP_CIMACEX_DATOS_CAPTURADataTable(ds.Tables("SP_CIMACEX_DATOS_CAPTURA")))
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
        Me.tableSP_CIMACEX_DATOS_CAPTURA = CType(Me.Tables("SP_CIMACEX_DATOS_CAPTURA"),SP_CIMACEX_DATOS_CAPTURADataTable)
        If (Not (Me.tableSP_CIMACEX_DATOS_CAPTURA) Is Nothing) Then
            Me.tableSP_CIMACEX_DATOS_CAPTURA.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_datos_captura"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_datos_captura.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableSP_CIMACEX_DATOS_CAPTURA = New SP_CIMACEX_DATOS_CAPTURADataTable
        Me.Tables.Add(Me.tableSP_CIMACEX_DATOS_CAPTURA)
    End Sub
    
    Private Function ShouldSerializeSP_CIMACEX_DATOS_CAPTURA() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub SP_CIMACEX_DATOS_CAPTURARowChangeEventHandler(ByVal sender As Object, ByVal e As SP_CIMACEX_DATOS_CAPTURARowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_DATOS_CAPTURADataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnepiscode As DataColumn
        
        Private columnpati_hfn As DataColumn
        
        Private columndia As DataColumn
        
        Private columnhora_ini As DataColumn
        
        Private columnpers_key As DataColumn
        
        Private columnperssur1 As DataColumn
        
        Private columnperssur2 As DataColumn
        
        Private columnpersname As DataColumn
        
        Private columnpersbirtdate As DataColumn
        
        Private columnpersdatecalc As DataColumn
        
        Private columntsexdesc As DataColumn
        
        Private columnpersfullname As DataColumn
        
        Private columnhora_fin As DataColumn
        
        Friend Sub New()
            MyBase.New("SP_CIMACEX_DATOS_CAPTURA")
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
        
        Friend ReadOnly Property diaColumn As DataColumn
            Get
                Return Me.columndia
            End Get
        End Property
        
        Friend ReadOnly Property hora_iniColumn As DataColumn
            Get
                Return Me.columnhora_ini
            End Get
        End Property
        
        Friend ReadOnly Property pers_keyColumn As DataColumn
            Get
                Return Me.columnpers_key
            End Get
        End Property
        
        Friend ReadOnly Property perssur1Column As DataColumn
            Get
                Return Me.columnperssur1
            End Get
        End Property
        
        Friend ReadOnly Property perssur2Column As DataColumn
            Get
                Return Me.columnperssur2
            End Get
        End Property
        
        Friend ReadOnly Property persnameColumn As DataColumn
            Get
                Return Me.columnpersname
            End Get
        End Property
        
        Friend ReadOnly Property persbirtdateColumn As DataColumn
            Get
                Return Me.columnpersbirtdate
            End Get
        End Property
        
        Friend ReadOnly Property persdatecalcColumn As DataColumn
            Get
                Return Me.columnpersdatecalc
            End Get
        End Property
        
        Friend ReadOnly Property tsexdescColumn As DataColumn
            Get
                Return Me.columntsexdesc
            End Get
        End Property
        
        Friend ReadOnly Property persfullnameColumn As DataColumn
            Get
                Return Me.columnpersfullname
            End Get
        End Property
        
        Friend ReadOnly Property hora_finColumn As DataColumn
            Get
                Return Me.columnhora_fin
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As SP_CIMACEX_DATOS_CAPTURARow
            Get
                Return CType(Me.Rows(index),SP_CIMACEX_DATOS_CAPTURARow)
            End Get
        End Property
        
        Public Event SP_CIMACEX_DATOS_CAPTURARowChanged As SP_CIMACEX_DATOS_CAPTURARowChangeEventHandler
        
        Public Event SP_CIMACEX_DATOS_CAPTURARowChanging As SP_CIMACEX_DATOS_CAPTURARowChangeEventHandler
        
        Public Event SP_CIMACEX_DATOS_CAPTURARowDeleted As SP_CIMACEX_DATOS_CAPTURARowChangeEventHandler
        
        Public Event SP_CIMACEX_DATOS_CAPTURARowDeleting As SP_CIMACEX_DATOS_CAPTURARowChangeEventHandler
        
        Public Overloads Sub AddSP_CIMACEX_DATOS_CAPTURARow(ByVal row As SP_CIMACEX_DATOS_CAPTURARow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddSP_CIMACEX_DATOS_CAPTURARow(ByVal episcode As String, ByVal pati_hfn As Integer, ByVal dia As String, ByVal hora_ini As String, ByVal pers_key As Integer, ByVal perssur1 As String, ByVal perssur2 As String, ByVal persname As String, ByVal persbirtdate As String, ByVal persdatecalc As String, ByVal tsexdesc As String, ByVal persfullname As String, ByVal hora_fin As String) As SP_CIMACEX_DATOS_CAPTURARow
            Dim rowSP_CIMACEX_DATOS_CAPTURARow As SP_CIMACEX_DATOS_CAPTURARow = CType(Me.NewRow,SP_CIMACEX_DATOS_CAPTURARow)
            rowSP_CIMACEX_DATOS_CAPTURARow.ItemArray = New Object() {episcode, pati_hfn, dia, hora_ini, pers_key, perssur1, perssur2, persname, persbirtdate, persdatecalc, tsexdesc, persfullname, hora_fin}
            Me.Rows.Add(rowSP_CIMACEX_DATOS_CAPTURARow)
            Return rowSP_CIMACEX_DATOS_CAPTURARow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As SP_CIMACEX_DATOS_CAPTURADataTable = CType(MyBase.Clone,SP_CIMACEX_DATOS_CAPTURADataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New SP_CIMACEX_DATOS_CAPTURADataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnepiscode = Me.Columns("episcode")
            Me.columnpati_hfn = Me.Columns("pati_hfn")
            Me.columndia = Me.Columns("dia")
            Me.columnhora_ini = Me.Columns("hora_ini")
            Me.columnpers_key = Me.Columns("pers_key")
            Me.columnperssur1 = Me.Columns("perssur1")
            Me.columnperssur2 = Me.Columns("perssur2")
            Me.columnpersname = Me.Columns("persname")
            Me.columnpersbirtdate = Me.Columns("persbirtdate")
            Me.columnpersdatecalc = Me.Columns("persdatecalc")
            Me.columntsexdesc = Me.Columns("tsexdesc")
            Me.columnpersfullname = Me.Columns("persfullname")
            Me.columnhora_fin = Me.Columns("hora_fin")
        End Sub
        
        Private Sub InitClass()
            Me.columnepiscode = New DataColumn("episcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnepiscode)
            Me.columnpati_hfn = New DataColumn("pati_hfn", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpati_hfn)
            Me.columndia = New DataColumn("dia", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndia)
            Me.columnhora_ini = New DataColumn("hora_ini", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhora_ini)
            Me.columnpers_key = New DataColumn("pers_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpers_key)
            Me.columnperssur1 = New DataColumn("perssur1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnperssur1)
            Me.columnperssur2 = New DataColumn("perssur2", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnperssur2)
            Me.columnpersname = New DataColumn("persname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpersname)
            Me.columnpersbirtdate = New DataColumn("persbirtdate", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpersbirtdate)
            Me.columnpersdatecalc = New DataColumn("persdatecalc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpersdatecalc)
            Me.columntsexdesc = New DataColumn("tsexdesc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columntsexdesc)
            Me.columnpersfullname = New DataColumn("persfullname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpersfullname)
            Me.columnhora_fin = New DataColumn("hora_fin", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhora_fin)
            Me.columnepiscode.AllowDBNull = false
            Me.columndia.ReadOnly = true
            Me.columnhora_ini.ReadOnly = true
            Me.columnpers_key.AllowDBNull = false
            Me.columnpersbirtdate.ReadOnly = true
            Me.columnpersdatecalc.ReadOnly = true
        End Sub
        
        Public Function NewSP_CIMACEX_DATOS_CAPTURARow() As SP_CIMACEX_DATOS_CAPTURARow
            Return CType(Me.NewRow,SP_CIMACEX_DATOS_CAPTURARow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New SP_CIMACEX_DATOS_CAPTURARow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(SP_CIMACEX_DATOS_CAPTURARow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.SP_CIMACEX_DATOS_CAPTURARowChangedEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_DATOS_CAPTURARowChanged(Me, New SP_CIMACEX_DATOS_CAPTURARowChangeEvent(CType(e.Row,SP_CIMACEX_DATOS_CAPTURARow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.SP_CIMACEX_DATOS_CAPTURARowChangingEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_DATOS_CAPTURARowChanging(Me, New SP_CIMACEX_DATOS_CAPTURARowChangeEvent(CType(e.Row,SP_CIMACEX_DATOS_CAPTURARow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.SP_CIMACEX_DATOS_CAPTURARowDeletedEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_DATOS_CAPTURARowDeleted(Me, New SP_CIMACEX_DATOS_CAPTURARowChangeEvent(CType(e.Row,SP_CIMACEX_DATOS_CAPTURARow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.SP_CIMACEX_DATOS_CAPTURARowDeletingEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_DATOS_CAPTURARowDeleting(Me, New SP_CIMACEX_DATOS_CAPTURARowChangeEvent(CType(e.Row,SP_CIMACEX_DATOS_CAPTURARow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveSP_CIMACEX_DATOS_CAPTURARow(ByVal row As SP_CIMACEX_DATOS_CAPTURARow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_DATOS_CAPTURARow
        Inherits DataRow
        
        Private tableSP_CIMACEX_DATOS_CAPTURA As SP_CIMACEX_DATOS_CAPTURADataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableSP_CIMACEX_DATOS_CAPTURA = CType(Me.Table,SP_CIMACEX_DATOS_CAPTURADataTable)
        End Sub
        
        Public Property episcode As String
            Get
                Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.episcodeColumn),String)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.episcodeColumn) = value
            End Set
        End Property
        
        Public Property pati_hfn As Integer
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.pati_hfnColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.pati_hfnColumn) = value
            End Set
        End Property
        
        Public Property dia As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.diaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.diaColumn) = value
            End Set
        End Property
        
        Public Property hora_ini As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.hora_iniColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.hora_iniColumn) = value
            End Set
        End Property
        
        Public Property pers_key As Integer
            Get
                Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.pers_keyColumn),Integer)
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.pers_keyColumn) = value
            End Set
        End Property
        
        Public Property perssur1 As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.perssur1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.perssur1Column) = value
            End Set
        End Property
        
        Public Property perssur2 As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.perssur2Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.perssur2Column) = value
            End Set
        End Property
        
        Public Property persname As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persnameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persnameColumn) = value
            End Set
        End Property
        
        Public Property persbirtdate As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persbirtdateColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persbirtdateColumn) = value
            End Set
        End Property
        
        Public Property persdatecalc As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persdatecalcColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persdatecalcColumn) = value
            End Set
        End Property
        
        Public Property tsexdesc As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.tsexdescColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.tsexdescColumn) = value
            End Set
        End Property
        
        Public Property persfullname As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persfullnameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persfullnameColumn) = value
            End Set
        End Property
        
        Public Property hora_fin As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.hora_finColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.hora_finColumn) = value
            End Set
        End Property
        
        Public Function Ispati_hfnNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.pati_hfnColumn)
        End Function
        
        Public Sub Setpati_hfnNull()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.pati_hfnColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsdiaNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.diaColumn)
        End Function
        
        Public Sub SetdiaNull()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.diaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ishora_iniNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.hora_iniColumn)
        End Function
        
        Public Sub Sethora_iniNull()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.hora_iniColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isperssur1Null() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.perssur1Column)
        End Function
        
        Public Sub Setperssur1Null()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.perssur1Column) = System.Convert.DBNull
        End Sub
        
        Public Function Isperssur2Null() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.perssur2Column)
        End Function
        
        Public Sub Setperssur2Null()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.perssur2Column) = System.Convert.DBNull
        End Sub
        
        Public Function IspersnameNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.persnameColumn)
        End Function
        
        Public Sub SetpersnameNull()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persnameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspersbirtdateNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.persbirtdateColumn)
        End Function
        
        Public Sub SetpersbirtdateNull()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persbirtdateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspersdatecalcNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.persdatecalcColumn)
        End Function
        
        Public Sub SetpersdatecalcNull()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persdatecalcColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IstsexdescNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.tsexdescColumn)
        End Function
        
        Public Sub SettsexdescNull()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.tsexdescColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspersfullnameNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.persfullnameColumn)
        End Function
        
        Public Sub SetpersfullnameNull()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.persfullnameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ishora_finNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_DATOS_CAPTURA.hora_finColumn)
        End Function
        
        Public Sub Sethora_finNull()
            Me(Me.tableSP_CIMACEX_DATOS_CAPTURA.hora_finColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_DATOS_CAPTURARowChangeEvent
        Inherits EventArgs
        
        Private eventRow As SP_CIMACEX_DATOS_CAPTURARow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As SP_CIMACEX_DATOS_CAPTURARow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As SP_CIMACEX_DATOS_CAPTURARow
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
