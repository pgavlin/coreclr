using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleIsNaN_DoubleIsNaN_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleIsNaN_DoubleIsNaN_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleIsNaN\\DoubleIsNaN.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
