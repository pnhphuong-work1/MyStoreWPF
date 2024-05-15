using BusinessObjects.Models;
using Repositories.Abstractions;
using Repositories.Repositories;
using Services.Abstractions;

namespace Services.Services;

public class AccountMemberService : IAccountMemberService
{
    private readonly IAccountMemberRepository _iAccountMemberRepository;
    public AccountMemberService()
    {
        _iAccountMemberRepository = new AccountMemberRepository();
    }

    public AccountMember? getAccountMemberByEmail(string email)
    {
        return _iAccountMemberRepository.GetAccountMemberByEmail(email);
    }
}