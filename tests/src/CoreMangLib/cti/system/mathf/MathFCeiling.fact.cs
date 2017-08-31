using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_mathf_MathFCeiling_MathFCeiling_
    {
        [OuterLoop]
        [Fact]
        public void _system_mathf_MathFCeiling_MathFCeiling_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\mathf\\MathFCeiling\\MathFCeiling.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
