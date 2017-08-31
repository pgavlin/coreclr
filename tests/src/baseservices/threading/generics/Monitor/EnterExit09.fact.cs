using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _generics_Monitor_EnterExit09_EnterExit09_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Monitor_EnterExit09_EnterExit09_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\generics\\Monitor\\EnterExit09\\EnterExit09.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
