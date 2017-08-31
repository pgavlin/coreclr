using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_byte_ByteIConvertibleToBoolean_ByteIConvertibleToBoolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_byte_ByteIConvertibleToBoolean_ByteIConvertibleToBoolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\byte\\ByteIConvertibleToBoolean\\ByteIConvertibleToBoolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
