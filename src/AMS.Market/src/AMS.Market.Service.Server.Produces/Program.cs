// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Market.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Hosting;

namespace Undersoft.AMS.Market.Service.Server.Produces;

/// <summary>
/// The program.
/// </summary>
public class Program
{
    static IServerHost? server;

    /// <summary>
    /// Application entry method
    /// </summary>
    /// <param name="args">The args.</param>
    public static void Main(string[] args)
    {
        Launch();
    }

    /// <summary>
    /// Launch serwer host
    /// </summary>
    public static void Launch()
    {
        try
        {
            Log.Info<Runlog>(null, "Starting Undersoft.AMS.Market.Service.Server.Produces ....");

            StartServer();
        }
        catch (Exception exception)
        {
            Log.Error<Runlog>(null, "Undersoft.AMS.Market.Service.Server.Produces terminated unexpectedly ....", exception);
        }
        finally
        {
            Log.Info<Runlog>(null, "Undersoft.AMS.Market.Service.Server.Produces shutted down ....");
        }
    }
    /// <summary>
    /// Restarts this instance.
    /// </summary>
    public static void Restart()
    {
        Log.Info<Runlog>(null, "Restarting Undersoft.AMS.Market.Service.Server.Produces ....");

        Shutdown();
        Launch();
    }

    /// <summary>
    /// Shuts down this instance.
    /// </summary>
    public static void Shutdown()
    {
        Log.Info<Runlog>(null, "Shutting down Undersoft.AMS.Market.Service.Server.Produces ....");

        server?.Host.StopAsync(TimeSpan.FromSeconds(5)).Wait();
    }

    private static void StartServer()
    {
        server = new ServerHost();
        server.Run<Setup>();
    }
}
