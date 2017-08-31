using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_iconvertible_IConvertibleToDouble_IConvertibleToDouble_
    {
        [OuterLoop]
        [Fact]
        public void _system_iconvertible_IConvertibleToDouble_IConvertibleToDouble_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\iconvertible\\IConvertibleToDouble\\IConvertibleToDouble.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
