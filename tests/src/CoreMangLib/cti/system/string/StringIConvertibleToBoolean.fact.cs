using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringIConvertibleToBoolean_StringIConvertibleToBoolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringIConvertibleToBoolean_StringIConvertibleToBoolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringIConvertibleToBoolean\\StringIConvertibleToBoolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
