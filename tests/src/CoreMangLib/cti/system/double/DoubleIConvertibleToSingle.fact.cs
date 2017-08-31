using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleIConvertibleToSingle_DoubleIConvertibleToSingle_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleIConvertibleToSingle_DoubleIConvertibleToSingle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleIConvertibleToSingle\\DoubleIConvertibleToSingle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
