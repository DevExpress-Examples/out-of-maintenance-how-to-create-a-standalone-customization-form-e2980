Imports System.Windows

Namespace DXPivotGrid_StandaloneFieldList
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = (New DataSet1TableAdapters.SalesPersonTableAdapter()).GetData()
		End Sub
	End Class
End Namespace
