
namespace DXSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.checkedComboBoxEdit = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedComboBoxEdit
            // 
            this.checkedComboBoxEdit.EditValue = "";
            this.checkedComboBoxEdit.Location = new System.Drawing.Point(33, 67);
            this.checkedComboBoxEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedComboBoxEdit.Name = "checkedComboBoxEdit";
            this.checkedComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit.Properties.DisplayMember = "LastName";
            this.checkedComboBoxEdit.Properties.IncrementalSearch = true;
            this.checkedComboBoxEdit.Properties.ValueMember = "FirstName";
            this.checkedComboBoxEdit.Size = new System.Drawing.Size(311, 20);
            this.checkedComboBoxEdit.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 262);
            this.Controls.Add(this.checkedComboBoxEdit);
            this.Name = "Form1";
            this.Text = "Incremental Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit;
    }
}

