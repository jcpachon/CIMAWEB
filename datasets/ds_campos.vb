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
Public Class ds_campos
    Inherits DataSet
    
    Private tablecima_plantillas_campos As cima_plantillas_camposDataTable
    
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
            If (Not (ds.Tables("cima_plantillas_campos")) Is Nothing) Then
                Me.Tables.Add(New cima_plantillas_camposDataTable(ds.Tables("cima_plantillas_campos")))
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
    Public ReadOnly Property cima_plantillas_campos As cima_plantillas_camposDataTable
        Get
            Return Me.tablecima_plantillas_campos
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_campos = CType(MyBase.Clone,ds_campos)
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
        If (Not (ds.Tables("cima_plantillas_campos")) Is Nothing) Then
            Me.Tables.Add(New cima_plantillas_camposDataTable(ds.Tables("cima_plantillas_campos")))
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
        Me.tablecima_plantillas_campos = CType(Me.Tables("cima_plantillas_campos"),cima_plantillas_camposDataTable)
        If (Not (Me.tablecima_plantillas_campos) Is Nothing) Then
            Me.tablecima_plantillas_campos.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_campos"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_campos.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablecima_plantillas_campos = New cima_plantillas_camposDataTable
        Me.Tables.Add(Me.tablecima_plantillas_campos)
    End Sub
    
    Private Function ShouldSerializecima_plantillas_campos() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub cima_plantillas_camposRowChangeEventHandler(ByVal sender As Object, ByVal e As cima_plantillas_camposRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_plantillas_camposDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCódigo As DataColumn
        
        Private columnNombre As DataColumn
        
        Private columnTipo_de_Dato As DataColumn
        
        Private columnDescripción_Campo As DataColumn
        
        Private columnOrden As DataColumn
        
        Private columnVisible_en_Informe As DataColumn
        
        Friend Sub New()
            MyBase.New("cima_plantillas_campos")
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
        
        Friend ReadOnly Property NombreColumn As DataColumn
            Get
                Return Me.columnNombre
            End Get
        End Property
        
        Friend ReadOnly Property Tipo_de_DatoColumn As DataColumn
            Get
                Return Me.columnTipo_de_Dato
            End Get
        End Property
        
        Friend ReadOnly Property Descripción_CampoColumn As DataColumn
            Get
                Return Me.columnDescripción_Campo
            End Get
        End Property
        
        Friend ReadOnly Property OrdenColumn As DataColumn
            Get
                Return Me.columnOrden
            End Get
        End Property
        
        Friend ReadOnly Property Visible_en_InformeColumn As DataColumn
            Get
                Return Me.columnVisible_en_Informe
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As cima_plantillas_camposRow
            Get
                Return CType(Me.Rows(index),cima_plantillas_camposRow)
            End Get
        End Property
        
        Public Event cima_plantillas_camposRowChanged As cima_plantillas_camposRowChangeEventHandler
        
        Public Event cima_plantillas_camposRowChanging As cima_plantillas_camposRowChangeEventHandler
        
        Public Event cima_plantillas_camposRowDeleted As cima_plantillas_camposRowChangeEventHandler
        
        Public Event cima_plantillas_camposRowDeleting As cima_plantillas_camposRowChangeEventHandler
        
        Public Overloads Sub Addcima_plantillas_camposRow(ByVal row As cima_plantillas_camposRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addcima_plantillas_camposRow(ByVal Código As Long, ByVal Nombre As String, ByVal Tipo_de_Dato As String, ByVal Descripción_Campo As String, ByVal Orden As Long, ByVal Visible_en_Informe As String) As cima_plantillas_camposRow
            Dim rowcima_plantillas_camposRow As cima_plantillas_camposRow = CType(Me.NewRow,cima_plantillas_camposRow)
            rowcima_plantillas_camposRow.ItemArray = New Object() {Código, Nombre, Tipo_de_Dato, Descripción_Campo, Orden, Visible_en_Informe}
            Me.Rows.Add(rowcima_plantillas_camposRow)
            Return rowcima_plantillas_camposRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As cima_plantillas_camposDataTable = CType(MyBase.Clone,cima_plantillas_camposDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New cima_plantillas_camposDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCódigo = Me.Columns("Código")
            Me.columnNombre = Me.Columns("Nombre")
            Me.columnTipo_de_Dato = Me.Columns("Tipo de Dato")
            Me.columnDescripción_Campo = Me.Columns("Descripción Campo")
            Me.columnOrden = Me.Columns("Orden")
            Me.columnVisible_en_Informe = Me.Columns("Visible en Informe")
        End Sub
        
        Private Sub InitClass()
            Me.columnCódigo = New DataColumn("Código", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCódigo)
            Me.columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNombre)
            Me.columnTipo_de_Dato = New DataColumn("Tipo de Dato", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTipo_de_Dato)
            Me.columnDescripción_Campo = New DataColumn("Descripción Campo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescripción_Campo)
            Me.columnOrden = New DataColumn("Orden", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrden)
            Me.columnVisible_en_Informe = New DataColumn("Visible en Informe", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnVisible_en_Informe)
        End Sub
        
        Public Function Newcima_plantillas_camposRow() As cima_plantillas_camposRow
            Return CType(Me.NewRow,cima_plantillas_camposRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New cima_plantillas_camposRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(cima_plantillas_camposRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.cima_plantillas_camposRowChangedEvent) Is Nothing) Then
                RaiseEvent cima_plantillas_camposRowChanged(Me, New cima_plantillas_camposRowChangeEvent(CType(e.Row,cima_plantillas_camposRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.cima_plantillas_camposRowChangingEvent) Is Nothing) Then
                RaiseEvent cima_plantillas_camposRowChanging(Me, New cima_plantillas_camposRowChangeEvent(CType(e.Row,cima_plantillas_camposRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.cima_plantillas_camposRowDeletedEvent) Is Nothing) Then
                RaiseEvent cima_plantillas_camposRowDeleted(Me, New cima_plantillas_camposRowChangeEvent(CType(e.Row,cima_plantillas_camposRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.cima_plantillas_camposRowDeletingEvent) Is Nothing) Then
                RaiseEvent cima_plantillas_camposRowDeleting(Me, New cima_plantillas_camposRowChangeEvent(CType(e.Row,cima_plantillas_camposRow), e.Action))
            End If
        End Sub
        
        Public Sub Removecima_plantillas_camposRow(ByVal row As cima_plantillas_camposRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_plantillas_camposRow
        Inherits DataRow
        
        Private tablecima_plantillas_campos As cima_plantillas_camposDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablecima_plantillas_campos = CType(Me.Table,cima_plantillas_camposDataTable)
        End Sub
        
        Public Property Código As Long
            Get
                Try 
                    Return CType(Me(Me.tablecima_plantillas_campos.CódigoColumn),Long)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_plantillas_campos.CódigoColumn) = value
            End Set
        End Property
        
        Public Property Nombre As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_plantillas_campos.NombreColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_plantillas_campos.NombreColumn) = value
            End Set
        End Property
        
        Public Property Tipo_de_Dato As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_plantillas_campos.Tipo_de_DatoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_plantillas_campos.Tipo_de_DatoColumn) = value
            End Set
        End Property
        
        Public Property Descripción_Campo As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_plantillas_campos.Descripción_CampoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_plantillas_campos.Descripción_CampoColumn) = value
            End Set
        End Property
        
        Public Property Orden As Long
            Get
                Try 
                    Return CType(Me(Me.tablecima_plantillas_campos.OrdenColumn),Long)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_plantillas_campos.OrdenColumn) = value
            End Set
        End Property
        
        Public Property Visible_en_Informe As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_plantillas_campos.Visible_en_InformeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_plantillas_campos.Visible_en_InformeColumn) = value
            End Set
        End Property
        
        Public Function IsCódigoNull() As Boolean
            Return Me.IsNull(Me.tablecima_plantillas_campos.CódigoColumn)
        End Function
        
        Public Sub SetCódigoNull()
            Me(Me.tablecima_plantillas_campos.CódigoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsNombreNull() As Boolean
            Return Me.IsNull(Me.tablecima_plantillas_campos.NombreColumn)
        End Function
        
        Public Sub SetNombreNull()
            Me(Me.tablecima_plantillas_campos.NombreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTipo_de_DatoNull() As Boolean
            Return Me.IsNull(Me.tablecima_plantillas_campos.Tipo_de_DatoColumn)
        End Function
        
        Public Sub SetTipo_de_DatoNull()
            Me(Me.tablecima_plantillas_campos.Tipo_de_DatoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDescripción_CampoNull() As Boolean
            Return Me.IsNull(Me.tablecima_plantillas_campos.Descripción_CampoColumn)
        End Function
        
        Public Sub SetDescripción_CampoNull()
            Me(Me.tablecima_plantillas_campos.Descripción_CampoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsOrdenNull() As Boolean
            Return Me.IsNull(Me.tablecima_plantillas_campos.OrdenColumn)
        End Function
        
        Public Sub SetOrdenNull()
            Me(Me.tablecima_plantillas_campos.OrdenColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsVisible_en_InformeNull() As Boolean
            Return Me.IsNull(Me.tablecima_plantillas_campos.Visible_en_InformeColumn)
        End Function
        
        Public Sub SetVisible_en_InformeNull()
            Me(Me.tablecima_plantillas_campos.Visible_en_InformeColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_plantillas_camposRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As cima_plantillas_camposRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As cima_plantillas_camposRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As cima_plantillas_camposRow
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