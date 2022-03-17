#pragma once
#include "Core.hpp"
#include <string>
#include "Table.hpp"

namespace DbEngine
{
    class DataBase
    {
    public:
        DataBase();
        ~DataBase();
        static void SetDataCatalog(const wchar_t * path);

        void Open(const std::string& name);
        void Close();

        void AddTable(Ref<Table> table);


    private:
    };

}
