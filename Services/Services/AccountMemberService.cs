using DataAccessLayer.Models;
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

    public AccountMember? getAccountMemberById(string accountId)
    {
        return _iAccountMemberRepository.GetAccountMemberById(accountId);
    }
}