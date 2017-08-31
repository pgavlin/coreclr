using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _FinalizeTimeout_FinalizeTimeout_FinalizeTimeout_
    {
        [Fact]
        public void _FinalizeTimeout_FinalizeTimeout_FinalizeTimeout_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\FinalizeTimeout\\FinalizeTimeout\\FinalizeTimeout.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
