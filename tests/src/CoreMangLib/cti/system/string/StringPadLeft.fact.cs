using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringPadLeft_StringPadLeft_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringPadLeft_StringPadLeft_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringPadLeft\\StringPadLeft.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
