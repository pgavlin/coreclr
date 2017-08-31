using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsUpper1_CharIsUpper1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsUpper1_CharIsUpper1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsUpper1\\CharIsUpper1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
