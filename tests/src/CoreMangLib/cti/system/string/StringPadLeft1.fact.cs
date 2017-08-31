using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringPadLeft1_StringPadLeft1_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringPadLeft1_StringPadLeft1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringPadLeft1\\StringPadLeft1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
