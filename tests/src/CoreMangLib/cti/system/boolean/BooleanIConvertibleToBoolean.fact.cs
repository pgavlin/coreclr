using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanIConvertibleToBoolean_BooleanIConvertibleToBoolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanIConvertibleToBoolean_BooleanIConvertibleToBoolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanIConvertibleToBoolean\\BooleanIConvertibleToBoolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
