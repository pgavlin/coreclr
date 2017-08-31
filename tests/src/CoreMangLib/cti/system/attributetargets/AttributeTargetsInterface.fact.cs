using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsInterface_AttributeTargetsInterface_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsInterface_AttributeTargetsInterface_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsInterface\\AttributeTargetsInterface.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
