﻿namespace Framework.AuthHelper;

// role name bayad az db khande shavad
public static class Roles
{
    public const string Administator = "1";
    public const string SystemUser = "2";
    public const string ContentUploader = "3";
    public const string ColleagueUser = "4";

    public static string GetRoleBy(long id)
    {
        switch (id)
        {
            case 1:
                return "مدیر سیستم";
            case 3:
                return "محتوا گذار";
            default:
                return "";
        }
    }
}
