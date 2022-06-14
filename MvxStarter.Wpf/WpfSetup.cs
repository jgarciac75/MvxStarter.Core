using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Wpf.Core;
using Serilog;
using Serilog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvxStarter.Wpf
{
  public class WpfSetup : MvxWpfSetup<Core.App>
  {
    protected override ILoggerFactory CreateLogFactory()
    {

      // serilog configuration
      Log.Logger = new LoggerConfiguration()
          .MinimumLevel.Debug()
          .WriteTo.Trace()
          .CreateLogger();

      return new SerilogLoggerFactory();

    }

    protected override ILoggerProvider CreateLogProvider()
    {

      return new SerilogLoggerProvider();
    }
  }
}
