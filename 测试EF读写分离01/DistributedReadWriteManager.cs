using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 测试EF读写分离01
{
    /// <summary>
    /// redis配置信息加载
    /// </summary>
    internal class DistributedReadWriteManager
    {
        /// <summary>
        /// 配置信息实体
        /// </summary>
        public static IList<DistributedReadWriteSection> Instance
        {
            get
            {
                return GetSection();
            }
        }

        private static IList<DistributedReadWriteSection> GetSection()
        {
            var dic = ConfigurationManager.GetSection("DistributedReadWriteSection") as Dictionary<string, DistributedReadWriteSection>;
            return dic.Values.ToList();
        }
    }
}
