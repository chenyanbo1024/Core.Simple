using Core.IServices;
using Core.Models;
using Core.Models.Model;
using Core.Services.Base;

namespace Core.Services;

public class UserServices : BaseServices<User>, IUserServices
{
    private readonly CoreContext _context;
    public UserServices(CoreContext context)
        :base(context)
    {
        _context = context;
    }
}
