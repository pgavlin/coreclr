using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToBoolean2_ConvertToBoolean2_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToBoolean2_ConvertToBoolean2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToBoolean2\\ConvertToBoolean2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
