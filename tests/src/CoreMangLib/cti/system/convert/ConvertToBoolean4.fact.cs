using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToBoolean4_ConvertToBoolean4_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToBoolean4_ConvertToBoolean4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToBoolean4\\ConvertToBoolean4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
