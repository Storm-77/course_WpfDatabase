#include "Blob.hpp"
#include <cstdlib>
#include <cstdint>
#include <cstring>

namespace DbEngine
{
    Blob::~Blob()
    {
        Dispose();
    }

    Blob::Blob(const Blob &other)
    {
        m_data = other.m_data;
        m_size = other.m_size;
    }

    Blob::Blob(const Blob &&other)
    {
        m_data = other.m_data;
        m_size = other.m_size;
    }

    char *Blob::Raw()
    {
        return reinterpret_cast<char *>(m_data);
    }

    void Blob::Create(size_t size)
    {
        if (m_data == nullptr)
            m_data = malloc(size);
    }

    void Blob::Resize(size_t newSize)
    {
        if (newSize <= m_size)
            return;

        void *newBlock = malloc(newSize);
        std::memcpy(newBlock, m_data, m_size);
        free(m_data);
        m_data = newBlock;
        m_size = newSize;
    }

    size_t Blob::GetSize()
    {
        return m_size;
    }

    void Blob::Dispose()
    {
        free(m_data);
        m_data = nullptr;
    }
}