using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_valuetype_ValueTypeEquals_ValueTypeEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_valuetype_ValueTypeEquals_ValueTypeEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\valuetype\\ValueTypeEquals\\ValueTypeEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
