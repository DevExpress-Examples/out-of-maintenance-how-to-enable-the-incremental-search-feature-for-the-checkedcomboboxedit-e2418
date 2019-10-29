Namespace DXSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.checkedComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
			CType(Me.checkedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' checkedComboBoxEdit
			' 
			Me.checkedComboBoxEdit.EditValue = ""
			Me.checkedComboBoxEdit.Location = New System.Drawing.Point(33, 67)
			Me.checkedComboBoxEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.checkedComboBoxEdit.Name = "checkedComboBoxEdit"
			Me.checkedComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.checkedComboBoxEdit.Properties.DisplayMember = "LastName"
			Me.checkedComboBoxEdit.Properties.IncrementalSearch = True
			Me.checkedComboBoxEdit.Properties.ValueMember = "FirstName"
			Me.checkedComboBoxEdit.Size = New System.Drawing.Size(311, 20)
			Me.checkedComboBoxEdit.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(389, 262)
			Me.Controls.Add(Me.checkedComboBoxEdit)
			Me.Name = "Form1"
			Me.Text = "Incremental Search"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.checkedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private checkedComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit
	End Class
End Namespace

