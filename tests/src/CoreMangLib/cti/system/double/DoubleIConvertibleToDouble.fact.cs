using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleIConvertibleToDouble_DoubleIConvertibleToDouble_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleIConvertibleToDouble_DoubleIConvertibleToDouble_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleIConvertibleToDouble\\DoubleIConvertibleToDouble.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
