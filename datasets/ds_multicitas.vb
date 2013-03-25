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
Public Class ds_multicitas
    Inherits DataSet
    
    Private tableMulticitas As MulticitasDataTable
    
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
            If (Not (ds.Tables("Multicitas")) Is Nothing) Then
                Me.Tables.Add(New MulticitasDataTable(ds.Tables("Multicitas")))
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
    Public ReadOnly Property Multicitas As MulticitasDataTable
        Get
            Return Me.tableMulticitas
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_multicitas = CType(MyBase.Clone,ds_multicitas)
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
        If (Not (ds.Tables("Multicitas")) Is Nothing) Then
            Me.Tables.Add(New MulticitasDataTable(ds.Tables("Multicitas")))
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
        Me.tableMulticitas = CType(Me.Tables("Multicitas"),MulticitasDataTable)
        If (Not (Me.tableMulticitas) Is Nothing) Then
            Me.tableMulticitas.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_multicitas"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_multicitas.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableMulticitas = New MulticitasDataTable
        Me.Tables.Add(Me.tableMulticitas)
    End Sub
    
    Private Function ShouldSerializeMulticitas() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub MulticitasRowChangeEventHandler(ByVal sender As Object, ByVal e As MulticitasRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class MulticitasDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnServicio As DataColumn
        
        Private columnAgenda As DataColumn
        
        Private columnGarante As DataColumn
        
        Private column_Agr__de_Cob_ As DataColumn
        
        Private columnPrestación As DataColumn
        
        Friend Sub New()
            MyBase.New("Multicitas")
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
        
        Friend ReadOnly Property ServicioColumn As DataColumn
            Get
                Return Me.columnServicio
            End Get
        End Property
        
        Friend ReadOnly Property AgendaColumn As DataColumn
            Get
                Return Me.columnAgenda
            End Get
        End Property
        
        Friend ReadOnly Property GaranteColumn As DataColumn
            Get
                Return Me.columnGarante
            End Get
        End Property
        
        Friend ReadOnly Property _Agr__de_Cob_Column As DataColumn
            Get
                Return Me.column_Agr__de_Cob_
            End Get
        End Property
        
        Friend ReadOnly Property PrestaciónColumn As DataColumn
            Get
                Return Me.columnPrestación
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As MulticitasRow
            Get
                Return CType(Me.Rows(index),MulticitasRow)
            End Get
        End Property
        
        Public Event MulticitasRowChanged As MulticitasRowChangeEventHandler
        
        Public Event MulticitasRowChanging As MulticitasRowChangeEventHandler
        
        Public Event MulticitasRowDeleted As MulticitasRowChangeEventHandler
        
        Public Event MulticitasRowDeleting As MulticitasRowChangeEventHandler
        
        Public Overloads Sub AddMulticitasRow(ByVal row As MulticitasRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddMulticitasRow(ByVal Servicio As String, ByVal Agenda As String, ByVal Garante As String, ByVal _Agr__de_Cob_ As String, ByVal Prestación As String) As MulticitasRow
            Dim rowMulticitasRow As MulticitasRow = CType(Me.NewRow,MulticitasRow)
            rowMulticitasRow.ItemArray = New Object() {Servicio, Agenda, Garante, _Agr__de_Cob_, Prestación}
            Me.Rows.Add(rowMulticitasRow)
            Return rowMulticitasRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As MulticitasDataTable = CType(MyBase.Clone,MulticitasDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New MulticitasDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnServicio = Me.Columns("Servicio")
            Me.columnAgenda = Me.Columns("Agenda")
            Me.columnGarante = Me.Columns("Garante")
            Me.column_Agr__de_Cob_ = Me.Columns("Agr. de Cob.")
            Me.columnPrestación = Me.Columns("Prestación")
        End Sub
        
        Private Sub InitClass()
            Me.columnServicio = New DataColumn("Servicio", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnServicio)
            Me.columnAgenda = New DataColumn("Agenda", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAgenda)
            Me.columnGarante = New DataColumn("Garante", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnGarante)
            Me.column_Agr__de_Cob_ = New DataColumn("Agr. de Cob.", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.column_Agr__de_Cob_)
            Me.columnPrestación = New DataColumn("Prestación", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPrestación)
        End Sub
        
        Public Function NewMulticitasRow() As MulticitasRow
            Return CType(Me.NewRow,MulticitasRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New MulticitasRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(MulticitasRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.MulticitasRowChangedEvent) Is Nothing) Then
                RaiseEvent MulticitasRowChanged(Me, New MulticitasRowChangeEvent(CType(e.Row,MulticitasRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.MulticitasRowChangingEvent) Is Nothing) Then
                RaiseEvent MulticitasRowChanging(Me, New MulticitasRowChangeEvent(CType(e.Row,MulticitasRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.MulticitasRowDeletedEvent) Is Nothing) Then
                RaiseEvent MulticitasRowDeleted(Me, New MulticitasRowChangeEvent(CType(e.Row,MulticitasRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.MulticitasRowDeletingEvent) Is Nothing) Then
                RaiseEvent MulticitasRowDeleting(Me, New MulticitasRowChangeEvent(CType(e.Row,MulticitasRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveMulticitasRow(ByVal row As MulticitasRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class MulticitasRow
        Inherits DataRow
        
        Private tableMulticitas As MulticitasDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableMulticitas = CType(Me.Table,MulticitasDataTable)
        End Sub
        
        Public Property Servicio As String
            Get
                Try 
                    Return CType(Me(Me.tableMulticitas.ServicioColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMulticitas.ServicioColumn) = value
            End Set
        End Property
        
        Public Property Agenda As String
            Get
                Try 
                    Return CType(Me(Me.tableMulticitas.AgendaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMulticitas.AgendaColumn) = value
            End Set
        End Property
        
        Public Property Garante As String
            Get
                Try 
                    Return CType(Me(Me.tableMulticitas.GaranteColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMulticitas.GaranteColumn) = value
            End Set
        End Property
        
        Public Property _Agr__de_Cob_ As String
            Get
                Try 
                    Return CType(Me(Me.tableMulticitas._Agr__de_Cob_Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMulticitas._Agr__de_Cob_Column) = value
            End Set
        End Property
        
        Public Property Prestación As String
            Get
                Try 
                    Return CType(Me(Me.tableMulticitas.PrestaciónColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableMulticitas.PrestaciónColumn) = value
            End Set
        End Property
        
        Public Function IsServicioNull() As Boolean
            Return Me.IsNull(Me.tableMulticitas.ServicioColumn)
        End Function
        
        Public Sub SetServicioNull()
            Me(Me.tableMulticitas.ServicioColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAgendaNull() As Boolean
            Return Me.IsNull(Me.tableMulticitas.AgendaColumn)
        End Function
        
        Public Sub SetAgendaNull()
            Me(Me.tableMulticitas.AgendaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsGaranteNull() As Boolean
            Return Me.IsNull(Me.tableMulticitas.GaranteColumn)
        End Function
        
        Public Sub SetGaranteNull()
            Me(Me.tableMulticitas.GaranteColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Is_Agr__de_Cob_Null() As Boolean
            Return Me.IsNull(Me.tableMulticitas._Agr__de_Cob_Column)
        End Function
        
        Public Sub Set_Agr__de_Cob_Null()
            Me(Me.tableMulticitas._Agr__de_Cob_Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsPrestaciónNull() As Boolean
            Return Me.IsNull(Me.tableMulticitas.PrestaciónColumn)
        End Function
        
        Public Sub SetPrestaciónNull()
            Me(Me.tableMulticitas.PrestaciónColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class MulticitasRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As MulticitasRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As MulticitasRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As MulticitasRow
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
