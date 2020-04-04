using System;
using System.Collections.Generic;

namespace Reface.AppStarter.Demo.FileStorage
{
    public interface IFileStorage<T>
        where T : IStorageData
    {
        void Insert(T value);
        void Update(Func<T, bool> filter, Action<T> updator);
        void Delete(Func<T, bool> filter);
        List<T> Select(Func<T, bool> filter);

        void Clear();
    }
}
