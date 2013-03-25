﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2490
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
Public Class ds_validacion_du
    Inherits DataSet
    
    Private tabledu As duDataTable
    
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
            If (Not (ds.Tables("du")) Is Nothing) Then
                Me.Tables.Add(New duDataTable(ds.Tables("du")))
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
    Public ReadOnly Property du As duDataTable
        Get
            Return Me.tabledu
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_validacion_du = CType(MyBase.Clone,ds_validacion_du)
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
        If (Not (ds.Tables("du")) Is Nothing) Then
            Me.Tables.Add(New duDataTable(ds.Tables("du")))
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
        Me.tabledu = CType(Me.Tables("du"),duDataTable)
        If (Not (Me.tabledu) Is Nothing) Then
            Me.tabledu.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_validacion_du"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_validacion_du.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tabledu = New duDataTable
        Me.Tables.Add(Me.tabledu)
    End Sub
    
    Private Function ShouldSerializedu() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub duRowChangeEventHandler(ByVal sender As Object, ByVal e As duRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class duDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columninvs_key As DataColumn
        
        Private columninvsdate As DataColumn
        
        Private columnfactura As DataColumn
        
        Private columnepiscode As DataColumn
        
        Private columnpaciente As DataColumn
        
        Private columndu As DataColumn
        
        Private columnlongitud As DataColumn
        
        Private columnnota As DataColumn
        
        Private columnmultigarante As DataColumn
        
        Private columndc As DataColumn
        
        Friend Sub New()
            MyBase.New("du")
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
        
        Friend ReadOnly Property invs_keyColumn As DataColumn
            Get
                Return Me.columninvs_key
            End Get
        End Property
        
        Friend ReadOnly Property invsdateColumn As DataColumn
            Get
                Return Me.columninvsdate
            End Get
        End Property
        
        Friend ReadOnly Property facturaColumn As DataColumn
            Get
                Return Me.columnfactura
            End Get
        End Property
        
        Friend ReadOnly Property episcodeColumn As DataColumn
            Get
                Return Me.columnepiscode
            End Get
        End Property
        
        Friend ReadOnly Property pacienteColumn As DataColumn
            Get
                Return Me.columnpaciente
            End Get
        End Property
        
        Friend ReadOnly Property duColumn As DataColumn
            Get
                Return Me.columndu
            End Get
        End Property
        
        Friend ReadOnly Property longitudColumn As DataColumn
            Get
                Return Me.columnlongitud
            End Get
        End Property
        
        Friend ReadOnly Property notaColumn As DataColumn
            Get
                Return Me.columnnota
            End Get
        End Property
        
        Friend ReadOnly Property multigaranteColumn As DataColumn
            Get
                Return Me.columnmultigarante
            End Get
        End Property
        
        Friend ReadOnly Property dcColumn As DataColumn
            Get
                Return Me.columndc
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As duRow
            Get
                Return CType(Me.Rows(index),duRow)
            End Get
        End Property
        
        Public Event duRowChanged As duRowChangeEventHandler
        
        Public Event duRowChanging As duRowChangeEventHandler
        
        Public Event duRowDeleted As duRowChangeEventHandler
        
        Public Event duRowDeleting As duRowChangeEventHandler
        
        Public Overloads Sub AddduRow(ByVal row As duRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddduRow(ByVal invs_key As Integer, ByVal invsdate As String, ByVal factura As String, ByVal episcode As String, ByVal paciente As String, ByVal du As String, ByVal longitud As Integer, ByVal nota As String, ByVal multigarante As String, ByVal dc As String) As duRow
            Dim rowduRow As duRow = CType(Me.NewRow,duRow)
            rowduRow.ItemArray = New Object() {invs_key, invsdate, factura, episcode, paciente, du, longitud, nota, multigarante, dc}
            Me.Rows.Add(rowduRow)
            Return rowduRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As duDataTable = CType(MyBase.Clone,duDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New duDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columninvs_key = Me.Columns("invs_key")
            Me.columninvsdate = Me.Columns("invsdate")
            Me.columnfactura = Me.Columns("factura")
            Me.columnepiscode = Me.Columns("episcode")
            Me.columnpaciente = Me.Columns("paciente")
            Me.columndu = Me.Columns("du")
            Me.columnlongitud = Me.Columns("longitud")
            Me.columnnota = Me.Columns("nota")
            Me.columnmultigarante = Me.Columns("multigarante")
            Me.columndc = Me.Columns("dc")
        End Sub
        
        Private Sub InitClass()
            Me.columninvs_key = New DataColumn("invs_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columninvs_key)
            Me.columninvsdate = New DataColumn("invsdate", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columninvsdate)
            Me.columnfactura = New DataColumn("factura", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfactura)
            Me.columnepiscode = New DataColumn("episcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnepiscode)
            Me.columnpaciente = New DataColumn("paciente", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpaciente)
            Me.columndu = New DataColumn("du", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndu)
            Me.columnlongitud = New DataColumn("longitud", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnlongitud)
            Me.columnnota = New DataColumn("nota", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnnota)
            Me.columnmultigarante = New DataColumn("multigarante", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnmultigarante)
            Me.columndc = New DataColumn("dc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndc)
        End Sub
        
        Public Function NewduRow() As duRow
            Return CType(Me.NewRow,duRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New duRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(duRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.duRowChangedEvent) Is Nothing) Then
                RaiseEvent duRowChanged(Me, New duRowChangeEvent(CType(e.Row,duRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.duRowChangingEvent) Is Nothing) Then
                RaiseEvent duRowChanging(Me, New duRowChangeEvent(CType(e.Row,duRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.duRowDeletedEvent) Is Nothing) Then
                RaiseEvent duRowDeleted(Me, New duRowChangeEvent(CType(e.Row,duRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.duRowDeletingEvent) Is Nothing) Then
                RaiseEvent duRowDeleting(Me, New duRowChangeEvent(CType(e.Row,duRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveduRow(ByVal row As duRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class duRow
        Inherits DataRow
        
        Private tabledu As duDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tabledu = CType(Me.Table,duDataTable)
        End Sub
        
        Public Property invs_key As Integer
            Get
                Try 
                    Return CType(Me(Me.tabledu.invs_keyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledu.invs_keyColumn) = value
            End Set
        End Property
        
        Public Property invsdate As String
            Get
                Try 
                    Return CType(Me(Me.tabledu.invsdateColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledu.invsdateColumn) = value
            End Set
        End Property
        
        Public Property factura As String
            Get
                Try 
                    Return CType(Me(Me.tabledu.facturaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledu.facturaColumn) = value
            End Set
        End Property
        
        Public Property episcode As String
            Get
                Try 
                    Return CType(Me(Me.tabledu.episcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledu.episcodeColumn) = value
            End Set
        End Property
        
        Public Property paciente As String
            Get
                Try 
                    Return CType(Me(Me.tabledu.pacienteColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledu.pacienteColumn) = value
            End Set
        End Property
        
        Public Property du As String
            Get
                Try 
                    Return CType(Me(Me.tabledu.duColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledu.duColumn) = value
            End Set
        End Property
        
        Public Property longitud As Integer
            Get
                Try 
                    Return CType(Me(Me.tabledu.longitudColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledu.longitudColumn) = value
            End Set
        End Property
        
        Public Property nota As String
            Get
                Try 
                    Return CType(Me(Me.tabledu.notaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledu.notaColumn) = value
            End Set
        End Property
        
        Public Property multigarante As String
            Get
                Try 
                    Return CType(Me(Me.tabledu.multigaranteColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledu.multigaranteColumn) = value
            End Set
        End Property
        
        Public Property dc As String
            Get
                Try 
                    Return CType(Me(Me.tabledu.dcColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledu.dcColumn) = value
            End Set
        End Property
        
        Public Function Isinvs_keyNull() As Boolean
            Return Me.IsNull(Me.tabledu.invs_keyColumn)
        End Function
        
        Public Sub Setinvs_keyNull()
            Me(Me.tabledu.invs_keyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsinvsdateNull() As Boolean
            Return Me.IsNull(Me.tabledu.invsdateColumn)
        End Function
        
        Public Sub SetinvsdateNull()
            Me(Me.tabledu.invsdateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsfacturaNull() As Boolean
            Return Me.IsNull(Me.tabledu.facturaColumn)
        End Function
        
        Public Sub SetfacturaNull()
            Me(Me.tabledu.facturaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsepiscodeNull() As Boolean
            Return Me.IsNull(Me.tabledu.episcodeColumn)
        End Function
        
        Public Sub SetepiscodeNull()
            Me(Me.tabledu.episcodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspacienteNull() As Boolean
            Return Me.IsNull(Me.tabledu.pacienteColumn)
        End Function
        
        Public Sub SetpacienteNull()
            Me(Me.tabledu.pacienteColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsduNull() As Boolean
            Return Me.IsNull(Me.tabledu.duColumn)
        End Function
        
        Public Sub SetduNull()
            Me(Me.tabledu.duColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IslongitudNull() As Boolean
            Return Me.IsNull(Me.tabledu.longitudColumn)
        End Function
        
        Public Sub SetlongitudNull()
            Me(Me.tabledu.longitudColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsnotaNull() As Boolean
            Return Me.IsNull(Me.tabledu.notaColumn)
        End Function
        
        Public Sub SetnotaNull()
            Me(Me.tabledu.notaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsmultigaranteNull() As Boolean
            Return Me.IsNull(Me.tabledu.multigaranteColumn)
        End Function
        
        Public Sub SetmultigaranteNull()
            Me(Me.tabledu.multigaranteColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsdcNull() As Boolean
            Return Me.IsNull(Me.tabledu.dcColumn)
        End Function
        
        Public Sub SetdcNull()
            Me(Me.tabledu.dcColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class duRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As duRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As duRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As duRow
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