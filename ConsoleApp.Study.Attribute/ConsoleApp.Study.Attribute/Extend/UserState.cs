using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Attribute.Extend
{
    public enum UserState
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Remark("正常1")]
        Normal = 0,

        /// <summary>
        /// 已冻结
        /// </summary>
        [Remark("已冻结1")]
        Frozen = 1,

        /// <summary>
        /// 已删除
        /// </summary>
        [Remark("已删除1")]
        Deleted = 2
    }
}
