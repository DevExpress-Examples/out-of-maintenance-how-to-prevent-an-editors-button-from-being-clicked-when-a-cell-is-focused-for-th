Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication4
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataTable1.Rows.Add("test")
			dataTable1.Rows.Add("test")
			dataTable1.Rows.Add("test")
			dataTable1.Rows.Add("test")
			dataTable1.Rows.Add("test")
		End Sub

		Private AllowShowEditor As Boolean = True

		Private Sub gridView1_ShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs) Handles gridView1.ShowingEditor
			e.Cancel = Not AllowShowEditor
		End Sub

		Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
			AllowShowEditor = False
			BeginInvoke(New MethodInvoker(AddressOf AnonymousMethod1))
        End Sub

        Private Sub AnonymousMethod1()
            AllowShowEditor = True
        End Sub

		Private Sub repositoryItemButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repositoryItemButtonEdit1.ButtonClick
			MessageBox.Show("Button Click")
		End Sub
	End Class
End Namespace