using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsSeparator2_CharIsSeparator2_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsSeparator2_CharIsSeparator2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsSeparator2\\CharIsSeparator2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
