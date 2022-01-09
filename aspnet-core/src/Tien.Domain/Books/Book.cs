using Volo.Abp.Domain.Entities.Auditing;

namespace Tien.Books
{
    public class Book : AuditedAggregateRoot<long>
    {
        public string Title { get; set; }
        public string Author { get; set;}
        public string Isbn { get; set;}
        public string Genre { get;set ;}
        public string Price { get; set;}
    }
}
