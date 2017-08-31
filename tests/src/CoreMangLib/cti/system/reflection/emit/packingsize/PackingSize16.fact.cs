using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_packingsize_PackingSize16_PackingSize16_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_packingsize_PackingSize16_PackingSize16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\packingsize\\PackingSize16\\PackingSize16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
