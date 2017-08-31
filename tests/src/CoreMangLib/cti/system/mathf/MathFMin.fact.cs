using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_mathf_MathFMin_MathFMin_
    {
        [OuterLoop]
        [Fact]
        public void _system_mathf_MathFMin_MathFMin_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\mathf\\MathFMin\\MathFMin.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
