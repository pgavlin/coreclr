using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_internalsvisibletoattribute_IVTACtor_IVTACtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_internalsvisibletoattribute_IVTACtor_IVTACtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\internalsvisibletoattribute\\IVTACtor\\IVTACtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
