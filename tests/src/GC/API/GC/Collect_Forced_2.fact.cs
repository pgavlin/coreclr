using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect_Forced_2_Collect_Forced_2_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Forced_2_Collect_Forced_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Forced_2\\Collect_Forced_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
