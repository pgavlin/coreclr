using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsMethod_AttributeTargetsMethod_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsMethod_AttributeTargetsMethod_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsMethod\\AttributeTargetsMethod.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
