using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_nullable_NullableGetHashCode_NullableGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_nullable_NullableGetHashCode_NullableGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\nullable\\NullableGetHashCode\\NullableGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
