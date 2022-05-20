Imports System.Windows

Namespace DXPivotGrid_StandaloneFieldList

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource =(New DataSet1TableAdapters.SalesPersonTableAdapter()).GetData()
        End Sub
    End Class
End Namespace
