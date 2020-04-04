using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Reface.AppStarter.Demo.FileStorage
{
    [Component]
    public class DefaultFileStorage<T> : IFileStorage<T>
        where T : IStorageData
    {
        private static List<T> list;

        private readonly ILogger logger;

        private string GetFileName()
        {
            return $"Storages/{typeof(T).FullName}.bin";
        }

        private void CreateDirIfNotExists()
        {
            DirectoryInfo dir = new DirectoryInfo("Storages");
            if (dir.Exists) return;
            dir.Create();
        }

        public DefaultFileStorage(ILogger logger)
        {
            this.logger = logger;
            this.logger.Warning("list is not null");
            if (list != null) return;
            FileInfo file = new FileInfo(GetFileName());
            if (!file.Exists)
            {
                this.logger.Warning("file is not exists");
                list = new List<T>();
                return;
            }
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (var stream = new FileStream(GetFileName(), FileMode.Open))
            {
                list = (List<T>)binaryFormatter.Deserialize(stream);
            }
            this.logger.Info("list inited");
        }

        private void SaveToFile()
        {
            if (list == null) return;

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            CreateDirIfNotExists();
            using (var stream = new FileStream(GetFileName(), FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(stream, list);
            }
            this.logger.Info("save to file success");
        }

        public void Delete(Func<T, bool> filter)
        {
            list = list.Where(x => !filter(x)).ToList();
            SaveToFile();
        }

        public void Insert(T value)
        {
            list.Add(value);
            SaveToFile();
        }

        public List<T> Select(Func<T, bool> filter)
        {
            return list.Where(filter)
                .Select(x => x.Copy())
                .Cast<T>().ToList();
        }

        public void Update(Func<T, bool> filter, Action<T> updator)
        {
            foreach (var data in list)
            {
                if (!filter(data)) continue;
                updator(data);
            }
            SaveToFile();
        }

        public void Clear()
        {
            if (!File.Exists(GetFileName())) return;
            File.Delete(GetFileName());
            this.logger.Warning("Clear");
        }
    }
}
