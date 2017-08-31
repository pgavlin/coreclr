using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToBoolean8_ConvertToBoolean8_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToBoolean8_ConvertToBoolean8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToBoolean8\\ConvertToBoolean8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
