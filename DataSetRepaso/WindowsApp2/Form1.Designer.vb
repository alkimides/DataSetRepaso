﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPedidoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPedidoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(454, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoPedidoToolStripMenuItem
        '
        Me.NuevoPedidoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPedidoToolStripMenuItem1, Me.MantenimientoProductosToolStripMenuItem})
        Me.NuevoPedidoToolStripMenuItem.Name = "NuevoPedidoToolStripMenuItem"
        Me.NuevoPedidoToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.NuevoPedidoToolStripMenuItem.Text = "Productos"
        '
        'NuevoPedidoToolStripMenuItem1
        '
        Me.NuevoPedidoToolStripMenuItem1.Name = "NuevoPedidoToolStripMenuItem1"
        Me.NuevoPedidoToolStripMenuItem1.Size = New System.Drawing.Size(213, 22)
        Me.NuevoPedidoToolStripMenuItem1.Text = "Nuevo Pedido"
        '
        'MantenimientoProductosToolStripMenuItem
        '
        Me.MantenimientoProductosToolStripMenuItem.Name = "MantenimientoProductosToolStripMenuItem"
        Me.MantenimientoProductosToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.MantenimientoProductosToolStripMenuItem.Text = "Mantenimiento Productos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 427)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoPedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoPedidoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MantenimientoProductosToolStripMenuItem As ToolStripMenuItem
End Class
