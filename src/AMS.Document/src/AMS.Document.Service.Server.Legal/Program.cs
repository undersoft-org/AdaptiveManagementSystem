// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.AMS.Document.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Server.Hosting;

namespace Undersoft.AMS.Document.Service.Server.Legal;

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
            Log.Info<Runlog>(null, "Starting Undersoft.AMS.Document.Service.Server.Legal ....");

            StartServer();
        }
        catch (Exception exception)
        {
            Log.Error<Runlog>(null, "Undersoft.AMS.Document.Service.Server.Legal terminated unexpectedly ....", exception);
        }
        finally
        {
            Log.Info<Runlog>(null, "Undersoft.AMS.Document.Service.Server.Legal shutted down ....");
        }
    }
    /// <summary>
    /// Restarts this instance.
    /// </summary>
    public static void Restart()
    {
        Log.Info<Runlog>(null, "Restarting Undersoft.AMS.Document.Service.Server.Legal ....");

        Shutdown();
        Launch();
    }

    /// <summary>
    /// Shuts down this instance.
    /// </summary>
    public static void Shutdown()
    {
        Log.Info<Runlog>(null, "Shutting down Undersoft.AMS.Document.Service.Server.Legal ....");

        server?.Host.StopAsync(TimeSpan.FromSeconds(5)).Wait();
    }

    private static void StartServer()
    {
        server = new ServerHost();
        server.Run<Setup>();
    }
}
