using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attribute_GetHashCode_GetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_attribute_GetHashCode_GetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attribute\\GetHashCode\\GetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
