﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.lbl_setting_splitwarntime = New System.Windows.Forms.Label()
        Me.splitwarn_trackbar = New System.Windows.Forms.TrackBar()
        Me.btn_settings_save = New System.Windows.Forms.Button()
        Me.ckbx_pause = New System.Windows.Forms.CheckBox()
        Me.ckbx_tooltips = New System.Windows.Forms.CheckBox()
        Me.ckbx_recorded = New System.Windows.Forms.CheckBox()
        Me.grp_settings_general = New System.Windows.Forms.GroupBox()
        Me.lbl_settings_warn_track = New System.Windows.Forms.Label()
        CType(Me.splitwarn_trackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_settings_general.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_setting_splitwarntime
        '
        Me.lbl_setting_splitwarntime.AutoSize = True
        Me.lbl_setting_splitwarntime.Location = New System.Drawing.Point(12, 107)
        Me.lbl_setting_splitwarntime.Name = "lbl_setting_splitwarntime"
        Me.lbl_setting_splitwarntime.Size = New System.Drawing.Size(96, 13)
        Me.lbl_setting_splitwarntime.TabIndex = 1
        Me.lbl_setting_splitwarntime.Text = "Split Warning Time"
        '
        'splitwarn_trackbar
        '
        Me.splitwarn_trackbar.Location = New System.Drawing.Point(12, 123)
        Me.splitwarn_trackbar.Maximum = 120
        Me.splitwarn_trackbar.Minimum = 1
        Me.splitwarn_trackbar.Name = "splitwarn_trackbar"
        Me.splitwarn_trackbar.Size = New System.Drawing.Size(260, 45)
        Me.splitwarn_trackbar.TabIndex = 2
        Me.splitwarn_trackbar.Value = 1
        '
        'btn_settings_save
        '
        Me.btn_settings_save.Image = Global.Timer__.My.Resources.Resources.save_bw
        Me.btn_settings_save.Location = New System.Drawing.Point(180, 29)
        Me.btn_settings_save.Name = "btn_settings_save"
        Me.btn_settings_save.Size = New System.Drawing.Size(92, 50)
        Me.btn_settings_save.TabIndex = 3
        Me.btn_settings_save.Text = "Save"
        Me.btn_settings_save.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_settings_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_settings_save.UseVisualStyleBackColor = True
        '
        'ckbx_pause
        '
        Me.ckbx_pause.AutoSize = True
        Me.ckbx_pause.Location = New System.Drawing.Point(6, 19)
        Me.ckbx_pause.Name = "ckbx_pause"
        Me.ckbx_pause.Size = New System.Drawing.Size(148, 17)
        Me.ckbx_pause.TabIndex = 4
        Me.ckbx_pause.Text = "Enable the pause button?"
        Me.ckbx_pause.UseVisualStyleBackColor = True
        '
        'ckbx_tooltips
        '
        Me.ckbx_tooltips.AutoSize = True
        Me.ckbx_tooltips.Location = New System.Drawing.Point(6, 41)
        Me.ckbx_tooltips.Name = "ckbx_tooltips"
        Me.ckbx_tooltips.Size = New System.Drawing.Size(95, 17)
        Me.ckbx_tooltips.TabIndex = 5
        Me.ckbx_tooltips.Text = "Show tooltips?"
        Me.ckbx_tooltips.UseVisualStyleBackColor = True
        '
        'ckbx_recorded
        '
        Me.ckbx_recorded.AutoSize = True
        Me.ckbx_recorded.Location = New System.Drawing.Point(6, 64)
        Me.ckbx_recorded.Name = "ckbx_recorded"
        Me.ckbx_recorded.Size = New System.Drawing.Size(142, 17)
        Me.ckbx_recorded.TabIndex = 6
        Me.ckbx_recorded.Text = "Mark items as recorded?"
        Me.ckbx_recorded.UseVisualStyleBackColor = True
        '
        'grp_settings_general
        '
        Me.grp_settings_general.Controls.Add(Me.ckbx_pause)
        Me.grp_settings_general.Controls.Add(Me.ckbx_recorded)
        Me.grp_settings_general.Controls.Add(Me.ckbx_tooltips)
        Me.grp_settings_general.Location = New System.Drawing.Point(15, 13)
        Me.grp_settings_general.Name = "grp_settings_general"
        Me.grp_settings_general.Size = New System.Drawing.Size(159, 91)
        Me.grp_settings_general.TabIndex = 7
        Me.grp_settings_general.TabStop = False
        Me.grp_settings_general.Text = "General"
        '
        'lbl_settings_warn_track
        '
        Me.lbl_settings_warn_track.AutoSize = True
        Me.lbl_settings_warn_track.Location = New System.Drawing.Point(115, 107)
        Me.lbl_settings_warn_track.Name = "lbl_settings_warn_track"
        Me.lbl_settings_warn_track.Size = New System.Drawing.Size(13, 13)
        Me.lbl_settings_warn_track.TabIndex = 8
        Me.lbl_settings_warn_track.Text = "0"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 158)
        Me.Controls.Add(Me.lbl_settings_warn_track)
        Me.Controls.Add(Me.grp_settings_general)
        Me.Controls.Add(Me.btn_settings_save)
        Me.Controls.Add(Me.splitwarn_trackbar)
        Me.Controls.Add(Me.lbl_setting_splitwarntime)
        Me.Name = "settings"
        Me.Text = "Timer Plus Plus Settings"
        CType(Me.splitwarn_trackbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_settings_general.ResumeLayout(False)
        Me.grp_settings_general.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_setting_splitwarntime As Label
    Friend WithEvents splitwarn_trackbar As TrackBar
    Friend WithEvents btn_settings_save As Button
    Friend WithEvents ckbx_pause As CheckBox
    Friend WithEvents ckbx_tooltips As CheckBox
    Friend WithEvents ckbx_recorded As CheckBox
    Friend WithEvents grp_settings_general As GroupBox
    Friend WithEvents lbl_settings_warn_track As Label
End Class