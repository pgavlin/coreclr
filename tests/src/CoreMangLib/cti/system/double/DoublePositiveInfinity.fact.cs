using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoublePositiveInfinity_DoublePositiveInfinity_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoublePositiveInfinity_DoublePositiveInfinity_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoublePositiveInfinity\\DoublePositiveInfinity.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
