﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MineCase.Server.Game
{
    /// <summary>
    /// 具有权限者接口
    /// </summary>
    public interface IPermissible
    {
        /// <summary>
        /// 判断是否具有特定的权限
        /// </summary>
        /// <param name="permission">要判断的权限</param>
        bool HasPermission(Permission permission);
    }
}
