#pragma once

namespace DbEngine
{

    class Blob
    {
    public:
        Blob() {}
        ~Blob();

        Blob(const Blob &other);
        Blob(const Blob &&other);

        char *Raw();
        void Create(size_t size);
        void Resize(size_t newSize);
        size_t GetSize();
        void Dispose();

    private:
        void *m_data = nullptr;
        size_t m_size;
    };

}