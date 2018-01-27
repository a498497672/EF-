using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 测试EF读写分离01
{
    class Program
    {
        static void Main(string[] args)
        {
            DbInterception.Add(new CommandInterceptor());

            TicketDbContext db = new TicketDbContext();

            var ticket = db.Tbl_Ticket.First();

            Thread.Sleep(1000);

            db.Tbl_Ticket.First();
            Thread.Sleep(1000);
            db.Tbl_Ticket.First();
            Thread.Sleep(1000);
            db.Tbl_Ticket.First();
            Thread.Sleep(1000);
            db.Tbl_Ticket.First();
            Thread.Sleep(1000);
            db.Tbl_Ticket.First();
            Thread.Sleep(1000);
            db.Tbl_Ticket.First();



            Console.ReadKey();
        }
    }
}
