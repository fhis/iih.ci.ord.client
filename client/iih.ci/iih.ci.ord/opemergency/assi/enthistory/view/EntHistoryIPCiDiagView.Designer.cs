﻿using xap.rui.bizcontrol.DiagnosticTimeline;
using xap.rui.control.forms.view;
using System.Windows.Forms;
using System;
namespace iih.ci.ord.opemergency.assi.enthistory.view
{
    partial class EntHistoryIPCiDiagView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.group = new TimeLineCtr();
            this.xapFormControl = new XapFormControl();
            this.SuspendLayout();

            //group.Size = new System.Drawing.Size(1000, 568);
            //group.Location = new Point(40, 0);

            //
            //
            // 
            group.Dock = DockStyle.Fill;
            group.IsShowBtn = false;
            this.xapFormControl.AddRender(group);

            //
            // xapFormControl
            //
            this.xapFormControl.Dock = DockStyle.Fill;

            //
            // EntHistoryIPCiDiagView
            //
            this.Controls.Add(this.xapFormControl);
            this.Load += new EventHandler(IpCiDiagView_Load);

            this.ResumeLayout(false);
        }

        private TimeLineCtr group;

        private XapFormControl xapFormControl;

        #endregion
    }
}
