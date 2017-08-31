using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringPadRight2_StringPadRight2_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringPadRight2_StringPadRight2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringPadRight2\\StringPadRight2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
