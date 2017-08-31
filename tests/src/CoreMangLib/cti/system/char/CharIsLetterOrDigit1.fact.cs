using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsLetterOrDigit1_CharIsLetterOrDigit1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsLetterOrDigit1_CharIsLetterOrDigit1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsLetterOrDigit1\\CharIsLetterOrDigit1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
