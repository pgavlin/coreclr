using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsLetter1_CharIsLetter1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsLetter1_CharIsLetter1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsLetter1\\CharIsLetter1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
