using Radore_OOP.Solid.kotu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Odevler.Odev3
{
    public class Logger2
    {
        public O_LogType o_logType;
        public O_ILog o_log;
        public Logger2(O_LogType o_logType, O_ILog o_log)
        {
            this.o_logType = o_logType;
            this.o_log = o_log;
        }

        public void LogKayit(O_LogType typ, string msg)
        {
            switch (typ)
            {
                case O_LogType.Xml:
                    o_log.LogYaz(msg);
                    break;
                case O_LogType.Db:
                    o_log.LogYaz(msg);
                    break;
                case O_LogType.Json:
                    o_log.LogYaz(msg);
                    break;
            }

        }
    }
}
