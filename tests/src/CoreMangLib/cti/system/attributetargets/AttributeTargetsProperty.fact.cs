using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsProperty_AttributeTargetsProperty_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsProperty_AttributeTargetsProperty_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsProperty\\AttributeTargetsProperty.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
