using DataAccessLayer.Models;

namespace DataAccessLayer.DAOs;

public class AccountMemberDAO
{
    public static AccountMember? GetAccountMemberById(string accountId)
    {
        using var context = new MyStoreContext();
        return context.AccountMembers.FirstOrDefault(a => a.MemberId.Equals(accountId));
    }
}