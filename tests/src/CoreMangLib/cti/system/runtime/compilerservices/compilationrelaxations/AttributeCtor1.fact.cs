using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_compilationrelaxations_AttributeCtor1_AttributeCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_compilationrelaxations_AttributeCtor1_AttributeCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\compilationrelaxations\\AttributeCtor1\\AttributeCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
