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
        public ILog log;
        public Logger2(O_LogType o_logType, ILog log)
        {
            this.o_logType = o_logType;
            this.log = log;
        }

        public void LogKayit(O_LogType typ, string msg)
        {
            switch (typ)
            {
                case O_LogType.Xml:
                    log.LogYaz(msg);
                    break;
                case O_LogType.Db:
                    log.LogYaz(msg);
                    break;
                case O_LogType.Json:
                    log.LogYaz(msg);
                    break;
            }

        }
    }
}
