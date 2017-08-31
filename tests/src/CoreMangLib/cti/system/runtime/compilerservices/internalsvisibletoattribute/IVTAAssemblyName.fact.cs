using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_internalsvisibletoattribute_IVTAAssemblyName_IVTAAssemblyName_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_internalsvisibletoattribute_IVTAAssemblyName_IVTAAssemblyName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\internalsvisibletoattribute\\IVTAAssemblyName\\IVTAAssemblyName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
