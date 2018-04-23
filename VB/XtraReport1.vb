Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
' ...

Namespace WindowsApplication1
	Partial Public Class XtraReport1
		Inherits XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel4_PreviewDoubleClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel6.PreviewDoubleClick, xrLabel5.PreviewDoubleClick, xrLabel4.PreviewDoubleClick
			Dim frm As New Form2()
			Dim label As XRLabel = TryCast(e.Brick.BrickOwner, XRLabel)
			Dim fieldName As String = label.DataBindings("Text").DataMember.Substring(label.DataBindings("Text").DataMember.LastIndexOf("."c) + 1)
			frm.str = (CType(e.Brick.Value, DataRowView))(fieldName).ToString()
			frm.ShowDialog()
			CType(e.Brick.Value, DataRowView)(fieldName) = frm.str
			Me.CreateDocument(False)
		End Sub

		Private Sub xrLabel4_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles xrLabel6.BeforePrint, xrLabel5.BeforePrint, xrLabel4.BeforePrint
			CType(sender, XRLabel).Tag = Me.DetailReport.GetCurrentRow()
		End Sub
	End Class
End Namespace
