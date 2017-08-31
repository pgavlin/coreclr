using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsDelegate_AttributeTargetsDelegate_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsDelegate_AttributeTargetsDelegate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsDelegate\\AttributeTargetsDelegate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
