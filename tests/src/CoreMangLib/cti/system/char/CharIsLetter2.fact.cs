using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsLetter2_CharIsLetter2_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsLetter2_CharIsLetter2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsLetter2\\CharIsLetter2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
