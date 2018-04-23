Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
' ..

Namespace WindowsApplication1
	Partial Public Class Form2
		Inherits Form
		Public str As String = ""
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			str = Me.textBox1.Text
			Me.Close()
		End Sub

		Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.textBox1.Text = str
		End Sub
	End Class
End Namespace