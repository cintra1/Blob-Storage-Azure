using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azureBlobStorage.Controllers
{
    public class BlobDto
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Uri { get; set; }
    }
}