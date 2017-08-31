using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsParameter_AttributeTargetsParameter_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsParameter_AttributeTargetsParameter_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsParameter\\AttributeTargetsParameter.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
