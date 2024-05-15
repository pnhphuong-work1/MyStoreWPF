using DataAccessLayer.Models;

namespace Services.Abstractions;

public interface IAccountMemberService
{
    AccountMember? getAccountMemberById(string accountId);
}