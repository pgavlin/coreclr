using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_packingsize_PackingSizeSize64_PackingSizeSize64_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_packingsize_PackingSizeSize64_PackingSizeSize64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\packingsize\\PackingSizeSize64\\PackingSizeSize64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
