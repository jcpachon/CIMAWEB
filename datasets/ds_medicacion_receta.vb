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
Public Class ds_medicacion_receta
    Inherits DataSet
    
    Private tablecima_medicacion As cima_medicacionDataTable
    
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
            If (Not (ds.Tables("cima_medicacion")) Is Nothing) Then
                Me.Tables.Add(New cima_medicacionDataTable(ds.Tables("cima_medicacion")))
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
    Public ReadOnly Property cima_medicacion As cima_medicacionDataTable
        Get
            Return Me.tablecima_medicacion
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds_medicacion_receta = CType(MyBase.Clone,ds_medicacion_receta)
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
        If (Not (ds.Tables("cima_medicacion")) Is Nothing) Then
            Me.Tables.Add(New cima_medicacionDataTable(ds.Tables("cima_medicacion")))
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
        Me.tablecima_medicacion = CType(Me.Tables("cima_medicacion"),cima_medicacionDataTable)
        If (Not (Me.tablecima_medicacion) Is Nothing) Then
            Me.tablecima_medicacion.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds_medicacion_receta"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ds_medicacion_receta.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablecima_medicacion = New cima_medicacionDataTable
        Me.Tables.Add(Me.tablecima_medicacion)
    End Sub
    
    Private Function ShouldSerializecima_medicacion() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub cima_medicacionRowChangeEventHandler(ByVal sender As Object, ByVal e As cima_medicacionRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_medicacionDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid_medicacion As DataColumn
        
        Private columnpers_key As DataColumn
        
        Private columndrugselecode_key As DataColumn
        
        Private columndrugseledesc As DataColumn
        
        Private columnfecha As DataColumn
        
        Private columnepiscode As DataColumn
        
        Private columnposologia As DataColumn
        
        Private columntipo_duracion As DataColumn
        
        Private columnduracion As DataColumn
        
        Private columnobservaciones As DataColumn
        
        Friend Sub New()
            MyBase.New("cima_medicacion")
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
        
        Friend ReadOnly Property id_medicacionColumn As DataColumn
            Get
                Return Me.columnid_medicacion
            End Get
        End Property
        
        Friend ReadOnly Property pers_keyColumn As DataColumn
            Get
                Return Me.columnpers_key
            End Get
        End Property
        
        Friend ReadOnly Property drugselecode_keyColumn As DataColumn
            Get
                Return Me.columndrugselecode_key
            End Get
        End Property
        
        Friend ReadOnly Property drugseledescColumn As DataColumn
            Get
                Return Me.columndrugseledesc
            End Get
        End Property
        
        Friend ReadOnly Property fechaColumn As DataColumn
            Get
                Return Me.columnfecha
            End Get
        End Property
        
        Friend ReadOnly Property episcodeColumn As DataColumn
            Get
                Return Me.columnepiscode
            End Get
        End Property
        
        Friend ReadOnly Property posologiaColumn As DataColumn
            Get
                Return Me.columnposologia
            End Get
        End Property
        
        Friend ReadOnly Property tipo_duracionColumn As DataColumn
            Get
                Return Me.columntipo_duracion
            End Get
        End Property
        
        Friend ReadOnly Property duracionColumn As DataColumn
            Get
                Return Me.columnduracion
            End Get
        End Property
        
        Friend ReadOnly Property observacionesColumn As DataColumn
            Get
                Return Me.columnobservaciones
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As cima_medicacionRow
            Get
                Return CType(Me.Rows(index),cima_medicacionRow)
            End Get
        End Property
        
        Public Event cima_medicacionRowChanged As cima_medicacionRowChangeEventHandler
        
        Public Event cima_medicacionRowChanging As cima_medicacionRowChangeEventHandler
        
        Public Event cima_medicacionRowDeleted As cima_medicacionRowChangeEventHandler
        
        Public Event cima_medicacionRowDeleting As cima_medicacionRowChangeEventHandler
        
        Public Overloads Sub Addcima_medicacionRow(ByVal row As cima_medicacionRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addcima_medicacionRow(ByVal pers_key As Integer, ByVal drugselecode_key As Integer, ByVal drugseledesc As String, ByVal fecha As Date, ByVal episcode As String, ByVal posologia As String, ByVal tipo_duracion As String, ByVal duracion As Integer, ByVal observaciones As String) As cima_medicacionRow
            Dim rowcima_medicacionRow As cima_medicacionRow = CType(Me.NewRow,cima_medicacionRow)
            rowcima_medicacionRow.ItemArray = New Object() {Nothing, pers_key, drugselecode_key, drugseledesc, fecha, episcode, posologia, tipo_duracion, duracion, observaciones}
            Me.Rows.Add(rowcima_medicacionRow)
            Return rowcima_medicacionRow
        End Function
        
        Public Function FindByid_medicacion(ByVal id_medicacion As Long) As cima_medicacionRow
            Return CType(Me.Rows.Find(New Object() {id_medicacion}),cima_medicacionRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As cima_medicacionDataTable = CType(MyBase.Clone,cima_medicacionDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New cima_medicacionDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid_medicacion = Me.Columns("id_medicacion")
            Me.columnpers_key = Me.Columns("pers_key")
            Me.columndrugselecode_key = Me.Columns("drugselecode_key")
            Me.columndrugseledesc = Me.Columns("drugseledesc")
            Me.columnfecha = Me.Columns("fecha")
            Me.columnepiscode = Me.Columns("episcode")
            Me.columnposologia = Me.Columns("posologia")
            Me.columntipo_duracion = Me.Columns("tipo_duracion")
            Me.columnduracion = Me.Columns("duracion")
            Me.columnobservaciones = Me.Columns("observaciones")
        End Sub
        
        Private Sub InitClass()
            Me.columnid_medicacion = New DataColumn("id_medicacion", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_medicacion)
            Me.columnpers_key = New DataColumn("pers_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpers_key)
            Me.columndrugselecode_key = New DataColumn("drugselecode_key", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndrugselecode_key)
            Me.columndrugseledesc = New DataColumn("drugseledesc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndrugseledesc)
            Me.columnfecha = New DataColumn("fecha", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfecha)
            Me.columnepiscode = New DataColumn("episcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnepiscode)
            Me.columnposologia = New DataColumn("posologia", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnposologia)
            Me.columntipo_duracion = New DataColumn("tipo_duracion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columntipo_duracion)
            Me.columnduracion = New DataColumn("duracion", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnduracion)
            Me.columnobservaciones = New DataColumn("observaciones", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnobservaciones)
            Me.Constraints.Add(New UniqueConstraint("ds_medicacion_recetaKey1", New DataColumn() {Me.columnid_medicacion}, true))
            Me.columnid_medicacion.AutoIncrement = true
            Me.columnid_medicacion.AllowDBNull = false
            Me.columnid_medicacion.ReadOnly = true
            Me.columnid_medicacion.Unique = true
        End Sub
        
        Public Function Newcima_medicacionRow() As cima_medicacionRow
            Return CType(Me.NewRow,cima_medicacionRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New cima_medicacionRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(cima_medicacionRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.cima_medicacionRowChangedEvent) Is Nothing) Then
                RaiseEvent cima_medicacionRowChanged(Me, New cima_medicacionRowChangeEvent(CType(e.Row,cima_medicacionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.cima_medicacionRowChangingEvent) Is Nothing) Then
                RaiseEvent cima_medicacionRowChanging(Me, New cima_medicacionRowChangeEvent(CType(e.Row,cima_medicacionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.cima_medicacionRowDeletedEvent) Is Nothing) Then
                RaiseEvent cima_medicacionRowDeleted(Me, New cima_medicacionRowChangeEvent(CType(e.Row,cima_medicacionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.cima_medicacionRowDeletingEvent) Is Nothing) Then
                RaiseEvent cima_medicacionRowDeleting(Me, New cima_medicacionRowChangeEvent(CType(e.Row,cima_medicacionRow), e.Action))
            End If
        End Sub
        
        Public Sub Removecima_medicacionRow(ByVal row As cima_medicacionRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_medicacionRow
        Inherits DataRow
        
        Private tablecima_medicacion As cima_medicacionDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablecima_medicacion = CType(Me.Table,cima_medicacionDataTable)
        End Sub
        
        Public Property id_medicacion As Long
            Get
                Return CType(Me(Me.tablecima_medicacion.id_medicacionColumn),Long)
            End Get
            Set
                Me(Me.tablecima_medicacion.id_medicacionColumn) = value
            End Set
        End Property
        
        Public Property pers_key As Integer
            Get
                Try 
                    Return CType(Me(Me.tablecima_medicacion.pers_keyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_medicacion.pers_keyColumn) = value
            End Set
        End Property
        
        Public Property drugselecode_key As Integer
            Get
                Try 
                    Return CType(Me(Me.tablecima_medicacion.drugselecode_keyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_medicacion.drugselecode_keyColumn) = value
            End Set
        End Property
        
        Public Property drugseledesc As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_medicacion.drugseledescColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_medicacion.drugseledescColumn) = value
            End Set
        End Property
        
        Public Property fecha As Date
            Get
                Try 
                    Return CType(Me(Me.tablecima_medicacion.fechaColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_medicacion.fechaColumn) = value
            End Set
        End Property
        
        Public Property episcode As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_medicacion.episcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_medicacion.episcodeColumn) = value
            End Set
        End Property
        
        Public Property posologia As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_medicacion.posologiaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_medicacion.posologiaColumn) = value
            End Set
        End Property
        
        Public Property tipo_duracion As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_medicacion.tipo_duracionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_medicacion.tipo_duracionColumn) = value
            End Set
        End Property
        
        Public Property duracion As Integer
            Get
                Try 
                    Return CType(Me(Me.tablecima_medicacion.duracionColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_medicacion.duracionColumn) = value
            End Set
        End Property
        
        Public Property observaciones As String
            Get
                Try 
                    Return CType(Me(Me.tablecima_medicacion.observacionesColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablecima_medicacion.observacionesColumn) = value
            End Set
        End Property
        
        Public Function Ispers_keyNull() As Boolean
            Return Me.IsNull(Me.tablecima_medicacion.pers_keyColumn)
        End Function
        
        Public Sub Setpers_keyNull()
            Me(Me.tablecima_medicacion.pers_keyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isdrugselecode_keyNull() As Boolean
            Return Me.IsNull(Me.tablecima_medicacion.drugselecode_keyColumn)
        End Function
        
        Public Sub Setdrugselecode_keyNull()
            Me(Me.tablecima_medicacion.drugselecode_keyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsdrugseledescNull() As Boolean
            Return Me.IsNull(Me.tablecima_medicacion.drugseledescColumn)
        End Function
        
        Public Sub SetdrugseledescNull()
            Me(Me.tablecima_medicacion.drugseledescColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsfechaNull() As Boolean
            Return Me.IsNull(Me.tablecima_medicacion.fechaColumn)
        End Function
        
        Public Sub SetfechaNull()
            Me(Me.tablecima_medicacion.fechaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsepiscodeNull() As Boolean
            Return Me.IsNull(Me.tablecima_medicacion.episcodeColumn)
        End Function
        
        Public Sub SetepiscodeNull()
            Me(Me.tablecima_medicacion.episcodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsposologiaNull() As Boolean
            Return Me.IsNull(Me.tablecima_medicacion.posologiaColumn)
        End Function
        
        Public Sub SetposologiaNull()
            Me(Me.tablecima_medicacion.posologiaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Istipo_duracionNull() As Boolean
            Return Me.IsNull(Me.tablecima_medicacion.tipo_duracionColumn)
        End Function
        
        Public Sub Settipo_duracionNull()
            Me(Me.tablecima_medicacion.tipo_duracionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsduracionNull() As Boolean
            Return Me.IsNull(Me.tablecima_medicacion.duracionColumn)
        End Function
        
        Public Sub SetduracionNull()
            Me(Me.tablecima_medicacion.duracionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsobservacionesNull() As Boolean
            Return Me.IsNull(Me.tablecima_medicacion.observacionesColumn)
        End Function
        
        Public Sub SetobservacionesNull()
            Me(Me.tablecima_medicacion.observacionesColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class cima_medicacionRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As cima_medicacionRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As cima_medicacionRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As cima_medicacionRow
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