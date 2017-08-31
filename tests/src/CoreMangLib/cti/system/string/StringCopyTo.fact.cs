using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringCopyTo_StringCopyTo_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringCopyTo_StringCopyTo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringCopyTo\\StringCopyTo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
