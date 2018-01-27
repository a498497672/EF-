using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 测试EF读写分离01
{
    class UsingNoMsdtc
    {
        //public static void UsingNoMsdtc(IUnitOfWork db, bool isOutest, Action action)
        //{
        //    var objectContext = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)db).ObjectContext;
        //    try
        //    {

        //        objectContext.Connection.Close();
        //        //强制将所有curd操作维持到主库
        //        Project.DistributedReadWriteForEF.CommandInterceptor.IsTransactionScope = true;
        //        //重新设置链接串
        //        if (System.Configuration.ConfigurationManager.AppSettings["writeDbConnection"] != null)
        //            objectContext.TransactionHandler.DbContext.Database.Connection.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["writeDbConnection"];

        //        objectContext.Connection.Open();

        //        using (TransactionScope trans = new TransactionScope())
        //        {
        //            action();
        //            trans.Complete();
        //            Project.DistributedReadWriteForEF.CommandInterceptor.IsTransactionScope = false;//事务结束将走读写分离
        //        }
        //    }
        //    finally
        //    {
        //        if (isOutest)//如果是最外层事务，再将连接关闭！内部事务与外部事务需要共用一个Connection的连接
        //            objectContext.Connection.Close(); //只能关闭,不能dispose,因为dispose之后,上下文就无法得到链接串了
        //    }
        //}
    }
}
