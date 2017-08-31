using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_valuetype_ValueTypeEquals2_ValueTypeEquals2_
    {
        [OuterLoop]
        [Fact]
        public void _system_valuetype_ValueTypeEquals2_ValueTypeEquals2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\valuetype\\ValueTypeEquals2\\ValueTypeEquals2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
