using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_TimerCallback_thread30_thread30_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TimerCallback_thread30_thread30_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\TimerCallback\\thread30\\thread30.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
