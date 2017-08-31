using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_iconvertible_IConvertibleToDateTime_IConvertibleToDateTime_
    {
        [OuterLoop]
        [Fact]
        public void _system_iconvertible_IConvertibleToDateTime_IConvertibleToDateTime_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\iconvertible\\IConvertibleToDateTime\\IConvertibleToDateTime.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
