using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToBoolean6_ConvertToBoolean6_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToBoolean6_ConvertToBoolean6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToBoolean6\\ConvertToBoolean6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
