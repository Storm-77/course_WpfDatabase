#include "Record.hpp"

namespace DbEngine
{
    namespace Utils
    {

        static size_t DbSizeOf(DbType type)
        {
            switch (type)
            {
            case DbType::None:
                return 0;
                break;
            case DbType::Inteager:
                return sizeof(int);
                break;
            case DbType::Float:
                return sizeof(float);
                break;

            default:
                break;
            }
        }

    } // namespace Utils

    size_t Record::GetSize() const
    {
        size_t size = 0;

        for (auto &&i : m_fields)
        {
            auto type = i.second.type;
            size += Utils::DbSizeOf(type);
            // todo string type handling
        }
        return size;
    }
}