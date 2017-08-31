using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleIConvertibleToInt16_DoubleIConvertibleToInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleIConvertibleToInt16_DoubleIConvertibleToInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleIConvertibleToInt16\\DoubleIConvertibleToInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
