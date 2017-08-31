using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_Monitor_EnterExit02_EnterExit02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_EnterExit02_EnterExit02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\EnterExit02\\EnterExit02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
