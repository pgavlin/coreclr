using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_mathf_MathFFloor_MathFFloor_
    {
        [OuterLoop]
        [Fact]
        public void _system_mathf_MathFFloor_MathFFloor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\mathf\\MathFFloor\\MathFFloor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
