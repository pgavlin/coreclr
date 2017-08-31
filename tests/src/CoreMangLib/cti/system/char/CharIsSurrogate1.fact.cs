using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsSurrogate1_CharIsSurrogate1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsSurrogate1_CharIsSurrogate1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsSurrogate1\\CharIsSurrogate1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
