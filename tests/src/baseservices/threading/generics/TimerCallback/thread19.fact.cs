using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_TimerCallback_thread19_thread19_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TimerCallback_thread19_thread19_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\TimerCallback\\thread19\\thread19.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
