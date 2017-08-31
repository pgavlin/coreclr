using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_Monitor_EnterExit11_EnterExit11_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_EnterExit11_EnterExit11_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\EnterExit11\\EnterExit11.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
