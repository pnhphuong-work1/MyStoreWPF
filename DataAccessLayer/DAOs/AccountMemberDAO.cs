using BusinessObjects.Models;

namespace DataAccessLayer.DAOs;

public class AccountMemberDAO
{
    public static AccountMember? GetAccountMemberByEmail(string email)
    {
        using var context = new MyStoreContext();
        return context.AccountMembers.FirstOrDefault(a => a.EmailAddress.Equals(email));
    }
}