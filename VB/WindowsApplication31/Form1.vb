Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DXSample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Function GetCustomers() As BindingList(Of Customer)
			Dim customers As New BindingList(Of Customer)()
			customers.Add(New Customer() With {
				.Id = 0,
				.Name = "Alex",
				.IsActive = True
			})
			customers.Add(New Customer() With {
				.Id = 1,
				.Name = "Sarah",
				.IsActive = True
			})
			customers.Add(New Customer() With {
				.Id = 2,
				.Name = "Bob",
				.IsActive = False
			})
			Return customers
		End Function
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			checkedComboBoxEdit.Properties.IncrementalSearch = True
			checkedComboBoxEdit.Properties.DataSource = GetCustomers()
			checkedComboBoxEdit.Properties.DisplayMember = "Name"
			checkedComboBoxEdit.Properties.ValueMember = "Id"
		End Sub
	End Class
	Friend Class Customer
		Public Property Id() As Integer
		Public Property Name() As String
		Public Property IsActive() As Boolean
	End Class
End Namespace
