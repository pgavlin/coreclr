using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attribute_DDB125472_GetHashCode_DDB125472_GetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_attribute_DDB125472_GetHashCode_DDB125472_GetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attribute\\DDB125472_GetHashCode\\DDB125472_GetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
