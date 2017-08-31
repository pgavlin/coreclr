using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharCompateTo1_CharCompateTo1_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharCompateTo1_CharCompateTo1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharCompateTo1\\CharCompateTo1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
