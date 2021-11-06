using MicroServiceEduDocumentGenerator.Domain.Model;
using MicroServiceEduDocumentGenerator.Persistence.FileHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduDocumentGenerator.Application.Service
{
    public class FileService : IFileService
    {
        private readonly IFileWriter _FileWriter;
        public FileService(IFileWriter fileWriter)
        {
            _FileWriter = fileWriter;
        }
        public void ExportToFile(Order order)
        {
            _FileWriter.WriteFile(order);
        }
    }
}
