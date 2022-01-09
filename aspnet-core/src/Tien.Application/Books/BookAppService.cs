using System;
using Tien.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Tien.Books
{
    public class BookAppService :
       CrudAppService<
           Book, //The Book entity
           BookDto, //Used to show books
           long, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateBookDto>, //Used to create/update a book
       IBookAppService //implement the IBookAppService
    {
        public BookAppService(IRepository<Book, long> repository)
            : base(repository)
        {
        }
    }
}
