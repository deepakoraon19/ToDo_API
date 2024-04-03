using Microsoft.EntityFrameworkCore;
using ToDo_API.Models;
using ToDo_API.ViewModels;

namespace ToDo_API.Services;

public class UserService
{
    private readonly TODOContext ctx;
    public UserService(TODOContext ctx) => this.ctx = ctx;

    public async Task<string> Delete(string id)
    {
        var guidID = Guid.Parse(id);
        var dm = await ctx.Users.SingleOrDefaultAsync(p => p.userId == guidID).ConfigureAwait(false);
        if (dm == null)
            return "Not Found";
        else
        {
            ctx.Users.Remove(dm);
            await ctx.SaveChangesAsync();
            return "Sucessfully deleted.";
        }
    }

    public List<Users> Get() => ctx.Users.Select(p => Mapper.MapToVM(p)).ToList();

    public async Task<string> Add(Users user)
    {
        user.LastUpdatedOn = DateTime.UtcNow;
        var dm = Mapper.MapToDM(user);
        await ctx.Users.AddAsync(dm);
        await ctx.SaveChangesAsync();
        await ctx.SaveChangesAsync();
        return dm.userId.ToString();
    }

    public async Task<string> Update(Users user)
    {
        user.LastUpdatedOn = DateTime.UtcNow;
        var dm = Mapper.MapToDM(user);
        await ctx.Users.AddAsync(dm);
        await ctx.SaveChangesAsync();
        await ctx.SaveChangesAsync();
        return dm.userId.ToString();
    }
}
