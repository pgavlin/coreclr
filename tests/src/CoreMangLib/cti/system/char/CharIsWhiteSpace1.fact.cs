using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsWhiteSpace1_CharIsWhiteSpace1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsWhiteSpace1_CharIsWhiteSpace1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsWhiteSpace1\\CharIsWhiteSpace1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
