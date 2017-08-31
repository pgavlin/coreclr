using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _inlining_dev10_bug719093_variancesmall_variancesmall_
    {
        [OuterLoop]
        [Fact]
        public void _inlining_dev10_bug719093_variancesmall_variancesmall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\inlining\\dev10_bug719093\\variancesmall\\variancesmall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
