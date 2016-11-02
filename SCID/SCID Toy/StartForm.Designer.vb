<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Me.Database1DataSet = New SCID.Database1DataSet()
        Me.InterviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New SCID.Database1DataSetTableAdapters.TableAdapterManager()
        Me.InterviewTableAdapter = New SCID.Database1DataSetTableAdapters.interviewTableAdapter()
        Me.InterviewIdBox = New System.Windows.Forms.TextBox()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RaterComboBox = New System.Windows.Forms.ComboBox()
        Me.RaterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StudyComboBox = New System.Windows.Forms.ComboBox()
        Me.StudyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BeginButton = New System.Windows.Forms.Button()
        Me.RaterTableAdapter = New SCID.Database1DataSetTableAdapters.raterTableAdapter()
        Me.StudyTableAdapter = New SCID.Database1DataSetTableAdapters.studyTableAdapter()
        Me.SubjectTableAdapter = New SCID.Database1DataSetTableAdapters.subjectTableAdapter()
        Me.AddSubjectButton = New System.Windows.Forms.Button()
        Me.AddRaterButton = New System.Windows.Forms.Button()
        Me.AddStudyButton = New System.Windows.Forms.Button()
        Me.AutoIdButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InterviewIdToLoadBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InterviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RaterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(131, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SCID-5 Tool"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InterviewBindingSource
        '
        Me.InterviewBindingSource.DataMember = "interview"
        Me.InterviewBindingSource.DataSource = Me.Database1DataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.interviewTableAdapter = Me.InterviewTableAdapter
        Me.TableAdapterManager.raterTableAdapter = Nothing
        Me.TableAdapterManager.responseTableAdapter = Nothing
        Me.TableAdapterManager.studyTableAdapter = Nothing
        Me.TableAdapterManager.subjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SCID.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InterviewTableAdapter
        '
        Me.InterviewTableAdapter.ClearBeforeFill = True
        '
        'InterviewIdBox
        '
        Me.InterviewIdBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InterviewIdBox.Location = New System.Drawing.Point(120, 220)
        Me.InterviewIdBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InterviewIdBox.Name = "InterviewIdBox"
        Me.InterviewIdBox.Size = New System.Drawing.Size(247, 25)
        Me.InterviewIdBox.TabIndex = 1
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DataSource = Me.SubjectBindingSource
        Me.SubjectComboBox.DisplayMember = "surname"
        Me.SubjectComboBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Location = New System.Drawing.Point(120, 253)
        Me.SubjectComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(247, 25)
        Me.SubjectComboBox.TabIndex = 2
        Me.SubjectComboBox.ValueMember = "id"
        '
        'SubjectBindingSource
        '
        Me.SubjectBindingSource.DataMember = "subject"
        Me.SubjectBindingSource.DataSource = Me.Database1DataSet
        '
        'RaterComboBox
        '
        Me.RaterComboBox.DataSource = Me.RaterBindingSource
        Me.RaterComboBox.DisplayMember = "surname"
        Me.RaterComboBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaterComboBox.FormattingEnabled = True
        Me.RaterComboBox.Location = New System.Drawing.Point(120, 286)
        Me.RaterComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RaterComboBox.Name = "RaterComboBox"
        Me.RaterComboBox.Size = New System.Drawing.Size(247, 25)
        Me.RaterComboBox.TabIndex = 3
        Me.RaterComboBox.ValueMember = "id"
        '
        'RaterBindingSource
        '
        Me.RaterBindingSource.DataMember = "rater"
        Me.RaterBindingSource.DataSource = Me.Database1DataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(25, 223)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Interview ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(51, 256)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Subject:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(64, 289)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rater:"
        '
        'StudyComboBox
        '
        Me.StudyComboBox.DataSource = Me.StudyBindingSource
        Me.StudyComboBox.DisplayMember = "title"
        Me.StudyComboBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudyComboBox.FormattingEnabled = True
        Me.StudyComboBox.Location = New System.Drawing.Point(120, 319)
        Me.StudyComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StudyComboBox.Name = "StudyComboBox"
        Me.StudyComboBox.Size = New System.Drawing.Size(247, 25)
        Me.StudyComboBox.TabIndex = 7
        Me.StudyComboBox.ValueMember = "id"
        '
        'StudyBindingSource
        '
        Me.StudyBindingSource.DataMember = "study"
        Me.StudyBindingSource.DataSource = Me.Database1DataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(63, 322)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Study:"
        '
        'BeginButton
        '
        Me.BeginButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginButton.Location = New System.Drawing.Point(189, 352)
        Me.BeginButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BeginButton.Name = "BeginButton"
        Me.BeginButton.Size = New System.Drawing.Size(103, 35)
        Me.BeginButton.TabIndex = 9
        Me.BeginButton.Text = "Begin"
        Me.BeginButton.UseVisualStyleBackColor = True
        '
        'RaterTableAdapter
        '
        Me.RaterTableAdapter.ClearBeforeFill = True
        '
        'StudyTableAdapter
        '
        Me.StudyTableAdapter.ClearBeforeFill = True
        '
        'SubjectTableAdapter
        '
        Me.SubjectTableAdapter.ClearBeforeFill = True
        '
        'AddSubjectButton
        '
        Me.AddSubjectButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSubjectButton.Location = New System.Drawing.Point(375, 253)
        Me.AddSubjectButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddSubjectButton.Name = "AddSubjectButton"
        Me.AddSubjectButton.Size = New System.Drawing.Size(103, 26)
        Me.AddSubjectButton.TabIndex = 10
        Me.AddSubjectButton.Text = "Add Subject"
        Me.AddSubjectButton.UseVisualStyleBackColor = True
        '
        'AddRaterButton
        '
        Me.AddRaterButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRaterButton.Location = New System.Drawing.Point(375, 285)
        Me.AddRaterButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddRaterButton.Name = "AddRaterButton"
        Me.AddRaterButton.Size = New System.Drawing.Size(103, 26)
        Me.AddRaterButton.TabIndex = 11
        Me.AddRaterButton.Text = "Add Rater"
        Me.AddRaterButton.UseVisualStyleBackColor = True
        '
        'AddStudyButton
        '
        Me.AddStudyButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudyButton.Location = New System.Drawing.Point(375, 319)
        Me.AddStudyButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddStudyButton.Name = "AddStudyButton"
        Me.AddStudyButton.Size = New System.Drawing.Size(103, 26)
        Me.AddStudyButton.TabIndex = 12
        Me.AddStudyButton.Text = "Add Study"
        Me.AddStudyButton.UseVisualStyleBackColor = True
        '
        'AutoIdButton
        '
        Me.AutoIdButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.AutoIdButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoIdButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AutoIdButton.Location = New System.Drawing.Point(375, 220)
        Me.AutoIdButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AutoIdButton.Name = "AutoIdButton"
        Me.AutoIdButton.Size = New System.Drawing.Size(67, 25)
        Me.AutoIdButton.TabIndex = 13
        Me.AutoIdButton.Text = "Auto"
        Me.AutoIdButton.UseVisualStyleBackColor = True
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(165, 133)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(155, 33)
        Me.LoadButton.TabIndex = 14
        Me.LoadButton.Text = "Load Interview by ID"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(198, 180)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 36)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "New"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(25, 104)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Interview ID:"
        '
        'InterviewIdToLoadBox
        '
        Me.InterviewIdToLoadBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InterviewIdToLoadBox.Location = New System.Drawing.Point(120, 101)
        Me.InterviewIdToLoadBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InterviewIdToLoadBox.Name = "InterviewIdToLoadBox"
        Me.InterviewIdToLoadBox.Size = New System.Drawing.Size(247, 25)
        Me.InterviewIdToLoadBox.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(198, 61)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 36)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Load"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(503, 397)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.InterviewIdToLoadBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.AutoIdButton)
        Me.Controls.Add(Me.AddStudyButton)
        Me.Controls.Add(Me.AddRaterButton)
        Me.Controls.Add(Me.AddSubjectButton)
        Me.Controls.Add(Me.BeginButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StudyComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RaterComboBox)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(Me.InterviewIdBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StartForm"
        Me.Text = "Toy SCID"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InterviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RaterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet As SCID.Database1DataSet
    Friend WithEvents InterviewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As SCID.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents InterviewIdBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RaterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StudyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BeginButton As System.Windows.Forms.Button
    Friend WithEvents RaterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RaterTableAdapter As SCID.Database1DataSetTableAdapters.raterTableAdapter
    Friend WithEvents StudyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudyTableAdapter As SCID.Database1DataSetTableAdapters.studyTableAdapter
    Friend WithEvents SubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectTableAdapter As SCID.Database1DataSetTableAdapters.subjectTableAdapter
    Friend WithEvents InterviewTableAdapter As SCID.Database1DataSetTableAdapters.interviewTableAdapter
    Friend WithEvents AddSubjectButton As System.Windows.Forms.Button
    Friend WithEvents AddRaterButton As System.Windows.Forms.Button
    Friend WithEvents AddStudyButton As System.Windows.Forms.Button
    Friend WithEvents AutoIdButton As System.Windows.Forms.Button
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents InterviewIdToLoadBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
