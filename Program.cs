using FreeSql;
using System;
using System.Collections.Generic;

namespace TestFreeSql
{
    class Program
    {
        static void Main(string[] args)
        {
            /* sql 脚本如下
               CREATE TABLE `test_freesql` (
              `id` int(11) NOT NULL COMMENT '主键自增id',
              `user_name` varchar(128) NOT NULL DEFAULT '' COMMENT '操作人',
              PRIMARY KEY (`id`)
            ) ENGINE=InnoDB DEFAULT CHARSET=utf8
             */
            var conn = "server=ip;port=port;user id=username;password=password;persistsecurityinfo=True;database=database;SslMode=none;ConvertZeroDatetime=true";
            MultiFreeSql fsql = new MultiFreeSql();

            fsql.Register("db_1", () => new FreeSqlBuilder().UseConnectionString(DataType.MySql, conn).UseAutoSyncStructure(false).Build());

            var list = new List<test_freesql>()
            {
                new test_freesql{id=1, user_name=null }
            };

            fsql.Change("db_1");

            var repo = fsql.GetRepository<test_freesql>();

            //list 只有一条数据会提示 user_name 不能为空，但是>1 条记录时会正常插入
            repo.Insert(list);

            Console.WriteLine("插入成功");
            Console.ReadLine();
        }
    }
}
