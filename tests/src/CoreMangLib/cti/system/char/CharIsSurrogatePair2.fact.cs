using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsSurrogatePair2_CharIsSurrogatePair2_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsSurrogatePair2_CharIsSurrogatePair2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsSurrogatePair2\\CharIsSurrogatePair2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
