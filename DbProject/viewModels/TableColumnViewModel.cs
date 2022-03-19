using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.viewModels
{
    public enum FieldType
    {
        Integer,
        Text,
        Blob,
        Real
    };

    class TableColumnViewModel : ViewModelBase
    {
        private string m_name;
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
                this.OnPropertyChanged(nameof(Name));
            }
        }

        private FieldType m_type;
        public FieldType Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type= value;
                this.OnPropertyChanged(nameof(Type));
            }
        }

        private bool m_notNull;
        public bool NotNull
        {
            get
            {
                return m_notNull;
            }
            set
            {
                m_notNull = value;
                this.OnPropertyChanged(nameof(NotNull));
            }
        }

        private bool m_autoIncrement;
        public bool AutoIncrement
        {
            get
            {
                return m_autoIncrement;
            }
            set
            {
                m_autoIncrement = value;
                this.OnPropertyChanged(nameof(AutoIncrement));
            }
        }

        private bool m_primaryKey;
        public bool PrimaryKey
        {
            get
            {
                return m_primaryKey;
            }
            set
            {
                m_primaryKey = value;
                this.OnPropertyChanged(nameof(PrimaryKey));
            }
        }
    }
}
