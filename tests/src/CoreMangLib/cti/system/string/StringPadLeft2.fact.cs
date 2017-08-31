using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringPadLeft2_StringPadLeft2_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringPadLeft2_StringPadLeft2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringPadLeft2\\StringPadLeft2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
