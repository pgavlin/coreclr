using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToBoolean_ConvertToBoolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToBoolean_ConvertToBoolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToBoolean\\ConvertToBoolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
