using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_mathf_MathFSin_MathFSin_
    {
        [OuterLoop]
        [Fact]
        public void _system_mathf_MathFSin_MathFSin_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\mathf\\MathFSin\\MathFSin.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
