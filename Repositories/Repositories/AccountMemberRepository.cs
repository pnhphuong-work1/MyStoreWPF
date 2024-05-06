using DataAccessLayer;
using DataAccessLayer.Models;
using Repositories.Abstractions;

namespace Repositories.Repositories;

public class AccountMemberRepository : RepositoryBase<AccountMember, string>, IAccountMemberRepository
{
    public AccountMemberRepository(MyStoreContext myStoreContext) : base(myStoreContext)
    {
    }
}