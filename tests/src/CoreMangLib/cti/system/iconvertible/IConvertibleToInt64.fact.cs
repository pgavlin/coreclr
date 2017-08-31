using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_iconvertible_IConvertibleToInt64_IConvertibleToInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_iconvertible_IConvertibleToInt64_IConvertibleToInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\iconvertible\\IConvertibleToInt64\\IConvertibleToInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
