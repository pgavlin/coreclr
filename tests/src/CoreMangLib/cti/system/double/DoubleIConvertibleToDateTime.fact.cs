using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleIConvertibleToDateTime_DoubleIConvertibleToDateTime_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleIConvertibleToDateTime_DoubleIConvertibleToDateTime_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleIConvertibleToDateTime\\DoubleIConvertibleToDateTime.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
