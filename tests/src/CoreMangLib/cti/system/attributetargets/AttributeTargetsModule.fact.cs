using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsModule_AttributeTargetsModule_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsModule_AttributeTargetsModule_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsModule\\AttributeTargetsModule.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
