using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_single_SingleIsNaN_SingleIsNaN_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleIsNaN_SingleIsNaN_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleIsNaN\\SingleIsNaN.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
