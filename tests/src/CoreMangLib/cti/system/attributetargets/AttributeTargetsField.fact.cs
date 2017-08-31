using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsField_AttributeTargetsField_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsField_AttributeTargetsField_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsField\\AttributeTargetsField.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
