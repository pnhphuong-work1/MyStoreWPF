using DataAccessLayer.Models;

namespace Repositories.Abstractions;

public interface IAccountMemberRepository
{
    AccountMember? GetAccountMemberById(string accountId);
}