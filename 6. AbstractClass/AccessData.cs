using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class AccessData
    {
        public virtual string DownloadData(string sql)
        {
            Console.WriteLine("Fazendo o download do arquivo...");
            return "98%";
        }

        public abstract void LoadData(string sql);

        public abstract void SaveData(string sql);
    }
}
