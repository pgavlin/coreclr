using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_mathf_MathFAbs_MathFAbs_
    {
        [OuterLoop]
        [Fact]
        public void _system_mathf_MathFAbs_MathFAbs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\mathf\\MathFAbs\\MathFAbs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
