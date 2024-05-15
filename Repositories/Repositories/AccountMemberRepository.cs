using DataAccessLayer;
using DataAccessLayer.DAOs;
using BusinessObjects.Models;
using Repositories.Abstractions;

namespace Repositories.Repositories;

public class AccountMemberRepository : IAccountMemberRepository
{
    public AccountMember? GetAccountMemberByEmail(string email) => AccountMemberDAO.GetAccountMemberByEmail(email);
}