using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_packingsize_PackingSizeSize32_PackingSizeSize32_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_packingsize_PackingSizeSize32_PackingSizeSize32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\packingsize\\PackingSizeSize32\\PackingSizeSize32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
