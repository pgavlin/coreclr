using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleIsInfinity_DoubleIsInfinity_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleIsInfinity_DoubleIsInfinity_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleIsInfinity\\DoubleIsInfinity.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
