using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsUpper2_CharIsUpper2_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsUpper2_CharIsUpper2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsUpper2\\CharIsUpper2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
