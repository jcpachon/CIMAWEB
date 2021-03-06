﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2463
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
Public Class ds_historico_camas
    Inherits DataSet
    
    Private tableSP_CIMACEX_HISTORICO_CAMAS As SP_CIMACEX_HISTORICO_CAMASDataTable
    
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
            If (Not (ds.Tables("SP_CIMACEX_HISTORICO_CAMAS")) Is Nothing) Then
                Me.Tables.Add(New SP_CIMACEX_HISTORICO_CAMASDataTable(ds.Tables("SP_CIMACEX_HISTORICO_CAMAS")))
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
    Public ReadOnly Property SP_CIMACEX_HISTORICO_CAMAS As SP_CIMACEX_HISTORICO_CAMASDataTable
        Get
            Return Me.tableSP_CIMACEX_HISTORICO_CAMAS
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_historico_camas = CType(MyBase.Clone,ds_historico_camas)
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
        If (Not (ds.Tables("SP_CIMACEX_HISTORICO_CAMAS")) Is Nothing) Then
            Me.Tables.Add(New SP_CIMACEX_HISTORICO_CAMASDataTable(ds.Tables("SP_CIMACEX_HISTORICO_CAMAS")))
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
        Me.tableSP_CIMACEX_HISTORICO_CAMAS = CType(Me.Tables("SP_CIMACEX_HISTORICO_CAMAS"),SP_CIMACEX_HISTORICO_CAMASDataTable)
        If (Not (Me.tableSP_CIMACEX_HISTORICO_CAMAS) Is Nothing) Then
            Me.tableSP_CIMACEX_HISTORICO_CAMAS.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_historico_camas"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_historico_camas.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableSP_CIMACEX_HISTORICO_CAMAS = New SP_CIMACEX_HISTORICO_CAMASDataTable
        Me.Tables.Add(Me.tableSP_CIMACEX_HISTORICO_CAMAS)
    End Sub
    
    Private Function ShouldSerializeSP_CIMACEX_HISTORICO_CAMAS() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub SP_CIMACEX_HISTORICO_CAMASRowChangeEventHandler(ByVal sender As Object, ByVal e As SP_CIMACEX_HISTORICO_CAMASRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_HISTORICO_CAMASDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnbedscode As DataColumn
        
        Private columnprimer_apellido As DataColumn
        
        Private columnsegundo_apellido As DataColumn
        
        Private columnnombre As DataColumn
        
        Private columnNHC As DataColumn
        
        Private columnepisodio As DataColumn
        
        Private columnMUTUA As DataColumn
        
        Private columnfecha_ingreso As DataColumn
        
        Private columnhora_ingreso As DataColumn
        
        Private columnfecha_alta As DataColumn
        
        Private columnhora_alta As DataColumn
        
        Friend Sub New()
            MyBase.New("SP_CIMACEX_HISTORICO_CAMAS")
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
        
        Friend ReadOnly Property bedscodeColumn As DataColumn
            Get
                Return Me.columnbedscode
            End Get
        End Property
        
        Friend ReadOnly Property primer_apellidoColumn As DataColumn
            Get
                Return Me.columnprimer_apellido
            End Get
        End Property
        
        Friend ReadOnly Property segundo_apellidoColumn As DataColumn
            Get
                Return Me.columnsegundo_apellido
            End Get
        End Property
        
        Friend ReadOnly Property nombreColumn As DataColumn
            Get
                Return Me.columnnombre
            End Get
        End Property
        
        Friend ReadOnly Property NHCColumn As DataColumn
            Get
                Return Me.columnNHC
            End Get
        End Property
        
        Friend ReadOnly Property episodioColumn As DataColumn
            Get
                Return Me.columnepisodio
            End Get
        End Property
        
        Friend ReadOnly Property MUTUAColumn As DataColumn
            Get
                Return Me.columnMUTUA
            End Get
        End Property
        
        Friend ReadOnly Property fecha_ingresoColumn As DataColumn
            Get
                Return Me.columnfecha_ingreso
            End Get
        End Property
        
        Friend ReadOnly Property hora_ingresoColumn As DataColumn
            Get
                Return Me.columnhora_ingreso
            End Get
        End Property
        
        Friend ReadOnly Property fecha_altaColumn As DataColumn
            Get
                Return Me.columnfecha_alta
            End Get
        End Property
        
        Friend ReadOnly Property hora_altaColumn As DataColumn
            Get
                Return Me.columnhora_alta
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As SP_CIMACEX_HISTORICO_CAMASRow
            Get
                Return CType(Me.Rows(index),SP_CIMACEX_HISTORICO_CAMASRow)
            End Get
        End Property
        
        Public Event SP_CIMACEX_HISTORICO_CAMASRowChanged As SP_CIMACEX_HISTORICO_CAMASRowChangeEventHandler
        
        Public Event SP_CIMACEX_HISTORICO_CAMASRowChanging As SP_CIMACEX_HISTORICO_CAMASRowChangeEventHandler
        
        Public Event SP_CIMACEX_HISTORICO_CAMASRowDeleted As SP_CIMACEX_HISTORICO_CAMASRowChangeEventHandler
        
        Public Event SP_CIMACEX_HISTORICO_CAMASRowDeleting As SP_CIMACEX_HISTORICO_CAMASRowChangeEventHandler
        
        Public Overloads Sub AddSP_CIMACEX_HISTORICO_CAMASRow(ByVal row As SP_CIMACEX_HISTORICO_CAMASRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddSP_CIMACEX_HISTORICO_CAMASRow(ByVal bedscode As String, ByVal primer_apellido As String, ByVal segundo_apellido As String, ByVal nombre As String, ByVal NHC As String, ByVal episodio As String, ByVal MUTUA As String, ByVal fecha_ingreso As String, ByVal hora_ingreso As String, ByVal fecha_alta As String, ByVal hora_alta As String) As SP_CIMACEX_HISTORICO_CAMASRow
            Dim rowSP_CIMACEX_HISTORICO_CAMASRow As SP_CIMACEX_HISTORICO_CAMASRow = CType(Me.NewRow,SP_CIMACEX_HISTORICO_CAMASRow)
            rowSP_CIMACEX_HISTORICO_CAMASRow.ItemArray = New Object() {bedscode, primer_apellido, segundo_apellido, nombre, NHC, episodio, MUTUA, fecha_ingreso, hora_ingreso, fecha_alta, hora_alta}
            Me.Rows.Add(rowSP_CIMACEX_HISTORICO_CAMASRow)
            Return rowSP_CIMACEX_HISTORICO_CAMASRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As SP_CIMACEX_HISTORICO_CAMASDataTable = CType(MyBase.Clone,SP_CIMACEX_HISTORICO_CAMASDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New SP_CIMACEX_HISTORICO_CAMASDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnbedscode = Me.Columns("bedscode")
            Me.columnprimer_apellido = Me.Columns("primer_apellido")
            Me.columnsegundo_apellido = Me.Columns("segundo_apellido")
            Me.columnnombre = Me.Columns("nombre")
            Me.columnNHC = Me.Columns("NHC")
            Me.columnepisodio = Me.Columns("episodio")
            Me.columnMUTUA = Me.Columns("MUTUA")
            Me.columnfecha_ingreso = Me.Columns("fecha_ingreso")
            Me.columnhora_ingreso = Me.Columns("hora_ingreso")
            Me.columnfecha_alta = Me.Columns("fecha_alta")
            Me.columnhora_alta = Me.Columns("hora_alta")
        End Sub
        
        Private Sub InitClass()
            Me.columnbedscode = New DataColumn("bedscode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnbedscode)
            Me.columnprimer_apellido = New DataColumn("primer_apellido", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnprimer_apellido)
            Me.columnsegundo_apellido = New DataColumn("segundo_apellido", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnsegundo_apellido)
            Me.columnnombre = New DataColumn("nombre", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnnombre)
            Me.columnNHC = New DataColumn("NHC", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNHC)
            Me.columnepisodio = New DataColumn("episodio", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnepisodio)
            Me.columnMUTUA = New DataColumn("MUTUA", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMUTUA)
            Me.columnfecha_ingreso = New DataColumn("fecha_ingreso", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfecha_ingreso)
            Me.columnhora_ingreso = New DataColumn("hora_ingreso", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhora_ingreso)
            Me.columnfecha_alta = New DataColumn("fecha_alta", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfecha_alta)
            Me.columnhora_alta = New DataColumn("hora_alta", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnhora_alta)
        End Sub
        
        Public Function NewSP_CIMACEX_HISTORICO_CAMASRow() As SP_CIMACEX_HISTORICO_CAMASRow
            Return CType(Me.NewRow,SP_CIMACEX_HISTORICO_CAMASRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New SP_CIMACEX_HISTORICO_CAMASRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(SP_CIMACEX_HISTORICO_CAMASRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.SP_CIMACEX_HISTORICO_CAMASRowChangedEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_HISTORICO_CAMASRowChanged(Me, New SP_CIMACEX_HISTORICO_CAMASRowChangeEvent(CType(e.Row,SP_CIMACEX_HISTORICO_CAMASRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.SP_CIMACEX_HISTORICO_CAMASRowChangingEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_HISTORICO_CAMASRowChanging(Me, New SP_CIMACEX_HISTORICO_CAMASRowChangeEvent(CType(e.Row,SP_CIMACEX_HISTORICO_CAMASRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.SP_CIMACEX_HISTORICO_CAMASRowDeletedEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_HISTORICO_CAMASRowDeleted(Me, New SP_CIMACEX_HISTORICO_CAMASRowChangeEvent(CType(e.Row,SP_CIMACEX_HISTORICO_CAMASRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.SP_CIMACEX_HISTORICO_CAMASRowDeletingEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_HISTORICO_CAMASRowDeleting(Me, New SP_CIMACEX_HISTORICO_CAMASRowChangeEvent(CType(e.Row,SP_CIMACEX_HISTORICO_CAMASRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveSP_CIMACEX_HISTORICO_CAMASRow(ByVal row As SP_CIMACEX_HISTORICO_CAMASRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_HISTORICO_CAMASRow
        Inherits DataRow
        
        Private tableSP_CIMACEX_HISTORICO_CAMAS As SP_CIMACEX_HISTORICO_CAMASDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableSP_CIMACEX_HISTORICO_CAMAS = CType(Me.Table,SP_CIMACEX_HISTORICO_CAMASDataTable)
        End Sub
        
        Public Property bedscode As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.bedscodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.bedscodeColumn) = value
            End Set
        End Property
        
        Public Property primer_apellido As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.primer_apellidoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.primer_apellidoColumn) = value
            End Set
        End Property
        
        Public Property segundo_apellido As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.segundo_apellidoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.segundo_apellidoColumn) = value
            End Set
        End Property
        
        Public Property nombre As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.nombreColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.nombreColumn) = value
            End Set
        End Property
        
        Public Property NHC As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.NHCColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.NHCColumn) = value
            End Set
        End Property
        
        Public Property episodio As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.episodioColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.episodioColumn) = value
            End Set
        End Property
        
        Public Property MUTUA As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.MUTUAColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.MUTUAColumn) = value
            End Set
        End Property
        
        Public Property fecha_ingreso As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.fecha_ingresoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.fecha_ingresoColumn) = value
            End Set
        End Property
        
        Public Property hora_ingreso As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.hora_ingresoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.hora_ingresoColumn) = value
            End Set
        End Property
        
        Public Property fecha_alta As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.fecha_altaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.fecha_altaColumn) = value
            End Set
        End Property
        
        Public Property hora_alta As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.hora_altaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.hora_altaColumn) = value
            End Set
        End Property
        
        Public Function IsbedscodeNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.bedscodeColumn)
        End Function
        
        Public Sub SetbedscodeNull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.bedscodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isprimer_apellidoNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.primer_apellidoColumn)
        End Function
        
        Public Sub Setprimer_apellidoNull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.primer_apellidoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Issegundo_apellidoNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.segundo_apellidoColumn)
        End Function
        
        Public Sub Setsegundo_apellidoNull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.segundo_apellidoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsnombreNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.nombreColumn)
        End Function
        
        Public Sub SetnombreNull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.nombreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsNHCNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.NHCColumn)
        End Function
        
        Public Sub SetNHCNull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.NHCColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsepisodioNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.episodioColumn)
        End Function
        
        Public Sub SetepisodioNull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.episodioColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsMUTUANull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.MUTUAColumn)
        End Function
        
        Public Sub SetMUTUANull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.MUTUAColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isfecha_ingresoNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.fecha_ingresoColumn)
        End Function
        
        Public Sub Setfecha_ingresoNull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.fecha_ingresoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ishora_ingresoNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.hora_ingresoColumn)
        End Function
        
        Public Sub Sethora_ingresoNull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.hora_ingresoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isfecha_altaNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.fecha_altaColumn)
        End Function
        
        Public Sub Setfecha_altaNull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.fecha_altaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ishora_altaNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_HISTORICO_CAMAS.hora_altaColumn)
        End Function
        
        Public Sub Sethora_altaNull()
            Me(Me.tableSP_CIMACEX_HISTORICO_CAMAS.hora_altaColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_HISTORICO_CAMASRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As SP_CIMACEX_HISTORICO_CAMASRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As SP_CIMACEX_HISTORICO_CAMASRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As SP_CIMACEX_HISTORICO_CAMASRow
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
