using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleIsPositiveInfinity_DoubleIsPositiveInfinity_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleIsPositiveInfinity_DoubleIsPositiveInfinity_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleIsPositiveInfinity\\DoubleIsPositiveInfinity.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
