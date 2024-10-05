// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Logging;
using Undersoft.SDK.Service.Application.Server.Hosting;

namespace Undersoft.AMS.Service.Application.Server;

public class Program
{

    static IApplicationServerHost? server;

    public static void Main(string[] args)
    {
        Launch();
    }

    public static void Launch()
    {
        try
        {
            Log.Info<Runlog>(null, "Starting Undersoft.AMS.Service.Application.Server ....");

            StartApplicationServer();
        }
        catch (Exception exception)
        {
            Log.Error<Runlog>(null, " Undersoft.AMS.Service.Application.Server terminated unexpectedly ....", exception);
        }
        finally
        {
            Log.Info<Runlog>(null, " Undersoft.AMS.Service.Application.Server shutted down ....");
        }
    }

    public static void Restart()
    {
        Log.Info<Runlog>(null, "Restarting  Undersoft.AMS.Service.Application.Server ....");

        Shutdown();
        Launch();
    }

    public static void Shutdown()
    {
        Log.Info<Runlog>(null, "Shutting down  Undersoft.AMS.Service.Application.Server ....");

        server?.Host.StopAsync(TimeSpan.FromSeconds(5)).Wait();
    }

    private static void StartApplicationServer()
    {
        server = new ApplicationServerHost();
        server.Run<Setup>();
    }
}
