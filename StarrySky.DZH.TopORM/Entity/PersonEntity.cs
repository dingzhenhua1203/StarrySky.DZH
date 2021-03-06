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
    [TableInfo("Person", DBTypeEnum.MySQL)]
    public class PersonEntity
    {
        [PrimaryKey]
        public long PId { get; set; }

        public string PName { get; set; }

        public int PSex { get; set; }

        public int PRowStatus { get; set; }

        public DateTime PCreateTime { get; set; }

        public string PCreateUser { get; set; }

        public DateTime PUpdateTime { get; set; }

        public string PUpdateUser { get; set; }

        [IgnoreField]
        public string PAddress { get; set; }
    }
}
