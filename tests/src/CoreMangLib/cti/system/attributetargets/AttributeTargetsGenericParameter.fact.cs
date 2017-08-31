using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsGenericParameter_AttributeTargetsGenericParameter_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsGenericParameter_AttributeTargetsGenericParameter_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsGenericParameter\\AttributeTargetsGenericParameter.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
