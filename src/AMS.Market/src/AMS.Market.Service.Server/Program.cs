// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Market.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Hosting;

namespace Undersoft.AMS.Market.Service.Server;

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
            Log.Info<Runlog>(null, "Starting Undersoft.AMS.Market.Service.Server ....");

            StartServer();
        }
        catch (Exception exception)
        {
            Log.Error<Runlog>(null, "Undersoft.AMS.Market.Service.Server terminated unexpectedly ....", exception);
        }
        finally
        {
            Log.Info<Runlog>(null, "Undersoft.AMS.Market.Service.Server shutted down ....");
        }
    }

    public static void Restart()
    {
        Log.Info<Runlog>(null, "Restarting Undersoft.AMS.Market.Service.Server ....");

        Shutdown();
        Launch();
    }

    public static void Shutdown()
    {
        Log.Info<Runlog>(null, "Shutting down Undersoft.AMS.Market.Service.Server ....");

        server?.Host.StopAsync(TimeSpan.FromSeconds(5)).Wait();
    }

    private static void StartServer()
    {
        server = new ServerHost();
        server.Run<Setup>();
    }
}
