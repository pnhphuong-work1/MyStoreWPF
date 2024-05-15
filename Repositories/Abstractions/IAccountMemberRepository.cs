using BusinessObjects.Models;

namespace Repositories.Abstractions;

public interface IAccountMemberRepository
{
    AccountMember? GetAccountMemberByEmail(string email);
}