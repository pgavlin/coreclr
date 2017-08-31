using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_iconvertible_IConvertibleToBoolean_IConvertibleToBoolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_iconvertible_IConvertibleToBoolean_IConvertibleToBoolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\iconvertible\\IConvertibleToBoolean\\IConvertibleToBoolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
