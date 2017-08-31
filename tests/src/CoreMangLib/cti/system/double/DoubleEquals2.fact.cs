using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleEquals2_DoubleEquals2_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleEquals2_DoubleEquals2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleEquals2\\DoubleEquals2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
