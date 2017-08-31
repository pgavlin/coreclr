using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_nullable_NullableGetValueOrDefault1_NullableGetValueOrDefault1_
    {
        [OuterLoop]
        [Fact]
        public void _system_nullable_NullableGetValueOrDefault1_NullableGetValueOrDefault1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\nullable\\NullableGetValueOrDefault1\\NullableGetValueOrDefault1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
