using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsSymbol1_CharIsSymbol1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsSymbol1_CharIsSymbol1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsSymbol1\\CharIsSymbol1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
