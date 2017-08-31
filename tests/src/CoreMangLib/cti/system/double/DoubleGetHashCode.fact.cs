using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleGetHashCode_DoubleGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleGetHashCode_DoubleGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleGetHashCode\\DoubleGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
