using DM = ToDo_API.Models;
using VM = ToDo_API.ViewModels;

static public class Mapper
{
    static public DM.User MapToDm(VM.Users vm) => new()
    {
        dateOfBirth = vm.DateOfBirth,
        lastUpdatedOn = vm.LastUpdatedOn,
        name = vm.Name,
        profilePic = vm.ProfilePic,
    };

    static public VM.Users MapToDm(DM.User vm) => new()
    {
        DateOfBirth = vm.dateOfBirth,
        LastUpdatedOn = vm.lastUpdatedOn,
        Name = vm.name,
        ProfilePic = vm.profilePic,
        UserId = vm.userId
    };
}
