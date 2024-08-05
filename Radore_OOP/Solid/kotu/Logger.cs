﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Solid.kotu
{
    public class Logger
    {
        public DbLog dbLog;
        public XmlLog xmlLog;
        public JsonLog jsonLog; // bunu ekleyerek solid prensiplerinden open-closed prensibine aykırılık
        public Logger(DbLog dbLog, XmlLog xmlLog, JsonLog jsonLog)
        {
            this.dbLog = dbLog;
            this.xmlLog = xmlLog;
            this.jsonLog = jsonLog;
        }

        public void LogKaydet(LogType type, string message)
        {
            switch (type)
            {
                case LogType.Xml:
                    xmlLog.xmlKayit(message);
                    break;
                case LogType.Db:
                    dbLog.dbKayit(message);
                    break;
                case LogType.Json:
                    jsonLog.JsonYaz(message);
                    break;
            }
        }
    }
}
