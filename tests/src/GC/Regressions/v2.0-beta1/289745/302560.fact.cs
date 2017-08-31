using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    class _v2_0_beta1_289745_302560_302560_
    {
        [Fact]
        public void _v2_0_beta1_289745_302560_302560_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Regressions\\v2.0-beta1\\289745\\302560\\302560.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
