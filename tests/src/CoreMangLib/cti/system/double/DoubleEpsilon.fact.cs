using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleEpsilon_DoubleEpsilon_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleEpsilon_DoubleEpsilon_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleEpsilon\\DoubleEpsilon.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
