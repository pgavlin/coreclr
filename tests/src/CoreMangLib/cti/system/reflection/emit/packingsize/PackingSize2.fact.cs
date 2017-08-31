using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_packingsize_PackingSize2_PackingSize2_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_packingsize_PackingSize2_PackingSize2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\packingsize\\PackingSize2\\PackingSize2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
