using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_nullable_NullableGetValueOrDefault2_NullableGetValueOrDefault2_
    {
        [OuterLoop]
        [Fact]
        public void _system_nullable_NullableGetValueOrDefault2_NullableGetValueOrDefault2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\nullable\\NullableGetValueOrDefault2\\NullableGetValueOrDefault2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
