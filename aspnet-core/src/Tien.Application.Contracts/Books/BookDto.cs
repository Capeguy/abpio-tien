using System;
using Volo.Abp.Application.Dtos;

namespace Tien.Dtos
{
    public class BookDto : AuditedEntityDto<long>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public string Genre { get; set; }
        public string Price { get; set; }
    }
}
