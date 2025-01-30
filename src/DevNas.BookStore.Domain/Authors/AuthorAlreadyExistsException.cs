using Volo.Abp;

namespace DevNas.BookStore.Authors
{
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
