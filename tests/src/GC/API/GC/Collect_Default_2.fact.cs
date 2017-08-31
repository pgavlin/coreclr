using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect_Default_2_Collect_Default_2_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Default_2_Collect_Default_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Default_2\\Collect_Default_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
