﻿namespace Options
{
    public enum TypeModules
    {
        LogUser = 1,
        Principal = 2,
        Users = 3,
        Moves = 4,
        Stats = 5,
        Binnacle = 6,
        Import = 7,
        Configuration = 8
    }

    public enum TypeSession
    {
        LogIn = 1,
        LogOut = 2
    }

    public enum TypeSearch //No cambiar las posiciones
    {
        Users = 1,
        Admin = 2,
        Moves = 3
    }

    public enum TypeIcon
    {
        Info = 1,
        Warning = 2,
        Danger = 3
    }
}