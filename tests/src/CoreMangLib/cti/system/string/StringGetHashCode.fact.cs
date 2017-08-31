using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringGetHashCode_StringGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringGetHashCode_StringGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringGetHashCode\\StringGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
