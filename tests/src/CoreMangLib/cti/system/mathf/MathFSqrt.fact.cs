using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_mathf_MathFSqrt_MathFSqrt_
    {
        [OuterLoop]
        [Fact]
        public void _system_mathf_MathFSqrt_MathFSqrt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\mathf\\MathFSqrt\\MathFSqrt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
