// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Hosting;

namespace Undersoft.AMS.Service.Server;

public class Program
{
    static IServerHost? server;

    public static void Main(string[] args)
    {
        Launch();
    }

    public static void Launch()
    {
        try
        {
            Log.Info<Runlog>(null, "Starting Undersoft.AMS.Service.Server ....");

            StartServer();
        }
        catch (Exception exception)
        {
            Log.Error<Runlog>(null, "Undersoft.AMS.Service.Server terminated unexpectedly ....", exception);
        }
        finally
        {
            Log.Info<Runlog>(null, "Undersoft.AMS.Service.Server shutted down ....");
        }
    }
    /// <summary>
    /// Restarts this instance.
    /// </summary>
    public static void Restart()
    {
        Log.Info<Runlog>(null, "Restarting Undersoft.AMS.Service.Server ....");

        Shutdown();
        Launch();
    }

    /// <summary>
    /// Shuts down this instance.
    /// </summary>
    public static void Shutdown()
    {
        Log.Info<Runlog>(null, "Shutting down Undersoft.AMS.Service.Server ....");

        server?.Host.StopAsync(TimeSpan.FromSeconds(5)).Wait();
    }

    private static void StartServer()
    {
        server = new ServerHost();
        server.Run<Setup>();
    }
}
