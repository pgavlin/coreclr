using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_TimerCallback_tighttimercallback_tighttimercallback_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TimerCallback_tighttimercallback_tighttimercallback_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\TimerCallback\\tighttimercallback\\tighttimercallback.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
