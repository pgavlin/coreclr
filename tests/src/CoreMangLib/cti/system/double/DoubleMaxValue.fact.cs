using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleMaxValue_DoubleMaxValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleMaxValue_DoubleMaxValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleMaxValue\\DoubleMaxValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
