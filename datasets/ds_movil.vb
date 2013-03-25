﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2443
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
Public Class ds_movil
    Inherits DataSet
    
    Private tablemovil As movilDataTable
    
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
            If (Not (ds.Tables("movil")) Is Nothing) Then
                Me.Tables.Add(New movilDataTable(ds.Tables("movil")))
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
    Public ReadOnly Property movil As movilDataTable
        Get
            Return Me.tablemovil
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_movil = CType(MyBase.Clone,ds_movil)
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
        If (Not (ds.Tables("movil")) Is Nothing) Then
            Me.Tables.Add(New movilDataTable(ds.Tables("movil")))
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
        Me.tablemovil = CType(Me.Tables("movil"),movilDataTable)
        If (Not (Me.tablemovil) Is Nothing) Then
            Me.tablemovil.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_movil"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_movil.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablemovil = New movilDataTable
        Me.Tables.Add(Me.tablemovil)
    End Sub
    
    Private Function ShouldSerializemovil() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub movilRowChangeEventHandler(ByVal sender As Object, ByVal e As movilRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class movilDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnmovil_paciente As DataColumn
        
        Private columnclave_sms As DataColumn
        
        Friend Sub New()
            MyBase.New("movil")
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
        
        Friend ReadOnly Property movil_pacienteColumn As DataColumn
            Get
                Return Me.columnmovil_paciente
            End Get
        End Property
        
        Friend ReadOnly Property clave_smsColumn As DataColumn
            Get
                Return Me.columnclave_sms
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As movilRow
            Get
                Return CType(Me.Rows(index),movilRow)
            End Get
        End Property
        
        Public Event movilRowChanged As movilRowChangeEventHandler
        
        Public Event movilRowChanging As movilRowChangeEventHandler
        
        Public Event movilRowDeleted As movilRowChangeEventHandler
        
        Public Event movilRowDeleting As movilRowChangeEventHandler
        
        Public Overloads Sub AddmovilRow(ByVal row As movilRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddmovilRow(ByVal movil_paciente As String, ByVal clave_sms As String) As movilRow
            Dim rowmovilRow As movilRow = CType(Me.NewRow,movilRow)
            rowmovilRow.ItemArray = New Object() {movil_paciente, clave_sms}
            Me.Rows.Add(rowmovilRow)
            Return rowmovilRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As movilDataTable = CType(MyBase.Clone,movilDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New movilDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnmovil_paciente = Me.Columns("movil_paciente")
            Me.columnclave_sms = Me.Columns("clave_sms")
        End Sub
        
        Private Sub InitClass()
            Me.columnmovil_paciente = New DataColumn("movil_paciente", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnmovil_paciente)
            Me.columnclave_sms = New DataColumn("clave_sms", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnclave_sms)
        End Sub
        
        Public Function NewmovilRow() As movilRow
            Return CType(Me.NewRow,movilRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New movilRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(movilRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.movilRowChangedEvent) Is Nothing) Then
                RaiseEvent movilRowChanged(Me, New movilRowChangeEvent(CType(e.Row,movilRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.movilRowChangingEvent) Is Nothing) Then
                RaiseEvent movilRowChanging(Me, New movilRowChangeEvent(CType(e.Row,movilRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.movilRowDeletedEvent) Is Nothing) Then
                RaiseEvent movilRowDeleted(Me, New movilRowChangeEvent(CType(e.Row,movilRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.movilRowDeletingEvent) Is Nothing) Then
                RaiseEvent movilRowDeleting(Me, New movilRowChangeEvent(CType(e.Row,movilRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovemovilRow(ByVal row As movilRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class movilRow
        Inherits DataRow
        
        Private tablemovil As movilDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablemovil = CType(Me.Table,movilDataTable)
        End Sub
        
        Public Property movil_paciente As String
            Get
                Try 
                    Return CType(Me(Me.tablemovil.movil_pacienteColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablemovil.movil_pacienteColumn) = value
            End Set
        End Property
        
        Public Property clave_sms As String
            Get
                Try 
                    Return CType(Me(Me.tablemovil.clave_smsColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablemovil.clave_smsColumn) = value
            End Set
        End Property
        
        Public Function Ismovil_pacienteNull() As Boolean
            Return Me.IsNull(Me.tablemovil.movil_pacienteColumn)
        End Function
        
        Public Sub Setmovil_pacienteNull()
            Me(Me.tablemovil.movil_pacienteColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isclave_smsNull() As Boolean
            Return Me.IsNull(Me.tablemovil.clave_smsColumn)
        End Function
        
        Public Sub Setclave_smsNull()
            Me(Me.tablemovil.clave_smsColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class movilRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As movilRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As movilRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As movilRow
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