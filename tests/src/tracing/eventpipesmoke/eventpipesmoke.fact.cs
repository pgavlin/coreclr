using CoreclrTestLib;
using Xunit;

namespace tracing_eventpipesmoke
{
    class _eventpipesmoke_eventpipesmoke_
    {
        [OuterLoop]
        [Fact]
        public void _eventpipesmoke_eventpipesmoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("tracing\\eventpipesmoke\\eventpipesmoke\\eventpipesmoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
