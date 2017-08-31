using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharToString1_CharToString1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharToString1_CharToString1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharToString1\\CharToString1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
