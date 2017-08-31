using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_Monitor_EnterExit08_EnterExit08_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_EnterExit08_EnterExit08_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\EnterExit08\\EnterExit08.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
