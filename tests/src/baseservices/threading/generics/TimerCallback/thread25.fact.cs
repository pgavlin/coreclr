using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_TimerCallback_thread25_thread25_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TimerCallback_thread25_thread25_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\TimerCallback\\thread25\\thread25.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
