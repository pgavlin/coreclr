using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleCompareTo1_DoubleCompareTo1_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleCompareTo1_DoubleCompareTo1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleCompareTo1\\DoubleCompareTo1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
