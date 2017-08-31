using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_mathf_MathFIEEERemainder_MathFIEEERemainder_
    {
        [OuterLoop]
        [Fact]
        public void _system_mathf_MathFIEEERemainder_MathFIEEERemainder_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\mathf\\MathFIEEERemainder\\MathFIEEERemainder.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
