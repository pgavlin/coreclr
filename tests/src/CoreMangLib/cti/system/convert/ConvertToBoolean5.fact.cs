using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToBoolean5_ConvertToBoolean5_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToBoolean5_ConvertToBoolean5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToBoolean5\\ConvertToBoolean5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
