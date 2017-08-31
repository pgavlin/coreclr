using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToBoolean7_ConvertToBoolean7_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToBoolean7_ConvertToBoolean7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToBoolean7\\ConvertToBoolean7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
