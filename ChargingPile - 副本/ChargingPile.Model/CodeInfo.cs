﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChargingPile.Model
{
    public class CodeInfo
    {

        /// <summary>
        /// 唯一id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 上级编码
        /// </summary>
        public string Parentid { get; set; }
        /// <summary>
        /// 应用系统Id
        /// </summary>
        public string Appid { get; set; }

        /// <summary>
        /// 基础编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 编码名称
        /// </summary>
        public string Codename { get; set; }

        /// <summary>
        /// 编码说明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 排序序号
        /// </summary>
        public decimal? Sortno { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateDT { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateDT { get; set; }
    }
}
