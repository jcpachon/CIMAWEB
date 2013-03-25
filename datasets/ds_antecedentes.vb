﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
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
Public Class ds_antecedentes
    Inherits DataSet
    
    Private tableSP_CIMACEX_ANTECEDENTES As SP_CIMACEX_ANTECEDENTESDataTable
    
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
            If (Not (ds.Tables("SP_CIMACEX_ANTECEDENTES")) Is Nothing) Then
                Me.Tables.Add(New SP_CIMACEX_ANTECEDENTESDataTable(ds.Tables("SP_CIMACEX_ANTECEDENTES")))
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
    Public ReadOnly Property SP_CIMACEX_ANTECEDENTES As SP_CIMACEX_ANTECEDENTESDataTable
        Get
            Return Me.tableSP_CIMACEX_ANTECEDENTES
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_antecedentes = CType(MyBase.Clone,ds_antecedentes)
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
        If (Not (ds.Tables("SP_CIMACEX_ANTECEDENTES")) Is Nothing) Then
            Me.Tables.Add(New SP_CIMACEX_ANTECEDENTESDataTable(ds.Tables("SP_CIMACEX_ANTECEDENTES")))
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
        Me.tableSP_CIMACEX_ANTECEDENTES = CType(Me.Tables("SP_CIMACEX_ANTECEDENTES"),SP_CIMACEX_ANTECEDENTESDataTable)
        If (Not (Me.tableSP_CIMACEX_ANTECEDENTES) Is Nothing) Then
            Me.tableSP_CIMACEX_ANTECEDENTES.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_antecedentes"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_antecedentes.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableSP_CIMACEX_ANTECEDENTES = New SP_CIMACEX_ANTECEDENTESDataTable
        Me.Tables.Add(Me.tableSP_CIMACEX_ANTECEDENTES)
    End Sub
    
    Private Function ShouldSerializeSP_CIMACEX_ANTECEDENTES() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub SP_CIMACEX_ANTECEDENTESRowChangeEventHandler(ByVal sender As Object, ByVal e As SP_CIMACEX_ANTECEDENTESRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_ANTECEDENTESDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCódigo As DataColumn
        
        Private columnDescripción As DataColumn
        
        Private columnFecha As DataColumn
        
        Private columnTipo As DataColumn
        
        Friend Sub New()
            MyBase.New("SP_CIMACEX_ANTECEDENTES")
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
        
        Friend ReadOnly Property CódigoColumn As DataColumn
            Get
                Return Me.columnCódigo
            End Get
        End Property
        
        Friend ReadOnly Property DescripciónColumn As DataColumn
            Get
                Return Me.columnDescripción
            End Get
        End Property
        
        Friend ReadOnly Property FechaColumn As DataColumn
            Get
                Return Me.columnFecha
            End Get
        End Property
        
        Friend ReadOnly Property TipoColumn As DataColumn
            Get
                Return Me.columnTipo
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As SP_CIMACEX_ANTECEDENTESRow
            Get
                Return CType(Me.Rows(index),SP_CIMACEX_ANTECEDENTESRow)
            End Get
        End Property
        
        Public Event SP_CIMACEX_ANTECEDENTESRowChanged As SP_CIMACEX_ANTECEDENTESRowChangeEventHandler
        
        Public Event SP_CIMACEX_ANTECEDENTESRowChanging As SP_CIMACEX_ANTECEDENTESRowChangeEventHandler
        
        Public Event SP_CIMACEX_ANTECEDENTESRowDeleted As SP_CIMACEX_ANTECEDENTESRowChangeEventHandler
        
        Public Event SP_CIMACEX_ANTECEDENTESRowDeleting As SP_CIMACEX_ANTECEDENTESRowChangeEventHandler
        
        Public Overloads Sub AddSP_CIMACEX_ANTECEDENTESRow(ByVal row As SP_CIMACEX_ANTECEDENTESRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddSP_CIMACEX_ANTECEDENTESRow(ByVal Código As String, ByVal Descripción As String, ByVal Fecha As Date, ByVal Tipo As String) As SP_CIMACEX_ANTECEDENTESRow
            Dim rowSP_CIMACEX_ANTECEDENTESRow As SP_CIMACEX_ANTECEDENTESRow = CType(Me.NewRow,SP_CIMACEX_ANTECEDENTESRow)
            rowSP_CIMACEX_ANTECEDENTESRow.ItemArray = New Object() {Código, Descripción, Fecha, Tipo}
            Me.Rows.Add(rowSP_CIMACEX_ANTECEDENTESRow)
            Return rowSP_CIMACEX_ANTECEDENTESRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As SP_CIMACEX_ANTECEDENTESDataTable = CType(MyBase.Clone,SP_CIMACEX_ANTECEDENTESDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New SP_CIMACEX_ANTECEDENTESDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCódigo = Me.Columns("Código")
            Me.columnDescripción = Me.Columns("Descripción")
            Me.columnFecha = Me.Columns("Fecha")
            Me.columnTipo = Me.Columns("Tipo")
        End Sub
        
        Private Sub InitClass()
            Me.columnCódigo = New DataColumn("Código", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCódigo)
            Me.columnDescripción = New DataColumn("Descripción", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescripción)
            Me.columnFecha = New DataColumn("Fecha", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFecha)
            Me.columnTipo = New DataColumn("Tipo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTipo)
        End Sub
        
        Public Function NewSP_CIMACEX_ANTECEDENTESRow() As SP_CIMACEX_ANTECEDENTESRow
            Return CType(Me.NewRow,SP_CIMACEX_ANTECEDENTESRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New SP_CIMACEX_ANTECEDENTESRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(SP_CIMACEX_ANTECEDENTESRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.SP_CIMACEX_ANTECEDENTESRowChangedEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_ANTECEDENTESRowChanged(Me, New SP_CIMACEX_ANTECEDENTESRowChangeEvent(CType(e.Row,SP_CIMACEX_ANTECEDENTESRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.SP_CIMACEX_ANTECEDENTESRowChangingEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_ANTECEDENTESRowChanging(Me, New SP_CIMACEX_ANTECEDENTESRowChangeEvent(CType(e.Row,SP_CIMACEX_ANTECEDENTESRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.SP_CIMACEX_ANTECEDENTESRowDeletedEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_ANTECEDENTESRowDeleted(Me, New SP_CIMACEX_ANTECEDENTESRowChangeEvent(CType(e.Row,SP_CIMACEX_ANTECEDENTESRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.SP_CIMACEX_ANTECEDENTESRowDeletingEvent) Is Nothing) Then
                RaiseEvent SP_CIMACEX_ANTECEDENTESRowDeleting(Me, New SP_CIMACEX_ANTECEDENTESRowChangeEvent(CType(e.Row,SP_CIMACEX_ANTECEDENTESRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveSP_CIMACEX_ANTECEDENTESRow(ByVal row As SP_CIMACEX_ANTECEDENTESRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_ANTECEDENTESRow
        Inherits DataRow
        
        Private tableSP_CIMACEX_ANTECEDENTES As SP_CIMACEX_ANTECEDENTESDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableSP_CIMACEX_ANTECEDENTES = CType(Me.Table,SP_CIMACEX_ANTECEDENTESDataTable)
        End Sub
        
        Public Property Código As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_ANTECEDENTES.CódigoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_ANTECEDENTES.CódigoColumn) = value
            End Set
        End Property
        
        Public Property Descripción As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_ANTECEDENTES.DescripciónColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_ANTECEDENTES.DescripciónColumn) = value
            End Set
        End Property
        
        Public Property Fecha As Date
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_ANTECEDENTES.FechaColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_ANTECEDENTES.FechaColumn) = value
            End Set
        End Property
        
        Public Property Tipo As String
            Get
                Try 
                    Return CType(Me(Me.tableSP_CIMACEX_ANTECEDENTES.TipoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSP_CIMACEX_ANTECEDENTES.TipoColumn) = value
            End Set
        End Property
        
        Public Function IsCódigoNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_ANTECEDENTES.CódigoColumn)
        End Function
        
        Public Sub SetCódigoNull()
            Me(Me.tableSP_CIMACEX_ANTECEDENTES.CódigoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDescripciónNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_ANTECEDENTES.DescripciónColumn)
        End Function
        
        Public Sub SetDescripciónNull()
            Me(Me.tableSP_CIMACEX_ANTECEDENTES.DescripciónColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFechaNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_ANTECEDENTES.FechaColumn)
        End Function
        
        Public Sub SetFechaNull()
            Me(Me.tableSP_CIMACEX_ANTECEDENTES.FechaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTipoNull() As Boolean
            Return Me.IsNull(Me.tableSP_CIMACEX_ANTECEDENTES.TipoColumn)
        End Function
        
        Public Sub SetTipoNull()
            Me(Me.tableSP_CIMACEX_ANTECEDENTES.TipoColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SP_CIMACEX_ANTECEDENTESRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As SP_CIMACEX_ANTECEDENTESRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As SP_CIMACEX_ANTECEDENTESRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As SP_CIMACEX_ANTECEDENTESRow
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