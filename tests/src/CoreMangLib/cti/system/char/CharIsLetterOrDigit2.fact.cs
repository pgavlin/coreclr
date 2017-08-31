using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsLetterOrDigit2_CharIsLetterOrDigit2_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsLetterOrDigit2_CharIsLetterOrDigit2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsLetterOrDigit2\\CharIsLetterOrDigit2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
