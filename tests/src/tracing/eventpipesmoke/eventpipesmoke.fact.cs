using CoreclrTestLib;
using Xunit;

namespace tracing_eventpipesmoke
{
    public class _eventpipesmoke_eventpipesmoke_
    {
        [OuterLoop]
        [Fact]
        public void _eventpipesmoke_eventpipesmoke_cmd()
        {
            CoreclrTestWrapperLib.RunTest("tracing\\eventpipesmoke\\eventpipesmoke\\eventpipesmoke.cmd");
        }
    }
}
