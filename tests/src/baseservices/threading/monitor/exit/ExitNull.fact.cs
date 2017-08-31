using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_exit_ExitNull_ExitNull_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_exit_ExitNull_ExitNull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\exit\\ExitNull\\ExitNull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
