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
Public Class ds_usuarios
    Inherits DataSet
    
    Private tablecima_usuarios As cima_usuariosDataTable
    
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
            If (Not (ds.Tables("cima_usuarios")) Is Nothing) Then
                Me.Tables.Add(New cima_usuariosDataTable(ds.Tables("cima_usuarios")))
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
    Public ReadOnly Property cima_usuarios As cima_usuariosDataTable
        Get
            Return Me.tablecima_usuarios
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_usuarios = CType(MyBase.Clone,ds_usuarios)
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
        If (Not (ds.Tables("cima_usuarios")) Is Nothing) Then
            Me.Tables.Add(New cima_usuariosDataTable(ds.Tables("cima_usuarios")))
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
        Me.tablecima_usuarios = CType(Me.Tables("cima_usuarios"),cima_usuariosDataTable)
        If (Not (Me.tablecima_usuarios) Is Nothing) Then
            Me.tablecima_usuarios.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_usuarios"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_usuarios.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablecima_usuarios = New cima_usuariosDataTable
        Me.Tables.Add(Me.tablecima_usuarios)
    End Sub
    
    Private Function ShouldSerializecima_usuarios() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub cima_usuariosRowChangeEventHandler(ByVal sender As Object, ByVal e As cima_usuariosRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_usuariosDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid_usuario As DataColumn
        
        Private columndescripcion As DataColumn
        
        Private columnperfil As DataColumn
        
        Private columngrupo As DataColumn
        
        Private columnactivo As DataColumn
        
        Private columnpws As DataColumn
        
        Private columnn_colegiado As DataColumn
        
        Friend Sub New()
            MyBase.New("cima_usuarios")
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
        
        Friend ReadOnly Property id_usuarioColumn As DataColumn
            Get
                Return Me.columnid_usuario
            End Get
        End Property
        
        Friend ReadOnly Property descripcionColumn As DataColumn
            Get
                Return Me.columndescripcion
            End Get
        End Property
        
        Friend ReadOnly Property perfilColumn As DataColumn
            Get
                Return Me.columnperfil
            End Get
        End Property
        
        Friend ReadOnly Property grupoColumn As DataColumn
            Get
                Return Me.columngrupo
            End Get
        End Property
        
        Friend ReadOnly Property activoColumn As DataColumn
            Get
                Return Me.columnactivo
            End Get
        End Property
        
        Friend ReadOnly Property pwsColumn As DataColumn
            Get
                Return Me.columnpws
            End Get
        End Property
        
        Friend ReadOnly Property n_colegiadoColumn As DataColumn
            Get
                Return Me.columnn_colegiado
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As cima_usuariosRow
            Get
                Return CType(Me.Rows(index),cima_usuariosRow)
            End Get
        End Property
        
        Public Event cima_usuariosRowChanged As cima_usuariosRowChangeEventHandler
        
        Public Event cima_usuariosRowChanging As cima_usuariosRowChangeEventHandler
        
        Public Event cima_usuariosRowDeleted As cima_usuariosRowChangeEventHandler
        
        Public Event cima_usuariosRowDeleting As cima_usuariosRowChangeEventHandler
        
        Public Overloads Sub Addcima_usuariosRow(ByVal row As cima_usuariosRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addcima_usuariosRow(ByVal id_usuario As String, ByVal descripcion As String, ByVal perfil As String, ByVal grupo As String, ByVal activo As String, ByVal pws As String, ByVal n_colegiado As String) As cima_usuariosRow
            Dim rowcima_usuariosRow As cima_usuariosRow = CType(Me.NewRow,cima_usuariosRow)
            rowcima_usuariosRow.ItemArray = New Object() {id_usuario, descripcion, perfil, grupo, activo, pws, n_colegiado}
            Me.Rows.Add(rowcima_usuariosRow)
            Return rowcima_usuariosRow
        End Function
        
        Public Function FindByid_usuario(ByVal id_usuario As String) As cima_usuariosRow
            Return CType(Me.Rows.Find(New Object() {id_usuario}),cima_usuariosRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As cima_usuariosDataTable = CType(MyBase.Clone,cima_usuariosDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New cima_usuariosDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid_usuario = Me.Columns("id_usuario")
            Me.columndescripcion = Me.Columns("descripcion")
            Me.columnperfil = Me.Columns("perfil")
            Me.columngrupo = Me.Columns("grupo")
            Me.columnactivo = Me.Columns("activo")
            Me.columnpws = Me.Columns("pws")
            Me.columnn_colegiado = Me.Columns("n_colegiado")
        End Sub
        
        Private Sub InitClass()
            Me.columnid_usuario = New DataColumn("id_usuario", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_usuario)
            Me.columndescripcion = New DataColumn("descripcion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndescripcion)
            Me.columnperfil = New DataColumn("perfil", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnperfil)
            Me.columngrupo = New DataColumn("grupo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columngrupo)
            Me.columnactivo = New DataColumn("activo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnactivo)
            Me.columnpws = New DataColumn("pws", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpws)
            Me.columnn_colegiado = New DataColumn("n_colegiado", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnn_colegiado)
            Me.Constraints.Add(New UniqueConstraint("ds_usuariosKey1", New DataColumn() {Me.columnid_usuario}, true))
            Me.columnid_usuario.AllowDBNull = false
            Me.columnid_usuario.Unique = true
        End Sub
        
        Public Function Newcima_usuariosRow() As cima_usuariosRow
            Return CType(Me.NewRow,cima_usuariosRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New cima_usuariosRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(cima_usuariosRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.cima_usuariosRowChangedEvent) Is Nothing) Then
                RaiseEvent cima_usuariosRowChanged(Me, New cima_usuariosRowChangeEvent(CType(e.Row,cima_usuariosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.cima_usuariosRowChangingEvent) Is Nothing) Then
                RaiseEvent cima_usuariosRowChanging(Me, New cima_usuariosRowChangeEvent(CType(e.Row,cima_usuariosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.cima_usuariosRowDeletedEvent) Is Nothing) Then
                RaiseEvent cima_usuariosRowDeleted(Me, New cima_usuariosRowChangeEvent(CType(e.Row,cima_usuariosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.cima_usuariosRowDeletingEvent) Is Nothing) Then
                RaiseEvent cima_usuariosRowDeleting(Me, New cima_usuariosRowChangeEvent(CType(e.Row,cima_usuariosRow), e.Action))
            End If
        End Sub
        
        Public Sub Removecima_usuariosRow(ByVal row As cima_usuariosRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_usuariosRow
        Inherits DataRow
        
        Private tablecima_usuarios As cima_usuariosDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablecima_usuarios = CType(Me.Table,cima_usuariosDataTable)
        End Sub
        
        Public Property id_usuario As String
            Get
                Return CType(Me(Me.tablecima_usuarios.id_usuarioColumn),String)
            End Get
            Set
                Me(Me.tablecima_usuarios.id_usuarioColumn) = value
            End Set
        End Property
        
        Public Property descripcion As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_usuarios.descripcionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_usuarios.descripcionColumn) = value
            End Set
        End Property
        
        Public Property perfil As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_usuarios.perfilColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_usuarios.perfilColumn) = value
            End Set
        End Property
        
        Public Property grupo As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_usuarios.grupoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_usuarios.grupoColumn) = value
            End Set
        End Property
        
        Public Property activo As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_usuarios.activoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_usuarios.activoColumn) = value
            End Set
        End Property
        
        Public Property pws As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_usuarios.pwsColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_usuarios.pwsColumn) = value
            End Set
        End Property
        
        Public Property n_colegiado As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_usuarios.n_colegiadoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_usuarios.n_colegiadoColumn) = value
            End Set
        End Property
        
        Public Function IsdescripcionNull() As Boolean
            Return Me.IsNull(Me.tablecima_usuarios.descripcionColumn)
        End Function
        
        Public Sub SetdescripcionNull()
            Me(Me.tablecima_usuarios.descripcionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsperfilNull() As Boolean
            Return Me.IsNull(Me.tablecima_usuarios.perfilColumn)
        End Function
        
        Public Sub SetperfilNull()
            Me(Me.tablecima_usuarios.perfilColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsgrupoNull() As Boolean
            Return Me.IsNull(Me.tablecima_usuarios.grupoColumn)
        End Function
        
        Public Sub SetgrupoNull()
            Me(Me.tablecima_usuarios.grupoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsactivoNull() As Boolean
            Return Me.IsNull(Me.tablecima_usuarios.activoColumn)
        End Function
        
        Public Sub SetactivoNull()
            Me(Me.tablecima_usuarios.activoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspwsNull() As Boolean
            Return Me.IsNull(Me.tablecima_usuarios.pwsColumn)
        End Function
        
        Public Sub SetpwsNull()
            Me(Me.tablecima_usuarios.pwsColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isn_colegiadoNull() As Boolean
            Return Me.IsNull(Me.tablecima_usuarios.n_colegiadoColumn)
        End Function
        
        Public Sub Setn_colegiadoNull()
            Me(Me.tablecima_usuarios.n_colegiadoColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_usuariosRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As cima_usuariosRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As cima_usuariosRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As cima_usuariosRow
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