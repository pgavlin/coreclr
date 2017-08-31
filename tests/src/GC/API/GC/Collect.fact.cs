using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect_Collect_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Collect_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect\\Collect.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
