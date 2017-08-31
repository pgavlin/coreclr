using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_sbyte_SByteIConvertibleToBoolean_SByteIConvertibleToBoolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_sbyte_SByteIConvertibleToBoolean_SByteIConvertibleToBoolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\sbyte\\SByteIConvertibleToBoolean\\SByteIConvertibleToBoolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
