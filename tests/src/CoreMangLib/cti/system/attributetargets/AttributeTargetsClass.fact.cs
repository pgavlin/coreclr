using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsClass_AttributeTargetsClass_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsClass_AttributeTargetsClass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsClass\\AttributeTargetsClass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
