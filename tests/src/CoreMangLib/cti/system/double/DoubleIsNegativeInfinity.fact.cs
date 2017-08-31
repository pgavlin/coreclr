using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleIsNegativeInfinity_DoubleIsNegativeInfinity_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleIsNegativeInfinity_DoubleIsNegativeInfinity_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleIsNegativeInfinity\\DoubleIsNegativeInfinity.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
