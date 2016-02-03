using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace web_api_owin.Middlewares
{
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class Timestamp
    {
        private readonly AppFunc next;
        public Timestamp(AppFunc next)
        {
            this.next = next;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            var stopwatch = Stopwatch.StartNew();
            var scope = (IDictionary<string, string[]>)environment["owin.ResponseHeaders"];
            await this.next(environment);
            stopwatch.Stop();
            scope.Add("ResponseTime", new[] { stopwatch.Elapsed.ToString() });
        }
    }
}