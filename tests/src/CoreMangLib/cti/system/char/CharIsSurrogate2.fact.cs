using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsSurrogate2_CharIsSurrogate2_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsSurrogate2_CharIsSurrogate2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsSurrogate2\\CharIsSurrogate2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
