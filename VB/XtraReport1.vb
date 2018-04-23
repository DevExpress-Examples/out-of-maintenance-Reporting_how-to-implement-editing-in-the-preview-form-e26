Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports DevExpress.XtraReports.UI
Imports System.Drawing.Printing
' ...

Namespace WindowsApplication1
	Partial Public Class XtraReport1
		Inherits XtraReport
		Private values As New ArrayList()
		Private i As Integer
		Public Sub New()
			InitializeComponent()
			i = 0
		End Sub

		Private Sub xrLabel4_PreviewDoubleClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel4.PreviewDoubleClick
			Dim frm As New Form2()
			frm.str = e.Brick.Text
			frm.ShowDialog()
			Dim s As String = frm.str
			i = 0
			values.Add(New IDInfo(Convert.ToInt32(e.Brick.Value), s))
			Me.CreateDocument()
		End Sub

		Private Sub xrLabel4_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles xrLabel4.BeforePrint
			CType(sender, XRLabel).Tag = i
			For j As Integer = 0 To values.Count - 1
				If (CType(values(j), IDInfo)).ID = i Then
					CType(sender, XRLabel).Text = (CType(values(j), IDInfo)).val
				End If
			Next j
			i += 1
		End Sub
	End Class
	Public Class IDInfo
		Public Sub New(ByVal i As Integer, ByVal v As String)
			ID = i
			val = v
		End Sub
		Public ID As Integer
		Public val As String
	End Class
End Namespace
