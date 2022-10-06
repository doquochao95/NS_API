using NeedleController.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using WinFormsMvp.Binder;
using WinFormsMvp.Unity;
using Infralution.Localization;
using System.Globalization;
using System.Configuration;
using Serilog.Sinks.MSSqlServer;
using Serilog;
using Serilog.Sinks.File;
using Serilog.Events;
using System.Threading;
using System.Collections.ObjectModel;
using System.Data;

namespace NeedleController
{
    public static class Program
    {
        private static string _connectionString = "data source=10.4.2.23;initial catalog=_NEEDLE_SUPPLIER_;user id=sa;password=shc@1234;multipleactiveresultsets=True";

        private const string _schemaName = "dbo";
        private const string _tableName = "LogEvents";
        public static int DeviceID { get; set; } = 2;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            const string Path = "LogFile\\log.txt";
            var columnOption = new ColumnOptions();
            columnOption.Store.Remove(StandardColumn.MessageTemplate);
            columnOption.Id.ColumnName = "LogId";
            columnOption.Level.ColumnName = "LogType";
            columnOption.AdditionalColumns = new Collection<SqlColumn>
            {
                new SqlColumn
                    {ColumnName = "MassageString", DataType = SqlDbType.NVarChar },
                new SqlColumn
                    {ColumnName = "DeviceID", DataType = SqlDbType.NVarChar}
            };

            Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File(Path,
                        rollingInterval: RollingInterval.Day,
                        rollOnFileSizeLimit: true)
                    .WriteTo.MSSqlServer(
                        connectionString: _connectionString,
                        sinkOptions: new MSSqlServerSinkOptions
                        {
                            TableName = _tableName,
                            SchemaName = _schemaName,
                            AutoCreateSqlTable = true
                        },
                        restrictedToMinimumLevel: LogEventLevel.Debug,
                        formatProvider: null,
                        columnOptions: columnOption,
                        logEventFormatter: null)
                    .CreateLogger();
            Logger.Debug("Getting started");
            CultureManager.ApplicationUICulture = CultureInfo.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
            Log.CloseAndFlush();
        }
    }
    public static class Logger
    {
        public static void Information(string MassageString, int device_id)
        {
            Log.Information("{MassageString}{DeviceID}", MassageString, device_id);
        }

        public static void Verbose(string MassageString, int device_id)
        {
            Log.Verbose("{MassageString}{DeviceID}", MassageString, device_id);
        }

        public static void Debug(string MassageString, int device_id)
        {
            Log.Debug("{MassageString}{DeviceID}", MassageString, device_id);
        }
        public static void Debug(string MassageString)
        {
            Log.Debug("{MassageString}", MassageString);
        }
        public static void Error(string MassageString, int device_id)
        {
            Log.Error("{MassageString}{DeviceID}", MassageString, device_id);
        }
    }
}
