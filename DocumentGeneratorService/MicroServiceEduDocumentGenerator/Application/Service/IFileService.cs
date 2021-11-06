using MicroServiceEduDocumentGenerator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduDocumentGenerator.Application.Service
{
    public interface IFileService
    {
        public void ExportToFile(Order order);
    }
}
