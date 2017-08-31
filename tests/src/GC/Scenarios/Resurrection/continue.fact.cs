using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Resurrection_continue_continue_
    {
        [Fact]
        public void _Resurrection_continue_continue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Resurrection\\continue\\continue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
