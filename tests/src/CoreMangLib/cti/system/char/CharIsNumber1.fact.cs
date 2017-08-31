using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIsNumber1_CharIsNumber1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIsNumber1_CharIsNumber1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIsNumber1\\CharIsNumber1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
