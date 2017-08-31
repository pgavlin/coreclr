using CoreclrTestLib;
using Xunit;

namespace tracing_eventsourcesmoke
{
    class _eventsourcesmoke_eventsourcesmoke_
    {
        [Fact]
        public void _eventsourcesmoke_eventsourcesmoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("tracing\\eventsourcesmoke\\eventsourcesmoke\\eventsourcesmoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
