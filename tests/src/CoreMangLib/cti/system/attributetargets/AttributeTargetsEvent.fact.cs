using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsEvent_AttributeTargetsEvent_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsEvent_AttributeTargetsEvent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsEvent\\AttributeTargetsEvent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
