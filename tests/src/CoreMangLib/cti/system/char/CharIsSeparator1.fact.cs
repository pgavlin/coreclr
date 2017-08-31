using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsSeparator1_CharIsSeparator1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsSeparator1_CharIsSeparator1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsSeparator1\\CharIsSeparator1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
