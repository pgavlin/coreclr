using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_c_initblk_ldc_c_initblk_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_c_initblk_ldc_c_initblk_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_c_initblk\\ldc_c_initblk.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
