using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIConvertibleToBoolean_CharIConvertibleToBoolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIConvertibleToBoolean_CharIConvertibleToBoolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIConvertibleToBoolean\\CharIConvertibleToBoolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
