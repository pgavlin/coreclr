using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect_neg_Collect_neg_
    {
        [Fact]
        public void _GC_Collect_neg_Collect_neg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_neg\\Collect_neg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
