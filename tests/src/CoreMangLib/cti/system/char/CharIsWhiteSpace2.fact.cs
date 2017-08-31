using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsWhiteSpace2_CharIsWhiteSpace2_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsWhiteSpace2_CharIsWhiteSpace2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsWhiteSpace2\\CharIsWhiteSpace2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
