using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_iconvertible_IConvertibleToInt16_IConvertibleToInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_iconvertible_IConvertibleToInt16_IConvertibleToInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\iconvertible\\IConvertibleToInt16\\IConvertibleToInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
