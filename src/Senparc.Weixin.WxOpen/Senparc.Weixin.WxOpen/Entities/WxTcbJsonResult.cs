﻿using Senparc.Weixin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.WxOpen.Entities
{
    public class WxTcbJsonResult : WxJsonResult
    {
        /// <summary>
        /// 云函数返回的buffer
        /// </summary>
        public string resp_data { get; set; }
    }
}
