using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_mathf_MathFAcos_MathFAcos_
    {
        [OuterLoop]
        [Fact]
        public void _system_mathf_MathFAcos_MathFAcos_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\mathf\\MathFAcos\\MathFAcos.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
