using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringTrim1b_StringTrim1b_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringTrim1b_StringTrim1b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringTrim1b\\StringTrim1b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
