using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsSurrogatePair1_CharIsSurrogatePair1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsSurrogatePair1_CharIsSurrogatePair1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsSurrogatePair1\\CharIsSurrogatePair1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
