using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_packingsize_PackingSizeSize128_PackingSizeSize128_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_packingsize_PackingSizeSize128_PackingSizeSize128_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\packingsize\\PackingSizeSize128\\PackingSizeSize128.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
