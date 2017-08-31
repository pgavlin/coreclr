using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_packingsize_PackingSizeUnspecified_PackingSizeUnspecified_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_packingsize_PackingSizeUnspecified_PackingSizeUnspecified_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\packingsize\\PackingSizeUnspecified\\PackingSizeUnspecified.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
