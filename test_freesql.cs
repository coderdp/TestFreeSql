//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace TestFreeSql
{

    [JsonObject(MemberSerialization.OptIn)]
    public partial class test_freesql
    {

        /// <summary>
        /// 主键自增id
        /// </summary>
        [JsonProperty, Column(IsPrimary = true)]
        public int id { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonProperty, Column(DbType = "varchar(128)")]
        public string user_name { get; set; }


        #region 外键 => 导航属性，ManyToMany

        #endregion
    }

}
