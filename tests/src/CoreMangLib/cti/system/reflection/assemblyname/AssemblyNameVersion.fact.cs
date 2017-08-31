using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblyname_AssemblyNameVersion_AssemblyNameVersion_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblyname_AssemblyNameVersion_AssemblyNameVersion_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblyname\\AssemblyNameVersion\\AssemblyNameVersion.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
