
namespace DXSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WindowsApplication31.nwindDataSet();
            this.employeesTableAdapter = new WindowsApplication31.nwindDataSetTableAdapters.EmployeesTableAdapter();
            this.customEdit1 = new DXSample.CustomEdit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // customEdit1
            // 
            this.customEdit1.EditValue = "";
            this.customEdit1.Location = new System.Drawing.Point(44, 83);
            this.customEdit1.Name = "customEdit1";
            this.customEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customEdit1.Properties.DataSource = this.employeesBindingSource;
            this.customEdit1.Properties.DisplayMember = "LastName";
            this.customEdit1.Properties.IncrementalSearch = true;
            this.customEdit1.Properties.ValueMember = "FirstName";
            this.customEdit1.Size = new System.Drawing.Size(415, 22);
            this.customEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 322);
            this.Controls.Add(this.customEdit1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Incremental Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomEdit customEdit1;
        private WindowsApplication31.nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private WindowsApplication31.nwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;

    }
}

