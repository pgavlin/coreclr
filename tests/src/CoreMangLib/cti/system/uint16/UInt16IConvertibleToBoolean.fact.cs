using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16IConvertibleToBoolean_UInt16IConvertibleToBoolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16IConvertibleToBoolean_UInt16IConvertibleToBoolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16IConvertibleToBoolean\\UInt16IConvertibleToBoolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
