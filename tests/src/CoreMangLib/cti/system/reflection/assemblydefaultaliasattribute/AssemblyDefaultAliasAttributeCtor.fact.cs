using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblydefaultaliasattribute_AssemblyDefaultAliasAttributeCtor_AssemblyDefaultAliasAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblydefaultaliasattribute_AssemblyDefaultAliasAttributeCtor_AssemblyDefaultAliasAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblydefaultaliasattribute\\AssemblyDefaultAliasAttributeCtor\\AssemblyDefaultAliasAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
