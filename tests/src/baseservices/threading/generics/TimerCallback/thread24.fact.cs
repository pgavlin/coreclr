using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_TimerCallback_thread24_thread24_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TimerCallback_thread24_thread24_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\TimerCallback\\thread24\\thread24.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
