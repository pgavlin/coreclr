using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_double_DoubleIConvertibleToBoolean_DoubleIConvertibleToBoolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_double_DoubleIConvertibleToBoolean_DoubleIConvertibleToBoolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\double\\DoubleIConvertibleToBoolean\\DoubleIConvertibleToBoolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
