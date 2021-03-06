﻿using System;

namespace SiteServer.Plugin.Hooks
{
    public interface IPageAdmin: IHooks
    {
        //
        // 摘要:
        //     在回发数据已加载到页服务器控件之后但在 System.Web.UI.Control.OnLoad(System.EventArgs) 事件之前，引发 System.Web.UI.Page.PreLoad
        //     事件。
        //
        // 参数:
        //   e:
        //     一个 System.EventArgs，其中包含事件数据。
        void OnPreLoad(EventArgs e);

        //
        // 摘要:
        //     在页加载阶段结束时引发 System.Web.UI.Page.LoadComplete 事件。
        //
        // 参数:
        //   e:
        //     一个 System.EventArgs，其中包含事件数据。
        void OnLoadComplete(EventArgs e);
    }
}
