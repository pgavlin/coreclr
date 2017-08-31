using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_single_SingleGetHashCode_SingleGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleGetHashCode_SingleGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleGetHashCode\\SingleGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
