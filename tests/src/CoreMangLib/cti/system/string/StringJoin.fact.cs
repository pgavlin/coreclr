using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringJoin_StringJoin_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringJoin_StringJoin_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringJoin\\StringJoin.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
