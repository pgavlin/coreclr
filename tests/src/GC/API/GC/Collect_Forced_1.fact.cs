using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect_Forced_1_Collect_Forced_1_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Forced_1_Collect_Forced_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Forced_1\\Collect_Forced_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
