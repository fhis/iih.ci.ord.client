﻿using xap.rui.bizcontrol.BillFormTmplConst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using xap.rui.engine.xactions;
using iih.ci.ord.opemergency.declare;

namespace iih.ci.ord.opemergency.action.ems
{
    /// <summary>
    /// <para>描    述 :                     			</para>
    /// <para>说    明 :                     			</para>
    /// <para>项目名称 :  iih.ci.ord.opemergency.action.ems    </para>    
    /// <para>类 名 称 :  EmsDeleteExpAction					</para> 
    /// <para>版 本 号 :  v1.0.0.0           			</para> 
    /// <para>作    者 :  qzwang         				</para> 
    /// <para>修 改 人 :  qzwang         				</para> 
    /// <para>创建时间 :  10/17/2016 11:12:45 AM             </para>
    /// <para>更新时间 :  10/17/2016 11:12:45 AM             </para> 
    /// <para>Copyright @ 北大医信（IIH项目组） 2016. All rights reserved.</para> 
    /// </summary>
    public class EmsDeleteExpAction : XBroadcastAction
    {
        public EmsDeleteExpAction()
            : base(EventCodeType.EVENT_HOTKEY_EXP_DELETE, "EmsDeleteExpAction", Keys.None, "医疗单删除费用项", "医疗单删除费用项")
        { }
    
    }
}
