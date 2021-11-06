using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using MicroServiceEduDocumentGenerator.Domain.Model;
using Newtonsoft.Json;

namespace MicroServiceEduDocumentGenerator.Persistence.FileHandler
{
    public class FileWriter : IFileWriter
    {
        public void WriteFile(Order order)
        {
            string fileName = $"{order.OrderNo}.json";
            string orderJson = JsonConvert.SerializeObject(order);

            string path = GetPath();
            var fullFileNameWithPath = Path.Combine(path, fileName);

            
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            File.WriteAllText(fullFileNameWithPath, orderJson);
        }
        private string GetPath()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var path = Path.Combine(currentDirectory, "Persistence", "Data");

            return path;
        }
    }
}
