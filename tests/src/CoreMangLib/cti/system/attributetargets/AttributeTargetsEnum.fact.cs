using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsEnum_AttributeTargetsEnum_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsEnum_AttributeTargetsEnum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsEnum\\AttributeTargetsEnum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
