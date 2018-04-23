Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository
Imports System.Windows.Forms

Namespace DXSample
	<UserRepositoryItem("RegisterCustomEdit")> _
	Public Class RepositoryItemCustomEdit
		Inherits RepositoryItemCheckedComboBoxEdit

		Shared Sub New()
			RegisterCustomEdit()
		End Sub

		Public Sub New()
		End Sub

		Public Const CustomEditName As String = "CustomEdit"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomEditName
			End Get
		End Property

		Public Shared Sub RegisterCustomEdit()
			Dim img As Image = Nothing
			Try
				img = CType(Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly(). GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp")), Bitmap)
			Catch
			End Try
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomEdit), GetType(RepositoryItemCustomEdit), GetType(PopupContainerEditViewInfo), New ButtonEditPainter(), True, img))
		End Sub

		Private incrementalSearch_Renamed As Boolean = False

		Public Property IncrementalSearch() As Boolean
			Get
				Return incrementalSearch_Renamed
			End Get
			Set(ByVal value As Boolean)
				If incrementalSearch_Renamed <> value Then
					incrementalSearch_Renamed = value
				End If
			End Set
		End Property

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemCustomEdit = TryCast(item, RepositoryItemCustomEdit)
				If source Is Nothing Then
					Return
				End If
				incrementalSearch_Renamed = source.IncrementalSearch
			Finally
				EndUpdate()
			End Try
		End Sub
	End Class


	Public Class CustomEdit
		Inherits CheckedComboBoxEdit

		Shared Sub New()
			RepositoryItemCustomEdit.RegisterCustomEdit()
		End Sub

		Public Sub New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomEdit.CustomEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomEdit)
			End Get
		End Property

		Protected Overrides Function CreatePopupCheckListControl() As PopupContainerControl
			Dim popupControl As PopupContainerControl = MyBase.CreatePopupCheckListControl()
			Dim listBox As CheckedListBoxControl = TryCast(popupControl.Controls(0), CheckedListBoxControl)
			listBox.IncrementalSearch = Properties.IncrementalSearch
			AddHandler listBox.KeyDown, AddressOf OnListBoxKeyDown
			Return popupControl
		End Function

		Private Sub OnListBoxKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			Dim listBox As CheckedListBoxControl = TryCast(sender, CheckedListBoxControl)
			If e.KeyData = Keys.Space AndAlso Properties.IncrementalSearch Then
				listBox.ToggleItem(listBox.SelectedIndex)
				e.Handled = True
			End If
		End Sub

	End Class
End Namespace
