using BusinessObjects.Models;

namespace Services.Abstractions;

public interface IAccountMemberService
{
    AccountMember? getAccountMemberByEmail(string email);
}