#pragma once
#include <string>
#include <unordered_map>
#include "Core.hpp"
#include "Blob.hpp"

namespace DbEngine
{
    enum class DbType
    {
        None = 0,
        Inteager,
        Float
        // varchar
    };

    struct EntityData
    {
        DbType type;
    };

    class Record
    {
    public:
        Record() {}
        ~Record() {}

        size_t GetSize() const;

        void Set( const std::string column, size_t size, void* data);

    private:
        std::unordered_map<std::string, EntityData> m_fields;
        Blob m_data;
    };

}