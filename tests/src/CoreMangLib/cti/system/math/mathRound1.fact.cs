using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_math_mathRound1_mathRound1_
    {
        [OuterLoop]
        [Fact]
        public void _system_math_mathRound1_mathRound1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\math\\mathRound1\\mathRound1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
