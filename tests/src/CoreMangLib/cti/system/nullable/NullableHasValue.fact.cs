using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_nullable_NullableHasValue_NullableHasValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_nullable_NullableHasValue_NullableHasValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\nullable\\NullableHasValue\\NullableHasValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
