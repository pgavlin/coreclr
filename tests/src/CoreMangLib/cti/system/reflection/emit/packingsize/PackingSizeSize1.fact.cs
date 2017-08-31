using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_packingsize_PackingSizeSize1_PackingSizeSize1_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_packingsize_PackingSizeSize1_PackingSizeSize1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\packingsize\\PackingSizeSize1\\PackingSizeSize1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
