Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid

Namespace Display_Unbound_Data
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = ProductList.GetData()
		End Sub
		Private Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As GridColumnDataEventArgs)
			If e.IsGetData Then
				Dim price As Integer = Convert.ToInt32(e.GetListSourceFieldValue("UnitPrice"))
				Dim unitsOnOrder As Integer = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"))
				e.Value = price * unitsOnOrder
			End If
		End Sub
	End Class
End Namespace
