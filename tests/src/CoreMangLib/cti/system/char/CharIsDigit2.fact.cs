using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsDigit2_CharIsDigit2_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsDigit2_CharIsDigit2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsDigit2\\CharIsDigit2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
