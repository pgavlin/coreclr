using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _RanCollect_rancollect_rancollect_
    {
        [Fact]
        public void _RanCollect_rancollect_rancollect_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\RanCollect\\rancollect\\rancollect.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
