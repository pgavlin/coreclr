using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_runtimecompatibilityattribute_RCAttrWrapNEThrows_RCAttrWrapNEThrows_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_runtimecompatibilityattribute_RCAttrWrapNEThrows_RCAttrWrapNEThrows_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\runtimecompatibilityattribute\\RCAttrWrapNEThrows\\RCAttrWrapNEThrows.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
