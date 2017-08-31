using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_nullable_NullableEquals2_NullableEquals2_
    {
        [OuterLoop]
        [Fact]
        public void _system_nullable_NullableEquals2_NullableEquals2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\nullable\\NullableEquals2\\NullableEquals2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
