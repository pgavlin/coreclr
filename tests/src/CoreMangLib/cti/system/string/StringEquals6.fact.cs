using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringEquals6_StringEquals6_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringEquals6_StringEquals6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringEquals6\\StringEquals6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
