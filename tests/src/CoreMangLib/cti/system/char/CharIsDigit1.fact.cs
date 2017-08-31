using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsDigit1_CharIsDigit1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsDigit1_CharIsDigit1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsDigit1\\CharIsDigit1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
