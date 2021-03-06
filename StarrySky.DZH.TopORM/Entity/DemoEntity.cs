﻿using StarrySky.DZH.TopORM.Common;
using StarrySky.DZH.TopORM.CustomAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarrySky.DZH.TopORM.Entity
{
    /// <summary>
    /// 不存表的字段加Ignore（不存or表没有） 否则报错MySql.Data.MySqlClient.MySqlException:“Unknown column 'xxx' in 'field list'”
    /// </summary>
    [TableInfo("Demo", DBTypeEnum.MySQL)]
    public class DemoEntity
    {
        [PrimaryKey]
        public long DId { get; set; }

        public string DName { get; set; }

        public int DSex { get; set; }

        public int DRowStatus { get; set; }

        public DateTime DCreateTime { get; set; }

        public string DCreateUser { get; set; }

        public DateTime DUpdateTime { get; set; }

        public string DUpdateUser { get; set; }

        [IgnoreField]
        public string DAddress { get; set; }
    }
}
