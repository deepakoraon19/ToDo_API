using DM = ToDo_API.Models;
using VM = ToDo_API.ViewModels;

public static class Mapper
{
    static public DM.User MapToDM(VM.Users vm) => new()
    {
        dateOfBirth = vm.DateOfBirth,
        lastUpdatedOn = vm.LastUpdatedOn,
        name = vm.Name,
        profilePic = vm.ProfilePic,
        password = vm.Password,
    };

    static public VM.Users MapToVM(DM.User dm) => new()
    {
        DateOfBirth = dm.dateOfBirth,
        LastUpdatedOn = dm.lastUpdatedOn,
        Name = dm.name,
        ProfilePic = dm.profilePic,
        UserId = dm.userId,
        Password = dm.password,
    };
}
