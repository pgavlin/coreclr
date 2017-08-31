using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_single_SingleToChar_SingleToChar_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleToChar_SingleToChar_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleToChar\\SingleToChar.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
