using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsPunctuation2_CharIsPunctuation2_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsPunctuation2_CharIsPunctuation2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsPunctuation2\\CharIsPunctuation2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
