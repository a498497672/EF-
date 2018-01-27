using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 测试EF读写分离01
{
    /// <summary>
    /// DistributedReadWriteForEFSection块，在web.config中提供DistributedReadWriteForEFSection块定义
    /// </summary>
    internal class DistributedReadWriteSection : ConfigurationSection
    {
        /// <summary>
        /// 主机地址
        /// </summary>
        [ConfigurationProperty("Ip", DefaultValue = "192.168.13.70")]
        public string Ip
        {
            get { return (string)this["Ip"]; }
            set { this["Ip"] = value; }
        }
        /// <summary>
        /// 端口号
        /// </summary>
        [ConfigurationProperty("Port", DefaultValue = "1433")]
        public int Port
        {
            get { return (int)this["Port"]; }
            set { this["Port"] = value; }
        }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [ConfigurationProperty("DbName", DefaultValue = "YTS_TicketDB")]
        public string DbName
        {
            get { return (string)this["DbName"]; }
            set { this["DbName"] = value; }
        }

        /// <summary>
        /// 数据库账号
        /// </summary>
        [ConfigurationProperty("UserId", DefaultValue = "sa")]
        public string UserId
        {
            get { return (string)this["UserId"]; }
            set { this["UserId"] = value; }
        }

        /// <summary>
        /// 数据库账号
        /// </summary>
        [ConfigurationProperty("Password", DefaultValue = "nyl000000")]
        public string Password
        {
            get { return (string)this["Password"]; }
            set { this["Password"] = value; }
        }
    }
}
