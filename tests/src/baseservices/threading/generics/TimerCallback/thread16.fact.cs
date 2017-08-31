using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_TimerCallback_thread16_thread16_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TimerCallback_thread16_thread16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\TimerCallback\\thread16\\thread16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
