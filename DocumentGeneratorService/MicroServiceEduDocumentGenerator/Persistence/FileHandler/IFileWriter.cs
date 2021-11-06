using MicroServiceEduDocumentGenerator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduDocumentGenerator.Persistence.FileHandler
{
    public interface IFileWriter
    {
        public void WriteFile(Order order);
       
    }
}
