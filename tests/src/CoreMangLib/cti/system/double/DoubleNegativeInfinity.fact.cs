using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleNegativeInfinity_DoubleNegativeInfinity_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleNegativeInfinity_DoubleNegativeInfinity_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleNegativeInfinity\\DoubleNegativeInfinity.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
