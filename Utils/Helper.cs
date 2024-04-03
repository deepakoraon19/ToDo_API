using ToDo_API.Models;

namespace ToDo_API.Utils;

public static class Helper
{
    public static async Task<Reply> CreateReply<T>(Func<Task<T?>> function)
    {
        Reply res = new();
        try
        {
            var x = await function().ConfigureAwait(false);
            res.Value = x.ToString();
        }
        catch (Exception e)
        {
            res.Error = e.Message;
        }
        return res;
    }

}
