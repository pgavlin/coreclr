using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_nullable_NullableGetUnderlyingType_NullableGetUnderlyingType_
    {
        [OuterLoop]
        [Fact]
        public void _system_nullable_NullableGetUnderlyingType_NullableGetUnderlyingType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\nullable\\NullableGetUnderlyingType\\NullableGetUnderlyingType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
