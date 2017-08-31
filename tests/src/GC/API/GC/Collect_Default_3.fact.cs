using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect_Default_3_Collect_Default_3_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Default_3_Collect_Default_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Default_3\\Collect_Default_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
