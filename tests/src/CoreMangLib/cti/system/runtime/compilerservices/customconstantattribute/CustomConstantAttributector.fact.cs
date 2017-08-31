using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_customconstantattribute_CustomConstantAttributector_CustomConstantAttributector_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_customconstantattribute_CustomConstantAttributector_CustomConstantAttributector_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\customconstantattribute\\CustomConstantAttributector\\CustomConstantAttributector.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
