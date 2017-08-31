using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringPadRight1_StringPadRight1_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringPadRight1_StringPadRight1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringPadRight1\\StringPadRight1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
