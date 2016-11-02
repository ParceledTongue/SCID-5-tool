<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionForm
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
        Me.Database1DataSet = New SCID.Database1DataSet()
        Me.ResponseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResponseTableAdapter = New SCID.Database1DataSetTableAdapters.responseTableAdapter()
        Me.CommentTableAdapter = New SCID.Database1DataSetTableAdapters.commentTableAdapter()
        Me.TableAdapterManager = New SCID.Database1DataSetTableAdapters.TableAdapterManager()
        Me.MainFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.NavBox = New System.Windows.Forms.ListBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.CommentBox = New System.Windows.Forms.TextBox()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResponseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResponseBindingSource
        '
        Me.ResponseBindingSource.DataMember = "response"
        Me.ResponseBindingSource.DataSource = Me.Database1DataSet
        '
        'CommentBindingSource
        '
        Me.CommentBindingSource.DataMember = "comment"
        Me.CommentBindingSource.DataSource = Me.Database1DataSet
        '
        'ResponseTableAdapter
        '
        Me.ResponseTableAdapter.ClearBeforeFill = True
        '
        'CommentTableAdapter
        '
        Me.CommentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.commentTableAdapter = Me.CommentTableAdapter
        Me.TableAdapterManager.interviewTableAdapter = Nothing
        Me.TableAdapterManager.raterTableAdapter = Nothing
        Me.TableAdapterManager.responseTableAdapter = Me.ResponseTableAdapter
        Me.TableAdapterManager.studyTableAdapter = Nothing
        Me.TableAdapterManager.subjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SCID.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainFlowLayoutPanel
        '
        Me.MainFlowLayoutPanel.AutoScroll = True
        Me.MainFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainFlowLayoutPanel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainFlowLayoutPanel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.MainFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainFlowLayoutPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel"
        Me.MainFlowLayoutPanel.Padding = New System.Windows.Forms.Padding(20)
        Me.MainFlowLayoutPanel.Size = New System.Drawing.Size(901, 544)
        Me.MainFlowLayoutPanel.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.NavBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1401, 544)
        Me.SplitContainer1.SplitterDistance = 272
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.TabStop = False
        '
        'NavBox
        '
        Me.NavBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.NavBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NavBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBox.FormattingEnabled = True
        Me.NavBox.ItemHeight = 16
        Me.NavBox.Location = New System.Drawing.Point(0, 0)
        Me.NavBox.Name = "NavBox"
        Me.NavBox.Size = New System.Drawing.Size(272, 544)
        Me.NavBox.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.MainFlowLayoutPanel)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CommentBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(1125, 544)
        Me.SplitContainer2.SplitterDistance = 901
        Me.SplitContainer2.TabIndex = 1
        '
        'CommentBox
        '
        Me.CommentBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CommentBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommentBox.Location = New System.Drawing.Point(0, 0)
        Me.CommentBox.Multiline = True
        Me.CommentBox.Name = "CommentBox"
        Me.CommentBox.Size = New System.Drawing.Size(220, 544)
        Me.CommentBox.TabIndex = 0
        '
        'QuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1401, 544)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "QuestionForm"
        Me.Text = "Toy SCID"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResponseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Database1DataSet As SCID.Database1DataSet
    Friend WithEvents ResponseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResponseTableAdapter As SCID.Database1DataSetTableAdapters.responseTableAdapter
    Friend WithEvents CommentTableAdapter As SCID.Database1DataSetTableAdapters.commentTableAdapter
    Friend WithEvents TableAdapterManager As SCID.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MainFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents NavBox As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents CommentBox As System.Windows.Forms.TextBox
End Class
