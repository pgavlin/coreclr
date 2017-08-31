using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_nullable_NullableEquals_NullableEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_nullable_NullableEquals_NullableEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\nullable\\NullableEquals\\NullableEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
