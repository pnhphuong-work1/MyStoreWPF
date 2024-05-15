using DataAccessLayer;
using DataAccessLayer.DAOs;
using DataAccessLayer.Models;
using Repositories.Abstractions;

namespace Repositories.Repositories;

public class AccountMemberRepository : IAccountMemberRepository
{
    public AccountMember? GetAccountMemberById(string accountId) 
        => AccountMemberDAO.GetAccountMemberById(accountId);
}