using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.models
{
    public class TableColumnModel
    {
        public string name;
        public string type;
        public bool notNull;
        public bool autoIncrement;
        public bool primaryKey;
    }
}
