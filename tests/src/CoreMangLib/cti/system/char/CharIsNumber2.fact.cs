using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsNumber2_CharIsNumber2_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsNumber2_CharIsNumber2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsNumber2\\CharIsNumber2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
