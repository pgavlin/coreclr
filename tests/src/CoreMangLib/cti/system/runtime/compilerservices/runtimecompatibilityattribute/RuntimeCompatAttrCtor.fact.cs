using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_runtimecompatibilityattribute_RuntimeCompatAttrCtor_RuntimeCompatAttrCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_runtimecompatibilityattribute_RuntimeCompatAttrCtor_RuntimeCompatAttrCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\runtimecompatibilityattribute\\RuntimeCompatAttrCtor\\RuntimeCompatAttrCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
