using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Boxing_arrcpy_arrcpy_
    {
        [Fact]
        public void _Boxing_arrcpy_arrcpy_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\arrcpy\\arrcpy.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
