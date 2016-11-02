<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudyEntryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleBox = New System.Windows.Forms.TextBox()
        Me.IdBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Database1DataSet = New SCID.Database1DataSet()
        Me.StudyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudyTableAdapter = New SCID.Database1DataSetTableAdapters.studyTableAdapter()
        Me.TableAdapterManager = New SCID.Database1DataSetTableAdapters.TableAdapterManager()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.AutoIdButton = New System.Windows.Forms.Button()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please enter the information for the study you would like" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to add."
        '
        'TitleBox
        '
        Me.TitleBox.Location = New System.Drawing.Point(109, 83)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(100, 20)
        Me.TitleBox.TabIndex = 9
        '
        'IdBox
        '
        Me.IdBox.Location = New System.Drawing.Point(109, 57)
        Me.IdBox.Name = "IdBox"
        Me.IdBox.Size = New System.Drawing.Size(100, 20)
        Me.IdBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID:"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudyBindingSource
        '
        Me.StudyBindingSource.DataMember = "study"
        Me.StudyBindingSource.DataSource = Me.Database1DataSet
        '
        'StudyTableAdapter
        '
        Me.StudyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.interviewTableAdapter = Nothing
        Me.TableAdapterManager.raterTableAdapter = Nothing
        Me.TableAdapterManager.responseTableAdapter = Nothing
        Me.TableAdapterManager.studyTableAdapter = Me.StudyTableAdapter
        Me.TableAdapterManager.subjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SCID.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(120, 117)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 10
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'AutoIdButton
        '
        Me.AutoIdButton.Location = New System.Drawing.Point(215, 57)
        Me.AutoIdButton.Name = "AutoIdButton"
        Me.AutoIdButton.Size = New System.Drawing.Size(53, 20)
        Me.AutoIdButton.TabIndex = 14
        Me.AutoIdButton.Text = "Auto"
        Me.AutoIdButton.UseVisualStyleBackColor = True
        '
        'StudyEntryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 152)
        Me.Controls.Add(Me.AutoIdButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.TitleBox)
        Me.Controls.Add(Me.IdBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "StudyEntryForm"
        Me.Text = "Add Study"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TitleBox As System.Windows.Forms.TextBox
    Friend WithEvents IdBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet As SCID.Database1DataSet
    Friend WithEvents StudyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudyTableAdapter As SCID.Database1DataSetTableAdapters.studyTableAdapter
    Friend WithEvents TableAdapterManager As SCID.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents AutoIdButton As System.Windows.Forms.Button
End Class
