using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsReturnValue_AttributeTargetsReturnValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsReturnValue_AttributeTargetsReturnValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsReturnValue\\AttributeTargetsReturnValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
