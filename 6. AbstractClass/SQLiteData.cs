using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class SQLiteData : AccessData
    {
        public override string DownloadData(string sql)
        {
            string output = base.DownloadData(sql);
            output += "(from SQL Lite)";
            return output;
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Carregando o arquivo...");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Arquivo Salvo!");
        }
    }
}
