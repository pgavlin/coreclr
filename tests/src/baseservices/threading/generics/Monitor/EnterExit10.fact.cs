using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_Monitor_EnterExit10_EnterExit10_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_EnterExit10_EnterExit10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\EnterExit10\\EnterExit10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
