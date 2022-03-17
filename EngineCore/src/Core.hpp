#pragma once
#include <memory>

namespace DbEngine
{

    template <class T>
    using Ref = std::shared_ptr<T>;

    template <class T, class... _Args>
    inline Ref<T> MakeRef(_Args... args)
    {
        return std::make_shared<T>(args...);
    }

}